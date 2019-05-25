using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace WebApiSelfHost
{
    public class MyService
    {
        public static readonly string BaseAddress = "http://localhost:9001/";

        public static void Run(){

            //A work-around
            //Explicitly load assembly
            //Reference https://stackoverflow.com/questions/30050588/system-missingmemberexception-the-server-factory-could-not-be-located-startin
            AppDomain.CurrentDomain.Load(typeof(Microsoft.Owin.Host.HttpListener.OwinHttpListener).Assembly.GetName()); 

            // Start OWIN host 
            WebApp.Start<Startup>(url: MyService.BaseAddress);
        }
    }
}
