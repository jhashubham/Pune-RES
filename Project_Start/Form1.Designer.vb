<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project_Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Project_Start))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SdlBtn = New System.Windows.Forms.Button()
        Me.EnqBtn = New System.Windows.Forms.Button()
        Me.ExtBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pune Train Enquiry System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SdlBtn
        '
        Me.SdlBtn.BackColor = System.Drawing.Color.IndianRed
        Me.SdlBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SdlBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SdlBtn.ForeColor = System.Drawing.Color.Black
        Me.SdlBtn.Location = New System.Drawing.Point(0, 298)
        Me.SdlBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SdlBtn.Name = "SdlBtn"
        Me.SdlBtn.Padding = New System.Windows.Forms.Padding(3)
        Me.SdlBtn.Size = New System.Drawing.Size(183, 39)
        Me.SdlBtn.TabIndex = 2
        Me.SdlBtn.TabStop = False
        Me.SdlBtn.Text = "STATION SCHEDULE"
        Me.SdlBtn.UseVisualStyleBackColor = False
        '
        'EnqBtn
        '
        Me.EnqBtn.BackColor = System.Drawing.Color.IndianRed
        Me.EnqBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnqBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnqBtn.ForeColor = System.Drawing.Color.Black
        Me.EnqBtn.Location = New System.Drawing.Point(178, 298)
        Me.EnqBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.EnqBtn.Name = "EnqBtn"
        Me.EnqBtn.Size = New System.Drawing.Size(183, 39)
        Me.EnqBtn.TabIndex = 1
        Me.EnqBtn.TabStop = False
        Me.EnqBtn.Text = "TRAIN ENQUIRY"
        Me.EnqBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.EnqBtn.UseVisualStyleBackColor = False
        '
        'ExtBtn
        '
        Me.ExtBtn.BackColor = System.Drawing.Color.IndianRed
        Me.ExtBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtBtn.Location = New System.Drawing.Point(359, 298)
        Me.ExtBtn.Name = "ExtBtn"
        Me.ExtBtn.Size = New System.Drawing.Size(180, 39)
        Me.ExtBtn.TabIndex = 3
        Me.ExtBtn.TabStop = False
        Me.ExtBtn.Text = "EXIT"
        Me.ExtBtn.UseVisualStyleBackColor = False
        '
        'Project_Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.train_railway_underground_28575_1366x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExtBtn)
        Me.Controls.Add(Me.EnqBtn)
        Me.Controls.Add(Me.SdlBtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 380)
        Me.MinimumSize = New System.Drawing.Size(560, 380)
        Me.Name = "Project_Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PTES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnqBtn As System.Windows.Forms.Button
    Friend WithEvents SdlBtn As System.Windows.Forms.Button
    Friend WithEvents ExtBtn As System.Windows.Forms.Button

End Class
