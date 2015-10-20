Public Class frmAddSanPham
    Private _DBAccess As New DataBaseAccess
    ' bien khi nao sua bi nao add
    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub
    Public Function InsertSanPham() As Boolean
        Dim sqlQuery As String = "Insert into San_Pham (MaSP,TenSP,Soluong,NgayNhap,MaTL) "
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}','{4}')", _
                                  txtMaSp.Text, txtTenSp.Text, txtSoluong.Text, txtNgayNhap.Text, txtMaTl.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'Ham update sanpham
    Private Function UpdateSanPham() As Boolean
        Dim sqlQuery As String = String.Format("Update San_Pham set TenSP = '{0}',Soluong = '{1}',NgayNhap = '{2}' where MaSP = '{3}' ", _
                                               txtTenSp.Text, txtSoluong.Text, txtNgayNhap.Text, txtMaSp.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'Ham kiem tra gia tri truoc khi add
    Private Function isEmpty()
        Return String.IsNullOrEmpty(txtMaSp.Text) OrElse String.IsNullOrEmpty(txtTenSp.Text) OrElse String.IsNullOrEmpty(txtSoluong.Text)
    End Function
    Private Sub frmAddSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Nhap gia tri vao truoc khi luu", "Thong bao", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateSanPham() Then
                    MessageBox.Show("sua lieu thanh cong", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertSanPham() Then
                    MessageBox.Show("them du lieu thanh cong", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
           
            Me.Close()
        End If
    End Sub

   
End Class