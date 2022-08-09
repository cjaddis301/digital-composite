<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.lbl_301 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_301
        '
        Me.lbl_301.BackColor = System.Drawing.Color.Transparent
        Me.lbl_301.Location = New System.Drawing.Point(476, 654)
        Me.lbl_301.Name = "lbl_301"
        Me.lbl_301.Size = New System.Drawing.Size(69, 101)
        Me.lbl_301.TabIndex = 0
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 776)
        Me.Controls.Add(Me.lbl_301)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Main"
        Me.Text = "Digital Composite"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_301 As System.Windows.Forms.Label

End Class
