<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NHANVIEN
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.NHANVIENBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSet4 = New QLBH.QLBHDataSet4()
        Me.NHANVIENBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSet3 = New QLBH.QLBHDataSet3()
        Me.NHANVIENBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSet2 = New QLBH.QLBHDataSet2()
        Me.NHANVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSet = New QLBH.QLBHDataSet()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtnlv = New System.Windows.Forms.TextBox()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MANVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOTENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYVLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GIOITINH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIACHI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYLV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYSINH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYHH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NHANVIENTableAdapter = New QLBH.QLBHDataSetTableAdapters.NHANVIENTableAdapter()
        Me.NHANVIENTableAdapter1 = New QLBH.QLBHDataSet2TableAdapters.NHANVIENTableAdapter()
        Me.NHANVIENTableAdapter2 = New QLBH.QLBHDataSet3TableAdapters.NHANVIENTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcccd = New System.Windows.Forms.TextBox()
        Me.txtgt = New System.Windows.Forms.TextBox()
        Me.txtdc = New System.Windows.Forms.TextBox()
        Me.txtnlviec = New System.Windows.Forms.TextBox()
        Me.NHANVIENTableAdapter3 = New QLBH.QLBHDataSet4TableAdapters.NHANVIENTableAdapter()
        Me.txtns = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnhh = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.NHANVIENBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NHANVIENBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NHANVIENBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Ngày vào làm  "
        '
        'txthoten
        '
        Me.txthoten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "HOTEN", True))
        Me.txthoten.Location = New System.Drawing.Point(224, 373)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(177, 26)
        Me.txthoten.TabIndex = 48
        '
        'NHANVIENBindingSource3
        '
        Me.NHANVIENBindingSource3.DataMember = "NHANVIEN"
        Me.NHANVIENBindingSource3.DataSource = Me.QLBHDataSet4
        '
        'QLBHDataSet4
        '
        Me.QLBHDataSet4.DataSetName = "QLBHDataSet4"
        Me.QLBHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NHANVIENBindingSource2
        '
        Me.NHANVIENBindingSource2.DataMember = "NHANVIEN"
        Me.NHANVIENBindingSource2.DataSource = Me.QLBHDataSet3
        '
        'QLBHDataSet3
        '
        Me.QLBHDataSet3.DataSetName = "QLBHDataSet3"
        Me.QLBHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NHANVIENBindingSource1
        '
        Me.NHANVIENBindingSource1.DataMember = "NHANVIEN"
        Me.NHANVIENBindingSource1.DataSource = Me.QLBHDataSet2
        '
        'QLBHDataSet2
        '
        Me.QLBHDataSet2.DataSetName = "QLBHDataSet2"
        Me.QLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NHANVIENBindingSource
        '
        Me.NHANVIENBindingSource.DataMember = "NHANVIEN"
        Me.NHANVIENBindingSource.DataSource = Me.QLBHDataSet
        '
        'QLBHDataSet
        '
        Me.QLBHDataSet.DataSetName = "QLBHDataSet"
        Me.QLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsdt
        '
        Me.txtsdt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "SDT", True))
        Me.txtsdt.Location = New System.Drawing.Point(224, 419)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(177, 26)
        Me.txtsdt.TabIndex = 49
        '
        'txtnlv
        '
        Me.txtnlv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "NGAYVL", True))
        Me.txtnlv.Location = New System.Drawing.Point(214, 475)
        Me.txtnlv.Name = "txtnlv"
        Me.txtnlv.Size = New System.Drawing.Size(177, 26)
        Me.txtnlv.TabIndex = 50
        '
        'txtmanv
        '
        Me.txtmanv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "MANV", True))
        Me.txtmanv.Location = New System.Drawing.Point(224, 329)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(177, 26)
        Me.txtmanv.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "SĐT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Họ Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Mã Nhân Viên"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(553, 607)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(96, 42)
        Me.btnexit.TabIndex = 41
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(404, 607)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(96, 42)
        Me.btndlt.TabIndex = 42
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(253, 607)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(96, 42)
        Me.btnupdate.TabIndex = 43
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(103, 607)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 42)
        Me.btnadd.TabIndex = 44
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(601, 27)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 34)
        Me.btnsearch.TabIndex = 40
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(131, 27)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(443, 26)
        Me.txtsearch.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MANVDataGridViewTextBoxColumn, Me.HOTENDataGridViewTextBoxColumn, Me.SDTDataGridViewTextBoxColumn, Me.NGAYVLDataGridViewTextBoxColumn, Me.CCCD, Me.GIOITINH, Me.DIACHI, Me.NGAYLV, Me.NGAYSINH, Me.NGAYHH})
        Me.DataGridView1.DataSource = Me.NHANVIENBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(97, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(673, 237)
        Me.DataGridView1.TabIndex = 37
        '
        'MANVDataGridViewTextBoxColumn
        '
        Me.MANVDataGridViewTextBoxColumn.DataPropertyName = "MANV"
        Me.MANVDataGridViewTextBoxColumn.HeaderText = "MANV"
        Me.MANVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MANVDataGridViewTextBoxColumn.Name = "MANVDataGridViewTextBoxColumn"
        Me.MANVDataGridViewTextBoxColumn.Width = 150
        '
        'HOTENDataGridViewTextBoxColumn
        '
        Me.HOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN"
        Me.HOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN"
        Me.HOTENDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HOTENDataGridViewTextBoxColumn.Name = "HOTENDataGridViewTextBoxColumn"
        Me.HOTENDataGridViewTextBoxColumn.Width = 150
        '
        'SDTDataGridViewTextBoxColumn
        '
        Me.SDTDataGridViewTextBoxColumn.DataPropertyName = "SDT"
        Me.SDTDataGridViewTextBoxColumn.HeaderText = "SDT"
        Me.SDTDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SDTDataGridViewTextBoxColumn.Name = "SDTDataGridViewTextBoxColumn"
        Me.SDTDataGridViewTextBoxColumn.Width = 150
        '
        'NGAYVLDataGridViewTextBoxColumn
        '
        Me.NGAYVLDataGridViewTextBoxColumn.DataPropertyName = "NGAYVL"
        Me.NGAYVLDataGridViewTextBoxColumn.HeaderText = "NGAYVL"
        Me.NGAYVLDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NGAYVLDataGridViewTextBoxColumn.Name = "NGAYVLDataGridViewTextBoxColumn"
        Me.NGAYVLDataGridViewTextBoxColumn.Width = 150
        '
        'CCCD
        '
        Me.CCCD.DataPropertyName = "CCCD"
        Me.CCCD.HeaderText = "CCCD"
        Me.CCCD.MinimumWidth = 8
        Me.CCCD.Name = "CCCD"
        Me.CCCD.Width = 150
        '
        'GIOITINH
        '
        Me.GIOITINH.DataPropertyName = "GIOITINH"
        Me.GIOITINH.HeaderText = "GIOITINH"
        Me.GIOITINH.MinimumWidth = 8
        Me.GIOITINH.Name = "GIOITINH"
        Me.GIOITINH.Width = 150
        '
        'DIACHI
        '
        Me.DIACHI.DataPropertyName = "DIACHI"
        Me.DIACHI.HeaderText = "DIACHI"
        Me.DIACHI.MinimumWidth = 8
        Me.DIACHI.Name = "DIACHI"
        Me.DIACHI.Width = 150
        '
        'NGAYLV
        '
        Me.NGAYLV.DataPropertyName = "NGAYLV"
        Me.NGAYLV.HeaderText = "NGAYLV"
        Me.NGAYLV.MinimumWidth = 8
        Me.NGAYLV.Name = "NGAYLV"
        Me.NGAYLV.Width = 150
        '
        'NGAYSINH
        '
        Me.NGAYSINH.DataPropertyName = "NGAYSINH"
        Me.NGAYSINH.HeaderText = "NGAYSINH"
        Me.NGAYSINH.MinimumWidth = 8
        Me.NGAYSINH.Name = "NGAYSINH"
        Me.NGAYSINH.Width = 150
        '
        'NGAYHH
        '
        Me.NGAYHH.DataPropertyName = "NGAYHH"
        Me.NGAYHH.HeaderText = "NGAYHH"
        Me.NGAYHH.MinimumWidth = 8
        Me.NGAYHH.Name = "NGAYHH"
        Me.NGAYHH.Width = 150
        '
        'NHANVIENTableAdapter
        '
        Me.NHANVIENTableAdapter.ClearBeforeFill = True
        '
        'NHANVIENTableAdapter1
        '
        Me.NHANVIENTableAdapter1.ClearBeforeFill = True
        '
        'NHANVIENTableAdapter2
        '
        Me.NHANVIENTableAdapter2.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "CCCD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(434, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "địa chỉ "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 475)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Ngày làm việc"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(438, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "giới tính"
        '
        'txtcccd
        '
        Me.txtcccd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "CCCD", True))
        Me.txtcccd.Location = New System.Drawing.Point(553, 332)
        Me.txtcccd.Name = "txtcccd"
        Me.txtcccd.Size = New System.Drawing.Size(177, 26)
        Me.txtcccd.TabIndex = 56
        '
        'txtgt
        '
        Me.txtgt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "GIOITINH", True))
        Me.txtgt.Location = New System.Drawing.Point(553, 378)
        Me.txtgt.Name = "txtgt"
        Me.txtgt.Size = New System.Drawing.Size(177, 26)
        Me.txtgt.TabIndex = 57
        '
        'txtdc
        '
        Me.txtdc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "DIACHI", True))
        Me.txtdc.Location = New System.Drawing.Point(553, 419)
        Me.txtdc.Name = "txtdc"
        Me.txtdc.Size = New System.Drawing.Size(177, 26)
        Me.txtdc.TabIndex = 58
        '
        'txtnlviec
        '
        Me.txtnlviec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "NGAYLV", True))
        Me.txtnlviec.Location = New System.Drawing.Point(560, 475)
        Me.txtnlviec.Name = "txtnlviec"
        Me.txtnlviec.Size = New System.Drawing.Size(177, 26)
        Me.txtnlviec.TabIndex = 59
        '
        'NHANVIENTableAdapter3
        '
        Me.NHANVIENTableAdapter3.ClearBeforeFill = True
        '
        'txtns
        '
        Me.txtns.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "NGAYSINH", True))
        Me.txtns.Location = New System.Drawing.Point(214, 531)
        Me.txtns.Name = "txtns"
        Me.txtns.Size = New System.Drawing.Size(177, 26)
        Me.txtns.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(77, 534)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 20)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "ngày sinh"
        '
        'txtnhh
        '
        Me.txtnhh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NHANVIENBindingSource3, "NGAYHH", True))
        Me.txtnhh.Location = New System.Drawing.Point(560, 525)
        Me.txtnhh.Name = "txtnhh"
        Me.txtnhh.Size = New System.Drawing.Size(177, 26)
        Me.txtnhh.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 531)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 20)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "ngày hết hạn"
        '
        'NHANVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 710)
        Me.Controls.Add(Me.txtnlviec)
        Me.Controls.Add(Me.txtdc)
        Me.Controls.Add(Me.txtgt)
        Me.Controls.Add(Me.txtcccd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtnhh)
        Me.Controls.Add(Me.txtns)
        Me.Controls.Add(Me.txtnlv)
        Me.Controls.Add(Me.txtmanv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NHANVIEN"
        Me.Text = "nv"
        CType(Me.NHANVIENBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NHANVIENBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NHANVIENBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NHANVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtsdt As TextBox
    Friend WithEvents txtnlv As TextBox
    Friend WithEvents txtmanv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btndlt As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QLBHDataSet As QLBHDataSet
    Friend WithEvents NHANVIENBindingSource As BindingSource
    Friend WithEvents NHANVIENTableAdapter As QLBHDataSetTableAdapters.NHANVIENTableAdapter
    Friend WithEvents QLBHDataSet2 As QLBHDataSet2
    Friend WithEvents NHANVIENBindingSource1 As BindingSource
    Friend WithEvents NHANVIENTableAdapter1 As QLBHDataSet2TableAdapters.NHANVIENTableAdapter
    Friend WithEvents QLBHDataSet3 As QLBHDataSet3
    Friend WithEvents NHANVIENBindingSource2 As BindingSource
    Friend WithEvents NHANVIENTableAdapter2 As QLBHDataSet3TableAdapters.NHANVIENTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcccd As TextBox
    Friend WithEvents txtgt As TextBox
    Friend WithEvents txtdc As TextBox
    Friend WithEvents txtnlviec As TextBox
    Friend WithEvents QLBHDataSet4 As QLBHDataSet4
    Friend WithEvents NHANVIENBindingSource3 As BindingSource
    Friend WithEvents NHANVIENTableAdapter3 As QLBHDataSet4TableAdapters.NHANVIENTableAdapter
    Friend WithEvents txtns As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnhh As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MANVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOTENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NGAYVLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CCCD As DataGridViewTextBoxColumn
    Friend WithEvents GIOITINH As DataGridViewTextBoxColumn
    Friend WithEvents DIACHI As DataGridViewTextBoxColumn
    Friend WithEvents NGAYLV As DataGridViewTextBoxColumn
    Friend WithEvents NGAYSINH As DataGridViewTextBoxColumn
    Friend WithEvents NGAYHH As DataGridViewTextBoxColumn
End Class
