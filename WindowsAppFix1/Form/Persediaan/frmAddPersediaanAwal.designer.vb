<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPersediaanAwal
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPersediaanAwal))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Persediaan_awal_detailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_awal_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsub_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduk_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colserial_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersediaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.cbDraft = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.cbKondisi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnTambah = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHapus = New DevExpress.XtraEditors.SimpleButton()
        Me.cbLokasi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LokasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Persediaan_awal_detailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDraft.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKondisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLokasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LokasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1302, 617)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1278, 593)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1273, 562)
        Me.XtraTabPage2.Text = "Form Add Persediaan Awal"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.LayoutControl3)
        Me.LayoutControl2.Controls.Add(Me.cbDraft)
        Me.LayoutControl2.Controls.Add(Me.btnBatal)
        Me.LayoutControl2.Controls.Add(Me.btnSimpan)
        Me.LayoutControl2.Controls.Add(Me.txtKeterangan)
        Me.LayoutControl2.Controls.Add(Me.dtTanggal)
        Me.LayoutControl2.Controls.Add(Me.cbKondisi)
        Me.LayoutControl2.Controls.Add(Me.btnTambah)
        Me.LayoutControl2.Controls.Add(Me.btnHapus)
        Me.LayoutControl2.Controls.Add(Me.cbLokasi)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1273, 562)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Location = New System.Drawing.Point(12, 157)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(1249, 352)
        Me.LayoutControl3.TabIndex = 14
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.Persediaan_awal_detailBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemDateEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1209, 332)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Persediaan_awal_detailBindingSource
        '
        Me.Persediaan_awal_detailBindingSource.DataSource = GetType(WindowsAppFix1.PersediaanAwalDetail)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colpersediaan_awal_id, Me.colpersediaan_id, Me.colharga_beli, Me.coljumlah, Me.colsub_total, Me.colcreated_at, Me.colupdated_at, Me.colproduk_id, Me.colbatch, Me.colexpired, Me.colserial_number, Me.colpersediaan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Width = 91
        '
        'colpersediaan_awal_id
        '
        Me.colpersediaan_awal_id.FieldName = "persediaan_awal_id"
        Me.colpersediaan_awal_id.Name = "colpersediaan_awal_id"
        Me.colpersediaan_awal_id.Width = 166
        '
        'colpersediaan_id
        '
        Me.colpersediaan_id.FieldName = "persediaan_id"
        Me.colpersediaan_id.Name = "colpersediaan_id"
        Me.colpersediaan_id.Width = 83
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
        Me.colharga_beli.Width = 83
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
        Me.coljumlah.VisibleIndex = 1
        Me.coljumlah.Width = 83
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
        Me.colsub_total.VisibleIndex = 6
        Me.colsub_total.Width = 83
        '
        'colcreated_at
        '
        Me.colcreated_at.FieldName = "created_at"
        Me.colcreated_at.Name = "colcreated_at"
        Me.colcreated_at.Width = 83
        '
        'colupdated_at
        '
        Me.colupdated_at.FieldName = "updated_at"
        Me.colupdated_at.Name = "colupdated_at"
        Me.colupdated_at.Width = 83
        '
        'colproduk_id
        '
        Me.colproduk_id.AppearanceCell.Options.UseTextOptions = True
        Me.colproduk_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colproduk_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colproduk_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colproduk_id.Caption = "Nama Produk"
        Me.colproduk_id.FieldName = "persediaan.produk.nama"
        Me.colproduk_id.Name = "colproduk_id"
        Me.colproduk_id.Visible = True
        Me.colproduk_id.VisibleIndex = 0
        Me.colproduk_id.Width = 83
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
        Me.colbatch.VisibleIndex = 2
        Me.colbatch.Width = 83
        '
        'colexpired
        '
        Me.colexpired.AppearanceHeader.Options.UseTextOptions = True
        Me.colexpired.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpired.Caption = "Expired"
        Me.colexpired.FieldName = "expired"
        Me.colexpired.Name = "colexpired"
        Me.colexpired.Visible = True
        Me.colexpired.VisibleIndex = 4
        Me.colexpired.Width = 83
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
        Me.colserial_number.Width = 83
        '
        'colpersediaan
        '
        Me.colpersediaan.FieldName = "persediaan"
        Me.colpersediaan.Name = "colpersediaan"
        Me.colpersediaan.Width = 103
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Delete", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "yyyy-MM-dd"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = ""
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1249, 352)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'cbDraft
        '
        Me.cbDraft.Location = New System.Drawing.Point(688, 40)
        Me.cbDraft.Name = "cbDraft"
        Me.cbDraft.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDraft.Properties.Items.AddRange(New Object() {"True", "False"})
        Me.cbDraft.Size = New System.Drawing.Size(573, 24)
        Me.cbDraft.StyleController = Me.LayoutControl2
        Me.cbDraft.TabIndex = 11
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(1141, 525)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(90, 25)
        Me.btnBatal.StyleController = Me.LayoutControl2
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(1027, 525)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(99, 25)
        Me.btnSimpan.StyleController = Me.LayoutControl2
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(91, 68)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(1170, 24)
        Me.txtKeterangan.StyleController = Me.LayoutControl2
        Me.txtKeterangan.TabIndex = 7
        '
        'dtTanggal
        '
        Me.dtTanggal.EditValue = Nothing
        Me.dtTanggal.Location = New System.Drawing.Point(91, 40)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTanggal.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.dtTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTanggal.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtTanggal.Size = New System.Drawing.Size(482, 24)
        Me.dtTanggal.StyleController = Me.LayoutControl2
        Me.dtTanggal.TabIndex = 6
        '
        'cbKondisi
        '
        Me.cbKondisi.Location = New System.Drawing.Point(91, 12)
        Me.cbKondisi.Name = "cbKondisi"
        Me.cbKondisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKondisi.Properties.Items.AddRange(New Object() {"Baik", "Rusak"})
        Me.cbKondisi.Size = New System.Drawing.Size(482, 24)
        Me.cbKondisi.StyleController = Me.LayoutControl2
        Me.cbKondisi.TabIndex = 4
        '
        'btnTambah
        '
        Me.btnTambah.ImageOptions.SvgImage = CType(resources.GetObject("btnTambah.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnTambah.Location = New System.Drawing.Point(24, 115)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(149, 38)
        Me.btnTambah.StyleController = Me.LayoutControl2
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Tambah Produk"
        '
        'btnHapus
        '
        Me.btnHapus.ImageOptions.SvgImage = CType(resources.GetObject("btnHapus.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnHapus.Location = New System.Drawing.Point(187, 115)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(136, 38)
        Me.btnHapus.StyleController = Me.LayoutControl2
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus Produk"
        '
        'cbLokasi
        '
        Me.cbLokasi.Location = New System.Drawing.Point(688, 12)
        Me.cbLokasi.Name = "cbLokasi"
        Me.cbLokasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLokasi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Lokasi", 46, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cbLokasi.Properties.DataSource = Me.LokasiBindingSource
        Me.cbLokasi.Properties.DisplayMember = "nama"
        Me.cbLokasi.Properties.NullText = ""
        Me.cbLokasi.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cbLokasi.Properties.PopupSizeable = False
        Me.cbLokasi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbLokasi.Properties.ValueMember = "id"
        Me.cbLokasi.Size = New System.Drawing.Size(573, 24)
        Me.cbLokasi.StyleController = Me.LayoutControl2
        Me.cbLokasi.TabIndex = 5
        '
        'LokasiBindingSource
        '
        Me.LokasiBindingSource.DataSource = GetType(WindowsAppFix1.Lokasi)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem5, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem6, Me.EmptySpaceItem8, Me.LayoutControlItem6, Me.EmptySpaceItem9, Me.LayoutControlItem12, Me.EmptySpaceItem11, Me.EmptySpaceItem7, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1273, 562)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbKondisi
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(565, 28)
        Me.LayoutControlItem2.Text = "Kondisi"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 18)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbLokasi
        Me.LayoutControlItem3.Location = New System.Drawing.Point(597, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(656, 28)
        Me.LayoutControlItem3.Text = "Lokasi"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 18)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtTanggal
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(565, 28)
        Me.LayoutControlItem4.Text = "Tanggal"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(75, 18)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtKeterangan
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1253, 28)
        Me.LayoutControlItem5.Text = "Keterangan"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 18)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(565, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(32, 28)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(1237, 19)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(1237, 19)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1253, 19)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(565, 28)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(32, 28)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnSimpan
        Me.LayoutControlItem7.Location = New System.Drawing.Point(1015, 513)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(103, 29)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnBatal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(1129, 513)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(94, 29)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(1118, 513)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(11, 29)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbDraft
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.LayoutControlItem9.Location = New System.Drawing.Point(597, 28)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(656, 28)
        Me.LayoutControlItem9.Text = "Draft"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(75, 18)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.LayoutControl3
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 145)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1253, 356)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(315, 103)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(938, 42)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(938, 42)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(938, 42)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 103)
        Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(12, 42)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(12, 42)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(12, 42)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnTambah
        Me.LayoutControlItem6.Location = New System.Drawing.Point(12, 103)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(153, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(1223, 513)
        Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(30, 29)
        Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(30, 29)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(30, 29)
        Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnHapus
        Me.LayoutControlItem12.Location = New System.Drawing.Point(175, 103)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(140, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(165, 103)
        Me.EmptySpaceItem11.MaxSize = New System.Drawing.Size(10, 42)
        Me.EmptySpaceItem11.MinSize = New System.Drawing.Size(10, 42)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(10, 42)
        Me.EmptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 513)
        Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(1015, 29)
        Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(1015, 29)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(1015, 29)
        Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 501)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1253, 12)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1302, 617)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraTabControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1282, 597)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1233, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.GridControl1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Tasks"
        '
        'frmAddPersediaanAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 617)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddPersediaanAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddPersediaanAwal"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Persediaan_awal_detailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDraft.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKondisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLokasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LokasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbKondisi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbDraft As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnTambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnHapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Persediaan_awal_detailBindingSource As BindingSource
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_awal_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsub_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduk_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colserial_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpersediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbLokasi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LokasiBindingSource As BindingSource
End Class
