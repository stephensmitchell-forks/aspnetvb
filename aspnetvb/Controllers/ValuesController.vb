Imports Microsoft.AspNetCore.Mvc

Namespace Controllers

    <Route("api/[controller]")>
    Public Class ValuesController
        Inherits Controller

        <HttpGet>
        Public Function [Get]() As IEnumerable(Of String)
            Return {"value1", "value2"}
        End Function

        <HttpGet("{id}")>
        Public Function [Get](id As Integer) As String
            Return "value"
        End Function

        <HttpPost>
        Public Sub Post(<FromBody> value As String)
        End Sub

        <HttpPut("{id}")>
        Public Sub Put(id As Integer, <FromBody> value As String)
        End Sub

        <HttpDelete("{id}")>
        Public Sub Delete(id As Integer)
        End Sub

    End Class

End Namespace