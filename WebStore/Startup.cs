using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace WebStore
{
    public class Startup
    {
        private readonly IConfiguration _Configuration;

        //�������� ������ � appsetings.json
        //��� ����� ��� ����������� ����������� ������ Startup
        public Startup(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        // ����� ������������ �������� ������ ����������
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // ����� ������������ ����� �������� � ������� ��������� �������� ��������
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
