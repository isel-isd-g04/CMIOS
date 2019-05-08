using System;
using System.Threading.Tasks;
using Grpc.Core;
using ValidationModels;

namespace ValidationServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RunAsync();

            Console.ReadKey();
        }


        private static async Task RunAsync()
        {
            
            var channelTarget = $"{"localhost"}:{5000}";

            Console.WriteLine($"Target: {channelTarget}");

            // Create a channel
            var channel = new Channel(channelTarget, ChannelCredentials.Insecure);

            try
            {
                // Create a client with the channel
                var client = new ValidationService.ValidationService.ValidationServiceClient(channel);



                // Create a request
                ValidationModels.ValidationRequest request = new ValidationRequest
                {
                    CodeCMIO = "tst",
                    CodeCSMP = "sad",
                    DateTime = DateTime.Now.Ticks,
                    PositionGPS = "bolhas",
                    Price = "5.5",
                    UserFiscalNumber = "234",
                    ValidatorID = "ID-validator"
                };

                // Send the request
                Console.WriteLine("GreeterClient sending request");
                var response = client.ValidationSingle(request);

                Console.WriteLine("GreeterClient received response: " + response.ToString());
            }
            catch (Exception excp)
            {
                Console.WriteLine("{0}",excp.Message);
            }
            finally
            {
                // Shutdown
                await channel.ShutdownAsync();
            }
        }

    }
}
