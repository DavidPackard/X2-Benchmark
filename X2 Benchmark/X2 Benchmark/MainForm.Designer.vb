<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn10Calc = New System.Windows.Forms.Button()
        Me.btn50Calc = New System.Windows.Forms.Button()
        Me.btn100Calc = New System.Windows.Forms.Button()
        Me.btn500Calc = New System.Windows.Forms.Button()
        Me.btn1000Calc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn10000Calc = New System.Windows.Forms.Button()
        Me.btnPatchNotes = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.X2_Benchmark.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(525, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn10Calc
        '
        Me.btn10Calc.Location = New System.Drawing.Point(13, 12)
        Me.btn10Calc.Name = "btn10Calc"
        Me.btn10Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn10Calc.TabIndex = 1
        Me.btn10Calc.Text = "10 Calculation Benchmark"
        Me.btn10Calc.UseVisualStyleBackColor = True
        '
        'btn50Calc
        '
        Me.btn50Calc.Location = New System.Drawing.Point(12, 41)
        Me.btn50Calc.Name = "btn50Calc"
        Me.btn50Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn50Calc.TabIndex = 1
        Me.btn50Calc.Text = "50 Calculation Benchmark"
        Me.btn50Calc.UseVisualStyleBackColor = True
        '
        'btn100Calc
        '
        Me.btn100Calc.Location = New System.Drawing.Point(12, 70)
        Me.btn100Calc.Name = "btn100Calc"
        Me.btn100Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn100Calc.TabIndex = 1
        Me.btn100Calc.Text = "100 Calculation Benchmark"
        Me.btn100Calc.UseVisualStyleBackColor = True
        '
        'btn500Calc
        '
        Me.btn500Calc.Location = New System.Drawing.Point(12, 99)
        Me.btn500Calc.Name = "btn500Calc"
        Me.btn500Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn500Calc.TabIndex = 1
        Me.btn500Calc.Text = "500 Calculation Benchmark"
        Me.btn500Calc.UseVisualStyleBackColor = True
        '
        'btn1000Calc
        '
        Me.btn1000Calc.Location = New System.Drawing.Point(12, 128)
        Me.btn1000Calc.Name = "btn1000Calc"
        Me.btn1000Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn1000Calc.TabIndex = 1
        Me.btn1000Calc.Text = "1000 Calculation Benchmark"
        Me.btn1000Calc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1000 Calculation Benchmark"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn10000Calc
        '
        Me.btn10000Calc.Location = New System.Drawing.Point(12, 157)
        Me.btn10000Calc.Name = "btn10000Calc"
        Me.btn10000Calc.Size = New System.Drawing.Size(159, 23)
        Me.btn10000Calc.TabIndex = 1
        Me.btn10000Calc.Text = "10000 Calculation Benchmark"
        Me.btn10000Calc.UseVisualStyleBackColor = True
        '
        'btnPatchNotes
        '
        Me.btnPatchNotes.Location = New System.Drawing.Point(13, 248)
        Me.btnPatchNotes.Name = "btnPatchNotes"
        Me.btnPatchNotes.Size = New System.Drawing.Size(105, 23)
        Me.btnPatchNotes.TabIndex = 2
        Me.btnPatchNotes.Text = "v1.2 Patch Notes"
        Me.btnPatchNotes.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.btnPatchNotes)
        Me.Controls.Add(Me.btn10000Calc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn1000Calc)
        Me.Controls.Add(Me.btn500Calc)
        Me.Controls.Add(Me.btn100Calc)
        Me.Controls.Add(Me.btn50Calc)
        Me.Controls.Add(Me.btn10Calc)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "X2 Benchmark - Version 1.2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn10Calc As Button
    Friend WithEvents btn50Calc As Button
    Friend WithEvents btn100Calc As Button
    Friend WithEvents btn500Calc As Button
    Friend WithEvents btn1000Calc As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn10000Calc As Button
    Friend WithEvents btnPatchNotes As Button
End Class
