﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomerList))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljenis_instansi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltelepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnpwp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkota_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsales_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldiskon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1003, 162)
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
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1003, 370)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CustomerBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(979, 346)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(WindowsAppFix1.Customer)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkode, Me.coljenis_instansi, Me.colnama, Me.coltelepon, Me.colemail, Me.colnpwp, Me.colalamat, Me.colkota_id, Me.colkota, Me.colsales_id, Me.colsales, Me.coldiskon, Me.colketerangan, Me.colcreated_at, Me.colupdated_at, Me.coldeleted_at})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colkode
        '
        Me.colkode.AppearanceCell.Options.UseTextOptions = True
        Me.colkode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkode.AppearanceHeader.Options.UseTextOptions = True
        Me.colkode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkode.Caption = "ID"
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        Me.colkode.Visible = True
        Me.colkode.VisibleIndex = 0
        '
        'coljenis_instansi
        '
        Me.coljenis_instansi.AppearanceCell.Options.UseTextOptions = True
        Me.coljenis_instansi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coljenis_instansi.AppearanceHeader.Options.UseTextOptions = True
        Me.coljenis_instansi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coljenis_instansi.Caption = "Instansi"
        Me.coljenis_instansi.FieldName = "jenis_instansi"
        Me.coljenis_instansi.Name = "coljenis_instansi"
        Me.coljenis_instansi.Visible = True
        Me.coljenis_instansi.VisibleIndex = 1
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
        'coltelepon
        '
        Me.coltelepon.AppearanceCell.Options.UseTextOptions = True
        Me.coltelepon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltelepon.AppearanceHeader.Options.UseTextOptions = True
        Me.coltelepon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltelepon.Caption = "Telepon"
        Me.coltelepon.FieldName = "telepon"
        Me.coltelepon.Name = "coltelepon"
        Me.coltelepon.Visible = True
        Me.coltelepon.VisibleIndex = 3
        '
        'colemail
        '
        Me.colemail.AppearanceHeader.Options.UseTextOptions = True
        Me.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colemail.Caption = "Email"
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 4
        '
        'colnpwp
        '
        Me.colnpwp.AppearanceCell.Options.UseTextOptions = True
        Me.colnpwp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colnpwp.AppearanceHeader.Options.UseTextOptions = True
        Me.colnpwp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colnpwp.Caption = "NPWP"
        Me.colnpwp.FieldName = "npwp"
        Me.colnpwp.Name = "colnpwp"
        Me.colnpwp.Visible = True
        Me.colnpwp.VisibleIndex = 5
        '
        'colalamat
        '
        Me.colalamat.AppearanceHeader.Options.UseTextOptions = True
        Me.colalamat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colalamat.Caption = "Alamat"
        Me.colalamat.FieldName = "alamat"
        Me.colalamat.Name = "colalamat"
        Me.colalamat.Visible = True
        Me.colalamat.VisibleIndex = 6
        '
        'colkota_id
        '
        Me.colkota_id.FieldName = "kota_id"
        Me.colkota_id.Name = "colkota_id"
        '
        'colkota
        '
        Me.colkota.AppearanceHeader.Options.UseTextOptions = True
        Me.colkota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colkota.Caption = "Kota"
        Me.colkota.FieldName = "kota.name"
        Me.colkota.Name = "colkota"
        Me.colkota.Visible = True
        Me.colkota.VisibleIndex = 7
        '
        'colsales_id
        '
        Me.colsales_id.FieldName = "sales_id"
        Me.colsales_id.Name = "colsales_id"
        '
        'colsales
        '
        Me.colsales.AppearanceHeader.Options.UseTextOptions = True
        Me.colsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsales.Caption = "Sales"
        Me.colsales.FieldName = "sales.nama"
        Me.colsales.Name = "colsales"
        Me.colsales.Visible = True
        Me.colsales.VisibleIndex = 9
        '
        'coldiskon
        '
        Me.coldiskon.AppearanceCell.Options.UseTextOptions = True
        Me.coldiskon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldiskon.AppearanceHeader.Options.UseTextOptions = True
        Me.coldiskon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldiskon.Caption = "Diskon"
        Me.coldiskon.FieldName = "diskon"
        Me.coldiskon.Name = "coldiskon"
        Me.coldiskon.Visible = True
        Me.coldiskon.VisibleIndex = 8
        '
        'colketerangan
        '
        Me.colketerangan.AppearanceHeader.Options.UseTextOptions = True
        Me.colketerangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 10
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
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1003, 370)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(983, 350)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 532)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormCustomerList"
        Me.Text = "FormCustomerList"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljenis_instansi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltelepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnpwp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colalamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkota_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsales_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldiskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted_at As DevExpress.XtraGrid.Columns.GridColumn
End Class
