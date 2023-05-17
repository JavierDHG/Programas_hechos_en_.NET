using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace App_Solicitud
{
    class Program
    {
        static void Main()
        {
            HttpWebRequest request = WebRequest.Create("http://taxisws.widetech.co/API/rest/CabSimpleResponse") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; //"application/json; charset=utf-8";
            request.Headers.Add("Name:USR,Value:taxi");
            request.Headers.Add("Name:PASS,Value:taxi");
            request.Headers.Add("Name:CLIENTEID,Value:51776");
            request.Headers.Add("Name:METHOD,Value:GETVEHICLETYPE");

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string resp = reader.ReadToEnd();
        }
    }
}
