<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Login))
        Me.TxtUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TxtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RequiredFieldValidator3 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.")
        Me.RequiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.")
        Me.RangeValidator1 = New DevComponents.DotNetBar.Validator.RangeValidator()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock()
        Me.OriginalIconHolder1 = New CloudToolkitN6.OriginalIconHolder()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btnok = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtUser.Border.Class = "TextBoxBorder"
        Me.TxtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtUser.Location = New System.Drawing.Point(114, 132)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(163, 20)
        Me.TxtUser.TabIndex = 0
        Me.TxtUser.WatermarkText = "Isikan Nama Pengguna"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(14, 129)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(88, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Nama Pengguna"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(14, 164)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Kata Sandi"
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtPass.Border.Class = "TextBoxBorder"
        Me.TxtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPass.Location = New System.Drawing.Point(114, 164)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(163, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.UseSystemPasswordChar = True
        Me.TxtPass.WatermarkText = "Isikan Kata Sandi"
        '
        'RequiredFieldValidator3
        '
        Me.RequiredFieldValidator3.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator1
        '
        Me.RequiredFieldValidator1.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RangeValidator1
        '
        Me.RangeValidator1.ErrorMessage = "Your error message here."
        Me.RangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(104, 132)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(12, 23)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = ":"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(104, 164)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(12, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = ":"
        '
        'CloudDigitalClock1
        '
        Me.CloudDigitalClock1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.CloudDigitalClock1.ColorLower_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloudDigitalClock1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CloudDigitalClock1.DateColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.DateFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.DrawDate = True
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(11, 16)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(271, 110)
        Me.CloudDigitalClock1.TabIndex = 9
        '
        'OriginalIconHolder1
        '
        Me.OriginalIconHolder1.AnimationsEnaled = True
        Me.OriginalIconHolder1.BackColor = System.Drawing.Color.Transparent
        Me.OriginalIconHolder1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OriginalIconHolder1.Location = New System.Drawing.Point(14, 193)
        Me.OriginalIconHolder1.Name = "OriginalIconHolder1"
        Me.OriginalIconHolder1.Size = New System.Drawing.Size(75, 59)
        Me.OriginalIconHolder1.TabIndex = 18
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.manage
        Me.ButtonX1.Location = New System.Drawing.Point(117, 293)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(168, 41)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 21
        Me.ButtonX1.Text = "Konfigurasi Database"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources._282516_478724225499858_932995606_n1
        Me.PictureBox1.Location = New System.Drawing.Point(283, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.stop_2
        Me.BtnCancel.Location = New System.Drawing.Point(195, 206)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 41)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "&Batal"
        '
        'Btnok
        '
        Me.Btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btnok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnok.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Check
        Me.Btnok.Location = New System.Drawing.Point(108, 206)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(81, 41)
        Me.Btnok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btnok.TabIndex = 4
        Me.Btnok.Text = "&Masuk"
        '
        'F_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(691, 269)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OriginalIconHolder1)
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Btnok)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Akun (Secured)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btnok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RequiredFieldValidator3 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RangeValidator1 As DevComponents.DotNetBar.Validator.RangeValidator
    Friend WithEvents RequiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
    Friend WithEvents OriginalIconHolder1 As CloudToolkitN6.OriginalIconHolder
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
