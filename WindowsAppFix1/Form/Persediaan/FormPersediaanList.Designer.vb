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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colactive_cash = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colproduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PersediaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.SearchEditItem, Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(893, 142)
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
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(893, 386)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(893, 386)
        Me.Root.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PersediaanBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(869, 362)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colproduk_id, Me.collokasi_id, Me.colkondisi, Me.colbatch, Me.colserial_number, Me.colexpired, Me.colharga_beli, Me.colstock_awal, Me.colstock_masuk, Me.colstock_keluar, Me.colstock_lost, Me.colstock_saldo, Me.colcreated_at, Me.colupdated_at, Me.colproduk, Me.collokasi})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(873, 366)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        'colproduk_id
        '
        Me.colproduk_id.FieldName = "produk_id"
        Me.colproduk_id.Name = "colproduk_id"
        Me.colproduk_id.Visible = True
        Me.colproduk_id.VisibleIndex = 2
        '
        'collokasi_id
        '
        Me.collokasi_id.FieldName = "lokasi_id"
        Me.collokasi_id.Name = "collokasi_id"
        Me.collokasi_id.Visible = True
        Me.collokasi_id.VisibleIndex = 3
        '
        'colkondisi
        '
        Me.colkondisi.FieldName = "kondisi"
        Me.colkondisi.Name = "colkondisi"
        Me.colkondisi.Visible = True
        Me.colkondisi.VisibleIndex = 4
        '
        'colbatch
        '
        Me.colbatch.FieldName = "batch"
        Me.colbatch.Name = "colbatch"
        Me.colbatch.Visible = True
        Me.colbatch.VisibleIndex = 5
        '
        'colserial_number
        '
        Me.colserial_number.FieldName = "serial_number"
        Me.colserial_number.Name = "colserial_number"
        Me.colserial_number.Visible = True
        Me.colserial_number.VisibleIndex = 6
        '
        'colexpired
        '
        Me.colexpired.FieldName = "expired"
        Me.colexpired.Name = "colexpired"
        Me.colexpired.Visible = True
        Me.colexpired.VisibleIndex = 7
        '
        'colharga_beli
        '
        Me.colharga_beli.FieldName = "harga_beli"
        Me.colharga_beli.Name = "colharga_beli"
        Me.colharga_beli.Visible = True
        Me.colharga_beli.VisibleIndex = 8
        '
        'colstock_awal
        '
        Me.colstock_awal.FieldName = "stock_awal"
        Me.colstock_awal.Name = "colstock_awal"
        Me.colstock_awal.Visible = True
        Me.colstock_awal.VisibleIndex = 9
        '
        'colstock_masuk
        '
        Me.colstock_masuk.FieldName = "stock_masuk"
        Me.colstock_masuk.Name = "colstock_masuk"
        Me.colstock_masuk.Visible = True
        Me.colstock_masuk.VisibleIndex = 10
        '
        'colstock_keluar
        '
        Me.colstock_keluar.FieldName = "stock_keluar"
        Me.colstock_keluar.Name = "colstock_keluar"
        Me.colstock_keluar.Visible = True
        Me.colstock_keluar.VisibleIndex = 11
        '
        'colstock_lost
        '
        Me.colstock_lost.FieldName = "stock_lost"
        Me.colstock_lost.Name = "colstock_lost"
        Me.colstock_lost.Visible = True
        Me.colstock_lost.VisibleIndex = 12
        '
        'colstock_saldo
        '
        Me.colstock_saldo.FieldName = "stock_saldo"
        Me.colstock_saldo.Name = "colstock_saldo"
        Me.colstock_saldo.Visible = True
        Me.colstock_saldo.VisibleIndex = 13
        '
        'colcreated_at
        '
        Me.colcreated_at.FieldName = "created_at"
        Me.colcreated_at.Name = "colcreated_at"
        Me.colcreated_at.Visible = True
        Me.colcreated_at.VisibleIndex = 14
        '
        'colupdated_at
        '
        Me.colupdated_at.FieldName = "updated_at"
        Me.colupdated_at.Name = "colupdated_at"
        Me.colupdated_at.Visible = True
        Me.colupdated_at.VisibleIndex = 15
        '
        'colproduk
        '
        Me.colproduk.FieldName = "produk"
        Me.colproduk.Name = "colproduk"
        Me.colproduk.Visible = True
        Me.colproduk.VisibleIndex = 16
        '
        'collokasi
        '
        Me.collokasi.FieldName = "lokasi"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 17
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
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
