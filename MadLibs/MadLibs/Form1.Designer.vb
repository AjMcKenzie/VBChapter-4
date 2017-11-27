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
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listNumber = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listBodyPartPlural = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listNoun = New System.Windows.Forms.ListBox()
        Me.listPluralNoun = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listColor
        '
        Me.listColor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Blue", "Red", "Yellow", "Green", "Purple", "Pink", "Black", "White"})
        Me.listColor.Location = New System.Drawing.Point(12, 32)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color"
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"Biggest", "Fastest", "Fatest", "Greatest", "Shortest", "Smallest", "Dumbest", "Smartest", "Ugliest"})
        Me.listEst.Location = New System.Drawing.Point(153, 32)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Word ending in est"
        '
        'listNumber
        '
        Me.listNumber.FormattingEnabled = True
        Me.listNumber.Items.AddRange(New Object() {"1", "10", "130", "101", "11", "12", "2", "3", "8"})
        Me.listNumber.Location = New System.Drawing.Point(300, 32)
        Me.listNumber.Name = "listNumber"
        Me.listNumber.Size = New System.Drawing.Size(120, 95)
        Me.listNumber.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Number"
        '
        'listBodyPartPlural
        '
        Me.listBodyPartPlural.FormattingEnabled = True
        Me.listBodyPartPlural.Location = New System.Drawing.Point(12, 161)
        Me.listBodyPartPlural.Name = "listBodyPartPlural"
        Me.listBodyPartPlural.Size = New System.Drawing.Size(120, 95)
        Me.listBodyPartPlural.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Body Part Plural"
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Location = New System.Drawing.Point(153, 161)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 5
        '
        'listNoun
        '
        Me.listNoun.FormattingEnabled = True
        Me.listNoun.Location = New System.Drawing.Point(294, 161)
        Me.listNoun.Name = "listNoun"
        Me.listNoun.Size = New System.Drawing.Size(120, 95)
        Me.listNoun.TabIndex = 6
        '
        'listPluralNoun
        '
        Me.listPluralNoun.FormattingEnabled = True
        Me.listPluralNoun.Location = New System.Drawing.Point(15, 288)
        Me.listPluralNoun.Name = "listPluralNoun"
        Me.listPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPluralNoun.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Animal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Plural Noun"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(166, 298)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(115, 39)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(300, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 39)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(166, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 413)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.listPluralNoun)
        Me.Controls.Add(Me.listNoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBodyPartPlural)
        Me.Controls.Add(Me.listNumber)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listColor)
        Me.Name = "Form1"
        Me.Text = "Mad Libs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listColor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listNumber As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listBodyPartPlural As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listNoun As System.Windows.Forms.ListBox
    Friend WithEvents listPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
