<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn10calc = New System.Windows.Forms.Button()
        Me.btn50calc = New System.Windows.Forms.Button()
        Me.btn100calc = New System.Windows.Forms.Button()
        Me.btn500calc = New System.Windows.Forms.Button()
        Me.btn1000calc = New System.Windows.Forms.Button()
        Me.btn10000calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFormShow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn10calc
        '
        Me.btn10calc.Location = New System.Drawing.Point(13, 13)
        Me.btn10calc.Name = "btn10calc"
        Me.btn10calc.Size = New System.Drawing.Size(111, 23)
        Me.btn10calc.TabIndex = 0
        Me.btn10calc.Text = "10 Calculations"
        Me.btn10calc.UseVisualStyleBackColor = True
        '
        'btn50calc
        '
        Me.btn50calc.Location = New System.Drawing.Point(13, 43)
        Me.btn50calc.Name = "btn50calc"
        Me.btn50calc.Size = New System.Drawing.Size(111, 23)
        Me.btn50calc.TabIndex = 1
        Me.btn50calc.Text = "50 Calculations"
        Me.btn50calc.UseVisualStyleBackColor = True
        '
        'btn100calc
        '
        Me.btn100calc.Location = New System.Drawing.Point(13, 73)
        Me.btn100calc.Name = "btn100calc"
        Me.btn100calc.Size = New System.Drawing.Size(111, 23)
        Me.btn100calc.TabIndex = 2
        Me.btn100calc.Text = "100 Calculations"
        Me.btn100calc.UseVisualStyleBackColor = True
        '
        'btn500calc
        '
        Me.btn500calc.Location = New System.Drawing.Point(13, 103)
        Me.btn500calc.Name = "btn500calc"
        Me.btn500calc.Size = New System.Drawing.Size(111, 23)
        Me.btn500calc.TabIndex = 3
        Me.btn500calc.Text = "500 Calculations"
        Me.btn500calc.UseVisualStyleBackColor = True
        '
        'btn1000calc
        '
        Me.btn1000calc.Location = New System.Drawing.Point(13, 133)
        Me.btn1000calc.Name = "btn1000calc"
        Me.btn1000calc.Size = New System.Drawing.Size(111, 23)
        Me.btn1000calc.TabIndex = 4
        Me.btn1000calc.Text = "1,000 Calculations"
        Me.btn1000calc.UseVisualStyleBackColor = True
        '
        'btn10000calc
        '
        Me.btn10000calc.Location = New System.Drawing.Point(13, 163)
        Me.btn10000calc.Name = "btn10000calc"
        Me.btn10000calc.Size = New System.Drawing.Size(111, 23)
        Me.btn10000calc.TabIndex = 5
        Me.btn10000calc.Text = "10,000 Calculations"
        Me.btn10000calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 78)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Creator: David Packard"
        '
        'lblFormShow
        '
        Me.lblFormShow.AutoSize = True
        Me.lblFormShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormShow.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblFormShow.Location = New System.Drawing.Point(146, 124)
        Me.lblFormShow.Name = "lblFormShow"
        Me.lblFormShow.Size = New System.Drawing.Size(188, 18)
        Me.lblFormShow.TabIndex = 8
        Me.lblFormShow.Text = "Google Form (click me)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 200)
        Me.Controls.Add(Me.lblFormShow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn10000calc)
        Me.Controls.Add(Me.btn1000calc)
        Me.Controls.Add(Me.btn500calc)
        Me.Controls.Add(Me.btn100calc)
        Me.Controls.Add(Me.btn50calc)
        Me.Controls.Add(Me.btn10calc)
        Me.Name = "Form1"
        Me.Text = "Test benchmark form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn10calc As Button
    Friend WithEvents btn50calc As Button
    Friend WithEvents btn100calc As Button
    Friend WithEvents btn500calc As Button
    Friend WithEvents btn1000calc As Button
    Friend WithEvents btn10000calc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn10calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench10.bat")
        Shell(OperatingPath)
    End Sub

    Private Sub btn50calc_Click(sender As Object, e As EventArgs) Handles btn50calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench50.bat")
        Shell(OperatingPath)
    End Sub

    Private Sub btn100calc_Click(sender As Object, e As EventArgs) Handles btn100calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench100.bat")
        Shell(OperatingPath)
    End Sub

    Private Sub btn500calc_Click(sender As Object, e As EventArgs) Handles btn500calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench500.bat")
        Shell(OperatingPath)
    End Sub

    Private Sub btn1000calc_Click(sender As Object, e As EventArgs) Handles btn1000calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench1000.bat")
        Shell(OperatingPath)
    End Sub

    Private Sub btn10000calc_Click(sender As Object, e As EventArgs) Handles btn10000calc.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim OperatingPath As String = IO.Path.Combine(path, "bench10000.bat")
        Shell(OperatingPath)
    End Sub

    Public WithEvents lblFormShow As Label

    Private Sub lblFormShow_Click(sender As Object, e As EventArgs) Handles lblFormShow.Click
        Dim myForm As ScoreSubmiss
        If myForm Is Nothing Then
            myForm = ScoreSubmiss
        End If
        myForm.Show()
    End Sub
End Class
