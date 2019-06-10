using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;
using ValidationModels;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, from validator");
            Helper.ReadConfigs();

//            while (true) { 
                RefreshDataAsync(Helper.RemoteAPI);
    //            Thread.Sleep(750);
  //          }
            //Console.ReadKey();
        }
        

        private static bool RefreshDataAsync(string serverPath)
        {
            try
            {
                var httpRequest = HttpWebRequest.CreateHttp(serverPath);
                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/octet-stream";
                var responseBody = httpRequest.GetRequestStream();
                Console.WriteLine("Requesting to {0} for user {1}",serverPath, Helper.UserNIF );

                var jsonMessage = JsonConvert.SerializeObject(new ValidationRequest()
                {
                    UserFiscalNumber = Helper.UserNIF,
                    UserIBAN = Helper.UserIBAN,
                    Price =  Helper.Price,
                }, new ProtoMessageConverter());

                var binaryData = Encoding.UTF8.GetBytes(jsonMessage);
                responseBody.Write(binaryData);

                HttpWebResponse response = (HttpWebResponse) httpRequest.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("The user is authorised: {0}", response.StatusCode);
                else
                    Console.WriteLine("The user is not authorised: {0}", response.StatusCode);

                response.Dispose();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

            return false ;
        }


    }
}
