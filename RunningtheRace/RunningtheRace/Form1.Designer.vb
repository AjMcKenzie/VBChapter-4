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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRunner1 = New System.Windows.Forms.TextBox()
        Me.txtRunner2 = New System.Windows.Forms.TextBox()
        Me.txtRunner3 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1stPlace = New System.Windows.Forms.Label()
        Me.lbl2ndPlace = New System.Windows.Forms.Label()
        Me.lbl3rdPlace = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names and finishing times."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in seconds)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Runner 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Runner 3:"
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(87, 157)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner1.TabIndex = 6
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(87, 191)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner2.TabIndex = 8
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(87, 227)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner3.TabIndex = 10
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(207, 157)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(71, 20)
        Me.txtTime1.TabIndex = 7
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(207, 191)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(71, 20)
        Me.txtTime2.TabIndex = 9
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(207, 230)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(71, 20)
        Me.txtTime3.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl3rdPlace)
        Me.GroupBox1.Controls.Add(Me.lbl2ndPlace)
        Me.GroupBox1.Controls.Add(Me.lbl1stPlace)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 131)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "1st Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "2nd Place:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "3rd Place:"
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1stPlace.Location = New System.Drawing.Point(103, 22)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(100, 26)
        Me.lbl1stPlace.TabIndex = 16
        Me.lbl1stPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2ndPlace.Location = New System.Drawing.Point(103, 55)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(100, 27)
        Me.lbl2ndPlace.TabIndex = 17
        Me.lbl2ndPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3rdPlace.Location = New System.Drawing.Point(103, 91)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(100, 26)
        Me.lbl3rdPlace.TabIndex = 18
        Me.lbl3rdPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 405)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(77, 40)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate Results"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(132, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 40)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "New Race"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 40)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtRunner3)
        Me.Controls.Add(Me.txtRunner2)
        Me.Controls.Add(Me.txtRunner1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Race Result"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.Label
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.Label
    Friend WithEvents lbl1stPlace As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
