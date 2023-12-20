<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHÁCH_HÀNG
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
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.KHACHHANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSet1 = New QLBH.QLBHDataSet1()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtns = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MAKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOTENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYSINHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOANHSODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGAYDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtds = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtndk = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.QLBHDataSet = New QLBH.QLBHDataSet()
        Me.QLBHDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLBHDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KHACHHANGTableAdapter = New QLBH.QLBHDataSet1TableAdapters.KHACHHANGTableAdapter()
        CType(Me.KHACHHANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLBHDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txthoten
        '
        Me.txthoten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "HOTEN", True))
        Me.txthoten.Location = New System.Drawing.Point(248, 386)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(177, 26)
        Me.txthoten.TabIndex = 18
        '
        'KHACHHANGBindingSource
        '
        Me.KHACHHANGBindingSource.DataMember = "KHACHHANG"
        Me.KHACHHANGBindingSource.DataSource = Me.QLBHDataSet1
        '
        'QLBHDataSet1
        '
        Me.QLBHDataSet1.DataSetName = "QLBHDataSet1"
        Me.QLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsdt
        '
        Me.txtsdt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "SDT", True))
        Me.txtsdt.Location = New System.Drawing.Point(248, 432)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(177, 26)
        Me.txtsdt.TabIndex = 19
        '
        'txtns
        '
        Me.txtns.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "NGAYSINH", True))
        Me.txtns.Location = New System.Drawing.Point(248, 488)
        Me.txtns.Name = "txtns"
        Me.txtns.Size = New System.Drawing.Size(177, 26)
        Me.txtns.TabIndex = 20
        '
        'txtmakh
        '
        Me.txtmakh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "MAKH", True))
        Me.txtmakh.Location = New System.Drawing.Point(248, 342)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(177, 26)
        Me.txtmakh.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SĐT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ngày Sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Họ Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mã Khách Hàng " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(471, 472)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(96, 42)
        Me.btndlt.TabIndex = 11
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(471, 404)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(96, 42)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(471, 337)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 42)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(583, 40)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 34)
        Me.btnsearch.TabIndex = 10
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(113, 40)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(443, 26)
        Me.txtsearch.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MAKHDataGridViewTextBoxColumn, Me.HOTENDataGridViewTextBoxColumn, Me.SDTDataGridViewTextBoxColumn, Me.NGAYSINHDataGridViewTextBoxColumn, Me.DOANHSODataGridViewTextBoxColumn, Me.NGAYDKDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KHACHHANGBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(747, 237)
        Me.DataGridView1.TabIndex = 7
        '
        'MAKHDataGridViewTextBoxColumn
        '
        Me.MAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH"
        Me.MAKHDataGridViewTextBoxColumn.HeaderText = "MAKH"
        Me.MAKHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MAKHDataGridViewTextBoxColumn.Name = "MAKHDataGridViewTextBoxColumn"
        Me.MAKHDataGridViewTextBoxColumn.Width = 150
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
        'NGAYSINHDataGridViewTextBoxColumn
        '
        Me.NGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH"
        Me.NGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH"
        Me.NGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NGAYSINHDataGridViewTextBoxColumn.Name = "NGAYSINHDataGridViewTextBoxColumn"
        Me.NGAYSINHDataGridViewTextBoxColumn.Width = 150
        '
        'DOANHSODataGridViewTextBoxColumn
        '
        Me.DOANHSODataGridViewTextBoxColumn.DataPropertyName = "DOANHSO"
        Me.DOANHSODataGridViewTextBoxColumn.HeaderText = "DOANHSO"
        Me.DOANHSODataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DOANHSODataGridViewTextBoxColumn.Name = "DOANHSODataGridViewTextBoxColumn"
        Me.DOANHSODataGridViewTextBoxColumn.Width = 150
        '
        'NGAYDKDataGridViewTextBoxColumn
        '
        Me.NGAYDKDataGridViewTextBoxColumn.DataPropertyName = "NGAYDK"
        Me.NGAYDKDataGridViewTextBoxColumn.HeaderText = "NGAYDK"
        Me.NGAYDKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NGAYDKDataGridViewTextBoxColumn.Name = "NGAYDKDataGridViewTextBoxColumn"
        Me.NGAYDKDataGridViewTextBoxColumn.Width = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 556)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Doanh Số"
        '
        'txtds
        '
        Me.txtds.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "DOANHSO", True))
        Me.txtds.Location = New System.Drawing.Point(248, 553)
        Me.txtds.Name = "txtds"
        Me.txtds.Size = New System.Drawing.Size(177, 26)
        Me.txtds.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 609)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Ngày Đăng kí "
        '
        'txtndk
        '
        Me.txtndk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACHHANGBindingSource, "NGAYDK", True))
        Me.txtndk.Location = New System.Drawing.Point(248, 609)
        Me.txtndk.Name = "txtndk"
        Me.txtndk.Size = New System.Drawing.Size(177, 26)
        Me.txtndk.TabIndex = 20
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(471, 545)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(96, 42)
        Me.btnexit.TabIndex = 27
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'QLBHDataSet
        '
        Me.QLBHDataSet.DataSetName = "QLBHDataSet"
        Me.QLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QLBHDataSetBindingSource
        '
        Me.QLBHDataSetBindingSource.DataSource = Me.QLBHDataSet
        Me.QLBHDataSetBindingSource.Position = 0
        '
        'QLBHDataSetBindingSource1
        '
        Me.QLBHDataSetBindingSource1.DataSource = Me.QLBHDataSet
        Me.QLBHDataSetBindingSource1.Position = 0
        '
        'QLBHDataSetBindingSource2
        '
        Me.QLBHDataSetBindingSource2.DataSource = Me.QLBHDataSet
        Me.QLBHDataSetBindingSource2.Position = 0
        '
        'KHACHHANGTableAdapter
        '
        Me.KHACHHANGTableAdapter.ClearBeforeFill = True
        '
        'KHÁCH_HÀNG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 653)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtndk)
        Me.Controls.Add(Me.txtds)
        Me.Controls.Add(Me.txtns)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "KHÁCH_HÀNG"
        Me.Text = "KHÁCH_HÀNG"
        CType(Me.KHACHHANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLBHDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtsdt As TextBox
    Friend WithEvents txtns As TextBox
    Friend WithEvents txtmakh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btndlt As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtds As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtndk As TextBox
    Friend WithEvents btnexit As Button
    Friend WithEvents QLBHDataSetBindingSource1 As BindingSource
    Friend WithEvents QLBHDataSet As QLBHDataSet
    Friend WithEvents QLBHDataSetBindingSource As BindingSource
    Friend WithEvents QLBHDataSetBindingSource2 As BindingSource
    Friend WithEvents QLBHDataSet1 As QLBHDataSet1
    Friend WithEvents KHACHHANGBindingSource As BindingSource
    Friend WithEvents KHACHHANGTableAdapter As QLBHDataSet1TableAdapters.KHACHHANGTableAdapter
    Friend WithEvents MAKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOTENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NGAYSINHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOANHSODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NGAYDKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
