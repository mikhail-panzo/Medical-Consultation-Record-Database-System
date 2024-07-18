Imports IBM.Data.DB2

Module PublicAccess

    Public Con As Common.DbConnection
    Public sql As String
    Public cmd As DB2Command
    Public dt As DataTable
    Public ds As DataSet
    Public adapter As DB2DataAdapter
    Public builder As DB2CommandBuilder

    Public Sub RunConnection()
        Con = New DB2Connection("Server=localhost:25000;Database=mcrddb;UID=db2admin;PWD=password;")

        Con.Open()
        Con.Close()
    End Sub

    Public Sub UpdateDataSet()

    End Sub

    Public Function ValidateCredentials(stUser As String, stPassword As String) As String
        Dim stKey As String

        If stUser = "admin" And stPassword = "admin" Then
            stKey = "admin"
        ElseIf stUser = "consultation" And stPassword = "consultation" Then
            stKey = "consultation"
        ElseIf stUser = "laboratory" And stPassword = "laboratory" Then
            stKey = "laboratory"
        ElseIf stUser = "business" And stPassword = "business" Then
            stKey = "business"
        Else
            stKey = ""
        End If

        Return stKey
    End Function

End Module
