Public Class Form1
    ' khai bao ket noi den databaseAcces
    Private _DBAccess As New DataBaseAccess
    'Khai bao bien trang thai kiem tra du lieu dang load
    Private _Isloading As Boolean
    'Load data oncombobox
    Public Sub LoadDataOnComBoBox()
        Dim sqlQuery As String = "Select MaTL,TenTL from The_Loai"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbSanPham.DataSource = dTable
        Me.cmbSanPham.ValueMember = "MaTL"
        Me.cmbSanPham.DisplayMember = "TenTL"

    End Sub
    'Load data san pham vao gridview

    Public Sub LoadDataOnGridView(MaTL As String)
        Dim sqlQuery As String = String.Format("select MaSP,TenSP,Soluong,NgayNhap,MaTL from San_Pham where MaTL = '{0}'", MaTL)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanPham.DataSource = dTable

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Isloading = True

        LoadDataOnComBoBox()
        LoadDataOnGridView(Me.cmbSanPham.SelectedValue)

        _Isloading = False
    End Sub

    Private Sub cmbSanPham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSanPham.SelectedIndexChanged, cmbSearch.SelectedIndexChanged
        If Not _Isloading Then
            LoadDataOnGridView(Me.cmbSanPham.SelectedValue)
        End If

    End Sub
    'tim kiem

    Public Sub SearchSanPham(MaTL As String, Value As String)
        Dim sqlQuery As String = String.Format("select MaSP,TenSP,Soluong,NgayNhap,MaTL from San_Pham where MaTL = '{0}'", MaTL)
        If cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format("And MaSP Like '{0}%'", Value)
        Else
            sqlQuery += String.Format("And TenSP Like '{0}%'", Value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanPham.DataSource = dTable

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchSanPham(Me.cmbSanPham.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim frm As New frmAddSanPham(False)
        frm.txtMaTl.Text = Me.cmbSanPham.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbSanPham.SelectedValue)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmAddSanPham(True)
        frm.txtMaTl.Text = Me.cmbSanPham.SelectedValue
        With Me.dgvSanPham
            frm.txtMaSp.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSP").Value
            frm.txtTenSp.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSP").Value
            frm.txtSoluong.Text = .Rows(.CurrentCell.RowIndex).Cells("Soluong").Value
            frm.txtNgayNhap.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayNhap").Value

        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbSanPham.SelectedValue)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim MasP As String = Me.dgvSanPham.Rows(Me.dgvSanPham.CurrentCell.RowIndex).Cells("MaSP").Value

        'xoa
        Dim sqlQuery As String = String.Format("Delete San_Pham where MaSP = '{0}'", MasP)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("xoa thanh cong", "Thong bao", MessageBoxButtons.OK)
            LoadDataOnGridView(Me.cmbSanPham.SelectedValue)
        Else
            MessageBox.Show("Loi xoa du lieu", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub
End Class
