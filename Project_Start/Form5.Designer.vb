<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Live
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Live))
        Me.BkBtn = New System.Windows.Forms.Button()
        Me.MnBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BkBtn
        '
        Me.BkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BkBtn.BackColor = System.Drawing.Color.IndianRed
        Me.BkBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BkBtn.ForeColor = System.Drawing.Color.Black
        Me.BkBtn.Location = New System.Drawing.Point(0, 301)
        Me.BkBtn.Name = "BkBtn"
        Me.BkBtn.Size = New System.Drawing.Size(102, 39)
        Me.BkBtn.TabIndex = 0
        Me.BkBtn.TabStop = False
        Me.BkBtn.Text = "BACK"
        Me.BkBtn.UseVisualStyleBackColor = False
        '
        'MnBtn
        '
        Me.MnBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MnBtn.BackColor = System.Drawing.Color.IndianRed
        Me.MnBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnBtn.ForeColor = System.Drawing.Color.Black
        Me.MnBtn.Location = New System.Drawing.Point(441, 301)
        Me.MnBtn.Name = "MnBtn"
        Me.MnBtn.Size = New System.Drawing.Size(102, 39)
        Me.MnBtn.TabIndex = 1
        Me.MnBtn.TabStop = False
        Me.MnBtn.Text = "MAIN"
        Me.MnBtn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.AliceBlue
        Me.Button3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(544, 40)
        Me.Button3.TabIndex = 0
        Me.Button3.TabStop = False
        Me.Button3.Text = "PUNE LIVE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 249)
        Me.DataGridView1.TabIndex = 2
        '
        'Live
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(544, 341)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MnBtn)
        Me.Controls.Add(Me.BkBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 380)
        Me.MinimumSize = New System.Drawing.Size(560, 380)
        Me.Name = "Live"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PTES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BkBtn As System.Windows.Forms.Button
    Friend WithEvents MnBtn As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
