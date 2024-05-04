using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Authentication.Classes
{
    internal class FirestoreHelper
    {
        static string fireconfig = @"
    
        {
          ""type"": ""service_account"",
          ""project_id"": ""cloud-8ab83"",
          ""private_key_id"": ""4db2e150781175b0d7ff2469359c3473c814b8f6"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCvE7R1EwMg6+T2\nm3Cv0YeZ+CMQ5KnlS+0O7ND5Pz6b92SwsaXkAcs9j3P5B6t39D2FH48owHJ0x/YS\ngfadR24T9cDdb6312D4o0jN2QOZ9V5LdssGSvVWuiURTHm3sASelKyNXtO53bHIn\n82OqsHNkducxG2XCtQo/zIQRdhjig9/r+DZJ12SeycGvhf0MCtcgzuTHWTnXvy3N\nyByIjWRdb9Zm9GFPfpQmEs1yOnoY/PLU2+9uTbzv8gpdYJM8SwOL6GdQpKzB9ghw\n9wtFA46gBBq/va02L+wo448Fi0toVQT2ct7abDQvhVBXhW60TH59RP2NdPtOArOk\n+1ZeK5YXAgMBAAECggEACn+qAKNFOsIqlsc3eLOd6BPDNo4fygpFivGUjn3GaV/q\nf9YHVqbs4yIpGDPnimfxEHyV/yGbO3mKPg3hFglkhnnkOOMrkWSIRbZlM6AssjOA\nMR85EG2eJ7s/h6R5fv+KuxLdKbNF4Y91QQQNY/z0zn962a0E6yokFTNUcB+e2mZo\nr46cVqHDIESVdUAa/yH169U+1NyoEjRXJD7YuajEpCewHj/WsGgyQmb722cI9KX7\nZtTWsX7tJ0v7WD+xLEn88hiBHEuI0Tnxe6+gA9yswKd5YoSty7HSeli6XkeZJbfl\nwcc3ca/ysYholPn13mw+I8LwX9CRcJivX2r7mAbrIQKBgQDYWIZci5n7U6kiJGhm\n2hD54kYJEoLxTN5fD5ORDzx1CEQiLviloP5CBAPFy9FGzBQEeQ/RjzvdGzMOz8+i\npsmdLPPomFbXIzWs26S0JRmwq/0SynBmTMgacyBIZS8UIDie0Y67d6bfHoSfGnxc\n4Iekemn3bD/1UBJ7+4RzTr4GWQKBgQDPKr7aUEbwADxCqiaPVwsfcJ3KPezC0bk+\nvtuAG0l9RxQ8XYG64kuDmbR37RhF83oPRDN1qIHfbPgiOylnqTt9S3LrD4yv62/M\nbgkDIKZ45lVTpr0qvzhBeqrd8i2c8cwuRnChcBlWiIciOy0aI+JCGsG9pR6Iljo3\n6nNvC53R7wKBgQCnWpNVM4hBqk3DY3Z/WWCYbDjQ+8je8B90WZBFPgv+XA6Ygs1F\nEmyclI52i1uv8F3rt9pMuQgN2eR9KLPtliePth5XZsCGW25B8QZPdAOTbveteXvJ\nJswD6dqnJd5tKx+he2l2CvDC19CvYsWg8u76hNdD1jEDipVB4yZqLBdCwQKBgBOO\nuoPLrla7/vRgMdG4avFl5U+RdweRWwakZ/55FQABtNRaE4Q8FtruqM3lkTQRX0WP\nr7f8133rQKWipi8GF/qlI80zI5n8BQrsnGcyLuUdAZMrG5KsiLgNx5G6ajn1zcvU\nlI95ELtNmkxN/90G5DZPZljr/KzyWb6roIgsNZL7AoGBAMyOy54ny2aJ0+D7mxGy\n0cAMedK6+UowzXEs1OkSEAXyDUJ4Jz80ZpKaYPMfOCOXkPC/x/nGvE1H8SlfaKyN\nfsC7wGjegxtOi3VIX8mZx3X4m2Bj+9XjUUErabU1SokzGElvK4q7NRyCp7i/zsAY\nYiEz1tdiE/zZbmr/o/kX7FhV\n-----END PRIVATE KEY-----\n"",
          ""client_email"":""firebase-adminsdk-nayot@cloud-8ab83.iam.gserviceaccount.com"",
          ""client_id"": ""110334171375393519770"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-nayot%40cloud-8ab83.iam.gserviceaccount.com"",
        } ";

        static string filepath ="";
        public static FirestoreDb database { get; private set; }

        public static void SetEnviromentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()))+".json"; 
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            database = FirestoreDb.Create("cloud-8ab83");
            File.Delete(filepath);
        }
    }
}
