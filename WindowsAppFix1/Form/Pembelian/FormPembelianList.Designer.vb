<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelianList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelianList))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpembelian_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colserial_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldiskon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsub_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpembelian_po_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltipe_pembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_pembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_tempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluser_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colppn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbiaya_lain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_bayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PembeliandetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembeliandetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.ChildGridLevelName = "tes"
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colpembelian_id, Me.colproduk_id, Me.colbatch, Me.colserial_number, Me.colexpired, Me.colharga_beli, Me.coljumlah, Me.coldiskon, Me.colsub_total, Me.colcreated_at1, Me.colupdated_at1, Me.colproduk})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colpembelian_id
        '
        Me.colpembelian_id.FieldName = "pembelian_id"
        Me.colpembelian_id.Name = "colpembelian_id"
        '
        'colproduk_id
        '
        Me.colproduk_id.FieldName = "produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        '
        'colbatch
        '
        Me.colbatch.AppearanceCell.Options.UseTextOptions = True
        Me.colbatch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colbatch.AppearanceHeader.Options.UseTextOptions = True
        Me.colbatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbatch.Caption = "Batch"
        Me.colbatch.FieldName = "batch"
        Me.colbatch.Name = "colbatch"
        Me.colbatch.Visible = True
        Me.colbatch.VisibleIndex = 1
        '
        'colserial_number
        '
        Me.colserial_number.AppearanceCell.Options.UseTextOptions = True
        Me.colserial_number.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colserial_number.AppearanceHeader.Options.UseTextOptions = True
        Me.colserial_number.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colserial_number.Caption = "Serial Number"
        Me.colserial_number.FieldName = "serial_number"
        Me.colserial_number.Name = "colserial_number"
        Me.colserial_number.Visible = True
        Me.colserial_number.VisibleIndex = 2
        '
        'colexpired
        '
        Me.colexpired.AppearanceCell.Options.UseTextOptions = True
        Me.colexpired.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpired.AppearanceHeader.Options.UseTextOptions = True
        Me.colexpired.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpired.Caption = "Expired"
        Me.colexpired.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.colexpired.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colexpired.FieldName = "expired"
        Me.colexpired.GroupFormat.FormatString = "yyyy-MM-dd"
        Me.colexpired.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colexpired.Name = "colexpired"
        Me.colexpired.Visible = True
        Me.colexpired.VisibleIndex = 3
        '
        'colharga_beli
        '
        Me.colharga_beli.AppearanceCell.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colharga_beli.AppearanceHeader.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colharga_beli.Caption = "Harga Beli"
        Me.colharga_beli.DisplayFormat.FormatString = "n0"
        Me.colharga_beli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colharga_beli.FieldName = "harga_beli"
        Me.colharga_beli.GroupFormat.FormatString = "n0"
        Me.colharga_beli.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colharga_beli.Name = "colharga_beli"
        Me.colharga_beli.Visible = True
        Me.colharga_beli.VisibleIndex = 4
        '
        'coljumlah
        '
        Me.coljumlah.AppearanceCell.Options.UseTextOptions = True
        Me.coljumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coljumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.coljumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coljumlah.Caption = "Jumlah"
        Me.coljumlah.FieldName = "jumlah"
        Me.coljumlah.Name = "coljumlah"
        Me.coljumlah.Visible = True
        Me.coljumlah.VisibleIndex = 5
        '
        'coldiskon
        '
        Me.coldiskon.AppearanceCell.Options.UseTextOptions = True
        Me.coldiskon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldiskon.AppearanceHeader.Options.UseTextOptions = True
        Me.coldiskon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldiskon.Caption = "Diskon"
        Me.coldiskon.FieldName = "diskon"
        Me.coldiskon.Name = "coldiskon"
        Me.coldiskon.Visible = True
        Me.coldiskon.VisibleIndex = 6
        '
        'colsub_total
        '
        Me.colsub_total.AppearanceCell.Options.UseTextOptions = True
        Me.colsub_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsub_total.AppearanceHeader.Options.UseTextOptions = True
        Me.colsub_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsub_total.Caption = "Sub Total"
        Me.colsub_total.DisplayFormat.FormatString = "n0"
        Me.colsub_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsub_total.FieldName = "sub_total"
        Me.colsub_total.GroupFormat.FormatString = "n0"
        Me.colsub_total.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsub_total.Name = "colsub_total"
        Me.colsub_total.Visible = True
        Me.colsub_total.VisibleIndex = 7
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
        'colproduk
        '
        Me.colproduk.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk.Caption = "Produk"
        Me.colproduk.FieldName = "produk.nama"
        Me.colproduk.Name = "colproduk"
        Me.colproduk.Visible = True
        Me.colproduk.VisibleIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PembelianBindingSource
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "pembelian_detail"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(776, 264)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataSource = GetType(WindowsAppFix1.Pembelian)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colpembelian_po_id, Me.colkode, Me.coldraft, Me.colstatus, Me.coltipe_pembelian, Me.coltgl_pembelian, Me.coltempo, Me.coltgl_tempo, Me.colsupplier_id, Me.coluser_id, Me.coltotal_barang, Me.colppn, Me.colbiaya_lain, Me.coltotal_bayar, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.colsupplier, Me.colusers})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colactive_cash
        '
        Me.colactive_cash.FieldName = "active_cash"
        Me.colactive_cash.Name = "colactive_cash"
        '
        'colpembelian_po_id
        '
        Me.colpembelian_po_id.FieldName = "pembelian_po_id"
        Me.colpembelian_po_id.Name = "colpembelian_po_id"
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
        'coltipe_pembelian
        '
        Me.coltipe_pembelian.AppearanceHeader.Options.UseTextOptions = True
        Me.coltipe_pembelian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltipe_pembelian.Caption = "Tipe Pembelian"
        Me.coltipe_pembelian.FieldName = "tipe_pembelian"
        Me.coltipe_pembelian.Name = "coltipe_pembelian"
        Me.coltipe_pembelian.Visible = True
        Me.coltipe_pembelian.VisibleIndex = 5
        '
        'coltgl_pembelian
        '
        Me.coltgl_pembelian.AppearanceCell.Options.UseTextOptions = True
        Me.coltgl_pembelian.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_pembelian.AppearanceHeader.Options.UseTextOptions = True
        Me.coltgl_pembelian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_pembelian.Caption = "Tanggal Pembelian"
        Me.coltgl_pembelian.FieldName = "tgl_pembelian"
        Me.coltgl_pembelian.Name = "coltgl_pembelian"
        Me.coltgl_pembelian.Visible = True
        Me.coltgl_pembelian.VisibleIndex = 6
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
        Me.coltgl_tempo.Caption = "Tanggal Tempo"
        Me.coltgl_tempo.FieldName = "tgl_tempo"
        Me.coltgl_tempo.Name = "coltgl_tempo"
        Me.coltgl_tempo.Visible = True
        Me.coltgl_tempo.VisibleIndex = 8
        '
        'colsupplier_id
        '
        Me.colsupplier_id.FieldName = "supplier_id"
        Me.colsupplier_id.Name = "colsupplier_id"
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
        Me.coltotal_barang.Caption = "Total Barang"
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
        Me.colppn.GroupFormat.FormatString = "n0"
        Me.colppn.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.colbiaya_lain.DisplayFormat.FormatString = "n0"
        Me.colbiaya_lain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.coltotal_bayar.Caption = "Total Bayar"
        Me.coltotal_bayar.DisplayFormat.FormatString = "n0"
        Me.coltotal_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotal_bayar.FieldName = "total_bayar"
        Me.coltotal_bayar.Name = "coltotal_bayar"
        Me.coltotal_bayar.Visible = True
        Me.coltotal_bayar.VisibleIndex = 12
        '
        'colketerangan
        '
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
        'colsupplier
        '
        Me.colsupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier.nama"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 1
        '
        'colusers
        '
        Me.colusers.AppearanceHeader.Options.UseTextOptions = True
        Me.colusers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colusers.Caption = "User"
        Me.colusers.FieldName = "users.name"
        Me.colusers.Name = "colusers"
        Me.colusers.Visible = True
        Me.colusers.VisibleIndex = 2
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 162)
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
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Print"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Aksi"
        '
        'PembeliandetailBindingSource
        '
        Me.PembeliandetailBindingSource.DataMember = "pembelian_detail"
        Me.PembeliandetailBindingSource.DataSource = Me.PembelianBindingSource
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 288)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 288)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(780, 268)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormPembelianList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPembelianList"
        Me.Text = "FormPembelianList"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembeliandetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PembelianBindingSource As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive_cash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpembelian_po_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltipe_pembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_pembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluser_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiaya_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpembelian_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colserial_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldiskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsub_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PembeliandetailBindingSource As BindingSource
End Class
