using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace CameraProject_6610301004
{
    public partial class FormMain : Form
    {
        // ตัวแปรสำหรับการใช้งานกล้อง
        private VideoCapture _capture = null; // ใช้สำหรับจับภาพจากกล้อง
        private Mat _frame = new Mat(); // เก็บเฟรมจากกล้อง
        private bool IsConnect = true; // สถานะการเชื่อมต่อกล้อง
        private bool isCapturing = true; // สถานะการบันทึกหรือหยุดบันทึก
        private Timer snapshotTimer;

        // ตัวตรวจจับใบหน้าด้วย Haar Cascade
        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"E:\CameraProject_6610301004\haarcascade_frontalface_default.xml");

        // ฟังก์ชันประมวลผลเฟรมที่ได้จากกล้อง
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null || _capture.Ptr == IntPtr.Zero) return;

            _capture.Retrieve(_frame);

            if (!_frame.IsEmpty)
            {
                var image = _frame.ToImage<Bgr, byte>();
                var grayImage = image.Convert<Gray, byte>();

                // ค้นหาใบหน้าในภาพขาวดำ
                var faces = _cascadeClassifier.DetectMultiScale(grayImage, 1.1, 10);

                foreach (var face in faces)
                {
                    image.Draw(face, new Bgr(Color.White), 3);
                }

                imageBox1.Image = image;

                // ถ้าเจอใบหน้า ให้ตัดใบหน้าและแสดงในกล่องเล็ก
                if (faces.Length > 0)
                {
                    grayImage.ROI = faces[0]; // เลือกเฉพาะส่วนใบหน้า
                    imageBox2.Image = grayImage.Copy(); // แสดงใบหน้าที่ตัดออกมา
                }
            }
        }

        // ฟังก์ชันเรียกใช้เมื่อปิดฟอร์ม
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ปิดการทำงานของกล้อง
            if (_capture != null)
            {
                _capture.Pause();
                _capture.Dispose();
                _capture = null;
            }

            // แสดงข้อความยืนยันก่อนปิดโปรแกรม
            DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่?",
                                                  "ยืนยันการปิด",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // ยกเลิกการปิดโปรแกรม
            }
        }

        // ตัวสร้างฟอร์ม
        public FormMain()
        {
            InitializeComponent(); // โหลดส่วนประกอบของฟอร์ม
            buttonStsrt.Enabled = false; // ปิดปุ่ม Start ไว้จนกว่าจะเชื่อมต่อกล้อง
            timerClock.Enabled = true;   // เปิดใช้งานนาฬิกา

            snapshotTimer = new Timer();
            snapshotTimer.Interval = 3000; // ตั้งเวลาเป็น 3 วินาที
            snapshotTimer.Tick += snapshotTimer_Tick;
        }

        // ฟังก์ชันโหลดฟอร์ม
        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                // กำหนดค่าการตั้งเวลา
                UpDownChoosetime.Minimum = 1; // นาทีต่ำสุด
                UpDownChoosetime.Maximum = 10; // นาทีสูงสุด
                UpDownChoosetime.Value = 1;   // ค่าเริ่มต้น
                UpDownChoosetime.Increment = 1; // เพิ่มทีละ 1 นาที

                UpDownChoosetime.ValueChanged += UpDownChoosetime_ValueChanged;

                // สร้างตัวจับเวลา snapshotTimer ถ้ายังไม่มีการสร้าง
                if (snapshotTimer == null)
                {
                    snapshotTimer = new Timer();
                    snapshotTimer.Interval = (int)UpDownChoosetime.Value * 60 * 1000; // แปลงเป็นมิลลิวินาที
                    snapshotTimer.Tick += snapshotTimer_Tick;
                }

                // สร้าง VideoCapture ถ้ายังไม่มีการสร้าง
                if (_capture == null)
                {
                    _capture = new VideoCapture();
                    _capture.ImageGrabbed += ProcessFrame;
                    _frame = new Mat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาดใน FormMain_Load: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // ฟังก์ชันเปลี่ยนข้อความใน TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ฟังก์ชันเปล่า
        }

        // ฟังก์ชันสำหรับปุ่มที่ไม่ได้ใช้งาน
        private void button3_Click(object sender, EventArgs e)
        {
            // ฟังก์ชันเปล่า
        }

        // ฟังก์ชันสำหรับปุ่ม "Flip Horizontal"
        private void buttonFlipHor_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipHorizontal = !_capture.FlipHorizontal; // สลับการกลับด้านแนวนอน
        }

        // ฟังก์ชันสำหรับปุ่ม "Flip Vertical"
        private void buttonFlipVer_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipVertical = !_capture.FlipVertical; // สลับการกลับด้านแนวตั้ง
        }

        // ฟังก์ชันเมื่อคลิกที่ imageBox1
        private void imageBox1_Click(object sender, EventArgs e)
        {
            // ฟังก์ชันเปล่า
        }

        // ฟังก์ชันเมื่อกรอกข้อความใน TextBox1
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame; // กำหนด ProcessFrame เป็นตัวจับภาพ
                _frame = new Mat();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        // ฟังก์ชันปุ่ม Connect หรือ Disconnect กล้อง
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (IsConnect)
            {
                buttonConnect.Text = "Disconnect";
                tbCarmera.BackColor = Color.Green;
                tbCarmera.Text = "Connected";
                buttonStsrt.Enabled = true;

                try
                {
                    _capture = new VideoCapture(); // เริ่มกล้อง
                    _capture.ImageGrabbed += ProcessFrame; // กำหนด ProcessFrame เมื่อจับภาพ
                    _frame = new Mat();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else
            {
                buttonConnect.Text = "Connect";
                tbCarmera.BackColor = Color.Red;
                tbCarmera.Text = "DisConnected";
                buttonStsrt.Enabled = false;

                try
                {
                    if (_capture != null)
                    {
                        _capture.Pause();
                        _capture.Dispose(); // ปิดกล้อง
                    }
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            IsConnect = !IsConnect; // สลับสถานะ
        }

        // ฟังก์ชันสำหรับปุ่มเริ่ม/หยุดบันทึก
        private void button5_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                buttonStsrt.Text = "Pause";
                textBox2.Text = "Record";
                textBox2.BackColor = Color.Green;
                buttonConnect.Enabled = false;

                if (_capture != null)
                {
                    _capture.Start(); // เริ่มจับภาพจากกล้อง
                }
            }
            else
            {
                buttonStsrt.Text = "Start";
                textBox2.BackColor = Color.Red;
                textBox2.Text = "No record";
                buttonConnect.Enabled = true;

                if (_capture != null)
                {
                    _capture.Pause(); // หยุดจับภาพจากกล้อง
                }
            }
            isCapturing = !isCapturing; // สลับสถานะการจับภาพ
        }

        // ฟังก์ชันสำหรับการกรอกข้อความใน TextBox อื่น
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame; // กำหนด ProcessFrame เป็นตัวจับภาพ
                _frame = new Mat();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        // ฟังก์ชันแสดงนาฬิกาและวันที่ในสถานะบาร์
        private void timerClock_Tick(object sender, EventArgs e)
        {
            string formatStringClock = "HH:mm:ss"; // รูปแบบเวลา
            string formatStringDate = "yyyy-MMM-dd"; // รูปแบบวันที่

            DateTime dtNow = DateTime.Now;
            statusLabelClock.Text = dtNow.ToString(formatStringClock); // แสดงเวลา
            statusLabalDate.Text = dtNow.ToString(formatStringDate); // แสดงวันที่
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textbox_log_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusLabalDate_Click(object sender, EventArgs e)
        {

        }


        #region imageBox2grey
        private void imageBox2_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                snapshotTimer.Stop(); // หยุดจับภาพ
                isCapturing = false;
                //MessageBox.Show("หยุดการจับภาพ", "สถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int selectedMinutes = (int)UpDownChoosetime.Value;
                snapshotTimer.Interval = selectedMinutes * 60 * 1000; // กำหนดเวลาในมิลลิวินาที
                snapshotTimer.Start(); // เริ่มจับภาพ
                isCapturing = true;
                //MessageBox.Show($"เริ่มจับภาพทุก ๆ {selectedMinutes} นาที", "สถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region buttonBrowse
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // ตั้งค่าต่างๆ ของ FolderBrowserDialog
                folderDialog.Description = "กรุณาเลือกโฟลเดอร์";
                folderDialog.ShowNewFolderButton = true; // อนุญาตให้สร้างโฟลเดอร์ใหม่
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // กำหนดโฟลเดอร์เริ่มต้น

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // แสดงเส้นทางที่เลือกใน MessageBox หรือ TextBox
                    string selectedPath = folderDialog.SelectedPath;
                    textBoxImageFolder.Text = selectedPath;
                }
            }
        }
        #endregion

        #region CheckBoxSnpshot
        private void checkBoxSnpshot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSnpshot.Checked)
            {
                checkBoxRecognizer.Enabled = false; // ล็อก checkBoxRecognizer
                snapshotTimer.Start(); // เริ่มจับเวลา
            }
            else
            {
                checkBoxRecognizer.Enabled = true; // ปลดล็อก checkBoxRecognizer
                snapshotTimer.Stop(); // หยุดจับเวลา
            }

        }
        #endregion

        #region UpDoownChoosetim
        private void UpDownChoosetime_ValueChanged(object sender, EventArgs e)
        {
            int selectedMinutes = (int)UpDownChoosetime.Value;


            //int milliseconds = selectedMinutes * 60 * 1000; // แปลงนาทีเป็นมิลลิวินาที
            //snapshotTimer.Interval = milliseconds;

        }
        #endregion

        #region CheckBoxRecognizer
        private void checkBoxRecognizer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecognizer.Checked)
            {
                checkBoxSnpshot.Enabled = false; // ล็อก checkBoxSnpshot

            }
            else
            {
                checkBoxSnpshot.Enabled = true; // ปลดล็อก checkBoxSnpshot

            }

        }
        #endregion

        #region SnapshotTimer
        private void snapshotTimer_Tick(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                MessageBox.Show("กล้องยังไม่ถูกเปิดใช้งาน!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                snapshotTimer.Stop();
                return;
            }

            string folderPath = textBoxImageFolder.Text;

            if (string.IsNullOrEmpty(folderPath) || !System.IO.Directory.Exists(folderPath))
            {
                MessageBox.Show("กรุณาเลือกโฟลเดอร์ที่ถูกต้องสำหรับการบันทึกภาพ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                snapshotTimer.Stop();
                return;
            }

            string fileName = $"snapshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string filePath = System.IO.Path.Combine(folderPath, fileName);

            try
            {
                using (var imageFrame = _capture.QueryFrame()?.ToImage<Bgr, Byte>())
                {
                    if (imageFrame == null)
                    {
                        MessageBox.Show("ไม่สามารถจับภาพจากกล้องได้!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var grayFrame = imageFrame.Convert<Gray, byte>();
                    var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);

                    if (faces.Length > 0)
                    {
                        int interval = (int)UpDownChoosetime.Value * 1000;
                        snapshotTimer.Interval = interval;

                        Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, faces[0].Width, faces[0].Height);
                        grayFrame.ROI = face_roi;
                        var faceImage = grayFrame.Copy();

                        faceImage.Save(filePath);
                        textBoxShowim.AppendText($"📷 Snapshot saved to: {filePath}{Environment.NewLine}");
                        textBoxShowim.AppendText($"⏳ Timer Interval: {snapshotTimer.Interval} ms{Environment.NewLine}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving snapshot: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void statusLabelClock_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
