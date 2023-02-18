<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.BarGroupMaster = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarJabatan = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarPegawai = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarLokasi = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarProduk = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarCustomer = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSupplier = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarGroupPersediaan = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarPersediaan = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarPersediaanAwal = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarPOPenjualan = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarPenjualan = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarPOPembelian = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarPembelian = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSeparatorItem1 = New DevExpress.XtraNavBar.NavBarSeparatorItem()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSeparatorItem2 = New DevExpress.XtraNavBar.NavBarSeparatorItem()
        Me.NavBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSeparatorItem3 = New DevExpress.XtraNavBar.NavBarSeparatorItem()
        Me.NavBarItem12 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSeparatorItem4 = New DevExpress.XtraNavBar.NavBarSeparatorItem()
        Me.NavBarItem13 = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemJabatan = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemLokasi = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemPegawai = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemProduk = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemCustomer = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarItemSupplier = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(604, 124)
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1268, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 526)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1268, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 501)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1268, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 501)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("c0942328-e6c1-4aae-a624-0ba898163b41")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 25)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 501)
        Me.DockPanel1.Text = "Main Menu"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 29)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 469)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.BarGroupMaster
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.BarGroupMaster, Me.BarGroupPersediaan, Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.BarItemJabatan, Me.BarItemLokasi, Me.BarItemPegawai, Me.BarItemProduk, Me.BarItemCustomer, Me.BarItemSupplier, Me.NavBarPersediaan, Me.NavBarPersediaanAwal, Me.NavBarPOPenjualan, Me.NavBarPenjualan, Me.NavBarPOPembelian, Me.NavBarPembelian, Me.NavBarJabatan, Me.NavBarPegawai, Me.NavBarLokasi, Me.NavBarProduk, Me.NavBarCustomer, Me.NavBarSupplier, Me.NavBarItem1, Me.NavBarItem7, Me.NavBarItem8, Me.NavBarItem9, Me.NavBarItem4, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarSeparatorItem1, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarSeparatorItem2, Me.NavBarItem10, Me.NavBarItem11, Me.NavBarSeparatorItem3, Me.NavBarItem12, Me.NavBarSeparatorItem4, Me.NavBarItem13})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 193
        Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.NavBarControl1.Size = New System.Drawing.Size(193, 469)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'BarGroupMaster
        '
        Me.BarGroupMaster.Caption = "Master"
        Me.BarGroupMaster.Expanded = True
        Me.BarGroupMaster.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarJabatan), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPegawai), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarLokasi), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarProduk), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarCustomer), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSupplier)})
        Me.BarGroupMaster.Name = "BarGroupMaster"
        '
        'NavBarJabatan
        '
        Me.NavBarJabatan.Caption = "Jabatan"
        Me.NavBarJabatan.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Jabatan
        Me.NavBarJabatan.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarJabatan.Name = "NavBarJabatan"
        '
        'NavBarPegawai
        '
        Me.NavBarPegawai.Caption = "Pegawai"
        Me.NavBarPegawai.ImageOptions.LargeImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarPegawai.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Pegawai
        Me.NavBarPegawai.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarPegawai.Name = "NavBarPegawai"
        '
        'NavBarLokasi
        '
        Me.NavBarLokasi.Caption = "Lokasi"
        Me.NavBarLokasi.ImageOptions.LargeImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarLokasi.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.icons8_map_marker_80
        Me.NavBarLokasi.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarLokasi.Name = "NavBarLokasi"
        '
        'NavBarProduk
        '
        Me.NavBarProduk.Caption = "Produk"
        Me.NavBarProduk.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.icons8_package_96
        Me.NavBarProduk.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarProduk.Name = "NavBarProduk"
        '
        'NavBarCustomer
        '
        Me.NavBarCustomer.Caption = "Customer"
        Me.NavBarCustomer.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.icons8_customer_64
        Me.NavBarCustomer.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarCustomer.Name = "NavBarCustomer"
        '
        'NavBarSupplier
        '
        Me.NavBarSupplier.Caption = "Supplier"
        Me.NavBarSupplier.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.icons8_supplier_80
        Me.NavBarSupplier.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarSupplier.Name = "NavBarSupplier"
        '
        'BarGroupPersediaan
        '
        Me.BarGroupPersediaan.Caption = "Persediaan"
        Me.BarGroupPersediaan.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPersediaan), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPersediaanAwal)})
        Me.BarGroupPersediaan.Name = "BarGroupPersediaan"
        '
        'NavBarPersediaan
        '
        Me.NavBarPersediaan.Caption = "Persediaan"
        Me.NavBarPersediaan.ImageOptions.LargeImage = CType(resources.GetObject("NavBarPersediaan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarPersediaan.ImageOptions.SmallImage = CType(resources.GetObject("NavBarPersediaan.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarPersediaan.Name = "NavBarPersediaan"
        '
        'NavBarPersediaanAwal
        '
        Me.NavBarPersediaanAwal.Caption = "Persediaan Awal"
        Me.NavBarPersediaanAwal.ImageOptions.LargeImage = CType(resources.GetObject("NavBarPersediaanAwal.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarPersediaanAwal.ImageOptions.SmallImage = CType(resources.GetObject("NavBarPersediaanAwal.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarPersediaanAwal.Name = "NavBarPersediaanAwal"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Penjualan"
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPOPenjualan), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPenjualan)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarPOPenjualan
        '
        Me.NavBarPOPenjualan.Caption = "Pre Order Penjualan"
        Me.NavBarPOPenjualan.ImageOptions.LargeImage = CType(resources.GetObject("NavBarPOPenjualan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarPOPenjualan.ImageOptions.SmallImage = CType(resources.GetObject("NavBarPOPenjualan.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarPOPenjualan.Name = "NavBarPOPenjualan"
        '
        'NavBarPenjualan
        '
        Me.NavBarPenjualan.Caption = "Invoice Penjualan"
        Me.NavBarPenjualan.ImageOptions.LargeImage = CType(resources.GetObject("NavBarPenjualan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarPenjualan.ImageOptions.SmallImage = CType(resources.GetObject("NavBarPenjualan.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarPenjualan.Name = "NavBarPenjualan"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Pembelian"
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPOPembelian), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarPembelian)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarPOPembelian
        '
        Me.NavBarPOPembelian.Caption = "Pre Order Pembelian"
        Me.NavBarPOPembelian.ImageOptions.LargeImage = CType(resources.GetObject("NavBarPOPembelian.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarPOPembelian.ImageOptions.SmallImage = CType(resources.GetObject("NavBarPOPembelian.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarPOPembelian.Name = "NavBarPOPembelian"
        '
        'NavBarPembelian
        '
        Me.NavBarPembelian.Caption = "Invoice Pembelian"
        Me.NavBarPembelian.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarPembelian.ImageOptions.SvgImage = CType(resources.GetObject("NavBarPembelian.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.NavBarPembelian.Name = "NavBarPembelian"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "Keuangan"
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSeparatorItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSeparatorItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem10), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem11), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSeparatorItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem12), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSeparatorItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem13)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        Me.NavBarGroup3.TopVisibleLinkIndex = 2
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Akun"
        Me.NavBarItem1.ImageOptions.LargeImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem1.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.bank1
        Me.NavBarItem1.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Tipe Akun"
        Me.NavBarItem2.ImageOptions.LargeImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem2.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Tipe_Akun
        Me.NavBarItem2.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Kategori Akun"
        Me.NavBarItem3.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Kategori_Akun
        Me.NavBarItem3.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarSeparatorItem1
        '
        Me.NavBarSeparatorItem1.CanDrag = False
        Me.NavBarSeparatorItem1.Enabled = False
        Me.NavBarSeparatorItem1.Hint = Nothing
        Me.NavBarSeparatorItem1.Name = "NavBarSeparatorItem1"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "Neraca Saldo"
        Me.NavBarItem5.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Neraca_Saldo
        Me.NavBarItem5.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "Neraca Awal"
        Me.NavBarItem6.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Neraca_Awal
        Me.NavBarItem6.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarSeparatorItem2
        '
        Me.NavBarSeparatorItem2.CanDrag = False
        Me.NavBarSeparatorItem2.Enabled = False
        Me.NavBarSeparatorItem2.Hint = Nothing
        Me.NavBarSeparatorItem2.Name = "NavBarSeparatorItem2"
        '
        'NavBarItem10
        '
        Me.NavBarItem10.Caption = "Hutang Pembelian"
        Me.NavBarItem10.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.Hutang_Pembelian
        Me.NavBarItem10.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem10.Name = "NavBarItem10"
        '
        'NavBarItem11
        '
        Me.NavBarItem11.Caption = "Saldo Hutang Pembelian"
        Me.NavBarItem11.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.saldo_hutang_pembelian
        Me.NavBarItem11.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem11.Name = "NavBarItem11"
        '
        'NavBarSeparatorItem3
        '
        Me.NavBarSeparatorItem3.CanDrag = False
        Me.NavBarSeparatorItem3.Enabled = False
        Me.NavBarSeparatorItem3.Hint = Nothing
        Me.NavBarSeparatorItem3.Name = "NavBarSeparatorItem3"
        '
        'NavBarItem12
        '
        Me.NavBarItem12.Caption = "Jurnal Transaksi"
        Me.NavBarItem12.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.jurnal_transaksi
        Me.NavBarItem12.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem12.Name = "NavBarItem12"
        '
        'NavBarSeparatorItem4
        '
        Me.NavBarSeparatorItem4.CanDrag = False
        Me.NavBarSeparatorItem4.Enabled = False
        Me.NavBarSeparatorItem4.Hint = Nothing
        Me.NavBarSeparatorItem4.Name = "NavBarSeparatorItem4"
        '
        'NavBarItem13
        '
        Me.NavBarItem13.Caption = "CoA Config"
        Me.NavBarItem13.ImageOptions.SmallImage = Global.WindowsAppFix1.My.Resources.Resources.COA
        Me.NavBarItem13.ImageOptions.SmallImageSize = New System.Drawing.Size(18, 18)
        Me.NavBarItem13.Name = "NavBarItem13"
        '
        'BarItemJabatan
        '
        Me.BarItemJabatan.Caption = "Jabatan"
        Me.BarItemJabatan.ImageOptions.LargeImage = CType(resources.GetObject("BarItemJabatan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemJabatan.ImageOptions.SmallImage = CType(resources.GetObject("BarItemJabatan.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemJabatan.Name = "BarItemJabatan"
        '
        'BarItemLokasi
        '
        Me.BarItemLokasi.Caption = "Lokasi"
        Me.BarItemLokasi.ImageOptions.LargeImage = CType(resources.GetObject("BarItemLokasi.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemLokasi.ImageOptions.SmallImage = CType(resources.GetObject("BarItemLokasi.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemLokasi.Name = "BarItemLokasi"
        '
        'BarItemPegawai
        '
        Me.BarItemPegawai.Caption = "Pegawai"
        Me.BarItemPegawai.ImageOptions.LargeImage = CType(resources.GetObject("BarItemPegawai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemPegawai.ImageOptions.SmallImage = CType(resources.GetObject("BarItemPegawai.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemPegawai.Name = "BarItemPegawai"
        '
        'BarItemProduk
        '
        Me.BarItemProduk.Caption = "Produk"
        Me.BarItemProduk.ImageOptions.LargeImage = CType(resources.GetObject("BarItemProduk.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemProduk.ImageOptions.SmallImage = CType(resources.GetObject("BarItemProduk.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemProduk.Name = "BarItemProduk"
        '
        'BarItemCustomer
        '
        Me.BarItemCustomer.Caption = "Customer"
        Me.BarItemCustomer.ImageOptions.LargeImage = CType(resources.GetObject("BarItemCustomer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemCustomer.ImageOptions.SmallImage = CType(resources.GetObject("BarItemCustomer.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemCustomer.Name = "BarItemCustomer"
        '
        'BarItemSupplier
        '
        Me.BarItemSupplier.Caption = "Suppier"
        Me.BarItemSupplier.ImageOptions.LargeImage = CType(resources.GetObject("BarItemSupplier.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarItemSupplier.ImageOptions.SmallImage = CType(resources.GetObject("BarItemSupplier.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.BarItemSupplier.Name = "BarItemSupplier"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "Neraca Saldo"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Caption = "Neraca Saldo Awal"
        Me.NavBarItem8.Name = "NavBarItem8"
        '
        'NavBarItem9
        '
        Me.NavBarItem9.Caption = "CoA Config"
        Me.NavBarItem9.Name = "NavBarItem9"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "Jurnal Transaksi"
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.MenuManager = Me.BarManager1
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 549)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents BarGroupMaster As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents BarItemJabatan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarItemPegawai As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarItemLokasi As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarItemProduk As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarItemCustomer As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarItemSupplier As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarGroupPersediaan As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents NavBarPersediaan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarPersediaanAwal As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarPOPenjualan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarPenjualan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarPOPembelian As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarPembelian As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarJabatan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarPegawai As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarLokasi As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarProduk As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarCustomer As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSupplier As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem9 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSeparatorItem1 As DevExpress.XtraNavBar.NavBarSeparatorItem
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSeparatorItem2 As DevExpress.XtraNavBar.NavBarSeparatorItem
    Friend WithEvents NavBarItem10 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem11 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSeparatorItem3 As DevExpress.XtraNavBar.NavBarSeparatorItem
    Friend WithEvents NavBarItem12 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSeparatorItem4 As DevExpress.XtraNavBar.NavBarSeparatorItem
    Friend WithEvents NavBarItem13 As DevExpress.XtraNavBar.NavBarItem
End Class
