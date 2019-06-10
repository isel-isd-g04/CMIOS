using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            RefreshDataAsync(Helper.RemoteAPI);

            Console.ReadKey();
        }
        

        private static void RefreshDataAsync(string serverPath)
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
                }, new ProtoMessageConverter());

                var binaryData = Encoding.UTF8.GetBytes(jsonMessage);
                responseBody.Write(binaryData);


                IAsyncResult asyncResult = httpRequest.BeginGetResponse(new AsyncCallback(result =>
                {
                    WebResponse response = httpRequest.EndGetResponse(result);
                    Stream dataStream = response.GetResponseStream();

                    if (dataStream == null)
                    {
                        response.Dispose();
                        Console.WriteLine("No answer");
                        return;
                    }

                    foreach (string responseHeader in response.Headers)
                    {
                        Console.WriteLine(responseHeader);

                    }

                    Int32 messageSize = (Int32)dataStream.Length;
                    Console.WriteLine("answer size{0}", messageSize);
                    if (messageSize < 3)
                    {
                        dataStream.Dispose();
                        response.Dispose();
                        return;
                    }

                    byte[] dataArray = new byte[messageSize];
                    Int32 readBytes = dataStream.Read(dataArray, 0, messageSize);

                    string responseString = Encoding.UTF8.GetString(dataArray, 0, readBytes);
                    responseString = Regex.Unescape(responseString);

                    
                    dataStream.Dispose();
                    response.Dispose();

                }), new object());

                //Blocks the call until the request is processed.
                asyncResult.AsyncWaitHandle.WaitOne();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }

            return;
        }


    }
}
