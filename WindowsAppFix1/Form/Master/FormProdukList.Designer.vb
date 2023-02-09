<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.colproduk_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
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
        Me.colid1.Visible = True
        Me.colid1.VisibleIndex = 0
        '
        'colproduk_id
        '
        Me.colproduk_id.FieldName = "produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        Me.colproduk_id.Visible = True
        Me.colproduk_id.VisibleIndex = 1
        '
        'coldeskripsi
        '
        Me.coldeskripsi.FieldName = "deskripsi"
        Me.coldeskripsi.Name = "coldeskripsi"
        Me.coldeskripsi.Visible = True
        Me.coldeskripsi.VisibleIndex = 2
        '
        'colurl
        '
        Me.colurl.FieldName = "url"
        Me.colurl.Name = "colurl"
        Me.colurl.Visible = True
        Me.colurl.VisibleIndex = 3
        '
        'colcreated_at1
        '
        Me.colcreated_at1.FieldName = "created_at"
        Me.colcreated_at1.Name = "colcreated_at1"
        Me.colcreated_at1.Visible = True
        Me.colcreated_at1.VisibleIndex = 4
        '
        'colupdated_at1
        '
        Me.colupdated_at1.FieldName = "updated_at"
        Me.colupdated_at1.Name = "colupdated_at1"
        Me.colupdated_at1.Visible = True
        Me.colupdated_at1.VisibleIndex = 5
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
        Me.GridControl1.Size = New System.Drawing.Size(776, 284)
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
        Me.colid2.Visible = True
        Me.colid2.VisibleIndex = 0
        '
        'colproduk_id1
        '
        Me.colproduk_id1.FieldName = "produk_id"
        Me.colproduk_id1.Name = "colproduk_id1"
        Me.colproduk_id1.Visible = True
        Me.colproduk_id1.VisibleIndex = 1
        '
        'colsatuan_beli
        '
        Me.colsatuan_beli.FieldName = "satuan_beli"
        Me.colsatuan_beli.Name = "colsatuan_beli"
        Me.colsatuan_beli.Visible = True
        Me.colsatuan_beli.VisibleIndex = 2
        '
        'colisi
        '
        Me.colisi.FieldName = "isi"
        Me.colisi.Name = "colisi"
        Me.colisi.Visible = True
        Me.colisi.VisibleIndex = 3
        '
        'colcreated_at2
        '
        Me.colcreated_at2.FieldName = "created_at"
        Me.colcreated_at2.Name = "colcreated_at2"
        Me.colcreated_at2.Visible = True
        Me.colcreated_at2.VisibleIndex = 4
        '
        'colupdated_at2
        '
        Me.colupdated_at2.FieldName = "updated_at"
        Me.colupdated_at2.Name = "colupdated_at2"
        Me.colupdated_at2.Visible = True
        Me.colupdated_at2.VisibleIndex = 5
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colproduk_kategori_id, Me.colkode, Me.colstatus, Me.colnama, Me.coltipe, Me.colmerk, Me.colsatuan_jual, Me.colharga, Me.colmax_diskon, Me.colbuffer_stock, Me.colminimum_stock, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.colproduk_kategori})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colproduk_kategori_id
        '
        Me.colproduk_kategori_id.FieldName = "produk_kategori_id"
        Me.colproduk_kategori_id.Name = "colproduk_kategori_id"
        Me.colproduk_kategori_id.Visible = True
        Me.colproduk_kategori_id.VisibleIndex = 1
        '
        'colkode
        '
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        Me.colkode.Visible = True
        Me.colkode.VisibleIndex = 2
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 3
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 4
        '
        'coltipe
        '
        Me.coltipe.FieldName = "tipe"
        Me.coltipe.Name = "coltipe"
        Me.coltipe.Visible = True
        Me.coltipe.VisibleIndex = 5
        '
        'colmerk
        '
        Me.colmerk.FieldName = "merk"
        Me.colmerk.Name = "colmerk"
        Me.colmerk.Visible = True
        Me.colmerk.VisibleIndex = 6
        '
        'colsatuan_jual
        '
        Me.colsatuan_jual.FieldName = "satuan_jual"
        Me.colsatuan_jual.Name = "colsatuan_jual"
        Me.colsatuan_jual.Visible = True
        Me.colsatuan_jual.VisibleIndex = 7
        '
        'colharga
        '
        Me.colharga.FieldName = "harga"
        Me.colharga.Name = "colharga"
        Me.colharga.Visible = True
        Me.colharga.VisibleIndex = 8
        '
        'colmax_diskon
        '
        Me.colmax_diskon.FieldName = "max_diskon"
        Me.colmax_diskon.Name = "colmax_diskon"
        Me.colmax_diskon.Visible = True
        Me.colmax_diskon.VisibleIndex = 9
        '
        'colbuffer_stock
        '
        Me.colbuffer_stock.FieldName = "buffer_stock"
        Me.colbuffer_stock.Name = "colbuffer_stock"
        Me.colbuffer_stock.Visible = True
        Me.colbuffer_stock.VisibleIndex = 10
        '
        'colminimum_stock
        '
        Me.colminimum_stock.FieldName = "minimum_stock"
        Me.colminimum_stock.Name = "colminimum_stock"
        Me.colminimum_stock.Visible = True
        Me.colminimum_stock.VisibleIndex = 11
        '
        'colketerangan
        '
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 12
        '
        'colcreated_at
        '
        Me.colcreated_at.FieldName = "created_at"
        Me.colcreated_at.Name = "colcreated_at"
        Me.colcreated_at.Visible = True
        Me.colcreated_at.VisibleIndex = 13
        '
        'colupdated_at
        '
        Me.colupdated_at.FieldName = "updated_at"
        Me.colupdated_at.Name = "colupdated_at"
        Me.colupdated_at.Visible = True
        Me.colupdated_at.VisibleIndex = 14
        '
        'coldeleted_at
        '
        Me.coldeleted_at.FieldName = "deleted_at"
        Me.coldeleted_at.Name = "coldeleted_at"
        Me.coldeleted_at.Visible = True
        Me.coldeleted_at.VisibleIndex = 15
        '
        'colproduk_kategori
        '
        Me.colproduk_kategori.FieldName = "produk_kategori"
        Me.colproduk_kategori.Name = "colproduk_kategori"
        Me.colproduk_kategori.Visible = True
        Me.colproduk_kategori.VisibleIndex = 16
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 142)
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
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 308)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 308)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(780, 288)
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
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
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
