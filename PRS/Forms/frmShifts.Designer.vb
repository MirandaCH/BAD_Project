<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShifts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShifts))
        Me.btnFirstShift = New System.Windows.Forms.Button()
        Me.btnSecondShift = New System.Windows.Forms.Button()
        Me.btnThirdShift = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFirstShift
        '
        Me.btnFirstShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFirstShift.Image = CType(resources.GetObject("btnFirstShift.Image"), System.Drawing.Image)
        Me.btnFirstShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirstShift.Location = New System.Drawing.Point(15, 34)
        Me.btnFirstShift.Name = "btnFirstShift"
        Me.btnFirstShift.Size = New System.Drawing.Size(103, 39)
        Me.btnFirstShift.TabIndex = 0
        Me.btnFirstShift.Text = "First Shift"
        Me.btnFirstShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFirstShift.UseVisualStyleBackColor = True
        '
        'btnSecondShift
        '
        Me.btnSecondShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondShift.Image = CType(resources.GetObject("btnSecondShift.Image"), System.Drawing.Image)
        Me.btnSecondShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecondShift.Location = New System.Drawing.Point(67, 79)
        Me.btnSecondShift.Name = "btnSecondShift"
        Me.btnSecondShift.Size = New System.Drawing.Size(117, 41)
        Me.btnSecondShift.TabIndex = 1
        Me.btnSecondShift.Text = "Second Shift"
        Me.btnSecondShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSecondShift.UseVisualStyleBackColor = True
        '
        'btnThirdShift
        '
        Me.btnThirdShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThirdShift.Image = CType(resources.GetObject("btnThirdShift.Image"), System.Drawing.Image)
        Me.btnThirdShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThirdShift.Location = New System.Drawing.Point(121, 126)
        Me.btnThirdShift.Name = "btnThirdShift"
        Me.btnThirdShift.Size = New System.Drawing.Size(106, 39)
        Me.btnThirdShift.TabIndex = 2
        Me.btnThirdShift.Text = "Third Shift"
        Me.btnThirdShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThirdShift.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Image = CType(resources.GetObject("lblChoose.Image"), System.Drawing.Image)
        Me.lblChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblChoose.Location = New System.Drawing.Point(12, 9)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(137, 13)
        Me.lblChoose.TabIndex = 3
        Me.lblChoose.Text = "       Choose your shift:"
        Me.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 178)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.btnThirdShift)
        Me.Controls.Add(Me.btnSecondShift)
        Me.Controls.Add(Me.btnFirstShift)
        Me.Name = "frmShifts"
        Me.Text = "Shifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFirstShift As System.Windows.Forms.Button
    Friend WithEvents btnSecondShift As System.Windows.Forms.Button
    Friend WithEvents btnThirdShift As System.Windows.Forms.Button
    Friend WithEvents lblChoose As System.Windows.Forms.Label
End Class
