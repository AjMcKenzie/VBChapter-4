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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radHamandTurkey = New System.Windows.Forms.RadioButton()
        Me.radChickenPatty = New System.Windows.Forms.RadioButton()
        Me.radCheeseBuger = New System.Windows.Forms.RadioButton()
        Me.radHambuger = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbChips = New System.Windows.Forms.PictureBox()
        Me.pbOnionRings = New System.Windows.Forms.PictureBox()
        Me.pbFries = New System.Windows.Forms.PictureBox()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.radOnionRings = New System.Windows.Forms.RadioButton()
        Me.radChips = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbHambuger = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbCheese = New System.Windows.Forms.PictureBox()
        Me.pbChicken = New System.Windows.Forms.PictureBox()
        Me.pbhamandTurkey = New System.Windows.Forms.PictureBox()
        Me.pbTomato = New System.Windows.Forms.PictureBox()
        Me.pbLettuce = New System.Windows.Forms.PictureBox()
        Me.pbMayo = New System.Windows.Forms.PictureBox()
        Me.pbPickles = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbChips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOnionRings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHambuger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChicken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbhamandTurkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTomato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLettuce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPickles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHamandTurkey)
        Me.GroupBox1.Controls.Add(Me.radChickenPatty)
        Me.GroupBox1.Controls.Add(Me.radCheeseBuger)
        Me.GroupBox1.Controls.Add(Me.radHambuger)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your meal"
        '
        'radHamandTurkey
        '
        Me.radHamandTurkey.AutoSize = True
        Me.radHamandTurkey.Location = New System.Drawing.Point(6, 134)
        Me.radHamandTurkey.Name = "radHamandTurkey"
        Me.radHamandTurkey.Size = New System.Drawing.Size(160, 17)
        Me.radHamandTurkey.TabIndex = 3
        Me.radHamandTurkey.TabStop = True
        Me.radHamandTurkey.Text = "Ham and Turkey Sandwhich"
        Me.radHamandTurkey.UseVisualStyleBackColor = True
        '
        'radChickenPatty
        '
        Me.radChickenPatty.AutoSize = True
        Me.radChickenPatty.Location = New System.Drawing.Point(7, 99)
        Me.radChickenPatty.Name = "radChickenPatty"
        Me.radChickenPatty.Size = New System.Drawing.Size(91, 17)
        Me.radChickenPatty.TabIndex = 2
        Me.radChickenPatty.TabStop = True
        Me.radChickenPatty.Text = "Chicken Patty"
        Me.radChickenPatty.UseVisualStyleBackColor = True
        '
        'radCheeseBuger
        '
        Me.radCheeseBuger.AutoSize = True
        Me.radCheeseBuger.Location = New System.Drawing.Point(6, 67)
        Me.radCheeseBuger.Name = "radCheeseBuger"
        Me.radCheeseBuger.Size = New System.Drawing.Size(92, 17)
        Me.radCheeseBuger.TabIndex = 1
        Me.radCheeseBuger.TabStop = True
        Me.radCheeseBuger.Text = "Cheese Buger"
        Me.radCheeseBuger.UseVisualStyleBackColor = True
        '
        'radHambuger
        '
        Me.radHambuger.AutoSize = True
        Me.radHambuger.Location = New System.Drawing.Point(7, 35)
        Me.radHambuger.Name = "radHambuger"
        Me.radHambuger.Size = New System.Drawing.Size(74, 17)
        Me.radHambuger.TabIndex = 0
        Me.radHambuger.TabStop = True
        Me.radHambuger.Text = "Hambuger"
        Me.radHambuger.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPickles)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(6, 135)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(60, 17)
        Me.chkPickles.TabIndex = 3
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(6, 100)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 68)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(6, 35)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pbChips)
        Me.GroupBox3.Controls.Add(Me.pbOnionRings)
        Me.GroupBox3.Controls.Add(Me.pbFries)
        Me.GroupBox3.Controls.Add(Me.radFries)
        Me.GroupBox3.Controls.Add(Me.radOnionRings)
        Me.GroupBox3.Controls.Add(Me.radChips)
        Me.GroupBox3.Location = New System.Drawing.Point(244, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(215, 125)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'pbChips
        '
        Me.pbChips.Image = CType(resources.GetObject("pbChips.Image"), System.Drawing.Image)
        Me.pbChips.Location = New System.Drawing.Point(95, 19)
        Me.pbChips.Name = "pbChips"
        Me.pbChips.Size = New System.Drawing.Size(109, 61)
        Me.pbChips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChips.TabIndex = 19
        Me.pbChips.TabStop = False
        Me.pbChips.Visible = False
        '
        'pbOnionRings
        '
        Me.pbOnionRings.Image = CType(resources.GetObject("pbOnionRings.Image"), System.Drawing.Image)
        Me.pbOnionRings.Location = New System.Drawing.Point(95, 19)
        Me.pbOnionRings.Name = "pbOnionRings"
        Me.pbOnionRings.Size = New System.Drawing.Size(109, 61)
        Me.pbOnionRings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOnionRings.TabIndex = 18
        Me.pbOnionRings.TabStop = False
        Me.pbOnionRings.Visible = False
        '
        'pbFries
        '
        Me.pbFries.Image = CType(resources.GetObject("pbFries.Image"), System.Drawing.Image)
        Me.pbFries.Location = New System.Drawing.Point(95, 19)
        Me.pbFries.Name = "pbFries"
        Me.pbFries.Size = New System.Drawing.Size(109, 61)
        Me.pbFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFries.TabIndex = 17
        Me.pbFries.TabStop = False
        Me.pbFries.Visible = False
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(6, 19)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(47, 17)
        Me.radFries.TabIndex = 4
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'radOnionRings
        '
        Me.radOnionRings.AutoSize = True
        Me.radOnionRings.Location = New System.Drawing.Point(6, 56)
        Me.radOnionRings.Name = "radOnionRings"
        Me.radOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.radOnionRings.TabIndex = 5
        Me.radOnionRings.TabStop = True
        Me.radOnionRings.Text = "Onion Rings"
        Me.radOnionRings.UseVisualStyleBackColor = True
        '
        'radChips
        '
        Me.radChips.AutoSize = True
        Me.radChips.Location = New System.Drawing.Point(6, 89)
        Me.radChips.Name = "radChips"
        Me.radChips.Size = New System.Drawing.Size(51, 17)
        Me.radChips.TabIndex = 6
        Me.radChips.TabStop = True
        Me.radChips.Text = "Chips"
        Me.radChips.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(4, 276)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(174, 104)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 213)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(478, 27)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to Delgsdos Sandwich Food Court"
        '
        'pbHambuger
        '
        Me.pbHambuger.Image = CType(resources.GetObject("pbHambuger.Image"), System.Drawing.Image)
        Me.pbHambuger.Location = New System.Drawing.Point(196, 42)
        Me.pbHambuger.Name = "pbHambuger"
        Me.pbHambuger.Size = New System.Drawing.Size(137, 83)
        Me.pbHambuger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHambuger.TabIndex = 6
        Me.pbHambuger.TabStop = False
        Me.pbHambuger.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(132, 251)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 277)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(53, 47)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(184, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 47)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pbCheese
        '
        Me.pbCheese.Image = CType(resources.GetObject("pbCheese.Image"), System.Drawing.Image)
        Me.pbCheese.Location = New System.Drawing.Point(196, 42)
        Me.pbCheese.Name = "pbCheese"
        Me.pbCheese.Size = New System.Drawing.Size(137, 83)
        Me.pbCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCheese.TabIndex = 10
        Me.pbCheese.TabStop = False
        Me.pbCheese.Visible = False
        '
        'pbChicken
        '
        Me.pbChicken.Image = CType(resources.GetObject("pbChicken.Image"), System.Drawing.Image)
        Me.pbChicken.Location = New System.Drawing.Point(196, 42)
        Me.pbChicken.Name = "pbChicken"
        Me.pbChicken.Size = New System.Drawing.Size(137, 83)
        Me.pbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChicken.TabIndex = 11
        Me.pbChicken.TabStop = False
        Me.pbChicken.Visible = False
        '
        'pbhamandTurkey
        '
        Me.pbhamandTurkey.Image = CType(resources.GetObject("pbhamandTurkey.Image"), System.Drawing.Image)
        Me.pbhamandTurkey.Location = New System.Drawing.Point(196, 42)
        Me.pbhamandTurkey.Name = "pbhamandTurkey"
        Me.pbhamandTurkey.Size = New System.Drawing.Size(137, 83)
        Me.pbhamandTurkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbhamandTurkey.TabIndex = 12
        Me.pbhamandTurkey.TabStop = False
        Me.pbhamandTurkey.Visible = False
        '
        'pbTomato
        '
        Me.pbTomato.Image = CType(resources.GetObject("pbTomato.Image"), System.Drawing.Image)
        Me.pbTomato.Location = New System.Drawing.Point(184, 131)
        Me.pbTomato.Name = "pbTomato"
        Me.pbTomato.Size = New System.Drawing.Size(53, 37)
        Me.pbTomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTomato.TabIndex = 13
        Me.pbTomato.TabStop = False
        Me.pbTomato.Visible = False
        '
        'pbLettuce
        '
        Me.pbLettuce.Image = CType(resources.GetObject("pbLettuce.Image"), System.Drawing.Image)
        Me.pbLettuce.Location = New System.Drawing.Point(299, 131)
        Me.pbLettuce.Name = "pbLettuce"
        Me.pbLettuce.Size = New System.Drawing.Size(57, 35)
        Me.pbLettuce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLettuce.TabIndex = 14
        Me.pbLettuce.TabStop = False
        Me.pbLettuce.Visible = False
        '
        'pbMayo
        '
        Me.pbMayo.Image = CType(resources.GetObject("pbMayo.Image"), System.Drawing.Image)
        Me.pbMayo.Location = New System.Drawing.Point(299, 172)
        Me.pbMayo.Name = "pbMayo"
        Me.pbMayo.Size = New System.Drawing.Size(57, 35)
        Me.pbMayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMayo.TabIndex = 15
        Me.pbMayo.TabStop = False
        Me.pbMayo.Visible = False
        '
        'pbPickles
        '
        Me.pbPickles.Image = CType(resources.GetObject("pbPickles.Image"), System.Drawing.Image)
        Me.pbPickles.Location = New System.Drawing.Point(184, 172)
        Me.pbPickles.Name = "pbPickles"
        Me.pbPickles.Size = New System.Drawing.Size(53, 38)
        Me.pbPickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPickles.TabIndex = 16
        Me.pbPickles.TabStop = False
        Me.pbPickles.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 388)
        Me.Controls.Add(Me.pbPickles)
        Me.Controls.Add(Me.pbMayo)
        Me.Controls.Add(Me.pbLettuce)
        Me.Controls.Add(Me.pbTomato)
        Me.Controls.Add(Me.pbhamandTurkey)
        Me.Controls.Add(Me.pbChicken)
        Me.Controls.Add(Me.pbCheese)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.pbHambuger)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbChips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOnionRings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHambuger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChicken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbhamandTurkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTomato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLettuce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPickles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radHamandTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents radChickenPatty As System.Windows.Forms.RadioButton
    Friend WithEvents radCheeseBuger As System.Windows.Forms.RadioButton
    Friend WithEvents radHambuger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents radOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents radChips As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbHambuger As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pbCheese As System.Windows.Forms.PictureBox
    Friend WithEvents pbChicken As System.Windows.Forms.PictureBox
    Friend WithEvents pbhamandTurkey As System.Windows.Forms.PictureBox
    Friend WithEvents pbTomato As System.Windows.Forms.PictureBox
    Friend WithEvents pbLettuce As System.Windows.Forms.PictureBox
    Friend WithEvents pbMayo As System.Windows.Forms.PictureBox
    Friend WithEvents pbPickles As System.Windows.Forms.PictureBox
    Friend WithEvents pbFries As System.Windows.Forms.PictureBox
    Friend WithEvents pbChips As System.Windows.Forms.PictureBox
    Friend WithEvents pbOnionRings As System.Windows.Forms.PictureBox

End Class
