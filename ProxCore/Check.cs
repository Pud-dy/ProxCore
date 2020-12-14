using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
namespace ProxCore
{
    public class Check
    {

        public static (bool, int) http(string ip, int port, int timeout = 3000, bool getresponsetime = false, string useragent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36")
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
                return (true, Convert.ToInt32(sw.ElapsedMilliseconds));
            }
            catch (Exception e)
            {
                return (false, 0);
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