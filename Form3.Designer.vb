<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet1 = New FinalProject.KarateDataSet1()
        Me.PaymentsTableAdapter = New FinalProject.KarateDataSet1TableAdapters.PaymentsTableAdapter()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.All_RecordsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.All_RecordsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Over50ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Over50ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnTotal = New System.Windows.Forms.ToolStripButton()
        Me.btnTotal2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.All_RecordsToolStrip.SuspendLayout()
        Me.Over50ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPayments
        '
        Me.dgvPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.AutoGenerateColumns = False
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MemberIdDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.PaymentsBindingSource
        Me.dgvPayments.Location = New System.Drawing.Point(45, 164)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersWidth = 51
        Me.dgvPayments.RowTemplate.Height = 24
        Me.dgvPayments.Size = New System.Drawing.Size(722, 290)
        Me.dgvPayments.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'MemberIdDataGridViewTextBoxColumn
        '
        Me.MemberIdDataGridViewTextBoxColumn.DataPropertyName = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn.HeaderText = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberIdDataGridViewTextBoxColumn.Name = "MemberIdDataGridViewTextBoxColumn"
        Me.MemberIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberIdDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentDateDataGridViewTextBoxColumn.Width = 125
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KarateDataSet1
        '
        'KarateDataSet1
        '
        Me.KarateDataSet1.DataSetName = "KarateDataSet1"
        Me.KarateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(577, 64)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 33)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'All_RecordsToolStrip
        '
        Me.All_RecordsToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.All_RecordsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.All_RecordsToolStripButton, Me.btnTotal})
        Me.All_RecordsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.All_RecordsToolStrip.Name = "All_RecordsToolStrip"
        Me.All_RecordsToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.All_RecordsToolStrip.TabIndex = 2
        Me.All_RecordsToolStrip.Text = "All_RecordsToolStrip"
        '
        'All_RecordsToolStripButton
        '
        Me.All_RecordsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.All_RecordsToolStripButton.Name = "All_RecordsToolStripButton"
        Me.All_RecordsToolStripButton.Size = New System.Drawing.Size(90, 24)
        Me.All_RecordsToolStripButton.Text = "All_Records"
        '
        'Over50ToolStrip
        '
        Me.Over50ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Over50ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Over50ToolStripButton, Me.btnTotal2})
        Me.Over50ToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.Over50ToolStrip.Name = "Over50ToolStrip"
        Me.Over50ToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.Over50ToolStrip.TabIndex = 3
        Me.Over50ToolStrip.Text = "Over50ToolStrip"
        '
        'Over50ToolStripButton
        '
        Me.Over50ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Over50ToolStripButton.Name = "Over50ToolStripButton"
        Me.Over50ToolStripButton.Size = New System.Drawing.Size(60, 24)
        Me.Over50ToolStripButton.Text = "Over50"
        '
        'btnTotal
        '
        Me.btnTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTotal.Image = CType(resources.GetObject("btnTotal.Image"), System.Drawing.Image)
        Me.btnTotal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(112, 24)
        Me.btnTotal.Text = "Total Payments"
        '
        'btnTotal2
        '
        Me.btnTotal2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTotal2.Image = CType(resources.GetObject("btnTotal2.Image"), System.Drawing.Image)
        Me.btnTotal2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTotal2.Name = "btnTotal2"
        Me.btnTotal2.Size = New System.Drawing.Size(112, 24)
        Me.btnTotal2.Text = "Total Payments"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.Over50ToolStrip)
        Me.Controls.Add(Me.All_RecordsToolStrip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvPayments)
        Me.Name = "Form3"
        Me.Text = "Payments"
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.All_RecordsToolStrip.ResumeLayout(False)
        Me.All_RecordsToolStrip.PerformLayout()
        Me.Over50ToolStrip.ResumeLayout(False)
        Me.Over50ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents KarateDataSet1 As KarateDataSet1
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateDataSet1TableAdapters.PaymentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnExit As Button
    Friend WithEvents All_RecordsToolStrip As ToolStrip
    Friend WithEvents All_RecordsToolStripButton As ToolStripButton
    Friend WithEvents Over50ToolStrip As ToolStrip
    Friend WithEvents Over50ToolStripButton As ToolStripButton
    Friend WithEvents btnTotal As ToolStripButton
    Friend WithEvents btnTotal2 As ToolStripButton
End Class
