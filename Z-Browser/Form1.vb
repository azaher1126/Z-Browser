Imports CefSharp.WinForms
Imports CefSharp
Public Class Form1
    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browser = New ChromiumWebBrowser() With {
            .Dock = DockStyle.Fill
        }
        panBrowser.Controls.Add(browser)
        If My.Settings.hpopen = True Then
            browser.Load(My.Settings.homepage)
        End If
    End Sub

    Private Sub goButton_Click(sender As Object, e As EventArgs) Handles goButton.Click
        If urlBar.Text = "" Then
        Else
            browser.Load(urlBar.Text)
        End If
    End Sub

    Private Sub urlBar_KeyDown(sender As Object, e As KeyEventArgs) Handles urlBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            goButton.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If urlBar.Focused = False Then
            urlBar.Text = browser.Address
        Else
        End If
        If SearchBar.Focused = False Then
            If urlBar.Text.Contains("www.google.ca/search?q=") Then
            Else
                SearchBar.Text = ""
            End If
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchBar.Text = "" Then
        Else
            browser.Load("http://www.google.ca/search?q=" & SearchBar.Text)
        End If
    End Sub

    Private Sub SearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchButton.PerformClick()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If browser.CanGoBack = True Then
            browser.Back
        End If
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        If browser.CanGoForward = True Then
            browser.Forward
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        browser.Load(My.Settings.homepage)
    End Sub

    Private Sub ReloadButton_Click(sender As Object, e As EventArgs) Handles ReloadButton.Click
        browser.Reload
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
