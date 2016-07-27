Public Class Pin

    Private Sub Pin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BSU.Show()
        chktxt.Focus()

        Dim val As New ToolTip()
        val.ShowAlways = True
        val.SetToolTip(Button1, "Validate PIN")

        Dim Enter As New ToolTip()
        Enter.ShowAlways = True
        Enter.SetToolTip(chktxt, "Enter PIN number")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If chktxt.Text = "00000" Or chktxt.Text = "00560" Or chktxt.Text = "034560" Or chktxt.Text = "10203" Or chktxt.Text = "30201" Then
            MsgBox("Access Granted")

            Me.Hide()
            BSU.Enabled = 1
            BSU.Show()

        Else
            MsgBox("Access Denied")
            chktxt.Text = ""
            chktxt.Focus()


        End If
    End Sub
End Class