using FaceRecognition.AWS;
using FaceRecognition.Camera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class MainView : Form
    {
        CameraDevice camera;
        AWSClient client;

        public MainView()
        {
            InitializeComponent();
            updateCameralist();
            camera = new CameraDevice();
            client = new AWSClient();
            //client.setID("AKIAZFAD7LHDADTHJZ5Y", "p0qcTFR8arMZ+x1pVGdwd83TE/cokx7M9dCiLqgl");
            I_TIMER_UI.Start();


        }

        private void updateCameralist()
        {
            var listIndex = DeviceService.CameraList();
            I_CB_CAMERA.Items.Clear();

            for(int i = 0; i < listIndex; i++)
            {
                I_CB_CAMERA.Items.Add(String.Format("#{0,2:00}", (i +1))+" 카메라");
            }
            if (I_CB_CAMERA.Items.Count > 0)
                I_CB_CAMERA.SelectedIndex = 0;
        }

        private void I_BTN_REFRESH_Click(object sender, EventArgs e)
        {
            updateCameralist();
        }

        private void I_BTN_START_Click(object sender, EventArgs e)
        {
            if(camera.IsCameraRunning == 0)
            {
                camera.setCamera(I_CB_CAMERA.SelectedIndex);
                I_CB_CAMERA.Enabled = false;
                camera.runCamera();
                I_BTN_START.Text = "Stop";
            }
            else
            {
                camera.stopCamera();
                I_CB_CAMERA.Enabled = true;
                I_BTN_START.Text = "Start";
            }

        }

        private void I_TIMER_UI_Tick(object sender, EventArgs e)
        {
            I_PB_MAIN.Image = camera.getBitmap();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            camera.stopCamera();
        }

        private void I_BTN_RECOGNITION_Click(object sender, EventArgs e)
        {
            long strat = System.DateTime.Now.Ticks;
            Dictionary<String,String> datas = Recognition.faceCheck(camera.getBitmap(), client);
            long end = System.DateTime.Now.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(end - strat);

            StringBuilder str = new StringBuilder();
            
            foreach(KeyValuePair<String, String> item in datas)
            {
                str.AppendLine(item.Key + " = " + item.Value);
            }

            str.AppendLine("수행 시간 - " + elapsedSpan.TotalMilliseconds + "ms");
            I_TB_LOG.Text = str.ToString();
        }

        private void I_BTN_KEY_Click(object sender, EventArgs e)
        {
            client.setID(I_TB_ACCESSKEY.Text, I_TB_SECRETACCESSKEY.Text);
        }
    }
}
