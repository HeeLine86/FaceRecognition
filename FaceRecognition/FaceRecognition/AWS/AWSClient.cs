using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.AWS
{
    class AWSClient
    {
        AmazonRekognitionClient amazonRekognitionClient;

        //String awsAccessKeyId;
        //String awsSecretAccessKey;

        public AWSClient()
        {

        }

        public AmazonRekognitionClient AmazonRekognitionClient { get => amazonRekognitionClient; set => amazonRekognitionClient = value; }

        public void setID(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region = null)
        {
            if (region == null)
                region = RegionEndpoint.APNortheast2;
            amazonRekognitionClient = new AmazonRekognitionClient(awsAccessKeyId, awsSecretAccessKey, region);
        }

       
    }
}
