Public Class Adminpin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If chktxt2.Text = "00560" Or chktxt2.Text = "034560" Or chktxt2.Text = "10203" Or chktxt2.Text = "30201" Then
            MsgBox("Access Granted")

            Me.Hide()
            BSU.GroupBox1.Enabled = 1
            BSU.GroupBox2.Enabled = 1
            BSU.Button41.Visible = 0
            BSU.Button47.Visible = 1




        Else
            MsgBox("Access Denied")
            chktxt2.Text = ""
            chktxt2.Focus()


        End If
    End Sub

    Private Sub Adminpin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim val As New ToolTip()
        val.ShowAlways = True
        val.SetToolTip(Button1, "Validate PIN")

        Dim Enter As New ToolTip()
        Enter.ShowAlways = True
        Enter.SetToolTip(chktxt2, "Enter PIN number")

    End Sub
End Class