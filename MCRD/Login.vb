Public Class Login

    'Draggable Form code
    Dim boolDrag As Boolean
    Dim intMouseX As Integer
    Dim intMouseY As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boolDrag = False
    End Sub

    Private Sub pnlTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseDown
        boolDrag = True

        intMouseX = Cursor.Position.X - Me.Left
        intMouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pnlTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseMove
        If boolDrag Then
            Me.Top = Cursor.Position.Y - intMouseY
            Me.Left = Cursor.Position.X - intMouseX
        End If
    End Sub

    Private Sub pnlTitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseUp
        boolDrag = False
    End Sub

    'Main code

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub

    Private Sub lblClose_MouseHover(sender As Object, e As EventArgs) Handles lblClose.MouseHover
        lblClose.ForeColor = System.Drawing.Color.LightCoral
    End Sub

    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim stDestination As String

        stDestination = ValidateCredentials(txtUserName.Text, txtPassword.Text)

        If stDestination = "admin" Then
            Me.Hide()
            Administrator.Show()
        ElseIf stDestination = "consultation" Then
            Me.Hide()
            Consultation.Show()
        ElseIf stDestination = "laboratory" Then
            Me.Hide()
            Laboratory.Show()
        ElseIf stDestination = "business" Then
            Me.Hide()
            BusinessOffice.Show()
        Else
            MsgBox("Invalid Username and/or Password")
        End If
    End Sub

End Class