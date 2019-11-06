using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace FaceRecognition.Camera
{
    class DeviceService
    {
        public static int CameraList()
        {
            int count = -1;
            bool wileFalg = true;
            while(wileFalg)
            {
                count++;
                try
                {
                    VideoCapture videoCapture = new VideoCapture(count);
                    if(videoCapture.IsOpened() == false)
                    {
                        wileFalg = false;
                    }
                    videoCapture.Dispose();
                }
                catch
                {
                    wileFalg = false;

                }

            }
            return count;
        }
    }
}
