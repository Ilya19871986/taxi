using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.Http;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net.Mail;


namespace SmsToDB
{
    class ApiDb
    {
        private string Md5(string s)
        {
            var m = MD5.Create();
            var h = m.ComputeHash(Encoding.UTF8.GetBytes(s));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < h.Length; i++)
            {
                sBuilder.Append(h[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private string CurrentTime()
        {
            return DateTime.Now.AddMinutes(10).ToString("yyyyMMddHHmmss");
        }

        public string Ping()
        {
            try
            {
                string s = "https://" + Properties.Settings.Default.host + ":" + Properties.Settings.Default.port + "/common_api/1.0/ping";

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
                req.Method = "GET";
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (StreamReader stream = new StreamReader(
                     resp.GetResponseStream(), Encoding.UTF8))
                {
                    return stream.ReadToEnd();
                }
            }
            catch
            {
                return "Error Ping()";
            }
        }

        public string Analyze_phone(string phone)
        {
            string tmp;
            string[] Ar;

            try
            {
                string s = "https://" + Properties.Settings.Default.host +
                           ":" + Properties.Settings.Default.port + "/common_api/1.0/analyze_phone?phone=" + phone + "&search_in_drivers_mobile=true&search_in_drivers_home=true";

                string signature = Md5("phone=" + phone + "&search_in_drivers_mobile=true&search_in_drivers_home=true" + Properties.Settings.Default.key_api);

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
                req.Method = "GET";
                req.Headers.Add("Signature: " + signature);
                req.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (StreamReader stream = new StreamReader(
                     resp.GetResponseStream(), Encoding.UTF8))
                {
                    tmp = stream.ReadToEnd();
                }
                if (tmp.Contains('"' + "code" + '"' + ':' + "100"))
                {
                    return "NOT_FOUND";
                }
                else
                {
                    Ar = tmp.Split(':');
                    Ar[5] = Ar[5].Trim('}');
                    return Ar[5];
                }
            }
            catch
            {
                return "Error Analyze_phone()";
            }
        }

        public bool Check_driver(string id)
        {
            string tmp;
            bool flag;

            try
            {
                string s = "https://" + Properties.Settings.Default.host +
                           ":" + Properties.Settings.Default.port + "/common_api/1.0/get_driver_info?driver_id=" + id + "&need_photo=false";

                string signature = Md5("driver_id=" + id + "&need_photo=false" + Properties.Settings.Default.key_api);

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
                req.Method = "GET";
                req.Headers.Add("Signature: " + signature);
                req.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (StreamReader stream = new StreamReader(
                     resp.GetResponseStream(), Encoding.UTF8))
                {
                    tmp = stream.ReadToEnd();
                }

                if (tmp.Contains('"' + "code" + '"' + ':' + "100"))
                {
                    flag = false;
                }
                else flag = tmp.Contains('"' + "is_dismissed" + '"' + ':' + "false");

                return flag;
            }
            catch
            {
                return false;
            }
        }

        public string POST(string Id, string Sum)
        {
            try
            {
                string s = "https://" + Properties.Settings.Default.host +
                           ":" + Properties.Settings.Default.port + "/common_api/1.0/create_driver_operation";

                string Data = "{" + '"' + "driver_id" + '"' + ':' + Id + "," + '"' + "oper_sum" + '"' + ':' + Sum + "," + '"' + "oper_type" + '"' + ':' + '"' + "receipt" + '"' + ',' +
                                                                                                    '"' + "name" + '"' + ':' + '"' + "QIWI or SB" + '"' + '}';

                string signature = Md5(Data + Properties.Settings.Default.key_api);

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
                req.Method = "POST";
                //req.Timeout = 100000;
                req.Headers.Add("Signature: " + signature);
                req.ContentType = "application/json";
                byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
                req.ContentLength = sentData.Length;
                Stream sendStream = req.GetRequestStream();
                sendStream.Write(sentData, 0, sentData.Length);
                sendStream.Close();
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
                Char[] read = new Char[256];
                int count = sr.Read(read, 0, 256);
                string Out = String.Empty;
                while (count > 0)
                {
                    String str = new String(read, 0, count);
                    Out += str;
                    count = sr.Read(read, 0, 256);
                }
                return Out;
            }
            catch
            {
                return "Error POST()";
            }
        }

        public string Create_dyn_priority(string type, string driver)
        {
            int priority = 100;

            DateTime current_day = new DateTime();
            current_day = DateTime.Now;

            string start_time = "";
            string finish_time = "";

            if ((type == "А") || (type == "A") || // установка времени приоритета c 08-00 до 08-00
                (type == "a") || (type == "а"))
            {
                start_time = current_day.ToString("yyyyMMdd") + "080000";
                finish_time = current_day.AddDays(1).ToString("yyyyMMdd") + "080000";
            };

            if ((type == "B") || (type == "В") ||// установка времени приоритета c 20-00 до 06-00
                (type == "B") || (type == "б"))
            {
                start_time = current_day.ToString("yyyyMMdd") + "200000";
                finish_time = current_day.AddDays(1).ToString("yyyyMMdd") + "060000";
            }

            if ((type == "C") || (type == "С") ||// установка времени приоритета user set
                (type == "c") || (type == "с"))
            {
                start_time = current_day.ToString("yyyyMMdd") + Properties.Settings.Default.C1 + "0000";
                finish_time = current_day.ToString("yyyyMMdd") + Properties.Settings.Default.C2 + "0000";
            }

            if ((type == "D") || (type == "d")) // установка времени приоритета время СЕГОДЯН/ЗАВТРА

            {
                start_time = current_day.ToString("yyyyMMdd") + Properties.Settings.Default.D1 + "0000";
                finish_time = current_day.AddDays(1).ToString("yyyyMMdd") + Properties.Settings.Default.D2 + "0000";
            };

            try
            {
                string s = "https://" + Properties.Settings.Default.host +
                           ":" + Properties.Settings.Default.port + "/common_api/1.0/create_driver_dyn_priority";

                string Data = "{" + '"' + "driver_id" + '"' + ':' + driver + "," + '"' +
                                          "priority" + '"' + ':' + priority + "," + '"' +
                                          "start_time" + '"' + ':' + '"' + start_time + '"' + ',' +
                                          '"' + "finish_time" + '"' + ':' + '"' + finish_time + '"' + ',' +
                                          '"' + "name" + '"' + ':' + '"' + driver + '"'
                             + '}';

                string signature = Md5(Data + Properties.Settings.Default.key_api);

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
                req.Method = "POST";
                //req.Timeout = 100000;
                req.Headers.Add("Signature: " + signature);
                req.ContentType = "application/json";
                byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
                req.ContentLength = sentData.Length;
                Stream sendStream = req.GetRequestStream();
                sendStream.Write(sentData, 0, sentData.Length);
                sendStream.Close();
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
                Char[] read = new Char[256];
                int count = sr.Read(read, 0, 256);
                string Out = String.Empty;
                while (count > 0)
                {
                    String str = new String(read, 0, count);
                    Out += str;
                    count = sr.Read(read, 0, 256);
                }
                return Out;
            }
            catch
            {
                return "Error Create_dyn_priority()";
            }
        }

        public string Chahge_order(string ORDER_id, string NEW_STATE)
        {
            string s = "https://" + Properties.Settings.Default.host + ":" + Properties.Settings.Default.port + "/common_api/1.0/change_order_state";
            string Data = "order_id=" + ORDER_id + "&new_state=" + NEW_STATE ;
            string signature = Md5(Data+ Properties.Settings.Default.key_api);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
            req.Method = "POST";
            //req.Timeout = 100000;
            req.Headers.Add("Signature: " + signature);
            req.ContentType = "application/x-www-form-urlencoded";
            byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream ReceiveStream = res.GetResponseStream();
            StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
            Char[] read = new Char[256];
            int count = sr.Read(read, 0, 256);
            string Out = String.Empty;
            while (count > 0)
            {
                String str = new String(read, 0, count);
                Out += str;
                count = sr.Read(read, 0, 256);
            }
            return Out;
        }

        public string Create_order(string ip)
        {
            const string q = "\"";            

            string s = "https://" + Properties.Settings.Default.host +
                           ":" + Properties.Settings.Default.port + "/common_api/1.0/create_order2";

           
           string Data = "{" + q + "phone" + q + ":" + q +"89886661515" + q + "," +
                        q + "server_time_offset" + q + ":0," + q + 
                        "source_time"+ q +":" + q + CurrentTime() + q + "," + q + 
                        "addresses" + q + ":[{" 
                                        + q + "address" + q + ":" + q + "Connection error GoIP " + ip + q + "," + q+ "lat" + q + ":" + "56.896817," + q + "lon" + q + ":53.147830," +
                                         q + "zone_id" + q + ":1," + q + "parking_id" + q +  ":2"+ 
                        "}]," + q + "order_params"+ q + ":[45]"
                        + "}";           

              string signature = Md5(Data + Properties.Settings.Default.key_api);
           
              ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
              HttpWebRequest req = (HttpWebRequest)WebRequest.Create(s);
              req.Method = "POST";
              //req.Timeout = 100000;
              req.Headers.Add("Signature: " + signature);
              req.ContentType = "application/json";
              byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
              req.ContentLength = sentData.Length;
              Stream sendStream = req.GetRequestStream();
              sendStream.Write(sentData, 0, sentData.Length);
              sendStream.Close();
              HttpWebResponse res = (HttpWebResponse)req.GetResponse();
              Stream ReceiveStream = res.GetResponseStream();
              StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
              Char[] read = new Char[256];
              int count = sr.Read(read, 0, 256);
              string Out = String.Empty;
              while (count > 0)
              {
                  String str = new String(read, 0, count);
                  Out += str;
                  count = sr.Read(read, 0, 256);
              }
              return Out;               
        }

    }
}
