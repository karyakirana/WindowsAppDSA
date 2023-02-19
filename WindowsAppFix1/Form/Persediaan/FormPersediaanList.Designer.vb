<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPersediaanList
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
        Me.PersediaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkondisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colserial_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstock_awal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstock_masuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstock_keluar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstock_lost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstock_saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.PersediaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersediaanBindingSource
        '
        Me.PersediaanBindingSource.DataSource = GetType(WindowsAppFix1.Persediaan)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(893, 162)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(893, 366)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PersediaanBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(869, 342)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colproduk, Me.collokasi, Me.colproduk_id, Me.collokasi_id, Me.colkondisi, Me.colbatch, Me.colserial_number, Me.colexpired, Me.colharga_beli, Me.colstock_awal, Me.colstock_masuk, Me.colstock_keluar, Me.colstock_lost, Me.colstock_saldo, Me.colcreated_at, Me.colupdated_at})
        Me.GridView1.GridControl = Me.GridControl1
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
        'collokasi
        '
        Me.collokasi.AppearanceHeader.Options.UseTextOptions = True
        Me.collokasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collokasi.Caption = "Lokasi"
        Me.collokasi.FieldName = "lokasi.nama"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 1
        '
        'colproduk_id
        '
        Me.colproduk_id.FieldName = "produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        '
        'collokasi_id
        '
        Me.collokasi_id.FieldName = "lokasi_id"
        Me.collokasi_id.Name = "collokasi_id"
        '
        'colkondisi
        '
        Me.colkondisi.AppearanceHeader.Options.UseTextOptions = True
        Me.colkondisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkondisi.Caption = "Kondisi"
        Me.colkondisi.FieldName = "kondisi"
        Me.colkondisi.Name = "colkondisi"
        Me.colkondisi.Visible = True
        Me.colkondisi.VisibleIndex = 2
        '
        'colbatch
        '
        Me.colbatch.AppearanceHeader.Options.UseTextOptions = True
        Me.colbatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbatch.Caption = "Batch"
        Me.colbatch.FieldName = "batch"
        Me.colbatch.Name = "colbatch"
        Me.colbatch.Visible = True
        Me.colbatch.VisibleIndex = 3
        '
        'colserial_number
        '
        Me.colserial_number.AppearanceHeader.Options.UseTextOptions = True
        Me.colserial_number.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colserial_number.Caption = "Serial Number"
        Me.colserial_number.FieldName = "serial_number"
        Me.colserial_number.Name = "colserial_number"
        Me.colserial_number.Visible = True
        Me.colserial_number.VisibleIndex = 4
        '
        'colexpired
        '
        Me.colexpired.AppearanceCell.Options.UseTextOptions = True
        Me.colexpired.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpired.AppearanceHeader.Options.UseTextOptions = True
        Me.colexpired.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpired.Caption = "Expired"
        Me.colexpired.FieldName = "expired"
        Me.colexpired.Name = "colexpired"
        Me.colexpired.Visible = True
        Me.colexpired.VisibleIndex = 5
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
        Me.colharga_beli.VisibleIndex = 6
        '
        'colstock_awal
        '
        Me.colstock_awal.AppearanceCell.Options.UseTextOptions = True
        Me.colstock_awal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colstock_awal.AppearanceHeader.Options.UseTextOptions = True
        Me.colstock_awal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstock_awal.Caption = "Stock Awal"
        Me.colstock_awal.FieldName = "stock_awal"
        Me.colstock_awal.Name = "colstock_awal"
        Me.colstock_awal.Visible = True
        Me.colstock_awal.VisibleIndex = 7
        '
        'colstock_masuk
        '
        Me.colstock_masuk.AppearanceCell.Options.UseTextOptions = True
        Me.colstock_masuk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colstock_masuk.AppearanceHeader.Options.UseTextOptions = True
        Me.colstock_masuk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstock_masuk.Caption = "Stock Masuk"
        Me.colstock_masuk.FieldName = "stock_masuk"
        Me.colstock_masuk.Name = "colstock_masuk"
        Me.colstock_masuk.Visible = True
        Me.colstock_masuk.VisibleIndex = 8
        '
        'colstock_keluar
        '
        Me.colstock_keluar.AppearanceCell.Options.UseTextOptions = True
        Me.colstock_keluar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colstock_keluar.AppearanceHeader.Options.UseTextOptions = True
        Me.colstock_keluar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstock_keluar.Caption = "Stock Keluar"
        Me.colstock_keluar.FieldName = "stock_keluar"
        Me.colstock_keluar.Name = "colstock_keluar"
        Me.colstock_keluar.Visible = True
        Me.colstock_keluar.VisibleIndex = 9
        '
        'colstock_lost
        '
        Me.colstock_lost.AppearanceCell.Options.UseTextOptions = True
        Me.colstock_lost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colstock_lost.AppearanceHeader.Options.UseTextOptions = True
        Me.colstock_lost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstock_lost.Caption = "Stock Lost"
        Me.colstock_lost.FieldName = "stock_lost"
        Me.colstock_lost.Name = "colstock_lost"
        Me.colstock_lost.Visible = True
        Me.colstock_lost.VisibleIndex = 10
        '
        'colstock_saldo
        '
        Me.colstock_saldo.AppearanceCell.Options.UseTextOptions = True
        Me.colstock_saldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colstock_saldo.AppearanceHeader.Options.UseTextOptions = True
        Me.colstock_saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstock_saldo.Caption = "Stock Saldo"
        Me.colstock_saldo.FieldName = "stock_saldo"
        Me.colstock_saldo.Name = "colstock_saldo"
        Me.colstock_saldo.Visible = True
        Me.colstock_saldo.VisibleIndex = 11
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
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(893, 366)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(873, 346)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormPersediaanList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 528)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPersediaanList"
        Me.Text = "FormPersediaanList"
        CType(Me.PersediaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersediaanBindingSource As BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive_cash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkondisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colserial_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_masuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_keluar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_lost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstock_saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
