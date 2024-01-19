<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 40)
        Label1.TabIndex = 0
        Label1.Text = "Enter a word:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(108, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(217, 34)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(46, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(379, 31)
        TextBox1.TabIndex = 2
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"Umbrella", "Boots", "RainCoat", "Gloves"})
        ListBox1.Location = New Point(128, 211)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(180, 129)
        ListBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(153, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 25)
        Label2.TabIndex = 4
        Label2.Text = "                     "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Location = New Point(277, 445)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(177, 143)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Colour"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(27, 108)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(70, 29)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(27, 48)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(87, 29)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Purple"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonHighlight
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(24, 445)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(172, 143)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Case"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(38, 84)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(107, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "To Lower"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(39, 48)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(109, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "To Upper"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 616)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Words"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton

End Class
