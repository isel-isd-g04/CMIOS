using System.Configuration;

namespace Validator
{
    public class Helper
    {
        public static string UserNIF;

        public static string UserIBAN;

        public static string RemoteAPI;

        public static float Price;

        public static void ReadConfigs()
        {
            UserNIF = ConfigurationManager.AppSettings["user-nif"];
            UserIBAN = ConfigurationManager.AppSettings["user-iban"];
            RemoteAPI = ConfigurationManager.AppSettings["remote-api"];
            Price = float.Parse(ConfigurationManager.AppSettings["price"]);


        }



    }
}