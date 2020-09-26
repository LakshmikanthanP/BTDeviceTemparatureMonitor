using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BTDeviceTemparatureMonitor
{
    public static class TelegramBot
    {
        public static void SendAlert(string text)
        {
            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            string apiToken = "1382706268:AAFYkfdhvrKTq99bC28-TDgLP7WcfKdulrM";
            string chatId = "@TestWeatherUpdates";
            urlString = String.Format(urlString, apiToken, chatId, text);
            WebRequest request = WebRequest.Create(urlString);
            Stream rs = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            string line = "";
            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    sb.Append(line);
            }
            string response = sb.ToString();
            // Do what you want with response
        }

    }
}
