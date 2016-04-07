<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmURLS
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1339, 779)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebBrowser1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1331, 753)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "URLVoid"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1325, 747)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.urlvoid.com", System.UriKind.Absolute)
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.WebBrowser2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1082, 657)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "VirusTotal"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(1076, 651)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("http://virustotal.com", System.UriKind.Absolute)
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.WebBrowser3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1082, 657)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "URLQuery"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser3.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScriptErrorsSuppressed = True
        Me.WebBrowser3.Size = New System.Drawing.Size(1082, 657)
        Me.WebBrowser3.TabIndex = 0
        Me.WebBrowser3.Url = New System.Uri("http://urlquery.net", System.UriKind.Absolute)
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.WebBrowser4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1082, 657)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "IPVoid"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser4.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.ScriptErrorsSuppressed = True
        Me.WebBrowser4.Size = New System.Drawing.Size(1082, 657)
        Me.WebBrowser4.TabIndex = 0
        Me.WebBrowser4.Url = New System.Uri("http://ipvoid.com", System.UriKind.Absolute)
        '
        'frmURLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 779)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmURLS"
        Me.Text = "urls"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
End Class
