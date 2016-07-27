Imports System
Imports Microsoft.VisualBasic
Imports System.IO

Public Class BSU

    Private Sub ICT_systemunitsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ICT_systemunitsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ICT_systemunitsDataSet)

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = 0
        GroupBox2.Enabled = 0
        Button47.Visible = 0
        '==============================================================================================

        Dim toolTip1 As New ToolTip()
        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(Button1, "Add New Data")
        toolTip1.SetToolTip(Button5, "Add New Data")
        toolTip1.SetToolTip(Button9, "Add New Data")
        toolTip1.SetToolTip(Button13, "Add New Data")
        toolTip1.SetToolTip(Button17, "Add New Data")
        toolTip1.SetToolTip(Button21, "Add New Data")
        toolTip1.SetToolTip(Button29, "Add New Data")
        toolTip1.SetToolTip(Button25, "Add New Data")




        Dim toolTip2 As New ToolTip()
        toolTip2.ShowAlways = True
        toolTip2.SetToolTip(Button33, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button34, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button35, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button36, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button37, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button38, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button39, "Cancel Adding New Data")
        toolTip2.SetToolTip(Button40, "Cancel Adding New Data")




        Dim toolTip3 As New ToolTip()
        toolTip3.ShowAlways = True
        toolTip3.SetToolTip(Button2, "Save or Update Data")
        toolTip3.SetToolTip(Button6, "Save or Update Data")
        toolTip3.SetToolTip(Button10, "Save or Update Data")
        toolTip3.SetToolTip(Button14, "Save or Update Data")
        toolTip3.SetToolTip(Button18, "Save or Update Data")
        toolTip3.SetToolTip(Button22, "Save or Update Data")
        toolTip3.SetToolTip(Button26, "Save or Update Data")
        toolTip3.SetToolTip(Button30, "Save or Update Data")





        Dim toolTip4 As New ToolTip()
        toolTip4.ShowAlways = True
        toolTip4.SetToolTip(Button3, "Delete Selected Data")
        toolTip4.SetToolTip(Button7, "Delete Selected Data")
        toolTip4.SetToolTip(Button11, "Delete Selected Data")
        toolTip4.SetToolTip(Button15, "Delete Selected Data")
        toolTip4.SetToolTip(Button19, "Delete Selected Data")
        toolTip4.SetToolTip(Button23, "Delete Selected Data")
        toolTip4.SetToolTip(Button27, "Delete Selected Data")
        toolTip4.SetToolTip(Button31, "Delete Selected Data")








        Dim toolTip5 As New ToolTip()
        toolTip5.ShowAlways = True
        toolTip5.SetToolTip(Button4, "Print this section")
        toolTip5.SetToolTip(Button8, "Print this section")
        toolTip5.SetToolTip(Button12, "Print this section")
        toolTip5.SetToolTip(Button16, "Print this section")
        toolTip5.SetToolTip(Button20, "Print this section")
        toolTip5.SetToolTip(Button24, "Print this section")
        toolTip5.SetToolTip(Button28, "Print this section")
        toolTip5.SetToolTip(Button32, "Print this section")



        Dim ena As New ToolTip()
        ena.ShowAlways = True
        ena.SetToolTip(Button41, "Enable this Features")

        Dim dis As New ToolTip()
        dis.ShowAlways = True
        dis.SetToolTip(Button47, "Disable this Features")





        Dim r1 As New ToolTip()
        r1.ShowAlways = True
        r1.SetToolTip(Button42, "Erase all data in this section")
        r1.SetToolTip(Button43, "Erase all data in this section")
        r1.SetToolTip(Button44, "Erase all data in this section")
        r1.SetToolTip(Button45, "Erase all data in this section")
        r1.SetToolTip(Button46, "Erase all data in this section")



        Dim bkup As New ToolTip()
        bkup.ShowAlways = True
        bkup.SetToolTip(Button48, "Backup All data in safe place")

        Dim rest As New ToolTip()
        rest.ShowAlways = True
        rest.SetToolTip(Button49, "Restore Data from a Backup")



        '=========================================================================================================











        'TODO: This line of code loads data into the 'Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits' table. You can move, or remove it, as needed.
        Me.Guidance_admission_systemunitsTableAdapter.Fill(Me.Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)
        'TODO: This line of code loads data into the 'Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk' table. You can move, or remove it, as needed.
        Me.CashierandReg_prt_spkTableAdapter.Fill(Me.Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)
        'TODO: This line of code loads data into the 'Cashier_Registrar_systemunitsDataSet.CashierandReg_su' table. You can move, or remove it, as needed.
        Me.CashierandReg_suTableAdapter.Fill(Me.Cashier_Registrar_systemunitsDataSet.CashierandReg_su)
        'TODO: This line of code loads data into the 'CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches' table. You can move, or remove it, as needed.
        Me.CISCOlab_routers_switchesTableAdapter.Fill(Me.CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)
        'TODO: This line of code loads data into the 'CISCOlab_systemunitsDataSet.CISCOlab' table. You can move, or remove it, as needed.
        Me.CISCOlabTableAdapter.Fill(Me.CISCOlab_systemunitsDataSet.CISCOlab)
        'TODO: This line of code loads data into the 'SoftLAB_systemunitsDataSet.SoftLAB_systemunits' table. You can move, or remove it, as needed.
        Me.SoftLAB_systemunitsTableAdapter.Fill(Me.SoftLAB_systemunitsDataSet.SoftLAB_systemunits)
        'TODO: This line of code loads data into the 'ICT_projectors_printers_speakersDataSet.ICT_pps' table. You can move, or remove it, as needed.
        Me.ICT_ppsTableAdapter.Fill(Me.ICT_projectors_printers_speakersDataSet.ICT_pps)
        'TODO: This line of code loads data into the 'ICT_systemunitsDataSet.ICT_systemunits' table. You can move, or remove it, as needed.
        Me.ICT_systemunitsTableAdapter.Fill(Me.ICT_systemunitsDataSet.ICT_systemunits)

        'ict cancel ko

        Button33.Visible = 0
        Button34.Visible = 0

        'soft lab cancel ko
        Button35.Visible = 0

        'cisco lab cancel ko
        Button36.Visible = 0
        Button37.Visible = 0

        'cash and reg cancel ko
        Button38.Visible = 0
        Button39.Visible = 0

        'guidance cancel ko
        Button40.Visible = 0






    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button33.Visible = 1
        Button1.Visible = 0


        Try
            Me.ICT_systemunitsBindingSource.AddNew()
            SystemUnitNoTextBox.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            SystemUnitNoTextBox.Focus()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button33.Visible = 0
            Button1.Visible = 1



            Try

                Me.Validate()
                Me.ICT_systemunitsBindingSource.EndEdit()
                Me.ICT_systemunitsTableAdapter.Update(ICT_systemunitsDataSet.ICT_systemunits)
                Me.ICT_systemunitsDataGridView.Sort(ICT_systemunitsDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.ICT_systemunitsTableAdapter.Fill(Me.ICT_systemunitsDataSet.ICT_systemunits)
                Me.ICT_systemunitsDataGridView.Refresh()

                MsgBox("Successfully Saved/Updated")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button33.Visible = 0
            Button1.Visible = 1


            Try

                Me.Validate()
                Me.ICT_systemunitsBindingSource.RemoveCurrent()
                Me.ICT_systemunitsBindingSource.EndEdit()
                Me.ICT_systemunitsTableAdapter.Update(ICT_systemunitsDataSet.ICT_systemunits)
                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete")
            End Try

        Else

            Me.ICT_systemunitsTableAdapter.Update(ICT_systemunitsDataSet.ICT_systemunits)


        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ICT_IGP_Print.Show()

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub ICT_systemunitsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICT_systemunitsBindingNavigator.RefreshItems

    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click

    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button34.Visible = 1
        Button5.Visible = 0

        Try
            Me.ICT_ppsBindingSource.AddNew()
            ProjectorNoTextBox.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            ProjectorNoTextBox.Focus()
        End Try


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button34.Visible = 0
            Button5.Visible = 1




            Try
                Me.Validate()
                Me.ICT_ppsBindingSource.EndEdit()
                Me.ICT_ppsTableAdapter.Update(ICT_projectors_printers_speakersDataSet.ICT_pps)


                ICT_ppsDataGridView.Sort(ICT_ppsDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.ICT_ppsTableAdapter.Fill(Me.ICT_projectors_printers_speakersDataSet.ICT_pps)
                MsgBox("Successfully Save")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else


        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button34.Visible = 0
            Button5.Visible = 1



            Try
                Me.Validate()
                Me.ICT_ppsBindingSource.RemoveCurrent()
                Me.ICT_ppsBindingSource.EndEdit()
                Me.ICT_ppsTableAdapter.Update(ICT_projectors_printers_speakersDataSet.ICT_pps)
                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete")
            End Try

        Else
            Me.ICT_ppsTableAdapter.Update(ICT_projectors_printers_speakersDataSet.ICT_pps)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ICTpps.Show()

    End Sub

    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button35.Visible = 1
        Button9.Visible = 0

        Try
            SoftLAB_systemunitsBindingSource.AddNew()
            SystemUnitNoTextBox1.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            SystemUnitNoTextBox1.Focus()
        End Try



    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button35.Visible = 0
            Button9.Visible = 1


            Try
                Me.Validate()
                Me.SoftLAB_systemunitsBindingSource.EndEdit()
                Me.SoftLAB_systemunitsTableAdapter.Update(SoftLAB_systemunitsDataSet.SoftLAB_systemunits)
                SoftLAB_systemunitsDataGridView.Sort(SoftLAB_systemunitsDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.SoftLAB_systemunitsTableAdapter.Fill(Me.SoftLAB_systemunitsDataSet.SoftLAB_systemunits)


                MsgBox("Successfully Saved/Updated")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button35.Visible = 0
            Button9.Visible = 1


            Try
                Me.Validate()
                Me.SoftLAB_systemunitsBindingSource.RemoveCurrent()
                Me.SoftLAB_systemunitsBindingSource.EndEdit()
                Me.SoftLAB_systemunitsTableAdapter.Update(SoftLAB_systemunitsDataSet.SoftLAB_systemunits)
                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete")
            End Try
        Else

        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Softlabsuprint.Show()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Button36.Visible = 1
        Button13.Visible = 0
        Try
            Me.CISCOlabBindingSource.AddNew()
            SystemUnitNoTextBox2.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            SystemUnitNoTextBox2.Focus()
        End Try


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button36.Visible = 0
            Button13.Visible = 1


            Try
                Me.Validate()
                Me.CISCOlabBindingSource.EndEdit()
                Me.CISCOlabTableAdapter.Update(CISCOlab_systemunitsDataSet.CISCOlab)

                CISCOlabDataGridView.Sort(CISCOlabDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.CISCOlabTableAdapter.Fill(Me.CISCOlab_systemunitsDataSet.CISCOlab)

                MsgBox("Successfully Saved")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Button36.Visible = 0
            Button13.Visible = 1


            Try
                Me.Validate()
                Me.CISCOlabBindingSource.RemoveCurrent()
                Me.CISCOlabBindingSource.EndEdit()
                Me.CISCOlabTableAdapter.Update(CISCOlab_systemunitsDataSet.CISCOlab)
                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete!!!")
            End Try
        Else


        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Ciscolabsu.Show()

    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button37.Visible = 1
        Button17.Visible = 0
        Try
            Me.CISCOlab_routers_switchesBindingSource.AddNew()
            RouterNoTextBox.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            RouterNoTextBox.Focus()
        End Try


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Button37.Visible = 0
            Button17.Visible = 1

            Try
                Me.Validate()
                Me.CISCOlab_routers_switchesBindingSource.EndEdit()
                Me.CISCOlab_routers_switchesTableAdapter.Update(CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)

                CISCOlab_routers_switchesDataGridView.Sort(CISCOlab_routers_switchesDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.CISCOlab_routers_switchesTableAdapter.Fill(Me.CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)


                MsgBox("Successfully Saved/Updated")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Button37.Visible = 0
            Button17.Visible = 1

            Try
                Me.Validate()
                Me.CISCOlab_routers_switchesBindingSource.RemoveCurrent()
                Me.CISCOlab_routers_switchesBindingSource.EndEdit()
                Me.CISCOlab_routers_switchesTableAdapter.Update(CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)

                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        CISCOrs.Show()

    End Sub

    Private Sub TabPage11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage11.Click

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button38.Visible = 1
        Button21.Visible = 0

        Try
            Me.CashierandReg_suBindingSource.AddNew()
            SystemUnitNoTextBox3.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            SystemUnitNoTextBox3.Focus()
        End Try

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Button38.Visible = 0
            Button21.Visible = 1

            Try
                Me.Validate()
                Me.CashierandReg_suBindingSource.EndEdit()
                Me.CashierandReg_suTableAdapter.Update(Cashier_Registrar_systemunitsDataSet.CashierandReg_su)

                CashierandReg_suDataGridView.Sort(CashierandReg_suDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.CashierandReg_suTableAdapter.Fill(Me.Cashier_Registrar_systemunitsDataSet.CashierandReg_su)


                MsgBox("Successfully Saved")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Button38.Visible = 0
            Button21.Visible = 1

            Try
                Me.Validate()
                Me.CashierandReg_suBindingSource.RemoveCurrent()
                Me.CashierandReg_suBindingSource.EndEdit()
                Me.CashierandReg_suTableAdapter.Update(Cashier_Registrar_systemunitsDataSet.CashierandReg_su)

                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete!!!")
            End Try
        Else


        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        CRsu.Show()

    End Sub

    Private Sub TabPage12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage12.Click

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Button39.Visible = 1
        Button25.Visible = 0
        Try
            Me.CashierandReg_prt_spkBindingSource.AddNew()
            PrinterNoTextBox1.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            PrinterNoTextBox1.Focus()
        End Try

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Button39.Visible = 0
            Button25.Visible = 1

            Try
                Me.Validate()
                Me.CashierandReg_prt_spkBindingSource.EndEdit()
                Me.CashierandReg_prt_spkTableAdapter.Update(Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)

                CashierandReg_prt_spkDataGridView.Sort(CashierandReg_prt_spkDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.CashierandReg_prt_spkTableAdapter.Fill(Me.Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)

                MsgBox("Successfully Saved/Updated")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Button39.Visible = 0
            Button25.Visible = 1
            Try
                Me.Validate()
                Me.CashierandReg_prt_spkBindingSource.RemoveCurrent()
                Me.CashierandReg_prt_spkBindingSource.EndEdit()
                Me.CashierandReg_prt_spkTableAdapter.Update(Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)
                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete!!!")
            End Try
        Else


        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        CRps.Show()

    End Sub

    Private Sub TabPage13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage13.Click

    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Button40.Visible = 1
        Button29.Visible = 0
        Try
            Me.Guidance_admission_systemunitsBindingSource.AddNew()
            SystemUnitNoTextBox4.Focus()
        Catch ex As Exception
            MsgBox("Add New Already clicked!!!")
            SystemUnitNoTextBox4.Focus()
        End Try

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Dim result As Integer = MessageBox.Show("Do you want to delete this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Button40.Visible = 0
            Button29.Visible = 1
            Try
                Me.Validate()
                Me.Guidance_admission_systemunitsBindingSource.RemoveCurrent()
                Me.Guidance_admission_systemunitsBindingSource.EndEdit()
                Me.Guidance_admission_systemunitsTableAdapter.Update(Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)

                MsgBox("Successfully Deleted")

            Catch ex As Exception
                MsgBox("No files to delete!!!")
            End Try
        Else

        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Dim result As Integer = MessageBox.Show("Do you want to save/update this?", "Administrator", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Button40.Visible = 0
            Button29.Visible = 1
            Try
                Me.Validate()
                Me.Guidance_admission_systemunitsBindingSource.EndEdit()
                Me.Guidance_admission_systemunitsTableAdapter.Update(Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)

                Guidance_admission_systemunitsDataGridView.Sort(Guidance_admission_systemunitsDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                Me.Guidance_admission_systemunitsTableAdapter.Fill(Me.Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)
                MsgBox("Successfully Saved/Updated")


            Catch ex As Exception
                MsgBox("An error occured while saving!!!")
            End Try
        Else


        End If
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        GAsu.Show()

    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Button33.Visible = 0
        Button1.Visible = 1
        ICT_systemunitsBindingSource.CancelEdit()

    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Button34.Visible = 0
        Button5.Visible = 1
        ICT_ppsBindingSource.CancelEdit()

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Button35.Visible = 0
        Button9.Visible = 1
        SoftLAB_systemunitsBindingSource.CancelEdit()

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Button36.Visible = 0
        Button13.Visible = 1
        CISCOlabBindingSource.CancelEdit()

    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Button37.Visible = 0
        Button17.Visible = 1
        CISCOlab_routers_switchesBindingSource.CancelEdit()

    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Button38.Visible = 0
        Button21.Visible = 1
        CashierandReg_suBindingSource.CancelEdit()


    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Button39.Visible = 0
        Button25.Visible = 1
        CashierandReg_prt_spkBindingSource.CancelEdit()

    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Button40.Visible = 0
        Button29.Visible = 1
        Guidance_admission_systemunitsBindingSource.CancelEdit()

    End Sub

    Private Sub ICT_systemunitsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ICT_systemunitsDataGridView.CellContentClick

    End Sub

    Private Sub Guidance_admission_systemunitsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Guidance_admission_systemunitsDataGridView.CellContentClick

    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        '=================================================================================================================
        Dim result As Integer = MessageBox.Show("Do you want to Reset all data?", "Administrator", MessageBoxButtons.YesNo)

        Dim res As Integer
        Dim res2 As Integer

        res = 1
        res2 = 1


        If result = DialogResult.Yes Then


            Do While res = 1
                Try

                    Me.Validate()
                    Me.ICT_systemunitsBindingSource.RemoveCurrent()
                    Me.ICT_systemunitsBindingSource.EndEdit()
                    Me.ICT_systemunitsTableAdapter.Update(ICT_systemunitsDataSet.ICT_systemunits)


                Catch ex As Exception
                    res = 0

                End Try
            Loop



            Do While res2 = 1
                Try
                    Me.Validate()
                    Me.ICT_ppsBindingSource.RemoveCurrent()
                    Me.ICT_ppsBindingSource.EndEdit()
                    Me.ICT_ppsTableAdapter.Update(ICT_projectors_printers_speakersDataSet.ICT_pps)


                Catch ex As Exception

                    res2 = 0

                End Try
            Loop
            MsgBox("Successfully Reset")

        Else
            Me.ICT_systemunitsTableAdapter.Update(ICT_systemunitsDataSet.ICT_systemunits)
            Me.ICT_ppsTableAdapter.Update(ICT_projectors_printers_speakersDataSet.ICT_pps)

        End If

        '=================================================================================================================

    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        '=================================================================================================================
        Dim result As Integer = MessageBox.Show("Do you want to Reset all data?", "Administrator", MessageBoxButtons.YesNo)

        Dim res As Integer


        res = 1



        If result = DialogResult.Yes Then


            Do While res = 1
                Try
                    Me.Validate()
                    Me.SoftLAB_systemunitsBindingSource.RemoveCurrent()
                    Me.SoftLAB_systemunitsBindingSource.EndEdit()
                    Me.SoftLAB_systemunitsTableAdapter.Update(SoftLAB_systemunitsDataSet.SoftLAB_systemunits)


                Catch ex As Exception
                    res = 0

                End Try
            Loop




            MsgBox("Successfully Reset")

        Else


        End If

        '=================================================================================================================

    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        '=================================================================================================================
        Dim result As Integer = MessageBox.Show("Do you want to Reset all data?", "Administrator", MessageBoxButtons.YesNo)

        Dim res As Integer
        Dim res2 As Integer

        res = 1
        res2 = 1


        If result = DialogResult.Yes Then


            Do While res = 1
                Try

                    Me.Validate()
                    Me.CISCOlabBindingSource.RemoveCurrent()
                    Me.CISCOlabBindingSource.EndEdit()
                    Me.CISCOlabTableAdapter.Update(CISCOlab_systemunitsDataSet.CISCOlab)


                Catch ex As Exception
                    res = 0

                End Try
            Loop



            Do While res2 = 1
                Try
                    Me.Validate()
                    Me.CISCOlab_routers_switchesBindingSource.RemoveCurrent()
                    Me.CISCOlab_routers_switchesBindingSource.EndEdit()
                    Me.CISCOlab_routers_switchesTableAdapter.Update(CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)



                Catch ex As Exception

                    res2 = 0

                End Try
            Loop
            MsgBox("Successfully Reset")

        Else


        End If

        '=================================================================================================================

    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        '=================================================================================================================
        Dim result As Integer = MessageBox.Show("Do you want to Reset all data?", "Administrator", MessageBoxButtons.YesNo)

        Dim res As Integer
        Dim res2 As Integer

        res = 1
        res2 = 1


        If result = DialogResult.Yes Then


            Do While res = 1
                Try

                    Me.Validate()
                    Me.CashierandReg_suBindingSource.RemoveCurrent()
                    Me.CashierandReg_suBindingSource.EndEdit()
                    Me.CashierandReg_suTableAdapter.Update(Cashier_Registrar_systemunitsDataSet.CashierandReg_su)


                Catch ex As Exception
                    res = 0

                End Try
            Loop



            Do While res2 = 1
                Try
                    Me.Validate()
                    Me.CashierandReg_prt_spkBindingSource.RemoveCurrent()
                    Me.CashierandReg_prt_spkBindingSource.EndEdit()
                    Me.CashierandReg_prt_spkTableAdapter.Update(Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)

                Catch ex As Exception

                    res2 = 0

                End Try
            Loop
            MsgBox("Successfully Reset")

        Else


        End If

        '=================================================================================================================

    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        '=================================================================================================================
        Dim result As Integer = MessageBox.Show("Do you want to Reset all data?", "Administrator", MessageBoxButtons.YesNo)

        Dim res As Integer


        res = 1



        If result = DialogResult.Yes Then


            Do While res = 1
                Try

                    Me.Validate()
                    Me.Guidance_admission_systemunitsBindingSource.RemoveCurrent()
                    Me.Guidance_admission_systemunitsBindingSource.EndEdit()
                    Me.Guidance_admission_systemunitsTableAdapter.Update(Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)



                Catch ex As Exception
                    res = 0

                End Try
            Loop



            MsgBox("Successfully Reset")

        Else


        End If

        '=================================================================================================================

    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Adminpin.Show()
        Adminpin.chktxt2.Text = ""
        Adminpin.chktxt2.Focus()


        Button41.Visible = 1



    End Sub

  

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Try ' ito yung back up ko
            Dim result As Integer = MessageBox.Show("Do you want to backup data?", "Administrator", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Directory.CreateDirectory("C:\BSU Backup")
                    Directory.CreateDirectory("D:\BSU Backup")
                    'bkup para sa cashier printers
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_printers-speakers.accdb", "C:\BSU Backup\Cashier_Registrar_printers-speakers.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_printers-speakers.accdb", "D:\BSU Backup\Cashier_Registrar_printers-speakers.accdb")

                    'bkup para sa cashier su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_systemunits.accdb", "C:\BSU Backup\Cashier_Registrar_systemunits.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_systemunits.accdb", "D:\BSU Backup\Cashier_Registrar_systemunits.accdb")

                    'bkup para sa cashier csico lab routers
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_routers_switches.accdb", "C:\BSU Backup\CISCOlab_routers_switches.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_routers_switches.accdb", "D:\BSU Backup\CISCOlab_routers_switches.accdb")

                    'bkup para sa cashier csico lab su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_systemunits.accdb", "C:\BSU Backup\CISCOlab_systemunits.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_systemunits.accdb", "D:\BSU Backup\CISCOlab_systemunits.accdb")

                    'bkup para guidance admission su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Guidance_Admission_systemunits.accdb", "C:\BSU Backup\Guidance_Admission_systemunits.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Guidance_Admission_systemunits.accdb", "D:\BSU Backup\Guidance_Admission_systemunits.accdb")


                    'bkup para ict print
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_projectors-printers-speakers.accdb", "C:\BSU Backup\ICT_projectors-printers-speakers.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_projectors-printers-speakers.accdb", "D:\BSU Backup\ICT_projectors-printers-speakers.accdb")


                    'bkup para ict print
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_systemunits.accdb", "C:\BSU Backup\ICT_systemunits.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_systemunits.accdb", "D:\BSU Backup\ICT_systemunits.accdb")

                    'bkup para softlab
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\SoftLAB_systemunits.accdb", "C:\BSU Backup\SoftLAB_systemunits.accdb")
                    FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\SoftLAB_systemunits.accdb", "D:\BSU Backup\SoftLAB_systemunits.accdb")





                    MsgBox("BackUp Successfully!!!" & vbCrLf & "D:\BSU Backup")

                Catch ex As Exception
                    MsgBox("Back up Error!!!" & vbCrLf & vbCrLf & "Maybe you are in a shared network")
                End Try


            Else
                MsgBox("BackUp Cancelled!!!")

            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Button41.Visible = 1
        Button47.Visible = 0
        GroupBox1.Enabled = 0
        GroupBox2.Enabled = 0

    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Try ' ito yung restore data
            Dim result As Integer = MessageBox.Show("Do you want to restore from back up?", "Administrator", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                   
                    'bkup para sa cashier printers
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_printers-speakers.accdb", "C:\BSU Backup\Cashier_Registrar_printers-speakers.accdb")
                    FileCopy("D:\BSU Backup\Cashier_Registrar_printers-speakers.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_printers-speakers.accdb")

                    'bkup para sa cashier su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_systemunits.accdb", "C:\BSU Backup\Cashier_Registrar_systemunits.accdb")
                    FileCopy("D:\BSU Backup\Cashier_Registrar_systemunits.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Cashier_Registrar_systemunits.accdb")

                    'bkup para sa cashier csico lab routers
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_routers_switches.accdb", "C:\BSU Backup\CISCOlab_routers_switches.accdb")
                    FileCopy("D:\BSU Backup\CISCOlab_routers_switches.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_routers_switches.accdb")

                    'bkup para sa cashier csico lab su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_systemunits.accdb", "C:\BSU Backup\CISCOlab_systemunits.accdb")
                    FileCopy("D:\BSU Backup\CISCOlab_systemunits.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\CISCOlab_systemunits.accdb")

                    'bkup para guidance admission su
                    ' FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Guidance_Admission_systemunits.accdb", "C:\BSU Backup\Guidance_Admission_systemunits.accdb")
                    FileCopy("D:\BSU Backup\Guidance_Admission_systemunits.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\Guidance_Admission_systemunits.accdb")


                    'bkup para ict print
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_projectors-printers-speakers.accdb", "C:\BSU Backup\ICT_projectors-printers-speakers.accdb")
                    FileCopy("D:\BSU Backup\ICT_projectors-printers-speakers.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_projectors-printers-speakers.accdb")


                    'bkup para ict print
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_systemunits.accdb", "C:\BSU Backup\ICT_systemunits.accdb")
                    FileCopy("D:\BSU Backup\ICT_systemunits.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\ICT_systemunits.accdb")

                    'bkup para softlab
                    'FileCopy("C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\SoftLAB_systemunits.accdb", "C:\BSU Backup\SoftLAB_systemunits.accdb")
                    FileCopy("D:\BSU Backup\SoftLAB_systemunits.accdb", "C:\Users\MJgutierrez\Desktop\BSU\BSU\BSUEquipments\BSUEquipments\bin\Debug\SoftLAB_systemunits.accdb")





                    MsgBox("Restored Successfully!!!")

                    MsgBox("Please Reboot Application")

                    Me.Close()


                Catch ex As Exception
                    MsgBox("Restoration Error!!!" & vbCrLf & vbCrLf & "Maybe you are in a shared network")
                End Try


            Else
                MsgBox("Restoration Cancelled!!!")

            End If

        Catch ex As Exception

        End Try


    End Sub
End Class
