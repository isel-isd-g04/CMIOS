using System.Configuration;

namespace CMOIValidationService
{
    public class Helpers
    {
        public static string CMOIIBAN;
        public static string CMOINIF;

        public static string CMSPCode;

        public static string RemoteGrpcApi;


        public static void ReadConfigs()
        {
            CMSPCode = ConfigurationManager.AppSettings["cmsp-code"];
            CMOINIF = ConfigurationManager.AppSettings["cmoi-nif"];
            CMOIIBAN = ConfigurationManager.AppSettings["cmoi-iban"];
            RemoteGrpcApi = ConfigurationManager.AppSettings["grpc-api"];

        }


    }
}