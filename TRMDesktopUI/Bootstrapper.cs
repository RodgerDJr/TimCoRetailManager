using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            AppDomainInitializer();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewfor<ShellViewModel>();
        }
    }
}
