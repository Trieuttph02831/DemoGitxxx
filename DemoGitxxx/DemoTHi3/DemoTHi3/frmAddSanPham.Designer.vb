<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSanPham
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtMaSp = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaTl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNgayNhap = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaSp"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(39, 187)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtMaSp
        '
        Me.txtMaSp.Location = New System.Drawing.Point(112, 41)
        Me.txtMaSp.Name = "txtMaSp"
        Me.txtMaSp.Size = New System.Drawing.Size(116, 20)
        Me.txtMaSp.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(153, 187)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MaTL"
        '
        'txtMaTl
        '
        Me.txtMaTl.Location = New System.Drawing.Point(112, 67)
        Me.txtMaTl.Name = "txtMaTl"
        Me.txtMaTl.Size = New System.Drawing.Size(116, 20)
        Me.txtMaTl.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ten SP"
        '
        'txtTenSp
        '
        Me.txtTenSp.Location = New System.Drawing.Point(112, 93)
        Me.txtTenSp.Name = "txtTenSp"
        Me.txtTenSp.Size = New System.Drawing.Size(116, 20)
        Me.txtTenSp.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SoLuong"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(112, 119)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(116, 20)
        Me.txtSoluong.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngay Nhap"
        '
        'txtNgayNhap
        '
        Me.txtNgayNhap.Location = New System.Drawing.Point(112, 145)
        Me.txtNgayNhap.Name = "txtNgayNhap"
        Me.txtNgayNhap.Size = New System.Drawing.Size(116, 20)
        Me.txtNgayNhap.TabIndex = 2
        '
        'frmAddSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtNgayNhap)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtTenSp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaTl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaSp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddSanPham"
        Me.Text = "frmAddSanPham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtMaSp As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaTl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTenSp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNgayNhap As System.Windows.Forms.TextBox
End Class
