<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualanList
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualanList))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenjualan_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_jual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsatuan_jual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldiskon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsub_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenjualan_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenjualan_penawaran_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltipe_penjualan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_penjualan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_tempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsales_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluser_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colppn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbiaya_lain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_bayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colpenjualan_id1, Me.colpersediaan_id, Me.colharga_jual, Me.coljumlah, Me.colsatuan_jual, Me.coldiskon, Me.colsub_total, Me.colcreated_at1, Me.colupdated_at1, Me.colpersediaan})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colpenjualan_id1
        '
        Me.colpenjualan_id1.FieldName = "penjualan_id"
        Me.colpenjualan_id1.Name = "colpenjualan_id1"
        '
        'colpersediaan_id
        '
        Me.colpersediaan_id.FieldName = "persediaan_id"
        Me.colpersediaan_id.Name = "colpersediaan_id"
        '
        'colharga_jual
        '
        Me.colharga_jual.FieldName = "harga_jual"
        Me.colharga_jual.Name = "colharga_jual"
        Me.colharga_jual.Visible = True
        Me.colharga_jual.VisibleIndex = 0
        '
        'coljumlah
        '
        Me.coljumlah.FieldName = "jumlah"
        Me.coljumlah.Name = "coljumlah"
        Me.coljumlah.Visible = True
        Me.coljumlah.VisibleIndex = 1
        '
        'colsatuan_jual
        '
        Me.colsatuan_jual.FieldName = "satuan_jual"
        Me.colsatuan_jual.Name = "colsatuan_jual"
        Me.colsatuan_jual.Visible = True
        Me.colsatuan_jual.VisibleIndex = 2
        '
        'coldiskon
        '
        Me.coldiskon.FieldName = "diskon"
        Me.coldiskon.Name = "coldiskon"
        Me.coldiskon.Visible = True
        Me.coldiskon.VisibleIndex = 3
        '
        'colsub_total
        '
        Me.colsub_total.FieldName = "sub_total"
        Me.colsub_total.Name = "colsub_total"
        Me.colsub_total.Visible = True
        Me.colsub_total.VisibleIndex = 4
        '
        'colcreated_at1
        '
        Me.colcreated_at1.FieldName = "created_at"
        Me.colcreated_at1.Name = "colcreated_at1"
        '
        'colupdated_at1
        '
        Me.colupdated_at1.FieldName = "updated_at"
        Me.colupdated_at1.Name = "colupdated_at1"
        '
        'colpersediaan
        '
        Me.colpersediaan.FieldName = "persediaan"
        Me.colpersediaan.Name = "colpersediaan"
        Me.colpersediaan.Visible = True
        Me.colpersediaan.VisibleIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PenjualanBindingSource
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "penjualan_detail"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(801, 277)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataSource = GetType(WindowsAppFix1.Penjualan)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colpenjualan_id, Me.colactive_cash, Me.colkode, Me.colpenjualan_penawaran_id, Me.coldraft, Me.colstatus, Me.coltipe_penjualan, Me.coltgl_penjualan, Me.coltempo, Me.coltgl_tempo, Me.colcustomer_id, Me.colsales_id, Me.coluser_id, Me.coltotal_barang, Me.colppn, Me.colbiaya_lain, Me.coltotal_bayar, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.colcustomer, Me.colsales})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colpenjualan_id
        '
        Me.colpenjualan_id.FieldName = "penjualan_id"
        Me.colpenjualan_id.Name = "colpenjualan_id"
        '
        'colactive_cash
        '
        Me.colactive_cash.FieldName = "active_cash"
        Me.colactive_cash.Name = "colactive_cash"
        '
        'colkode
        '
        Me.colkode.AppearanceCell.Options.UseTextOptions = True
        Me.colkode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkode.AppearanceHeader.Options.UseTextOptions = True
        Me.colkode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkode.Caption = "Kode"
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        Me.colkode.Visible = True
        Me.colkode.VisibleIndex = 0
        '
        'colpenjualan_penawaran_id
        '
        Me.colpenjualan_penawaran_id.FieldName = "penjualan_penawaran_id"
        Me.colpenjualan_penawaran_id.Name = "colpenjualan_penawaran_id"
        '
        'coldraft
        '
        Me.coldraft.AppearanceCell.Options.UseTextOptions = True
        Me.coldraft.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldraft.AppearanceHeader.Options.UseTextOptions = True
        Me.coldraft.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldraft.Caption = "Draft"
        Me.coldraft.FieldName = "draft"
        Me.coldraft.Name = "coldraft"
        Me.coldraft.Visible = True
        Me.coldraft.VisibleIndex = 3
        '
        'colstatus
        '
        Me.colstatus.AppearanceCell.Options.UseTextOptions = True
        Me.colstatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstatus.Caption = "Status"
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 4
        '
        'coltipe_penjualan
        '
        Me.coltipe_penjualan.AppearanceCell.Options.UseTextOptions = True
        Me.coltipe_penjualan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.coltipe_penjualan.AppearanceHeader.Options.UseTextOptions = True
        Me.coltipe_penjualan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltipe_penjualan.Caption = "Tipe Penjualan"
        Me.coltipe_penjualan.FieldName = "tipe_penjualan"
        Me.coltipe_penjualan.Name = "coltipe_penjualan"
        Me.coltipe_penjualan.Visible = True
        Me.coltipe_penjualan.VisibleIndex = 5
        '
        'coltgl_penjualan
        '
        Me.coltgl_penjualan.AppearanceCell.Options.UseTextOptions = True
        Me.coltgl_penjualan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_penjualan.AppearanceHeader.Options.UseTextOptions = True
        Me.coltgl_penjualan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_penjualan.Caption = "Tgl. Penjualan"
        Me.coltgl_penjualan.FieldName = "tgl_penjualan"
        Me.coltgl_penjualan.Name = "coltgl_penjualan"
        Me.coltgl_penjualan.Visible = True
        Me.coltgl_penjualan.VisibleIndex = 6
        '
        'coltempo
        '
        Me.coltempo.AppearanceCell.Options.UseTextOptions = True
        Me.coltempo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltempo.AppearanceHeader.Options.UseTextOptions = True
        Me.coltempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltempo.Caption = "Tempo"
        Me.coltempo.FieldName = "tempo"
        Me.coltempo.Name = "coltempo"
        Me.coltempo.Visible = True
        Me.coltempo.VisibleIndex = 7
        '
        'coltgl_tempo
        '
        Me.coltgl_tempo.AppearanceCell.Options.UseTextOptions = True
        Me.coltgl_tempo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_tempo.AppearanceHeader.Options.UseTextOptions = True
        Me.coltgl_tempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_tempo.Caption = "Tgl. Tempo"
        Me.coltgl_tempo.FieldName = "tgl_tempo"
        Me.coltgl_tempo.Name = "coltgl_tempo"
        Me.coltgl_tempo.Visible = True
        Me.coltgl_tempo.VisibleIndex = 8
        '
        'colcustomer_id
        '
        Me.colcustomer_id.FieldName = "customer_id"
        Me.colcustomer_id.Name = "colcustomer_id"
        '
        'colsales_id
        '
        Me.colsales_id.FieldName = "sales_id"
        Me.colsales_id.Name = "colsales_id"
        '
        'coluser_id
        '
        Me.coluser_id.FieldName = "user_id"
        Me.coluser_id.Name = "coluser_id"
        '
        'coltotal_barang
        '
        Me.coltotal_barang.AppearanceCell.Options.UseTextOptions = True
        Me.coltotal_barang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotal_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotal_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltotal_barang.Caption = "Jumlah"
        Me.coltotal_barang.FieldName = "total_barang"
        Me.coltotal_barang.Name = "coltotal_barang"
        Me.coltotal_barang.Visible = True
        Me.coltotal_barang.VisibleIndex = 9
        '
        'colppn
        '
        Me.colppn.AppearanceCell.Options.UseTextOptions = True
        Me.colppn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colppn.AppearanceHeader.Options.UseTextOptions = True
        Me.colppn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colppn.Caption = "PPN"
        Me.colppn.FieldName = "ppn"
        Me.colppn.Name = "colppn"
        Me.colppn.Visible = True
        Me.colppn.VisibleIndex = 10
        '
        'colbiaya_lain
        '
        Me.colbiaya_lain.AppearanceCell.Options.UseTextOptions = True
        Me.colbiaya_lain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colbiaya_lain.AppearanceHeader.Options.UseTextOptions = True
        Me.colbiaya_lain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbiaya_lain.Caption = "Biaya Lain"
        Me.colbiaya_lain.FieldName = "biaya_lain"
        Me.colbiaya_lain.Name = "colbiaya_lain"
        Me.colbiaya_lain.Visible = True
        Me.colbiaya_lain.VisibleIndex = 11
        '
        'coltotal_bayar
        '
        Me.coltotal_bayar.AppearanceCell.Options.UseTextOptions = True
        Me.coltotal_bayar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotal_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotal_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltotal_bayar.Caption = "Total Barang"
        Me.coltotal_bayar.FieldName = "total_bayar"
        Me.coltotal_bayar.Name = "coltotal_bayar"
        Me.coltotal_bayar.Visible = True
        Me.coltotal_bayar.VisibleIndex = 12
        '
        'colketerangan
        '
        Me.colketerangan.AppearanceCell.Options.UseTextOptions = True
        Me.colketerangan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colketerangan.AppearanceHeader.Options.UseTextOptions = True
        Me.colketerangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 13
        '
        'colcreated_at
        '
        Me.colcreated_at.FieldName = "created_at"
        Me.colcreated_at.Name = "colcreated_at"
        '
        'colupdated_at
        '
        Me.colupdated_at.FieldName = "updated_at"
        Me.colupdated_at.Name = "colupdated_at"
        '
        'coldeleted_at
        '
        Me.coldeleted_at.FieldName = "deleted_at"
        Me.coldeleted_at.Name = "coldeleted_at"
        '
        'colcustomer
        '
        Me.colcustomer.AppearanceCell.Options.UseTextOptions = True
        Me.colcustomer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colcustomer.AppearanceHeader.Options.UseTextOptions = True
        Me.colcustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcustomer.Caption = "Customer"
        Me.colcustomer.FieldName = "customer.nama"
        Me.colcustomer.Name = "colcustomer"
        Me.colcustomer.Visible = True
        Me.colcustomer.VisibleIndex = 1
        '
        'colsales
        '
        Me.colsales.AppearanceCell.Options.UseTextOptions = True
        Me.colsales.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colsales.AppearanceHeader.Options.UseTextOptions = True
        Me.colsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsales.Caption = "Sales"
        Me.colsales.FieldName = "sales.nama"
        Me.colsales.Name = "colsales"
        Me.colsales.Visible = True
        Me.colsales.VisibleIndex = 2
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(825, 162)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Edit"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Delete"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Close"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Aksi"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(825, 301)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(825, 301)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(805, 281)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormPenjualanList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 463)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPenjualanList"
        Me.Text = "FormPenjualanList"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PenjualanBindingSource As BindingSource
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpenjualan_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive_cash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpenjualan_penawaran_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltipe_penjualan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_penjualan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsales_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluser_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiaya_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpenjualan_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_jual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsatuan_jual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldiskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsub_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan As DevExpress.XtraGrid.Columns.GridColumn
End Class
