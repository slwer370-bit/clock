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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATEToolStripMenuItem
        '
        Me.DATEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem1, Me.TimeToolStripMenuItem, Me.TimeDateToolStripMenuItem})
        Me.DATEToolStripMenuItem.Name = "DATEToolStripMenuItem"
        Me.DATEToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DATEToolStripMenuItem.Text = "Clock"
        '
        'DateToolStripMenuItem1
        '
        Me.DateToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HourToolStripMenuItem, Me.MinuteToolStripMenuItem, Me.SecondToolStripMenuItem, Me.MonthToolStripMenuItem, Me.YearToolStripMenuItem, Me.WeekdayToolStripMenuItem})
        Me.DateToolStripMenuItem1.Name = "DateToolStripMenuItem1"
        Me.DateToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DateToolStripMenuItem1.Text = "Date"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TimeToolStripMenuItem.Text = "Time"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TimeDateToolStripMenuItem.Text = "Time&Date"
        '
        'HourToolStripMenuItem
        '
        Me.HourToolStripMenuItem.Name = "HourToolStripMenuItem"
        Me.HourToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HourToolStripMenuItem.Text = "Hour"
        '
        'MinuteToolStripMenuItem
        '
        Me.MinuteToolStripMenuItem.Name = "MinuteToolStripMenuItem"
        Me.MinuteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MinuteToolStripMenuItem.Text = "Minute"
        '
        'SecondToolStripMenuItem
        '
        Me.SecondToolStripMenuItem.Name = "SecondToolStripMenuItem"
        Me.SecondToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SecondToolStripMenuItem.Text = "Second"
        '
        'MonthToolStripMenuItem
        '
        Me.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        Me.MonthToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MonthToolStripMenuItem.Text = "Month"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YearToolStripMenuItem.Text = "Year"
        '
        'WeekdayToolStripMenuItem
        '
        Me.WeekdayToolStripMenuItem.Name = "WeekdayToolStripMenuItem"
        Me.WeekdayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WeekdayToolStripMenuItem.Text = "Weekday"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(241, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 111)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MinuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekdayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
