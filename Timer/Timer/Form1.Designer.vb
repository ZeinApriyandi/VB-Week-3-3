<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_timer
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.txt_jam = New System.Windows.Forms.TextBox()
        Me.dtp_jam = New System.Windows.Forms.DateTimePicker()
        Me.tmr_jam = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.Location = New System.Drawing.Point(12, 9)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(39, 13)
        Me.lbl_jam.TabIndex = 0
        Me.lbl_jam.Text = "Label1"
        '
        'txt_jam
        '
        Me.txt_jam.Location = New System.Drawing.Point(15, 36)
        Me.txt_jam.Name = "txt_jam"
        Me.txt_jam.Size = New System.Drawing.Size(100, 20)
        Me.txt_jam.TabIndex = 1
        '
        'dtp_jam
        '
        Me.dtp_jam.CustomFormat = "hh:mm:ss"
        Me.dtp_jam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_jam.Location = New System.Drawing.Point(15, 77)
        Me.dtp_jam.Name = "dtp_jam"
        Me.dtp_jam.Size = New System.Drawing.Size(100, 20)
        Me.dtp_jam.TabIndex = 2
        '
        'tmr_jam
        '
        Me.tmr_jam.Interval = 1000
        '
        'frm_timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.dtp_jam)
        Me.Controls.Add(Me.txt_jam)
        Me.Controls.Add(Me.lbl_jam)
        Me.Name = "frm_timer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_jam As System.Windows.Forms.Label
    Friend WithEvents txt_jam As System.Windows.Forms.TextBox
    Friend WithEvents dtp_jam As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmr_jam As System.Windows.Forms.Timer

End Class
