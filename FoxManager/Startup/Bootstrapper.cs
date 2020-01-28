using Autofac;
using FoxManager.ViewModel;
using FoxManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxManager.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            /////////////////////////////////////////////////////////////////////////////////
            // Register View Model
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();

            return builder.Build();
        }
    }
}
