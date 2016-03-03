using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace Sandbox
{
    public class Startup
    {
        private int visitorNumber = 0;
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            visitorNumber++;
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("You are visitor number: " + visitorNumber);
            });
        }
    }
}
