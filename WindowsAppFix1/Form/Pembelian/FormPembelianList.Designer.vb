﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelianList))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GridControl1.Size = New System.Drawing.Size(776, 284)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colpembelian_po_id, Me.colkode, Me.coldraft, Me.colstatus, Me.coltipe_pembelian, Me.coltgl_pembelian, Me.coltempo, Me.coltgl_tempo, Me.colsupplier_id, Me.coluser_id, Me.coltotal_barang, Me.colppn, Me.colbiaya_lain, Me.coltotal_bayar, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.colsupplier, Me.colusers})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
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
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataSource = GetType(WindowsAppFix1.Pembelian)
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colactive_cash
        '
        Me.colactive_cash.FieldName = "active_cash"
        Me.colactive_cash.Name = "colactive_cash"
        Me.colactive_cash.Visible = True
        Me.colactive_cash.VisibleIndex = 1
        '
        'colpembelian_po_id
        '
        Me.colpembelian_po_id.FieldName = "pembelian_po_id"
        Me.colpembelian_po_id.Name = "colpembelian_po_id"
        Me.colpembelian_po_id.Visible = True
        Me.colpembelian_po_id.VisibleIndex = 2
        '
        'colkode
        '
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        Me.colkode.Visible = True
        Me.colkode.VisibleIndex = 3
        '
        'coldraft
        '
        Me.coldraft.FieldName = "draft"
        Me.coldraft.Name = "coldraft"
        Me.coldraft.Visible = True
        Me.coldraft.VisibleIndex = 4
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 5
        '
        'coltipe_pembelian
        '
        Me.coltipe_pembelian.FieldName = "tipe_pembelian"
        Me.coltipe_pembelian.Name = "coltipe_pembelian"
        Me.coltipe_pembelian.Visible = True
        Me.coltipe_pembelian.VisibleIndex = 6
        '
        'coltgl_pembelian
        '
        Me.coltgl_pembelian.FieldName = "tgl_pembelian"
        Me.coltgl_pembelian.Name = "coltgl_pembelian"
        Me.coltgl_pembelian.Visible = True
        Me.coltgl_pembelian.VisibleIndex = 7
        '
        'coltempo
        '
        Me.coltempo.FieldName = "tempo"
        Me.coltempo.Name = "coltempo"
        Me.coltempo.Visible = True
        Me.coltempo.VisibleIndex = 8
        '
        'coltgl_tempo
        '
        Me.coltgl_tempo.FieldName = "tgl_tempo"
        Me.coltgl_tempo.Name = "coltgl_tempo"
        Me.coltgl_tempo.Visible = True
        Me.coltgl_tempo.VisibleIndex = 9
        '
        'colsupplier_id
        '
        Me.colsupplier_id.FieldName = "supplier_id"
        Me.colsupplier_id.Name = "colsupplier_id"
        Me.colsupplier_id.Visible = True
        Me.colsupplier_id.VisibleIndex = 10
        '
        'coluser_id
        '
        Me.coluser_id.FieldName = "user_id"
        Me.coluser_id.Name = "coluser_id"
        Me.coluser_id.Visible = True
        Me.coluser_id.VisibleIndex = 11
        '
        'coltotal_barang
        '
        Me.coltotal_barang.FieldName = "total_barang"
        Me.coltotal_barang.Name = "coltotal_barang"
        Me.coltotal_barang.Visible = True
        Me.coltotal_barang.VisibleIndex = 12
        '
        'colppn
        '
        Me.colppn.FieldName = "ppn"
        Me.colppn.Name = "colppn"
        Me.colppn.Visible = True
        Me.colppn.VisibleIndex = 13
        '
        'colbiaya_lain
        '
        Me.colbiaya_lain.FieldName = "biaya_lain"
        Me.colbiaya_lain.Name = "colbiaya_lain"
        Me.colbiaya_lain.Visible = True
        Me.colbiaya_lain.VisibleIndex = 14
        '
        'coltotal_bayar
        '
        Me.coltotal_bayar.FieldName = "total_bayar"
        Me.coltotal_bayar.Name = "coltotal_bayar"
        Me.coltotal_bayar.Visible = True
        Me.coltotal_bayar.VisibleIndex = 15
        '
        'colketerangan
        '
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 16
        '
        'colcreated_at
        '
        Me.colcreated_at.FieldName = "created_at"
        Me.colcreated_at.Name = "colcreated_at"
        Me.colcreated_at.Visible = True
        Me.colcreated_at.VisibleIndex = 17
        '
        'colupdated_at
        '
        Me.colupdated_at.FieldName = "updated_at"
        Me.colupdated_at.Name = "colupdated_at"
        Me.colupdated_at.Visible = True
        Me.colupdated_at.VisibleIndex = 18
        '
        'coldeleted_at
        '
        Me.coldeleted_at.FieldName = "deleted_at"
        Me.coldeleted_at.Name = "coldeleted_at"
        Me.coldeleted_at.Visible = True
        Me.coldeleted_at.VisibleIndex = 19
        '
        'colsupplier
        '
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 20
        '
        'colusers
        '
        Me.colusers.FieldName = "users"
        Me.colusers.Name = "colusers"
        Me.colusers.Visible = True
        Me.colusers.VisibleIndex = 21
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
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
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class