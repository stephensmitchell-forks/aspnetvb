Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.EntityFrameworkCore


Public Class Startup

    Public Sub New(configuration As IConfiguration)
        Me.Configuration = configuration
    End Sub


    Public ReadOnly Property Configuration As IConfiguration


    Public Sub ConfigureServices(services As IServiceCollection)

        services.AddMvc()
        services.AddDbContext(Of ValuesContextVb)(Function(opt) opt.UseInMemoryDatabase("ValuesList"))


    End Sub


    Public Sub Configure(app As IApplicationBuilder, env As IHostingEnvironment)
        If env.IsDevelopment() Then
            app.UseDeveloperExceptionPage()
        End If

        app.UseMvc()
    End Sub

End Class
