Imports System.Threading

Public Class Splash
    Dim threadMain As New Thread(AddressOf ConnectThread)

    'Draggable Form code
    Dim boolDrag As Boolean
    Dim intMouseX As Integer
    Dim intMouseY As Integer


    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub connectThread()
        Call RunConnection()
    End Sub

    Private Sub Splash_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        threadMain.Start()
        threadMain.Join()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progLoad.Increment(5)

        If progLoad.Value = 100 Then
            Login.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub

End Class
