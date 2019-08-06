<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LuckySeven
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LuckySeven))
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lYouPlayed = New System.Windows.Forms.Label()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblNumber3 = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.PicLuckySeven = New System.Windows.Forms.PictureBox()
        Me.PicLuckySeven777 = New System.Windows.Forms.PictureBox()
        CType(Me.PicLuckySeven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLuckySeven777, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSpin.Location = New System.Drawing.Point(12, 12)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(95, 35)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(12, 101)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 35)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(12, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lYouPlayed
        '
        Me.lYouPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lYouPlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lYouPlayed.Location = New System.Drawing.Point(8, 297)
        Me.lYouPlayed.Name = "lYouPlayed"
        Me.lYouPlayed.Size = New System.Drawing.Size(108, 32)
        Me.lYouPlayed.TabIndex = 3
        Me.lYouPlayed.Text = "You Played"
        Me.lYouPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumber1
        '
        Me.lblNumber1.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblNumber1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumber1.Location = New System.Drawing.Point(120, 16)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(100, 100)
        Me.lblNumber1.TabIndex = 5
        Me.lblNumber1.Text = "0"
        Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumber2
        '
        Me.lblNumber2.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblNumber2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumber2.Location = New System.Drawing.Point(250, 16)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(100, 100)
        Me.lblNumber2.TabIndex = 6
        Me.lblNumber2.Text = "0"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumber3
        '
        Me.lblNumber3.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblNumber3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumber3.Location = New System.Drawing.Point(380, 16)
        Me.lblNumber3.Name = "lblNumber3"
        Me.lblNumber3.Size = New System.Drawing.Size(100, 100)
        Me.lblNumber3.TabIndex = 7
        Me.lblNumber3.Text = "0"
        Me.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCounter
        '
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCounter.Location = New System.Drawing.Point(6, 339)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(108, 32)
        Me.lblCounter.TabIndex = 8
        Me.lblCounter.Text = "0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicLuckySeven
        '
        Me.PicLuckySeven.Image = CType(resources.GetObject("PicLuckySeven.Image"), System.Drawing.Image)
        Me.PicLuckySeven.Location = New System.Drawing.Point(120, 142)
        Me.PicLuckySeven.Name = "PicLuckySeven"
        Me.PicLuckySeven.Size = New System.Drawing.Size(360, 231)
        Me.PicLuckySeven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLuckySeven.TabIndex = 9
        Me.PicLuckySeven.TabStop = False
        Me.PicLuckySeven.Visible = False
        '
        'PicLuckySeven777
        '
        Me.PicLuckySeven777.Image = CType(resources.GetObject("PicLuckySeven777.Image"), System.Drawing.Image)
        Me.PicLuckySeven777.Location = New System.Drawing.Point(120, 142)
        Me.PicLuckySeven777.Name = "PicLuckySeven777"
        Me.PicLuckySeven777.Size = New System.Drawing.Size(360, 231)
        Me.PicLuckySeven777.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLuckySeven777.TabIndex = 10
        Me.PicLuckySeven777.TabStop = False
        Me.PicLuckySeven777.Visible = False
        '
        'LuckySeven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(503, 392)
        Me.Controls.Add(Me.PicLuckySeven777)
        Me.Controls.Add(Me.PicLuckySeven)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblNumber3)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.lYouPlayed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSpin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LuckySeven"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lucky Seven SB 2018"
        CType(Me.PicLuckySeven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLuckySeven777, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lYouPlayed As Label
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents lblNumber3 As Label
    Friend WithEvents lblCounter As Label
    Friend WithEvents PicLuckySeven As PictureBox
    Friend WithEvents PicLuckySeven777 As PictureBox
End Class
