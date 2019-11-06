using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace FaceRecognition.Camera
{
    class CameraDevice
    {
        private VideoCapture videoCapture;
        Mat[] frame;
        private Thread thread;
        int bufferIndex;
        int deviceIndex;
        private int isCameraRunning;

        public int IsCameraRunning { get => isCameraRunning;}

        public CameraDevice()
        {
            videoCapture = new VideoCapture();
            frame = new Mat[2];
            frame[0] = new Mat();
            frame[1] = new Mat();
            deviceIndex = -1;
            isCameraRunning = 0;
            bufferIndex = 0;
        }

        public void setCamera(int deviceIndex)
        {
            this.deviceIndex = deviceIndex;
        }

        public void runCamera()
        {
            if (isCameraRunning == 0)
            {
                thread = new Thread(new ThreadStart(CaptureCameraCallback));
                isCameraRunning = 1;
                thread.Start();
            }
        }

        public void stopCamera()
        {
            isCameraRunning = 0;
        }

        public Bitmap getBitmap()
        {
            try
            {
                if (isCameraRunning == 1)
                    return BitmapConverter.ToBitmap(frame[(bufferIndex + 1) & 0x01]);
                else
                {
                    Bitmap returnValue = new Bitmap(640, 480);

                    return returnValue;
                }
            }
            catch
            {
                Bitmap returnValue = new Bitmap(640, 480);

                return returnValue;
            }
                 
        }

        private void CaptureCameraCallback()
        {
            try
            {
                videoCapture.Open(0);

                while (isCameraRunning == 1)
                {
                    videoCapture.Read(frame[bufferIndex]);
                    bufferIndex = (bufferIndex + 1) & 0x01;
                }
            }
            catch (Exception e)
            {
                isCameraRunning = 0;
            }
        }
    }
}
