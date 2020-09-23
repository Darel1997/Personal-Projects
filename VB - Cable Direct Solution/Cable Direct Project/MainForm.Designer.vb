<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lstConnection = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 140)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(115, 36)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(153, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 36)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(12, 188)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(256, 36)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = True
        Me.radBusiness.Location = New System.Drawing.Point(191, 49)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(67, 17)
        Me.radBusiness.TabIndex = 3
        Me.radBusiness.TabStop = True
        Me.radBusiness.Text = "&Business"
        Me.radBusiness.UseVisualStyleBackColor = True
        '
        'radResidential
        '
        Me.radResidential.AutoSize = True
        Me.radResidential.Checked = True
        Me.radResidential.Location = New System.Drawing.Point(191, 26)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(77, 17)
        Me.radResidential.TabIndex = 4
        Me.radResidential.TabStop = True
        Me.radResidential.Text = "&Residential"
        Me.radResidential.UseVisualStyleBackColor = True
        '
        'lstPremium
        '
        Me.lstPremium.FormattingEnabled = True
        Me.lstPremium.Location = New System.Drawing.Point(15, 26)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(48, 95)
        Me.lstPremium.TabIndex = 5
        '
        'lstConnection
        '
        Me.lstConnection.FormattingEnabled = True
        Me.lstConnection.Location = New System.Drawing.Point(113, 26)
        Me.lstConnection.Name = "lstConnection"
        Me.lstConnection.Size = New System.Drawing.Size(48, 95)
        Me.lstConnection.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Premium Channels"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Connections"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 233)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstConnection)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.radResidential)
        Me.Controls.Add(Me.radBusiness)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents radBusiness As RadioButton
    Friend WithEvents radResidential As RadioButton
    Friend WithEvents lstPremium As ListBox
    Friend WithEvents lstConnection As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
