<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_brotherInfo
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
        Me.img_brother = New System.Windows.Forms.PictureBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_bond = New System.Windows.Forms.Label()
        Me.lbl_Major = New System.Windows.Forms.Label()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.lbl_grade = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        CType(Me.img_brother, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_brother
        '
        Me.img_brother.Location = New System.Drawing.Point(13, 13)
        Me.img_brother.Name = "img_brother"
        Me.img_brother.Size = New System.Drawing.Size(235, 337)
        Me.img_brother.TabIndex = 0
        Me.img_brother.TabStop = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(254, 13)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "Name: "
        '
        'lbl_bond
        '
        Me.lbl_bond.AutoSize = True
        Me.lbl_bond.Location = New System.Drawing.Point(254, 38)
        Me.lbl_bond.Name = "lbl_bond"
        Me.lbl_bond.Size = New System.Drawing.Size(38, 13)
        Me.lbl_bond.TabIndex = 2
        Me.lbl_bond.Text = "Bond: "
        '
        'lbl_Major
        '
        Me.lbl_Major.AutoSize = True
        Me.lbl_Major.Location = New System.Drawing.Point(254, 63)
        Me.lbl_Major.Name = "lbl_Major"
        Me.lbl_Major.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Major.TabIndex = 3
        Me.lbl_Major.Text = "Major: "
        '
        'btn_done
        '
        Me.btn_done.Location = New System.Drawing.Point(497, 439)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(75, 23)
        Me.btn_done.TabIndex = 4
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'lbl_grade
        '
        Me.lbl_grade.AutoSize = True
        Me.lbl_grade.Location = New System.Drawing.Point(421, 38)
        Me.lbl_grade.Name = "lbl_grade"
        Me.lbl_grade.Size = New System.Drawing.Size(35, 13)
        Me.lbl_grade.TabIndex = 5
        Me.lbl_grade.Text = "Year: "
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Location = New System.Drawing.Point(257, 97)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(52, 13)
        Me.lbl_position.TabIndex = 6
        Me.lbl_position.Text = "Positions "
        '
        'Form_brotherInfo
        '
        Me.AcceptButton = Me.btn_done
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 474)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_grade)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.lbl_Major)
        Me.Controls.Add(Me.lbl_bond)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.img_brother)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_brotherInfo"
        CType(Me.img_brother, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_brother As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_bond As System.Windows.Forms.Label
    Friend WithEvents lbl_Major As System.Windows.Forms.Label
    Friend WithEvents btn_done As System.Windows.Forms.Button
    Friend WithEvents lbl_grade As System.Windows.Forms.Label
    Friend WithEvents lbl_position As System.Windows.Forms.Label
End Class
