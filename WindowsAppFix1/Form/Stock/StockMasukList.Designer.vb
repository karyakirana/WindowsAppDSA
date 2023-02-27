<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMasukList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMasukList))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.StockMasukGridControl = New DevExpress.XtraGrid.GridControl()
        Me.StockMasukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstockable_masuk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstockable_masuk_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkondisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsurat_jalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_masuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluser_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_hpp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.StockMasukGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMasukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1185, 162)
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
        Me.LayoutControl1.Controls.Add(Me.StockMasukGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1185, 427)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'StockMasukGridControl
        '
        Me.StockMasukGridControl.DataSource = Me.StockMasukBindingSource
        Me.StockMasukGridControl.Location = New System.Drawing.Point(12, 12)
        Me.StockMasukGridControl.MainView = Me.GridView1
        Me.StockMasukGridControl.MenuManager = Me.RibbonControl1
        Me.StockMasukGridControl.Name = "StockMasukGridControl"
        Me.StockMasukGridControl.Size = New System.Drawing.Size(1161, 403)
        Me.StockMasukGridControl.TabIndex = 4
        Me.StockMasukGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StockMasukBindingSource
        '
        Me.StockMasukBindingSource.DataSource = GetType(WindowsAppFix1.StockMasuk)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colstockable_masuk_id, Me.colstockable_masuk_type, Me.colkode, Me.coldraft, Me.colkondisi, Me.colstatus, Me.colsurat_jalan, Me.coltgl_masuk, Me.collokasi_id, Me.colsupplier_id, Me.colcustomer_id, Me.coluser_id, Me.coltotal_barang, Me.coltotal_hpp, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.collokasi, Me.colsupplier, Me.colcustomer, Me.colusers})
        Me.GridView1.GridControl = Me.StockMasukGridControl
        Me.GridView1.Name = "GridView1"
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
        'colstockable_masuk_id
        '
        Me.colstockable_masuk_id.FieldName = "stockable_masuk_id"
        Me.colstockable_masuk_id.Name = "colstockable_masuk_id"
        '
        'colstockable_masuk_type
        '
        Me.colstockable_masuk_type.FieldName = "stockable_masuk_type"
        Me.colstockable_masuk_type.Name = "colstockable_masuk_type"
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
        Me.coldraft.VisibleIndex = 7
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
        Me.colkondisi.VisibleIndex = 8
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
        Me.colstatus.VisibleIndex = 9
        '
        'colsurat_jalan
        '
        Me.colsurat_jalan.AppearanceCell.Options.UseTextOptions = True
        Me.colsurat_jalan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colsurat_jalan.AppearanceHeader.Options.UseTextOptions = True
        Me.colsurat_jalan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsurat_jalan.Caption = "Surat Jalan"
        Me.colsurat_jalan.FieldName = "surat_jalan"
        Me.colsurat_jalan.Name = "colsurat_jalan"
        Me.colsurat_jalan.Visible = True
        Me.colsurat_jalan.VisibleIndex = 5
        '
        'coltgl_masuk
        '
        Me.coltgl_masuk.AppearanceCell.Options.UseTextOptions = True
        Me.coltgl_masuk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_masuk.AppearanceHeader.Options.UseTextOptions = True
        Me.coltgl_masuk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltgl_masuk.Caption = "Tanggal Masuk"
        Me.coltgl_masuk.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.coltgl_masuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coltgl_masuk.FieldName = "tgl_masuk"
        Me.coltgl_masuk.Name = "coltgl_masuk"
        Me.coltgl_masuk.Visible = True
        Me.coltgl_masuk.VisibleIndex = 4
        '
        'collokasi_id
        '
        Me.collokasi_id.FieldName = "lokasi_id"
        Me.collokasi_id.Name = "collokasi_id"
        '
        'colsupplier_id
        '
        Me.colsupplier_id.FieldName = "supplier_id"
        Me.colsupplier_id.Name = "colsupplier_id"
        '
        'colcustomer_id
        '
        Me.colcustomer_id.FieldName = "customer_id"
        Me.colcustomer_id.Name = "colcustomer_id"
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
        Me.coltotal_barang.VisibleIndex = 10
        '
        'coltotal_hpp
        '
        Me.coltotal_hpp.AppearanceCell.Options.UseTextOptions = True
        Me.coltotal_hpp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotal_hpp.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotal_hpp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltotal_hpp.Caption = "Total HPP"
        Me.coltotal_hpp.FieldName = "total_hpp"
        Me.coltotal_hpp.Name = "coltotal_hpp"
        Me.coltotal_hpp.Visible = True
        Me.coltotal_hpp.VisibleIndex = 11
        '
        'colketerangan
        '
        Me.colketerangan.AppearanceCell.Options.UseTextOptions = True
        Me.colketerangan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colketerangan.AppearanceHeader.Options.UseTextOptions = True
        Me.colketerangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 12
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
        'collokasi
        '
        Me.collokasi.AppearanceCell.Options.UseTextOptions = True
        Me.collokasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.collokasi.AppearanceHeader.Options.UseTextOptions = True
        Me.collokasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collokasi.Caption = "Lokasi"
        Me.collokasi.FieldName = "lokasi.nama"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 3
        '
        'colsupplier
        '
        Me.colsupplier.AppearanceCell.Options.UseTextOptions = True
        Me.colsupplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colsupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "stock_masuk_detail"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 1
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
        Me.colcustomer.VisibleIndex = 2
        '
        'colusers
        '
        Me.colusers.AppearanceCell.Options.UseTextOptions = True
        Me.colusers.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colusers.AppearanceHeader.Options.UseTextOptions = True
        Me.colusers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colusers.Caption = "Pembuat"
        Me.colusers.FieldName = "users.name"
        Me.colusers.Name = "colusers"
        Me.colusers.Visible = True
        Me.colusers.VisibleIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1185, 427)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.StockMasukGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1165, 407)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'StockMasukList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 589)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "StockMasukList"
        Me.Text = "StockMasukList"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.StockMasukGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMasukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StockMasukGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents StockMasukBindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive_cash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstockable_masuk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstockable_masuk_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkondisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsurat_jalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_masuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluser_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_hpp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
