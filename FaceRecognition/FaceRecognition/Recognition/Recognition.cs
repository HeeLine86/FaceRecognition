using Amazon.Rekognition.Model;
using FaceRecognition.AWS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition
{
    class Recognition
    {
        public static Dictionary<String, String> faceCheck(Bitmap image, AWSClient client)
        {
            Dictionary<String, String> returnValue = new Dictionary<string, string>();

            var memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            DetectFacesRequest dfr = new DetectFacesRequest
            {
                Image = new Amazon.Rekognition.Model.Image
                {
                    Bytes = memoryStream
                }
            };
            dfr.Attributes.Add("ALL");

            try
            {
                Task<DetectFacesResponse> outcomeTask = client.AmazonRekognitionClient.DetectFacesAsync(dfr);
                DetectFacesResponse outcome = outcomeTask.Result;

                if (outcome.FaceDetails.Count > 0)
                {
                    foreach (var fd in outcome.FaceDetails)
                    {
                        // Get the bounding box
                        BoundingBox bb = fd.BoundingBox;
                        AgeRange ag = fd.AgeRange;
                        Gender gd = fd.Gender;
                        Console.WriteLine($"Bounding box = ({bb.Left}, {bb.Top}, {bb.Height}, {bb.Width})");

                        returnValue.Add("Gender", gd.Confidence.ToString());
                        returnValue.Add("GenderType", gd.Value.ToString());
                        returnValue.Add("AgeRangeHigh", ag.High.ToString());
                        returnValue.Add("AgeRangeLow", ag.Low.ToString());

                    }
                }
            }
            catch (Exception e)
            {
                //
            }

            return returnValue;
        }
    }
}
