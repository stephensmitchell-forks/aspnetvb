Imports Microsoft.AspNetCore
Imports Microsoft.AspNetCore.Hosting

Class Program

    Shared Sub Main(args As String())
        BuildWebHost(args).Run()
    End Sub

    Public Shared Function BuildWebHost(args() As String) As IWebHost
        Return WebHost.CreateDefaultBuilder(args).UseStartup(Of Startup)().Build()
    End Function

End Class