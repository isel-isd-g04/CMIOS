using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
using ValidationModels;

namespace CMOIValidationService
{
    public class ValidationProcessor :IDisposable
    {
        private static ValidationProcessor _instance;

        private Channel _grpChannel;

        private ValidationService.ValidationService.ValidationServiceClient _grpcClient;

        public static ValidationProcessor Instance 
        {
            get
            {
                if (_instance != null)
                    return _instance;


                _instance = new ValidationProcessor();
                return _instance;
            }
        }


        private ValidationProcessor()
        {
            Console.WriteLine($"Target: {Helpers.RemoteGrpcApi}");
            // Create a channel
            _grpChannel = new Channel(Helpers.RemoteGrpcApi, ChannelCredentials.Insecure);

            try
            {
                // Create a client with the channel
                _grpcClient = new ValidationService.ValidationService.ValidationServiceClient(_grpChannel);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                //If we dont connect we blow up until we can, docker will restart the process
                throw excp;
            }
        }

        public bool ValidateUser(ValidationRequest request)
        {
            try
            {
                request.CodeCSMP = Helpers.CMSPCode;
                request.CMOINIB = Helpers.CMOIIBAN;
                request.CMOINIF = Helpers.CMOINIF;

                // Send the request
                Console.WriteLine("GreeterClient sending request");
                var response = _grpcClient.ValidationSingle(request);

                Console.WriteLine("GreeterClient received response: " + response.ToString());

                return response.Authorised;
            }
            catch (Exception excp)
            {
                Console.WriteLine("{0}", excp.Message);
            }

            return false;
        }

        public void Dispose()
        {
            if (_grpChannel != null)
                _grpChannel.ShutdownAsync();
        }
    }
}