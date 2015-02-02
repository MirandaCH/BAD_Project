<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstShift
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstShift))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTt = New System.Windows.Forms.TextBox()
        Me.lblTt = New System.Windows.Forms.Label()
        Me.txtTb = New System.Windows.Forms.TextBox()
        Me.lblTb = New System.Windows.Forms.Label()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.lblTc = New System.Windows.Forms.Label()
        Me.btnTpaid = New System.Windows.Forms.Button()
        Me.lblTrucks = New System.Windows.Forms.Label()
        Me.btnBpaid = New System.Windows.Forms.Button()
        Me.lblBuses = New System.Windows.Forms.Label()
        Me.btnCpaid = New System.Windows.Forms.Button()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(73, 224)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 30)
        Me.btnBack.TabIndex = 59
        Me.btnBack.Text = "Back to Shifts"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(148, 193)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 58
        Me.txtTotal.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(30, 200)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 17)
        Me.lblTotal.TabIndex = 57
        Me.lblTotal.Text = "Total"
        '
        'txtTt
        '
        Me.txtTt.Location = New System.Drawing.Point(148, 167)
        Me.txtTt.Name = "txtTt"
        Me.txtTt.ReadOnly = True
        Me.txtTt.Size = New System.Drawing.Size(100, 20)
        Me.txtTt.TabIndex = 56
        Me.txtTt.Text = "0"
        '
        'lblTt
        '
        Me.lblTt.AutoSize = True
        Me.lblTt.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTt.Location = New System.Drawing.Point(30, 174)
        Me.lblTt.Name = "lblTt"
        Me.lblTt.Size = New System.Drawing.Size(114, 17)
        Me.lblTt.TabIndex = 55
        Me.lblTt.Text = "Total from Trucks:"
        '
        'txtTb
        '
        Me.txtTb.Location = New System.Drawing.Point(148, 141)
        Me.txtTb.Name = "txtTb"
        Me.txtTb.ReadOnly = True
        Me.txtTb.Size = New System.Drawing.Size(100, 20)
        Me.txtTb.TabIndex = 54
        Me.txtTb.Text = "0"
        '
        'lblTb
        '
        Me.lblTb.AutoSize = True
        Me.lblTb.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTb.Location = New System.Drawing.Point(30, 148)
        Me.lblTb.Name = "lblTb"
        Me.lblTb.Size = New System.Drawing.Size(108, 17)
        Me.lblTb.TabIndex = 53
        Me.lblTb.Text = "Total from Buses:"
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(148, 115)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.ReadOnly = True
        Me.txtTc.Size = New System.Drawing.Size(100, 20)
        Me.txtTc.TabIndex = 52
        Me.txtTc.Text = "0"
        '
        'lblTc
        '
        Me.lblTc.AutoSize = True
        Me.lblTc.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTc.Location = New System.Drawing.Point(30, 122)
        Me.lblTc.Name = "lblTc"
        Me.lblTc.Size = New System.Drawing.Size(101, 17)
        Me.lblTc.TabIndex = 51
        Me.lblTc.Text = "Total from Cars:"
        '
        'btnTpaid
        '
        Me.btnTpaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpaid.Location = New System.Drawing.Point(148, 67)
        Me.btnTpaid.Name = "btnTpaid"
        Me.btnTpaid.Size = New System.Drawing.Size(100, 23)
        Me.btnTpaid.TabIndex = 50
        Me.btnTpaid.Text = "PAID"
        Me.btnTpaid.UseVisualStyleBackColor = True
        '
        'lblTrucks
        '
        Me.lblTrucks.AutoSize = True
        Me.lblTrucks.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrucks.Location = New System.Drawing.Point(30, 72)
        Me.lblTrucks.Name = "lblTrucks"
        Me.lblTrucks.Size = New System.Drawing.Size(93, 17)
        Me.lblTrucks.TabIndex = 49
        Me.lblTrucks.Text = "Trucks: 110 den"
        '
        'btnBpaid
        '
        Me.btnBpaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBpaid.Location = New System.Drawing.Point(148, 38)
        Me.btnBpaid.Name = "btnBpaid"
        Me.btnBpaid.Size = New System.Drawing.Size(100, 23)
        Me.btnBpaid.TabIndex = 48
        Me.btnBpaid.Text = "PAID"
        Me.btnBpaid.UseVisualStyleBackColor = True
        '
        'lblBuses
        '
        Me.lblBuses.AutoSize = True
        Me.lblBuses.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuses.Location = New System.Drawing.Point(30, 43)
        Me.lblBuses.Name = "lblBuses"
        Me.lblBuses.Size = New System.Drawing.Size(89, 17)
        Me.lblBuses.TabIndex = 47
        Me.lblBuses.Text = "Buses: 100 den"
        '
        'btnCpaid
        '
        Me.btnCpaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCpaid.Location = New System.Drawing.Point(148, 9)
        Me.btnCpaid.Name = "btnCpaid"
        Me.btnCpaid.Size = New System.Drawing.Size(100, 23)
        Me.btnCpaid.TabIndex = 46
        Me.btnCpaid.Text = "PAID"
        Me.btnCpaid.UseVisualStyleBackColor = True
        '
        'lblCars
        '
        Me.lblCars.AutoSize = True
        Me.lblCars.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCars.Location = New System.Drawing.Point(30, 14)
        Me.lblCars.Name = "lblCars"
        Me.lblCars.Size = New System.Drawing.Size(77, 17)
        Me.lblCars.TabIndex = 45
        Me.lblCars.Text = "Cars: 50 den"
        '
        'frmFirstShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 266)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTt)
        Me.Controls.Add(Me.lblTt)
        Me.Controls.Add(Me.txtTb)
        Me.Controls.Add(Me.lblTb)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.lblTc)
        Me.Controls.Add(Me.btnTpaid)
        Me.Controls.Add(Me.lblTrucks)
        Me.Controls.Add(Me.btnBpaid)
        Me.Controls.Add(Me.lblBuses)
        Me.Controls.Add(Me.btnCpaid)
        Me.Controls.Add(Me.lblCars)
        Me.Name = "frmFirstShift"
        Me.Text = "First Shift"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTt As System.Windows.Forms.TextBox
    Friend WithEvents lblTt As System.Windows.Forms.Label
    Friend WithEvents txtTb As System.Windows.Forms.TextBox
    Friend WithEvents lblTb As System.Windows.Forms.Label
    Friend WithEvents txtTc As System.Windows.Forms.TextBox
    Friend WithEvents lblTc As System.Windows.Forms.Label
    Friend WithEvents btnTpaid As System.Windows.Forms.Button
    Friend WithEvents lblTrucks As System.Windows.Forms.Label
    Friend WithEvents btnBpaid As System.Windows.Forms.Button
    Friend WithEvents lblBuses As System.Windows.Forms.Label
    Friend WithEvents btnCpaid As System.Windows.Forms.Button
    Friend WithEvents lblCars As System.Windows.Forms.Label
End Class
