using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        // ตัวตรวจจับใบหน้าด้วย Haar Cascade
        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"E:\CameraProject_6610301004\haarcascade_frontalface_default.xml");

        // ฟังก์ชันประมวลผลเฟรมที่ได้จากกล้อง
        private void ProcessFrame(object sender, EventArgs e)
        {
            // ถ้ากล้องไม่พร้อม ไม่ทำอะไร
            if (_capture == null || _capture.Ptr == IntPtr.Zero) return;

            // ดึงเฟรมจากกล้อง
            _capture.Retrieve(_frame);

            // ถ้าภาพไม่ว่างเปล่า
            if (!_frame.IsEmpty)
            {
                // แปลงภาพให้เป็นภาพสี
                var image = _frame.ToImage<Bgr, byte>();

                // แปลงภาพสีให้เป็นภาพขาวดำ
                var grayImage = image.Convert<Gray, byte>();

                // ค้นหาใบหน้าในภาพขาวดำ
                var faces = _cascadeClassifier.DetectMultiScale(grayImage, 1.1, 10);

                // วาดกรอบรอบใบหน้าที่เจอ
                foreach (var face in faces)
                {
                    image.Draw(face, new Bgr(Color.White), 3);
                }

                // แสดงภาพในกล่องภาพหลัก
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
        }

        // ฟังก์ชันโหลดฟอร์ม
        private void FormMain_Load(object sender, EventArgs e)
        {
            // ฟังก์ชันเปล่าสำหรับการกำหนดคำสั่งเพิ่มเติมตอนโหลดฟอร์ม
        }

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

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
