using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;

namespace ProxCore
{
    public class Check // Checking module for http/s,socks-4/5 - coming soon
    {

        public static (bool, int, string) http(string ip, int port, int timeout = 3000, string useragent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36")
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.com");
                request.UserAgent = useragent;
                request.Proxy = new WebProxy(ip, port);
                request.Timeout = timeout;
                request.GetResponse();
                sw.Stop();
                int Timeout = sw.Elapsed.Milliseconds;
                Responses.responsetime = Timeout;
                WebClient wbc = new WebClient();
                string jsondata = wbc.DownloadString("https://freegeoip.live/json/"+ip);
                //Console.WriteLine(jsondata);
                var serializer = new JavaScriptSerializer();
                dynamic result = serializer.DeserializeObject(jsondata);
                var ccode = result["country_code"];
                //Console.WriteLine(UserId);
                return (true,Timeout,ccode);
            }
            catch (Exception e)
            {
                return (false,0,"Failed");
            }
        }
        public static bool sock4(string ip, int port, int timeout = 3000) {
            try
            {
                TcpClient client = new TcpClient(ip, port);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}