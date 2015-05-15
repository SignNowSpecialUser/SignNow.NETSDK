﻿using System;

namespace com.signnow.sdk
{
    public class Config
    {
        /**
         * Created by Deepak on 5/14/2015
         * 
         * This class is used to read the configuration parameters like, base endpointURL, clientID, clientSecret to access SignNow Application.
         */
        private static string apiBase;
         private static string clientId;
         private static string clientSecret;

         public Config(string apiBase, string clientId, string clientSecret) {
             Config.apiBase=apiBase;
             Config.clientId = clientId;
             Config.clientSecret=clientSecret;
        }

        public static string getApiBase() {

            if(apiBase.Equals("signnow.eval"))
            {
                return "https://capi-eval.signnow.com/api";
            }
            else if(apiBase.Equals("signnow.public"))
            {
                return "https://api.signnow.com";
            }
            return apiBase;
        }

        public static string getClientId()
        {
            return clientId;
        }

        public static string getClientSecret()
        {
            return clientSecret;
        }

        public static String getBase64EncodedClientCredentials()
        {
            string idAndSecret = Config.getClientId() + ":" + Config.getClientSecret();
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(idAndSecret);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}