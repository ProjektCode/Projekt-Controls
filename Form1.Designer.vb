<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ProjektCircularPictureBox1 = New Projekt_Controls.ProjektCircularPictureBox()
        Me.ProjektComboBox1 = New Projekt_Controls.ProjektComboBox()
        Me.ProjektSeparator6 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektTextBox3 = New Projekt_Controls.ProjektTextBox()
        Me.ProjektTextBox2 = New Projekt_Controls.ProjektTextBox()
        Me.ProjektTextBox1 = New Projekt_Controls.ProjektTextBox()
        Me.ProjektSeparator5 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektSeparator4 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektSeparator3 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektSeparator2 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektSeparator1 = New Projekt_Controls.ProjektSeparator()
        Me.ProjektDatePicker1 = New Projekt_Controls.ProjektDatePicker()
        Me.ProjektButton1 = New Projekt_Controls.ProjektButton()
        Me.DragMain = New Projekt_Controls.ProjektDrag_Component()
        Me.MainRound = New Projekt_Controls.ProjektRoundedForm_Component()
        Me.pnlHeader.SuspendLayout()
        CType(Me.ProjektCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DarkRed
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1280, 46)
        Me.pnlHeader.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1205, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 46)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(464, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PROJEKT CUSTOM CONTROLS"
        '
        'ProjektCircularPictureBox1
        '
        Me.ProjektCircularPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.ProjektCircularPictureBox1.BackgroundImage = CType(resources.GetObject("ProjektCircularPictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.ProjektCircularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProjektCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.ProjektCircularPictureBox1.BorderColor = System.Drawing.Color.Crimson
        Me.ProjektCircularPictureBox1.BorderColor2 = System.Drawing.Color.DarkRed
        Me.ProjektCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.ProjektCircularPictureBox1.BorderSize = 5
        Me.ProjektCircularPictureBox1.GradientAngle = 50.0R
        Me.ProjektCircularPictureBox1.Image = CType(resources.GetObject("ProjektCircularPictureBox1.Image"), System.Drawing.Image)
        Me.ProjektCircularPictureBox1.Location = New System.Drawing.Point(338, 52)
        Me.ProjektCircularPictureBox1.Name = "ProjektCircularPictureBox1"
        Me.ProjektCircularPictureBox1.Size = New System.Drawing.Size(239, 239)
        Me.ProjektCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProjektCircularPictureBox1.TabIndex = 17
        Me.ProjektCircularPictureBox1.TabStop = False
        '
        'ProjektComboBox1
        '
        Me.ProjektComboBox1._Text = ""
        Me.ProjektComboBox1.BackColor = System.Drawing.Color.Crimson
        Me.ProjektComboBox1.BorderColor = System.Drawing.Color.White
        Me.ProjektComboBox1.BorderSize = 1
        Me.ProjektComboBox1.DataSource = Nothing
        Me.ProjektComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ProjektComboBox1.ForeColor = System.Drawing.Color.DimGray
        Me.ProjektComboBox1.IconColor = System.Drawing.Color.White
        Me.ProjektComboBox1.ListBackColor = System.Drawing.Color.Crimson
        Me.ProjektComboBox1.ListTextColor = System.Drawing.Color.White
        Me.ProjektComboBox1.Location = New System.Drawing.Point(12, 586)
        Me.ProjektComboBox1.MinimumSize = New System.Drawing.Size(200, 30)
        Me.ProjektComboBox1.Name = "ProjektComboBox1"
        Me.ProjektComboBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.ProjektComboBox1.Size = New System.Drawing.Size(200, 30)
        Me.ProjektComboBox1.TabIndex = 16
        '
        'ProjektSeparator6
        '
        Me.ProjektSeparator6.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator6.isVertical = False
        Me.ProjektSeparator6.Location = New System.Drawing.Point(12, 557)
        Me.ProjektSeparator6.Name = "ProjektSeparator6"
        Me.ProjektSeparator6.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator6.TabIndex = 15
        Me.ProjektSeparator6.Text = "ProjektSeparator6"
        Me.ProjektSeparator6.Thickness = 1
        '
        'ProjektTextBox3
        '
        Me.ProjektTextBox3._Text = ""
        Me.ProjektTextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.ProjektTextBox3.BorderColor = System.Drawing.Color.Crimson
        Me.ProjektTextBox3.BorderFocusColor = System.Drawing.Color.DarkRed
        Me.ProjektTextBox3.BorderRadius = 0
        Me.ProjektTextBox3.BorderSize = 3
        Me.ProjektTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjektTextBox3.ForeColor = System.Drawing.Color.DimGray
        Me.ProjektTextBox3.IsPasswordChar = False
        Me.ProjektTextBox3.IsPlaceHolder = True
        Me.ProjektTextBox3.Location = New System.Drawing.Point(12, 440)
        Me.ProjektTextBox3.MultiLine = True
        Me.ProjektTextBox3.Name = "ProjektTextBox3"
        Me.ProjektTextBox3.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProjektTextBox3.PasswordChar = False
        Me.ProjektTextBox3.PlaceHolderColor = System.Drawing.Color.DarkSlateGray
        Me.ProjektTextBox3.PlaceHolderText = "PROJEKT"
        Me.ProjektTextBox3.Size = New System.Drawing.Size(320, 111)
        Me.ProjektTextBox3.TabIndex = 14
        Me.ProjektTextBox3.UnderlineStyle = False
        '
        'ProjektTextBox2
        '
        Me.ProjektTextBox2._Text = ""
        Me.ProjektTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ProjektTextBox2.BorderColor = System.Drawing.Color.Crimson
        Me.ProjektTextBox2.BorderFocusColor = System.Drawing.Color.DarkRed
        Me.ProjektTextBox2.BorderRadius = 0
        Me.ProjektTextBox2.BorderSize = 3
        Me.ProjektTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjektTextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.ProjektTextBox2.IsPasswordChar = False
        Me.ProjektTextBox2.IsPlaceHolder = True
        Me.ProjektTextBox2.Location = New System.Drawing.Point(12, 403)
        Me.ProjektTextBox2.MultiLine = False
        Me.ProjektTextBox2.Name = "ProjektTextBox2"
        Me.ProjektTextBox2.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProjektTextBox2.PasswordChar = False
        Me.ProjektTextBox2.PlaceHolderColor = System.Drawing.Color.DarkSlateGray
        Me.ProjektTextBox2.PlaceHolderText = "PROJEKT"
        Me.ProjektTextBox2.Size = New System.Drawing.Size(320, 31)
        Me.ProjektTextBox2.TabIndex = 13
        Me.ProjektTextBox2.UnderlineStyle = True
        '
        'ProjektTextBox1
        '
        Me.ProjektTextBox1._Text = ""
        Me.ProjektTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ProjektTextBox1.BorderColor = System.Drawing.Color.Crimson
        Me.ProjektTextBox1.BorderFocusColor = System.Drawing.Color.DarkRed
        Me.ProjektTextBox1.BorderRadius = 10
        Me.ProjektTextBox1.BorderSize = 1
        Me.ProjektTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjektTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.ProjektTextBox1.IsPasswordChar = False
        Me.ProjektTextBox1.IsPlaceHolder = True
        Me.ProjektTextBox1.Location = New System.Drawing.Point(12, 366)
        Me.ProjektTextBox1.MultiLine = False
        Me.ProjektTextBox1.Name = "ProjektTextBox1"
        Me.ProjektTextBox1.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProjektTextBox1.PasswordChar = False
        Me.ProjektTextBox1.PlaceHolderColor = System.Drawing.Color.DarkSlateGray
        Me.ProjektTextBox1.PlaceHolderText = "PROJEKT"
        Me.ProjektTextBox1.Size = New System.Drawing.Size(320, 31)
        Me.ProjektTextBox1.TabIndex = 12
        Me.ProjektTextBox1.UnderlineStyle = False
        '
        'ProjektSeparator5
        '
        Me.ProjektSeparator5.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator5.isVertical = False
        Me.ProjektSeparator5.Location = New System.Drawing.Point(12, 337)
        Me.ProjektSeparator5.Name = "ProjektSeparator5"
        Me.ProjektSeparator5.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator5.TabIndex = 11
        Me.ProjektSeparator5.Text = "ProjektSeparator5"
        Me.ProjektSeparator5.Thickness = 1
        '
        'ProjektSeparator4
        '
        Me.ProjektSeparator4.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator4.isVertical = False
        Me.ProjektSeparator4.Location = New System.Drawing.Point(12, 280)
        Me.ProjektSeparator4.Name = "ProjektSeparator4"
        Me.ProjektSeparator4.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator4.TabIndex = 9
        Me.ProjektSeparator4.Text = "ProjektSeparator4"
        Me.ProjektSeparator4.Thickness = 1
        '
        'ProjektSeparator3
        '
        Me.ProjektSeparator3.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator3.isVertical = False
        Me.ProjektSeparator3.Location = New System.Drawing.Point(12, 205)
        Me.ProjektSeparator3.Name = "ProjektSeparator3"
        Me.ProjektSeparator3.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator3.TabIndex = 8
        Me.ProjektSeparator3.Text = "ProjektSeparator3"
        Me.ProjektSeparator3.Thickness = 1
        '
        'ProjektSeparator2
        '
        Me.ProjektSeparator2.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator2.isVertical = False
        Me.ProjektSeparator2.Location = New System.Drawing.Point(12, 135)
        Me.ProjektSeparator2.Name = "ProjektSeparator2"
        Me.ProjektSeparator2.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator2.TabIndex = 7
        Me.ProjektSeparator2.Text = "ProjektSeparator2"
        Me.ProjektSeparator2.Thickness = 1
        '
        'ProjektSeparator1
        '
        Me.ProjektSeparator1.ForeColor = System.Drawing.Color.Crimson
        Me.ProjektSeparator1.isVertical = False
        Me.ProjektSeparator1.Location = New System.Drawing.Point(12, 79)
        Me.ProjektSeparator1.Name = "ProjektSeparator1"
        Me.ProjektSeparator1.Size = New System.Drawing.Size(320, 23)
        Me.ProjektSeparator1.TabIndex = 6
        Me.ProjektSeparator1.Text = "ProjektSeparator1"
        Me.ProjektSeparator1.Thickness = 1
        '
        'ProjektDatePicker1
        '
        Me.ProjektDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.ProjektDatePicker1.BorderSize = 0
        Me.ProjektDatePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.ProjektDatePicker1.Location = New System.Drawing.Point(12, 164)
        Me.ProjektDatePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.ProjektDatePicker1.Name = "ProjektDatePicker1"
        Me.ProjektDatePicker1.Size = New System.Drawing.Size(320, 35)
        Me.ProjektDatePicker1.SkinColor = System.Drawing.Color.Crimson
        Me.ProjektDatePicker1.TabIndex = 4
        Me.ProjektDatePicker1.TextColor = System.Drawing.Color.White
        '
        'ProjektButton1
        '
        Me.ProjektButton1.BackColor = System.Drawing.Color.Crimson
        Me.ProjektButton1.BackgroundColor = System.Drawing.Color.Crimson
        Me.ProjektButton1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.ProjektButton1.BorderRadius = 30
        Me.ProjektButton1.BorderSize = 0
        Me.ProjektButton1.FlatAppearance.BorderSize = 0
        Me.ProjektButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProjektButton1.ForeColor = System.Drawing.Color.White
        Me.ProjektButton1.Location = New System.Drawing.Point(12, 234)
        Me.ProjektButton1.Name = "ProjektButton1"
        Me.ProjektButton1.Size = New System.Drawing.Size(150, 40)
        Me.ProjektButton1.TabIndex = 3
        Me.ProjektButton1.Text = "ProjektButton1"
        Me.ProjektButton1.TextColor = System.Drawing.Color.White
        Me.ProjektButton1.UseVisualStyleBackColor = False
        '
        'DragMain
        '
        Me.DragMain.SelectedControl = Me.pnlHeader
        '
        'MainRound
        '
        Me.MainRound.BorderSize = 20
        Me.MainRound.SelectedForm = Nothing
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.ProjektCircularPictureBox1)
        Me.Controls.Add(Me.ProjektComboBox1)
        Me.Controls.Add(Me.ProjektSeparator6)
        Me.Controls.Add(Me.ProjektTextBox3)
        Me.Controls.Add(Me.ProjektTextBox2)
        Me.Controls.Add(Me.ProjektTextBox1)
        Me.Controls.Add(Me.ProjektSeparator5)
        Me.Controls.Add(Me.ProjektSeparator4)
        Me.Controls.Add(Me.ProjektSeparator3)
        Me.Controls.Add(Me.ProjektSeparator2)
        Me.Controls.Add(Me.ProjektSeparator1)
        Me.Controls.Add(Me.ProjektDatePicker1)
        Me.Controls.Add(Me.ProjektButton1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.ProjektCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents ProjektRadioButton1 As ProjektRadioButton
    Friend WithEvents ProjektRadioButton2 As ProjektRadioButton
    Friend WithEvents ProjektButton1 As ProjektButton
    Friend WithEvents ProjektDatePicker1 As ProjektDatePicker
    Friend WithEvents ProjektToggleButton1 As ProjektToggleButton
    Friend WithEvents ProjektSeparator1 As ProjektSeparator
    Friend WithEvents ProjektSeparator2 As ProjektSeparator
    Friend WithEvents ProjektSeparator3 As ProjektSeparator
    Friend WithEvents ProjektSeparator4 As ProjektSeparator
    Friend WithEvents DragMain As ProjektDrag_Component
    Friend WithEvents ProjektSeparator5 As ProjektSeparator
    Friend WithEvents MainRound As ProjektRoundedForm_Component
    Friend WithEvents ProjektTextBox1 As ProjektTextBox
    Friend WithEvents ProjektTextBox2 As ProjektTextBox
    Friend WithEvents ProjektTextBox3 As ProjektTextBox
    Friend WithEvents ProjektSeparator6 As ProjektSeparator
    Friend WithEvents ProjektComboBox1 As ProjektComboBox
    Friend WithEvents ProjektCircularPictureBox1 As ProjektCircularPictureBox
End Class
