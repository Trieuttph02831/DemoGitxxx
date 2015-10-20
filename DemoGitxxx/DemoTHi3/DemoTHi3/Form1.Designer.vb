<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSanPham = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSanPham
        '
        Me.dgvSanPham.AllowUserToAddRows = False
        Me.dgvSanPham.AllowUserToDeleteRows = False
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(33, 95)
        Me.dgvSanPham.MultiSelect = False
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.ReadOnly = True
        Me.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanPham.Size = New System.Drawing.Size(458, 254)
        Me.dgvSanPham.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(520, 95)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(122, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(520, 124)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(122, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(520, 153)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSanPham)
        Me.GroupBox1.Location = New System.Drawing.Point(507, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cmbSanPham
        '
        Me.cmbSanPham.FormattingEnabled = True
        Me.cmbSanPham.Location = New System.Drawing.Point(14, 34)
        Me.cmbSanPham.Name = "cmbSanPham"
        Me.cmbSanPham.Size = New System.Drawing.Size(121, 21)
        Me.cmbSanPham.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(239, 59)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 20)
        Me.txtSearch.TabIndex = 3
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Tim Kiem Ma", "Tim Kiem Ten"})
        Me.cmbSearch.Location = New System.Drawing.Point(94, 58)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearch.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 361)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSanPham As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox

End Class
