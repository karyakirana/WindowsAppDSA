﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProdukList
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProdukList))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeskripsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colurl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ProdukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsatuan_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_kategori_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmerk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsatuan_jual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmax_diskon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbuffer_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colminimum_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colproduk_id, Me.coldeskripsi, Me.colurl, Me.colcreated_at1, Me.colupdated_at1})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colproduk_id
        '
        Me.colproduk_id.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_id.Caption = "ID"
        Me.colproduk_id.FieldName = "produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        Me.colproduk_id.Visible = True
        Me.colproduk_id.VisibleIndex = 0
        '
        'coldeskripsi
        '
        Me.coldeskripsi.AppearanceHeader.Options.UseTextOptions = True
        Me.coldeskripsi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldeskripsi.Caption = "Deskripsi"
        Me.coldeskripsi.FieldName = "deskripsi"
        Me.coldeskripsi.Name = "coldeskripsi"
        Me.coldeskripsi.Visible = True
        Me.coldeskripsi.VisibleIndex = 1
        '
        'colurl
        '
        Me.colurl.AppearanceHeader.Options.UseTextOptions = True
        Me.colurl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colurl.Caption = "Url"
        Me.colurl.FieldName = "url"
        Me.colurl.Name = "colurl"
        Me.colurl.Visible = True
        Me.colurl.VisibleIndex = 2
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
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ProdukBindingSource
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "produk_image"
        GridLevelNode2.LevelTemplate = Me.GridView3
        GridLevelNode2.RelationName = "produk_kemasan_beli"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(776, 264)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView1, Me.GridView4, Me.GridView2})
        '
        'ProdukBindingSource
        '
        Me.ProdukBindingSource.DataSource = GetType(WindowsAppFix1.Produk)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid2, Me.colproduk_id1, Me.colsatuan_beli, Me.colisi, Me.colcreated_at2, Me.colupdated_at2})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        '
        'colid2
        '
        Me.colid2.FieldName = "id"
        Me.colid2.Name = "colid2"
        '
        'colproduk_id1
        '
        Me.colproduk_id1.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_id1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_id1.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_id1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_id1.Caption = "ID"
        Me.colproduk_id1.FieldName = "produk_id"
        Me.colproduk_id1.Name = "colproduk_id1"
        Me.colproduk_id1.Visible = True
        Me.colproduk_id1.VisibleIndex = 0
        '
        'colsatuan_beli
        '
        Me.colsatuan_beli.AppearanceCell.Options.UseTextOptions = True
        Me.colsatuan_beli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colsatuan_beli.AppearanceHeader.Options.UseTextOptions = True
        Me.colsatuan_beli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsatuan_beli.Caption = "Satuan Beli"
        Me.colsatuan_beli.FieldName = "satuan_beli"
        Me.colsatuan_beli.Name = "colsatuan_beli"
        Me.colsatuan_beli.Visible = True
        Me.colsatuan_beli.VisibleIndex = 1
        '
        'colisi
        '
        Me.colisi.AppearanceCell.Options.UseTextOptions = True
        Me.colisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colisi.AppearanceHeader.Options.UseTextOptions = True
        Me.colisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colisi.Caption = "Isi"
        Me.colisi.FieldName = "isi"
        Me.colisi.Name = "colisi"
        Me.colisi.Visible = True
        Me.colisi.VisibleIndex = 2
        '
        'colcreated_at2
        '
        Me.colcreated_at2.FieldName = "created_at"
        Me.colcreated_at2.Name = "colcreated_at2"
        '
        'colupdated_at2
        '
        Me.colupdated_at2.FieldName = "updated_at"
        Me.colupdated_at2.Name = "colupdated_at2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colproduk_kategori_id, Me.colkode, Me.colstatus, Me.colnama, Me.colproduk_kategori, Me.coltipe, Me.colmerk, Me.colsatuan_jual, Me.colharga, Me.colmax_diskon, Me.colbuffer_stock, Me.colminimum_stock, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colproduk_kategori_id
        '
        Me.colproduk_kategori_id.FieldName = "produk_kategori_id"
        Me.colproduk_kategori_id.Name = "colproduk_kategori_id"
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
        Me.colstatus.VisibleIndex = 1
        '
        'colnama
        '
        Me.colnama.AppearanceHeader.Options.UseTextOptions = True
        Me.colnama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colnama.Caption = "Nama"
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 2
        '
        'colproduk_kategori
        '
        Me.colproduk_kategori.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_kategori.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_kategori.Caption = "Kategori"
        Me.colproduk_kategori.FieldName = "produk_kategori.nama"
        Me.colproduk_kategori.Name = "colproduk_kategori"
        Me.colproduk_kategori.Visible = True
        Me.colproduk_kategori.VisibleIndex = 5
        '
        'coltipe
        '
        Me.coltipe.AppearanceHeader.Options.UseTextOptions = True
        Me.coltipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltipe.Caption = "Tipe"
        Me.coltipe.FieldName = "tipe"
        Me.coltipe.Name = "coltipe"
        Me.coltipe.Visible = True
        Me.coltipe.VisibleIndex = 3
        '
        'colmerk
        '
        Me.colmerk.AppearanceHeader.Options.UseTextOptions = True
        Me.colmerk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colmerk.Caption = "Merk"
        Me.colmerk.FieldName = "merk"
        Me.colmerk.Name = "colmerk"
        Me.colmerk.Visible = True
        Me.colmerk.VisibleIndex = 4
        '
        'colsatuan_jual
        '
        Me.colsatuan_jual.AppearanceCell.Options.UseTextOptions = True
        Me.colsatuan_jual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsatuan_jual.AppearanceHeader.Options.UseTextOptions = True
        Me.colsatuan_jual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsatuan_jual.Caption = "Satuan Jual"
        Me.colsatuan_jual.FieldName = "satuan_jual"
        Me.colsatuan_jual.Name = "colsatuan_jual"
        Me.colsatuan_jual.Visible = True
        Me.colsatuan_jual.VisibleIndex = 6
        '
        'colharga
        '
        Me.colharga.AppearanceHeader.Options.UseTextOptions = True
        Me.colharga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colharga.Caption = "Harga"
        Me.colharga.DisplayFormat.FormatString = "n0"
        Me.colharga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colharga.FieldName = "harga"
        Me.colharga.Name = "colharga"
        Me.colharga.Visible = True
        Me.colharga.VisibleIndex = 7
        '
        'colmax_diskon
        '
        Me.colmax_diskon.AppearanceHeader.Options.UseTextOptions = True
        Me.colmax_diskon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colmax_diskon.Caption = "Maks. Diskon"
        Me.colmax_diskon.FieldName = "max_diskon"
        Me.colmax_diskon.Name = "colmax_diskon"
        Me.colmax_diskon.Visible = True
        Me.colmax_diskon.VisibleIndex = 8
        '
        'colbuffer_stock
        '
        Me.colbuffer_stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colbuffer_stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbuffer_stock.Caption = "Buffer Stock"
        Me.colbuffer_stock.FieldName = "buffer_stock"
        Me.colbuffer_stock.Name = "colbuffer_stock"
        Me.colbuffer_stock.Visible = True
        Me.colbuffer_stock.VisibleIndex = 9
        '
        'colminimum_stock
        '
        Me.colminimum_stock.AppearanceHeader.Options.UseTextOptions = True
        Me.colminimum_stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colminimum_stock.Caption = "Min. Stock"
        Me.colminimum_stock.FieldName = "minimum_stock"
        Me.colminimum_stock.Name = "colminimum_stock"
        Me.colminimum_stock.Visible = True
        Me.colminimum_stock.VisibleIndex = 10
        '
        'colketerangan
        '
        Me.colketerangan.AppearanceHeader.Options.UseTextOptions = True
        Me.colketerangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 11
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.btnEdit, Me.btnDelete, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
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
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 2
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 3
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 4
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDelete)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Aksi"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "produk_id"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "deskripsi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "url"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "created_at"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "updated_at"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
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
        'FormProdukList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormProdukList"
        Me.Text = "FormProdukList"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ProdukBindingSource As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_kategori_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmerk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsatuan_jual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmax_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbuffer_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colminimum_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_kategori As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeskripsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colurl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsatuan_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
