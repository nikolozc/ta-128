Public Class Form1

    Private persArray As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intIndex As Integer = 1 To 50
            Dim newPers As New Person
            NumericUpDown1.Value = Person.minAge
            newPers.pName = "Sam " & intIndex
            persArray.Add(newPers)
        Next
        UpdateList()
    End Sub

    Private Sub UpdateList()
        ListBox1.Items.Clear()
        For Each thePerson As Person In persArray
            ListBox1.Items.Add(thePerson.pName & " minimum age " & Person.minAge)
        Next
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Person.minAge = NumericUpDown1.Value
        UpdateList()
    End Sub
End Class


Public Class Person

    Public pName As String
    Public Shared minAge As Integer = 16

End Class