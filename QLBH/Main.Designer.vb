﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI DANNH MỤC THÀNH VIÊN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BẠN MUỐN ĐI ĐẾN DANH MỤC NÀO "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 62)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "NHÂN VIÊN "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(456, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "KHÁCH HÀNG "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(345, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 62)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
