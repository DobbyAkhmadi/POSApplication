<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Password
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Password))
        Me.Btnok = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'Btnok
        '
        Me.Btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btnok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnok.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Check
        Me.Btnok.Location = New System.Drawing.Point(148, 12)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(81, 41)
        Me.Btnok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btnok.TabIndex = 5
        Me.Btnok.Text = "Ok"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxX1.MaxLength = 10
        Me.TextBoxX1.Multiline = True
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxX1.Size = New System.Drawing.Size(130, 41)
        Me.TextBoxX1.TabIndex = 6
        Me.TextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 65)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.Btnok)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masukan Password "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
