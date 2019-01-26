<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BackButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.HomeButton = New System.Windows.Forms.ToolStripButton()
        Me.ReloadButton = New System.Windows.Forms.ToolStripButton()
        Me.urlBar = New System.Windows.Forms.ToolStripTextBox()
        Me.goButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchBar = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.panBrowser = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackButton, Me.ForwardButton, Me.HomeButton, Me.ReloadButton, Me.urlBar, Me.goButton, Me.SearchBar, Me.SearchButton, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BackButton
        '
        Me.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(23, 22)
        Me.BackButton.Text = "Back"
        '
        'ForwardButton
        '
        Me.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), System.Drawing.Image)
        Me.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(23, 22)
        Me.ForwardButton.Text = "Forward"
        '
        'HomeButton
        '
        Me.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), System.Drawing.Image)
        Me.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(23, 22)
        Me.HomeButton.Text = "Home"
        '
        'ReloadButton
        '
        Me.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReloadButton.Image = CType(resources.GetObject("ReloadButton.Image"), System.Drawing.Image)
        Me.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReloadButton.Name = "ReloadButton"
        Me.ReloadButton.Size = New System.Drawing.Size(23, 22)
        Me.ReloadButton.Text = "Reload"
        '
        'urlBar
        '
        Me.urlBar.Name = "urlBar"
        Me.urlBar.Size = New System.Drawing.Size(800, 25)
        '
        'goButton
        '
        Me.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.goButton.Image = CType(resources.GetObject("goButton.Image"), System.Drawing.Image)
        Me.goButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(23, 22)
        Me.goButton.Text = "Go"
        '
        'SearchBar
        '
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(250, 25)
        '
        'SearchButton
        '
        Me.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), System.Drawing.Image)
        Me.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(23, 22)
        Me.SearchButton.Text = "Search"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "Tools"
        '
        'panBrowser
        '
        Me.panBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBrowser.Location = New System.Drawing.Point(0, 25)
        Me.panBrowser.Name = "panBrowser"
        Me.panBrowser.Size = New System.Drawing.Size(1264, 656)
        Me.panBrowser.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.panBrowser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Z-Browser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BackButton As ToolStripButton
    Friend WithEvents ForwardButton As ToolStripButton
    Friend WithEvents HomeButton As ToolStripButton
    Friend WithEvents ReloadButton As ToolStripButton
    Friend WithEvents urlBar As ToolStripTextBox
    Friend WithEvents goButton As ToolStripButton
    Friend WithEvents panBrowser As Panel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SearchBar As ToolStripTextBox
    Friend WithEvents SearchButton As ToolStripButton
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
