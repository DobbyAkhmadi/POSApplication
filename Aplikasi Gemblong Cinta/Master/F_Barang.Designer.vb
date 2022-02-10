<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Barang
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Barang))
        Me.BtnHapus = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxtHargaBeli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TxtHargaJual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Txtstok = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TxtRasa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BtnRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxtKunci = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CbCari = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BtnCari = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.BtnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.BtnUbah = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnHapus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Addressbook_remove
        Me.BtnHapus.Location = New System.Drawing.Point(258, 469)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 39)
        Me.BtnHapus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "&Hapus"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TxtHargaBeli)
        Me.GroupPanel1.Controls.Add(Me.TxtNo)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.TxtHargaJual)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.Txtstok)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.TxtRasa)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Location = New System.Drawing.Point(17, 10)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(599, 156)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 26
        Me.GroupPanel1.Text = "Input Data Barang"
        Me.GroupPanel1.TitleImage = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.address_book_add
        '
        'TxtHargaBeli
        '
        Me.TxtHargaBeli.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtHargaBeli.Border.Class = "TextBoxBorder"
        Me.TxtHargaBeli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtHargaBeli.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtHargaBeli.Location = New System.Drawing.Point(136, 90)
        Me.TxtHargaBeli.MaxLength = 10
        Me.TxtHargaBeli.Name = "TxtHargaBeli"
        Me.TxtHargaBeli.Size = New System.Drawing.Size(95, 20)
        Me.TxtHargaBeli.TabIndex = 4
        Me.TxtHargaBeli.WatermarkText = "Isikan Data"
        '
        'TxtNo
        '
        Me.TxtNo.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtNo.Border.Class = "TextBoxBorder"
        Me.TxtNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNo.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNo.Location = New System.Drawing.Point(136, 6)
        Me.TxtNo.Name = "TxtNo"
        Me.TxtNo.ReadOnly = True
        Me.TxtNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtNo.TabIndex = 1
        Me.TxtNo.WatermarkText = "Isikan Data"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(19, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(97, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Kode Barang"
        '
        'TxtHargaJual
        '
        Me.TxtHargaJual.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtHargaJual.Border.Class = "TextBoxBorder"
        Me.TxtHargaJual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtHargaJual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtHargaJual.Location = New System.Drawing.Point(436, 9)
        Me.TxtHargaJual.MaxLength = 10
        Me.TxtHargaJual.Name = "TxtHargaJual"
        Me.TxtHargaJual.Size = New System.Drawing.Size(147, 20)
        Me.TxtHargaJual.TabIndex = 4
        Me.TxtHargaJual.WatermarkText = "Isikan Data"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(122, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = ":"
        '
        'Txtstok
        '
        Me.Txtstok.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.Txtstok.Border.Class = "TextBoxBorder"
        Me.Txtstok.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtstok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtstok.Location = New System.Drawing.Point(136, 61)
        Me.Txtstok.MaxLength = 5
        Me.Txtstok.Name = "Txtstok"
        Me.Txtstok.Size = New System.Drawing.Size(71, 20)
        Me.Txtstok.TabIndex = 2
        Me.Txtstok.WatermarkText = "Isikan Data"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(19, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 23)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Rasa"
        '
        'TxtRasa
        '
        Me.TxtRasa.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtRasa.Border.Class = "TextBoxBorder"
        Me.TxtRasa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRasa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRasa.Location = New System.Drawing.Point(136, 35)
        Me.TxtRasa.MaxLength = 35
        Me.TxtRasa.Name = "TxtRasa"
        Me.TxtRasa.Size = New System.Drawing.Size(152, 20)
        Me.TxtRasa.TabIndex = 1
        Me.TxtRasa.WatermarkText = "Isikan Data"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(19, 61)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(97, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Stok"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(19, 87)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(97, 23)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Harga Beli"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(319, 6)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(97, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Harga Jual"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(122, 32)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 11
        Me.LabelX7.Text = ":"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(122, 61)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 12
        Me.LabelX8.Text = ":"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(122, 87)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(75, 23)
        Me.LabelX9.TabIndex = 13
        Me.LabelX9.Text = ":"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(422, 9)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 14
        Me.LabelX10.Text = ":"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.BtnRefresh)
        Me.GroupPanel4.Location = New System.Drawing.Point(368, 172)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(248, 112)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 36
        Me.GroupPanel4.Text = "Tampilkan Seluruh Data"
        Me.GroupPanel4.TitleImage = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.data_transfer
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Order
        Me.BtnRefresh.Location = New System.Drawing.Point(17, 13)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(202, 46)
        Me.BtnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnRefresh.TabIndex = 0
        Me.BtnRefresh.Text = "&Tampil Data"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.TxtKunci)
        Me.GroupPanel2.Controls.Add(Me.CbCari)
        Me.GroupPanel2.Controls.Add(Me.BtnCari)
        Me.GroupPanel2.Location = New System.Drawing.Point(17, 172)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(291, 94)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 35
        Me.GroupPanel2.Text = "Cari Data"
        Me.GroupPanel2.TitleImage = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.old_edit_find
        '
        'TxtKunci
        '
        Me.TxtKunci.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtKunci.Border.Class = "TextBoxBorder"
        Me.TxtKunci.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtKunci.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtKunci.Location = New System.Drawing.Point(23, 32)
        Me.TxtKunci.Name = "TxtKunci"
        Me.TxtKunci.Size = New System.Drawing.Size(128, 20)
        Me.TxtKunci.TabIndex = 36
        Me.TxtKunci.WatermarkText = "Kata Kunci"
        '
        'CbCari
        '
        Me.CbCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCari.DisplayMember = "Text"
        Me.CbCari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbCari.FormattingEnabled = True
        Me.CbCari.ItemHeight = 14
        Me.CbCari.Location = New System.Drawing.Point(23, 5)
        Me.CbCari.Name = "CbCari"
        Me.CbCari.Size = New System.Drawing.Size(128, 20)
        Me.CbCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CbCari.TabIndex = 35
        Me.CbCari.Text = "Pilih"
        '
        'BtnCari
        '
        Me.BtnCari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCari.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Addressbook_search
        Me.BtnCari.Location = New System.Drawing.Point(174, 5)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(88, 47)
        Me.BtnCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCari.TabIndex = 34
        Me.BtnCari.Text = "&Tampil"
        '
        'BtnBatal
        '
        Me.BtnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBatal.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Go_back
        Me.BtnBatal.Location = New System.Drawing.Point(339, 469)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 39)
        Me.BtnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnBatal.TabIndex = 5
        Me.BtnBatal.Text = "&Batal"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSimpan.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Save
        Me.BtnSimpan.Location = New System.Drawing.Point(96, 469)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 39)
        Me.BtnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSimpan.TabIndex = 2
        Me.BtnSimpan.Text = "&Simpan"
        '
        'BtnUbah
        '
        Me.BtnUbah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUbah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUbah.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Addressbook_edit1
        Me.BtnUbah.Location = New System.Drawing.Point(177, 469)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 39)
        Me.BtnUbah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUbah.TabIndex = 3
        Me.BtnUbah.Text = "&Ubah"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel3.Location = New System.Drawing.Point(17, 290)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(547, 173)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 33
        Me.GroupPanel3.Text = "Data Barang"
        Me.GroupPanel3.TitleImage = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.books
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column4, Me.Column5, Me.Column2})
        Me.DataGridViewX1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(541, 135)
        Me.DataGridViewX1.TabIndex = 37
        '
        'Column8
        '
        Me.Column8.HeaderText = "Kode Barang"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Rasa"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Jual"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Stok"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'BtnBaru
        '
        Me.BtnBaru.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBaru.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBaru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBaru.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Addressbook_add
        Me.BtnBaru.Location = New System.Drawing.Point(15, 469)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(75, 39)
        Me.BtnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnBaru.TabIndex = 1
        Me.BtnBaru.Text = "&Baru"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Stok"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'F_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 518)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupPanel4)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBaru)
        Me.Controls.Add(Me.GroupPanel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Master Barang"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnHapus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TxtHargaBeli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtHargaJual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txtstok As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtRasa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TxtKunci As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CbCari As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BtnCari As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUbah As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents BtnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
