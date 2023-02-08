<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindProduk
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ProdukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.colproduk_image = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_kemasan_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ProdukBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(776, 426)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ProdukBindingSource
        '
        Me.ProdukBindingSource.DataSource = GetType(WindowsAppFix1.Produk)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colproduk_kategori_id, Me.colkode, Me.colstatus, Me.colnama, Me.coltipe, Me.colmerk, Me.colsatuan_jual, Me.colharga, Me.colmax_diskon, Me.colbuffer_stock, Me.colminimum_stock, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at, Me.colproduk_kategori, Me.colproduk_image, Me.colproduk_kemasan_beli})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        '
        'colnama
        '
        Me.colnama.AppearanceCell.Options.UseTextOptions = True
        Me.colnama.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colnama.AppearanceHeader.Options.UseTextOptions = True
        Me.colnama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colnama.Caption = "Nama Produk"
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 0
        '
        'coltipe
        '
        Me.coltipe.FieldName = "tipe"
        Me.coltipe.Name = "coltipe"
        '
        'colmerk
        '
        Me.colmerk.AppearanceCell.Options.UseTextOptions = True
        Me.colmerk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colmerk.AppearanceHeader.Options.UseTextOptions = True
        Me.colmerk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colmerk.Caption = "Merk"
        Me.colmerk.FieldName = "merk"
        Me.colmerk.Name = "colmerk"
        Me.colmerk.Visible = True
        Me.colmerk.VisibleIndex = 1
        '
        'colsatuan_jual
        '
        Me.colsatuan_jual.FieldName = "satuan_jual"
        Me.colsatuan_jual.Name = "colsatuan_jual"
        '
        'colharga
        '
        Me.colharga.FieldName = "harga"
        Me.colharga.Name = "colharga"
        '
        'colmax_diskon
        '
        Me.colmax_diskon.FieldName = "max_diskon"
        Me.colmax_diskon.Name = "colmax_diskon"
        '
        'colbuffer_stock
        '
        Me.colbuffer_stock.FieldName = "buffer_stock"
        Me.colbuffer_stock.Name = "colbuffer_stock"
        '
        'colminimum_stock
        '
        Me.colminimum_stock.FieldName = "minimum_stock"
        Me.colminimum_stock.Name = "colminimum_stock"
        '
        'colketerangan
        '
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
        'colproduk_kategori
        '
        Me.colproduk_kategori.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_kategori.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colproduk_kategori.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_kategori.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_kategori.Caption = "Kategori"
        Me.colproduk_kategori.FieldName = "produk_kategori.nama"
        Me.colproduk_kategori.Name = "colproduk_kategori"
        Me.colproduk_kategori.Visible = True
        Me.colproduk_kategori.VisibleIndex = 2
        '
        'colproduk_image
        '
        Me.colproduk_image.FieldName = "produk_image"
        Me.colproduk_image.Name = "colproduk_image"
        '
        'colproduk_kemasan_beli
        '
        Me.colproduk_kemasan_beli.FieldName = "produk_kemasan_beli"
        Me.colproduk_kemasan_beli.Name = "colproduk_kemasan_beli"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 450)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(780, 430)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FrmFindProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmFindProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Produk"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ProdukBindingSource As BindingSource
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
    Friend WithEvents colproduk_image As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_kemasan_beli As DevExpress.XtraGrid.Columns.GridColumn
End Class
