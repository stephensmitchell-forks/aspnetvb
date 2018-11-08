Imports Microsoft.EntityFrameworkCore

Public Class ValuesContextVb
    Inherits DbContext

    Public Sub New(ByVal options As DbContextOptions(Of ValuesContextVb))
        MyBase.New(options)
    End Sub

    Public Property TodoItems As DbSet(Of ValuesItemVb)

End Class