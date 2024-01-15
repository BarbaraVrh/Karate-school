<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.FKPaymentsMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet1 = New FinalProject.KarateDataSet1()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter1 = New FinalProject.KarateDataSet1TableAdapters.MembersTableAdapter()
        Me.TableAdapterManager1 = New FinalProject.KarateDataSet1TableAdapters.TableAdapterManager()
        Me.PaymentsTableAdapter = New FinalProject.KarateDataSet1TableAdapters.PaymentsTableAdapter()
        Me.MembersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPaymentsMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(98, 68)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 22)
        Me.txtID.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(98, 225)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(98, 189)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtPhone.TabIndex = 4
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(98, 148)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 22)
        Me.txtFirst.TabIndex = 5
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(98, 108)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 22)
        Me.txtLast.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 74)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(23, 16)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 228)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(83, 16)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date Joined:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(12, 151)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(75, 16)
        Me.lblFirst.TabIndex = 9
        Me.lblFirst.Text = "First Name:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(12, 111)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(75, 16)
        Me.lblLast.TabIndex = 10
        Me.lblLast.Text = "Last Name:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 189)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(49, 16)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(352, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(163, 41)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add New Member"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(412, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 32)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
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
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.MembersBindingSource3
        Me.dgvPayments.Location = New System.Drawing.Point(21, 263)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.RowHeadersWidth = 51
        Me.dgvPayments.RowTemplate.Height = 24
        Me.dgvPayments.Size = New System.Drawing.Size(791, 137)
        Me.dgvPayments.TabIndex = 14
        '
        'FKPaymentsMembersBindingSource
        '
        Me.FKPaymentsMembersBindingSource.DataMember = "FK_Payments_Members"
        Me.FKPaymentsMembersBindingSource.DataSource = Me.MembersBindingSource1
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
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Width = 125
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateJoinedDataGridViewTextBoxColumn.Width = 125
        '
        'MembersBindingSource3
        '
        Me.MembersBindingSource3.DataMember = "Members"
        Me.MembersBindingSource3.DataSource = Me.KarateDataSet1
        '
        'KarateDataSet1
        '
        Me.KarateDataSet1.DataSetName = "KarateDataSet1"
        Me.KarateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.KarateDataSet1
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MembersTableAdapter = Me.MembersTableAdapter1
        Me.TableAdapterManager1.PaymentsTableAdapter = Me.PaymentsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FinalProject.KarateDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'MembersBindingSource2
        '
        Me.MembersBindingSource2.DataMember = "Members"
        Me.MembersBindingSource2.DataSource = Me.KarateDataSet1
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KarateDataSet1
        '
        'MembersBindingSource4
        '
        Me.MembersBindingSource4.DataMember = "Members"
        Me.MembersBindingSource4.DataSource = Me.KarateDataSet1
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateDataSet1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 402)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form2"
        Me.Text = "MembersForm"
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPaymentsMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents KarateDataSet1 As KarateDataSet1
    Friend WithEvents MembersBindingSource1 As BindingSource
    Friend WithEvents MembersTableAdapter1 As KarateDataSet1TableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager1 As KarateDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PaymentsTableAdapter As KarateDataSet1TableAdapters.PaymentsTableAdapter
    Friend WithEvents FKPaymentsMembersBindingSource As BindingSource
    Friend WithEvents MembersBindingSource4 As BindingSource
    Friend WithEvents MembersBindingSource2 As BindingSource
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembersBindingSource3 As BindingSource
End Class
