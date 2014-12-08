<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsingleoumulti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsingleoumulti))
        Me.btnmulti = New System.Windows.Forms.Button
        Me.btnsingle = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnmulti
        '
        Me.btnmulti.Location = New System.Drawing.Point(102, 158)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(117, 47)
        Me.btnmulti.TabIndex = 0
        Me.btnmulti.Text = "Multiplayer"
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btnsingle
        '
        Me.btnsingle.Location = New System.Drawing.Point(102, 52)
        Me.btnsingle.Name = "btnsingle"
        Me.btnsingle.Size = New System.Drawing.Size(117, 50)
        Me.btnsingle.TabIndex = 1
        Me.btnsingle.Text = "Singleplayer"
        Me.btnsingle.UseVisualStyleBackColor = True
        '
        'frmsingleoumulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 291)
        Me.Controls.Add(Me.btnsingle)
        Me.Controls.Add(Me.btnmulti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsingleoumulti"
        Me.Text = "Jogo da Velha 2.0"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnmulti As System.Windows.Forms.Button
    Friend WithEvents btnsingle As System.Windows.Forms.Button
End Class
