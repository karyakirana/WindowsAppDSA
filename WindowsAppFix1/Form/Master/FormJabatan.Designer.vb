<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJabatan
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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.namaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.keteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemFornama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForketerangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.[True]
        Me.DataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.DataLayoutControl1.Controls.Add(Me.btnBatal)
        Me.DataLayoutControl1.Controls.Add(Me.btnSimpan)
        Me.DataLayoutControl1.Controls.Add(Me.namaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.keteranganTextEdit)
        Me.DataLayoutControl1.DataSource = Me.JabatanBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(800, 450)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(713, 84)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 22)
        Me.btnBatal.StyleController = Me.DataLayoutControl1
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(634, 84)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 22)
        Me.btnSimpan.StyleController = Me.DataLayoutControl1
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        '
        'namaTextEdit
        '
        Me.namaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JabatanBindingSource, "nama", True))
        Me.namaTextEdit.Location = New System.Drawing.Point(79, 12)
        Me.namaTextEdit.Name = "namaTextEdit"
        Me.namaTextEdit.Size = New System.Drawing.Size(709, 20)
        Me.namaTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaTextEdit.TabIndex = 4
        '
        'JabatanBindingSource
        '
        Me.JabatanBindingSource.DataSource = GetType(WindowsAppFix1.Jabatan)
        '
        'keteranganTextEdit
        '
        Me.keteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JabatanBindingSource, "keterangan", True))
        Me.keteranganTextEdit.Location = New System.Drawing.Point(79, 36)
        Me.keteranganTextEdit.Name = "keteranganTextEdit"
        Me.keteranganTextEdit.Size = New System.Drawing.Size(709, 20)
        Me.keteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.keteranganTextEdit.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 450)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AllowDrawBackground = False
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemFornama, Me.ItemForketerangan, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(780, 430)
        '
        'ItemFornama
        '
        Me.ItemFornama.Control = Me.namaTextEdit
        Me.ItemFornama.Location = New System.Drawing.Point(0, 0)
        Me.ItemFornama.Name = "ItemFornama"
        Me.ItemFornama.Size = New System.Drawing.Size(780, 24)
        Me.ItemFornama.Text = "nama"
        Me.ItemFornama.TextSize = New System.Drawing.Size(55, 13)
        '
        'ItemForketerangan
        '
        Me.ItemForketerangan.Control = Me.keteranganTextEdit
        Me.ItemForketerangan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForketerangan.Name = "ItemForketerangan"
        Me.ItemForketerangan.Size = New System.Drawing.Size(780, 24)
        Me.ItemForketerangan.Text = "keterangan"
        Me.ItemForketerangan.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnSimpan
        Me.LayoutControlItem1.Location = New System.Drawing.Point(622, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnBatal
        Me.LayoutControlItem2.Location = New System.Drawing.Point(701, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(622, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(780, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 98)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(780, 332)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'FormJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormJabatan"
        Me.Text = "FormAddJabatan"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents namaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JabatanBindingSource As BindingSource
    Friend WithEvents keteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemFornama As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForketerangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
