Public Class Form1

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        If Txtusername.Text = "amani" And Txtpassword.Text = "13131" Then
            MsgBox("You login succefully")
            Txtusername.Text = ""
            Txtpassword.Text = ""
            newcustomerdetails.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Username or Password")
            Txtusername.Text = ""
            Txtpassword.Text = ""
        End If
    End Sub

    Private Sub Txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpassword.TextChanged
       
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
