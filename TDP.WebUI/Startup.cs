﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDP.WebUI.Startup))]
namespace TDP.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
