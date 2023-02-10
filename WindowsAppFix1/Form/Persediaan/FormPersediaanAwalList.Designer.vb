<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPersediaanAwalList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPersediaanAwalList))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_awal_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_kode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_batch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_expired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsub_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PersediaanAwalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_persediaan_awal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkondisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluser_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_nominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersediaanAwalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colpersediaan_awal_id, Me.colpersediaan_id, Me.colproduk_id, Me.colproduk_kode, Me.colproduk_nama, Me.colpersediaan_batch, Me.colpersediaan_expired, Me.colpersediaan_serial, Me.colharga_beli, Me.coljumlah, Me.colsub_total, Me.colcreated_at1, Me.colupdated_at1, Me.colpersediaan, Me.colpersediaan1})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.LevelIndent = 15
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.ViewCaption = "Detail"
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colpersediaan_awal_id
        '
        Me.colpersediaan_awal_id.FieldName = "persediaan_awal_id"
        Me.colpersediaan_awal_id.Name = "colpersediaan_awal_id"
        '
        'colpersediaan_id
        '
        Me.colpersediaan_id.FieldName = "persediaan_id"
        Me.colpersediaan_id.Name = "colpersediaan_id"
        '
        'colproduk_id
        '
        Me.colproduk_id.FieldName = "persediaan.produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        '
        'colproduk_kode
        '
        Me.colproduk_kode.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_kode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_kode.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_kode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_kode.Caption = "ID Produk"
        Me.colproduk_kode.FieldName = "persediaan.produk.kode"
        Me.colproduk_kode.Name = "colproduk_kode"
        Me.colproduk_kode.Visible = True
        Me.colproduk_kode.VisibleIndex = 0
        '
        'colproduk_nama
        '
        Me.colproduk_nama.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_nama.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colproduk_nama.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_nama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_nama.Caption = "Nama Produk"
        Me.colproduk_nama.FieldName = "persediaan.produk.nama"
        Me.colproduk_nama.Name = "colproduk_nama"
        Me.colproduk_nama.Visible = True
        Me.colproduk_nama.VisibleIndex = 1
        '
        'colpersediaan_batch
        '
        Me.colpersediaan_batch.AppearanceCell.Options.UseTextOptions = True
        Me.colpersediaan_batch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colpersediaan_batch.AppearanceHeader.Options.UseTextOptions = True
        Me.colpersediaan_batch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpersediaan_batch.Caption = "Batch"
        Me.colpersediaan_batch.FieldName = "persediaan.batch"
        Me.colpersediaan_batch.Name = "colpersediaan_batch"
        Me.colpersediaan_batch.Visible = True
        Me.colpersediaan_batch.VisibleIndex = 2
        '
        'colpersediaan_expired
        '
        Me.colpersediaan_expired.AppearanceCell.Options.UseTextOptions = True
        Me.colpersediaan_expired.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpersediaan_expired.AppearanceHeader.Options.UseTextOptions = True
        Me.colpersediaan_expired.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpersediaan_expired.Caption = "Expired"
        Me.colpersediaan_expired.FieldName = "persediaan.expired"
        Me.colpersediaan_expired.Name = "colpersediaan_expired"
        Me.colpersediaan_expired.Visible = True
        Me.colpersediaan_expired.VisibleIndex = 3
        '
        'colpersediaan_serial
        '
        Me.colpersediaan_serial.AppearanceCell.Options.UseTextOptions = True
        Me.colpersediaan_serial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpersediaan_serial.AppearanceHeader.Options.UseTextOptions = True
        Me.colpersediaan_serial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colpersediaan_serial.Caption = "Serial Number"
        Me.colpersediaan_serial.Name = "colpersediaan_serial"
        Me.colpersediaan_serial.Visible = True
        Me.colpersediaan_serial.VisibleIndex = 4
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
        Me.colharga_beli.Name = "colharga_beli"
        Me.colharga_beli.Visible = True
        Me.colharga_beli.VisibleIndex = 5
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
        Me.coljumlah.VisibleIndex = 6
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
        'colpersediaan
        '
        Me.colpersediaan.FieldName = "persediaan"
        Me.colpersediaan.Name = "colpersediaan"
        '
        'colpersediaan1
        '
        Me.colpersediaan1.FieldName = "persediaan"
        Me.colpersediaan1.Name = "colpersediaan1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PersediaanAwalBindingSource
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "persediaan_awal_detail"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1132, 367)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'PersediaanAwalBindingSource
        '
        Me.PersediaanAwalBindingSource.DataSource = GetType(WindowsAppFix1.PersediaanAwal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colkode, Me.coldraft, Me.coltgl_persediaan_awal, Me.colkondisi, Me.collokasi_id, Me.collokasi, Me.coltotal_barang, Me.coluser_id, Me.colusers, Me.coltotal_nominal, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.ViewCaption = "Detail"
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
        Me.coldraft.VisibleIndex = 1
        '
        'coltgl_persediaan_awal
        '
        Me.coltgl_persediaan_awal.AppearanceCell.Options.UseTextOptions = True
        Me.coltgl_persediaan_awal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_persediaan_awal.AppearanceHeader.Options.UseTextOptions = True
        Me.coltgl_persediaan_awal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_persediaan_awal.Caption = "Tgl Persediaan Awal"
        Me.coltgl_persediaan_awal.FieldName = "tgl_persediaan_awal"
        Me.coltgl_persediaan_awal.Name = "coltgl_persediaan_awal"
        Me.coltgl_persediaan_awal.Visible = True
        Me.coltgl_persediaan_awal.VisibleIndex = 3
        '
        'colkondisi
        '
        Me.colkondisi.AppearanceCell.Options.UseTextOptions = True
        Me.colkondisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkondisi.AppearanceHeader.Options.UseTextOptions = True
        Me.colkondisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkondisi.Caption = "Kondisi"
        Me.colkondisi.FieldName = "kondisi"
        Me.colkondisi.Name = "colkondisi"
        Me.colkondisi.Visible = True
        Me.colkondisi.VisibleIndex = 2
        '
        'collokasi_id
        '
        Me.collokasi_id.FieldName = "lokasi_id"
        Me.collokasi_id.Name = "collokasi_id"
        '
        'collokasi
        '
        Me.collokasi.AppearanceCell.Options.UseTextOptions = True
        Me.collokasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collokasi.AppearanceHeader.Options.UseTextOptions = True
        Me.collokasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collokasi.Caption = "Lokasi"
        Me.collokasi.FieldName = "lokasi.nama"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 4
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
        Me.coltotal_barang.VisibleIndex = 5
        '
        'coluser_id
        '
        Me.coluser_id.FieldName = "user_id"
        Me.coluser_id.Name = "coluser_id"
        '
        'colusers
        '
        Me.colusers.AppearanceCell.Options.UseTextOptions = True
        Me.colusers.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colusers.AppearanceHeader.Options.UseTextOptions = True
        Me.colusers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colusers.Caption = "Pembuat"
        Me.colusers.FieldName = "users.name"
        Me.colusers.Name = "colusers"
        Me.colusers.Visible = True
        Me.colusers.VisibleIndex = 6
        '
        'coltotal_nominal
        '
        Me.coltotal_nominal.AppearanceCell.Options.UseTextOptions = True
        Me.coltotal_nominal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotal_nominal.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotal_nominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltotal_nominal.Caption = "Total Nominal"
        Me.coltotal_nominal.CustomizationCaption = "Nominal"
        Me.coltotal_nominal.DisplayFormat.FormatString = "n0"
        Me.coltotal_nominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotal_nominal.FieldName = "total_nominal"
        Me.coltotal_nominal.Name = "coltotal_nominal"
        Me.coltotal_nominal.Visible = True
        Me.coltotal_nominal.VisibleIndex = 7
        '
        'colketerangan
        '
        Me.colketerangan.CustomizationCaption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
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
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.btnEdit, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 162)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 2
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEdit)
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
        Me.LayoutControl1.Size = New System.Drawing.Size(1156, 391)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1156, 391)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1136, 371)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormPersediaanAwalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 553)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPersediaanAwalList"
        Me.Text = "FormPersediaanAwalList"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersediaanAwalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersediaanAwalBindingSource As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive_cash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkondisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_persediaan_awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluser_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_nominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_awal_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsub_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_kode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_batch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_expired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
