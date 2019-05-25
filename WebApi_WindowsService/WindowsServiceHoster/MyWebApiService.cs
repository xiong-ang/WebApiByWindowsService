using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WebApiSelfHost;

namespace WindowsServiceHoster
{
    public partial class MyWebApiService : ServiceBase
    {
        public MyWebApiService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WebApiSelfHost.MyService.Run();
        }

        protected override void OnStop()
        {
        }
    }
}
