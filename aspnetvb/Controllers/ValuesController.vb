Imports Microsoft.AspNetCore.Mvc
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.IO

Namespace Controllers

    <Route("api/[controller]")>
    Public Class ValuesController
        Inherits ControllerBase




        Private ReadOnly _context As ValuesContextVb

        Public Sub New(ByVal context As ValuesContextVb)
            _context = context

            If _context.TodoItems.Count() = 0 Then
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item1a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item2a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item3a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item4a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item5a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item6a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item7a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item8a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item9a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item10a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item11a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item12a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item13a"
                })
                _context.TodoItems.Add(New ValuesItemVb With {
                    .Name = "Item14a"
                })
                _context.SaveChanges()
            End If
        End Sub


        '<HttpGet>
        'Public Function [Get]() As IEnumerable(Of String)
        '    Return {"value1", "value2"}
        'End Function

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

        <HttpGet>
        Public Function GetAll() As ActionResult(Of List(Of ValuesItemVb))
            Return _context.TodoItems.ToList()
        End Function

        <HttpGet("{id}", Name:="GetTodo")>
        Public Function GetById(ByVal id As Long) As ActionResult(Of ValuesItemVb)
            Dim item = _context.TodoItems.Find(id)

            If item Is Nothing Then
                Return NotFound()
            End If

            Return item
        End Function

    End Class

End Namespace