<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRsu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRsu))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Cashier_Registrar_systemunitsDataSet = New BSUEquipments.Cashier_Registrar_systemunitsDataSet()
        Me.CashierandReg_suBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashierandReg_suTableAdapter = New BSUEquipments.Cashier_Registrar_systemunitsDataSetTableAdapters.CashierandReg_suTableAdapter()
        CType(Me.Cashier_Registrar_systemunitsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashierandReg_suBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CashierandReg_suBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.CRsu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(853, 403)
        Me.ReportViewer1.TabIndex = 0
        '
        'Cashier_Registrar_systemunitsDataSet
        '
        Me.Cashier_Registrar_systemunitsDataSet.DataSetName = "Cashier_Registrar_systemunitsDataSet"
        Me.Cashier_Registrar_systemunitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CashierandReg_suBindingSource
        '
        Me.CashierandReg_suBindingSource.DataMember = "CashierandReg_su"
        Me.CashierandReg_suBindingSource.DataSource = Me.Cashier_Registrar_systemunitsDataSet
        '
        'CashierandReg_suTableAdapter
        '
        Me.CashierandReg_suTableAdapter.ClearBeforeFill = True
        '
        'CRsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 403)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CRsu"
        Me.Text = "Cashier / Registrar Print Report "
        CType(Me.Cashier_Registrar_systemunitsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashierandReg_suBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CashierandReg_suBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cashier_Registrar_systemunitsDataSet As BSUEquipments.Cashier_Registrar_systemunitsDataSet
    Friend WithEvents CashierandReg_suTableAdapter As BSUEquipments.Cashier_Registrar_systemunitsDataSetTableAdapters.CashierandReg_suTableAdapter
End Class
