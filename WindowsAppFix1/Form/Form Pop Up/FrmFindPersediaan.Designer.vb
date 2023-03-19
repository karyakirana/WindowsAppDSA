<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindPersediaan
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.PersediaanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PersediaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.PersediaanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersediaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(817, 467)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(793, 443)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(788, 412)
        Me.XtraTabPage1.Text = "Form Find Persediaan "
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.PersediaanGridControl)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(788, 412)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'PersediaanGridControl
        '
        Me.PersediaanGridControl.DataSource = Me.PersediaanBindingSource
        Me.PersediaanGridControl.Location = New System.Drawing.Point(12, 12)
        Me.PersediaanGridControl.MainView = Me.GridView1
        Me.PersediaanGridControl.Name = "PersediaanGridControl"
        Me.PersediaanGridControl.Size = New System.Drawing.Size(764, 388)
        Me.PersediaanGridControl.TabIndex = 4
        Me.PersediaanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PersediaanBindingSource
        '
        Me.PersediaanBindingSource.DataSource = GetType(WindowsAppFix1.Persediaan)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colactive_cash, Me.colproduk_id, Me.collokasi_id, Me.colkondisi, Me.colbatch, Me.colserial_number, Me.colexpired, Me.colharga_beli, Me.colstock_awal, Me.colstock_masuk, Me.colstock_keluar, Me.colstock_lost, Me.colstock_saldo, Me.colcreated_at, Me.colupdated_at, Me.colproduk, Me.collokasi})
        Me.GridView1.GridControl = Me.PersediaanGridControl
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
        Me.colkondisi.AppearanceCell.Options.UseTextOptions = True
        Me.colkondisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        Me.colbatch.AppearanceCell.Options.UseTextOptions = True
        Me.colbatch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbatch.AppearanceHeader.Options.UseTextOptions = True
        Me.colbatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbatch.Caption = "Batch"
        Me.colbatch.FieldName = "batch"
        Me.colbatch.Name = "colbatch"
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
        Me.colserial_number.VisibleIndex = 3
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
        '
        'colharga_beli
        '
        Me.colharga_beli.AppearanceCell.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colharga_beli.AppearanceHeader.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colharga_beli.Caption = "Harga Beli"
        Me.colharga_beli.FieldName = "harga_beli"
        Me.colharga_beli.Name = "colharga_beli"
        Me.colharga_beli.Visible = True
        Me.colharga_beli.VisibleIndex = 4
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
        Me.colstock_awal.VisibleIndex = 5
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
        Me.colstock_masuk.VisibleIndex = 6
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
        Me.colstock_keluar.VisibleIndex = 7
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
        Me.colstock_lost.VisibleIndex = 8
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
        Me.colstock_saldo.VisibleIndex = 9
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
        'colproduk
        '
        Me.colproduk.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        Me.collokasi.AppearanceCell.Options.UseTextOptions = True
        Me.collokasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.collokasi.AppearanceHeader.Options.UseTextOptions = True
        Me.collokasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.collokasi.Caption = "Lokasi"
        Me.collokasi.FieldName = "lokasi.nama"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(788, 412)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PersediaanGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(768, 392)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(817, 467)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraTabControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(797, 447)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FrmFindPersediaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 467)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmFindPersediaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFindPersediaan"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.PersediaanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersediaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PersediaanGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents PersediaanBindingSource As BindingSource
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
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
