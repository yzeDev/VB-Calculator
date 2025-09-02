<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        DecimalBtn = New Button()
        BackspaceBtn = New Button()
        ClrBtn = New Button()
        DivideBtn = New Button()
        EqualBtn = New Button()
        Button0 = New Button()
        MultiplyBtn = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        MinusBtn = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        PlusBtn = New Button()
        Button3 = New Button()
        Button2 = New Button()
        DisplayLabel = New Label()
        Button1 = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = SystemColors.InactiveBorder
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(DecimalBtn, 2, 6)
        TableLayoutPanel1.Controls.Add(BackspaceBtn, 2, 2)
        TableLayoutPanel1.Controls.Add(ClrBtn, 1, 2)
        TableLayoutPanel1.Controls.Add(DivideBtn, 3, 5)
        TableLayoutPanel1.Controls.Add(EqualBtn, 3, 6)
        TableLayoutPanel1.Controls.Add(Button0, 1, 6)
        TableLayoutPanel1.Controls.Add(MultiplyBtn, 3, 4)
        TableLayoutPanel1.Controls.Add(Button9, 2, 5)
        TableLayoutPanel1.Controls.Add(Button8, 1, 5)
        TableLayoutPanel1.Controls.Add(Button7, 0, 5)
        TableLayoutPanel1.Controls.Add(MinusBtn, 3, 3)
        TableLayoutPanel1.Controls.Add(Button6, 2, 4)
        TableLayoutPanel1.Controls.Add(Button5, 1, 4)
        TableLayoutPanel1.Controls.Add(Button4, 0, 4)
        TableLayoutPanel1.Controls.Add(PlusBtn, 3, 2)
        TableLayoutPanel1.Controls.Add(Button3, 2, 3)
        TableLayoutPanel1.Controls.Add(Button2, 1, 3)
        TableLayoutPanel1.Controls.Add(DisplayLabel, 0, 1)
        TableLayoutPanel1.Controls.Add(Button1, 0, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Yu Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.0284643F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.0284643F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5886164F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5886164F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5886164F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5886164F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5886145F))
        TableLayoutPanel1.Size = New Size(503, 1050)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        TableLayoutPanel1.SetColumnSpan(Label1, 4)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Variable Display", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 115)
        Label1.TabIndex = 20
        Label1.TextAlign = ContentAlignment.BottomRight
        ' 
        ' DecimalBtn
        ' 
        DecimalBtn.BackColor = SystemColors.ControlLightLight
        DecimalBtn.Dock = DockStyle.Fill
        DecimalBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        DecimalBtn.ForeColor = SystemColors.ControlText
        DecimalBtn.Location = New Point(253, 885)
        DecimalBtn.Name = "DecimalBtn"
        DecimalBtn.Size = New Size(119, 162)
        DecimalBtn.TabIndex = 19
        DecimalBtn.TabStop = False
        DecimalBtn.Text = "."
        DecimalBtn.UseVisualStyleBackColor = False
        ' 
        ' BackspaceBtn
        ' 
        BackspaceBtn.BackColor = SystemColors.ControlLightLight
        BackspaceBtn.Dock = DockStyle.Fill
        BackspaceBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        BackspaceBtn.ForeColor = SystemColors.ControlText
        BackspaceBtn.Location = New Point(253, 233)
        BackspaceBtn.Name = "BackspaceBtn"
        BackspaceBtn.Size = New Size(119, 157)
        BackspaceBtn.TabIndex = 18
        BackspaceBtn.TabStop = False
        BackspaceBtn.Text = "←"
        BackspaceBtn.UseVisualStyleBackColor = False
        ' 
        ' ClrBtn
        ' 
        ClrBtn.BackColor = SystemColors.ControlLightLight
        ClrBtn.Dock = DockStyle.Fill
        ClrBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        ClrBtn.ForeColor = SystemColors.ControlText
        ClrBtn.Location = New Point(128, 233)
        ClrBtn.Name = "ClrBtn"
        ClrBtn.Size = New Size(119, 157)
        ClrBtn.TabIndex = 17
        ClrBtn.TabStop = False
        ClrBtn.Text = "Clear"
        ClrBtn.UseVisualStyleBackColor = False
        ' 
        ' DivideBtn
        ' 
        DivideBtn.BackColor = SystemColors.ControlLightLight
        DivideBtn.Dock = DockStyle.Fill
        DivideBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        DivideBtn.ForeColor = SystemColors.ControlText
        DivideBtn.Location = New Point(378, 722)
        DivideBtn.Name = "DivideBtn"
        DivideBtn.Size = New Size(122, 157)
        DivideBtn.TabIndex = 16
        DivideBtn.TabStop = False
        DivideBtn.Text = "÷"
        DivideBtn.UseVisualStyleBackColor = False
        ' 
        ' EqualBtn
        ' 
        EqualBtn.BackColor = Color.IndianRed
        EqualBtn.Dock = DockStyle.Fill
        EqualBtn.Font = New Font("Segoe UI Variable Display", 9.0F, FontStyle.Bold)
        EqualBtn.Location = New Point(378, 885)
        EqualBtn.Name = "EqualBtn"
        EqualBtn.Size = New Size(122, 162)
        EqualBtn.TabIndex = 15
        EqualBtn.TabStop = False
        EqualBtn.Text = "="
        EqualBtn.UseVisualStyleBackColor = False
        ' 
        ' Button0
        ' 
        Button0.BackColor = SystemColors.ControlLightLight
        Button0.Dock = DockStyle.Fill
        Button0.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button0.ForeColor = SystemColors.ControlText
        Button0.Location = New Point(128, 885)
        Button0.Name = "Button0"
        Button0.Size = New Size(119, 162)
        Button0.TabIndex = 14
        Button0.TabStop = False
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = False
        ' 
        ' MultiplyBtn
        ' 
        MultiplyBtn.BackColor = SystemColors.ControlLightLight
        MultiplyBtn.Dock = DockStyle.Fill
        MultiplyBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        MultiplyBtn.ForeColor = SystemColors.ControlText
        MultiplyBtn.Location = New Point(378, 559)
        MultiplyBtn.Name = "MultiplyBtn"
        MultiplyBtn.Size = New Size(122, 157)
        MultiplyBtn.TabIndex = 12
        MultiplyBtn.TabStop = False
        MultiplyBtn.Text = "×"
        MultiplyBtn.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = SystemColors.ControlLightLight
        Button9.Dock = DockStyle.Fill
        Button9.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button9.ForeColor = SystemColors.ControlText
        Button9.Location = New Point(253, 722)
        Button9.Name = "Button9"
        Button9.Size = New Size(119, 157)
        Button9.TabIndex = 11
        Button9.TabStop = False
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.ControlLightLight
        Button8.Dock = DockStyle.Fill
        Button8.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button8.ForeColor = SystemColors.ControlText
        Button8.Location = New Point(128, 722)
        Button8.Name = "Button8"
        Button8.Size = New Size(119, 157)
        Button8.TabIndex = 10
        Button8.TabStop = False
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.ControlLightLight
        Button7.Dock = DockStyle.Fill
        Button7.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button7.ForeColor = SystemColors.ControlText
        Button7.Location = New Point(3, 722)
        Button7.Name = "Button7"
        Button7.Size = New Size(119, 157)
        Button7.TabIndex = 9
        Button7.TabStop = False
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' MinusBtn
        ' 
        MinusBtn.BackColor = SystemColors.ControlLightLight
        MinusBtn.Dock = DockStyle.Fill
        MinusBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        MinusBtn.ForeColor = SystemColors.ControlText
        MinusBtn.Location = New Point(378, 396)
        MinusBtn.Name = "MinusBtn"
        MinusBtn.Size = New Size(122, 157)
        MinusBtn.TabIndex = 8
        MinusBtn.TabStop = False
        MinusBtn.Text = "-"
        MinusBtn.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ControlLightLight
        Button6.Dock = DockStyle.Fill
        Button6.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(253, 559)
        Button6.Name = "Button6"
        Button6.Size = New Size(119, 157)
        Button6.TabIndex = 7
        Button6.TabStop = False
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlLightLight
        Button5.Dock = DockStyle.Fill
        Button5.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(128, 559)
        Button5.Name = "Button5"
        Button5.Size = New Size(119, 157)
        Button5.TabIndex = 6
        Button5.TabStop = False
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLightLight
        Button4.Dock = DockStyle.Fill
        Button4.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(3, 559)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 157)
        Button4.TabIndex = 5
        Button4.TabStop = False
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PlusBtn
        ' 
        PlusBtn.BackColor = SystemColors.ControlLightLight
        PlusBtn.Dock = DockStyle.Fill
        PlusBtn.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        PlusBtn.ForeColor = SystemColors.ControlText
        PlusBtn.Location = New Point(378, 233)
        PlusBtn.Name = "PlusBtn"
        PlusBtn.Size = New Size(122, 157)
        PlusBtn.TabIndex = 4
        PlusBtn.TabStop = False
        PlusBtn.Text = "+"
        PlusBtn.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlLightLight
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(253, 396)
        Button3.Name = "Button3"
        Button3.Size = New Size(119, 157)
        Button3.TabIndex = 3
        Button3.TabStop = False
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLightLight
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(128, 396)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 157)
        Button2.TabIndex = 2
        Button2.TabStop = False
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DisplayLabel
        ' 
        DisplayLabel.AutoSize = True
        DisplayLabel.BackColor = Color.White
        TableLayoutPanel1.SetColumnSpan(DisplayLabel, 4)
        DisplayLabel.Dock = DockStyle.Fill
        DisplayLabel.Font = New Font("Segoe UI Variable Display", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DisplayLabel.ForeColor = Color.Black
        DisplayLabel.Location = New Point(3, 115)
        DisplayLabel.Name = "DisplayLabel"
        DisplayLabel.Size = New Size(497, 115)
        DisplayLabel.TabIndex = 0
        DisplayLabel.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI Variable Small Semibol", 9.0F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(3, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 157)
        Button1.TabIndex = 1
        Button1.TabStop = False
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(503, 1050)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KeyPreview = True
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vinas & Aedri - Calculator"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents DisplayLabel As Label
    Friend WithEvents DivideBtn As Button
    Friend WithEvents EqualBtn As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents MultiplyBtn As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MinusBtn As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PlusBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackspaceBtn As Button
    Friend WithEvents ClrBtn As Button
    Friend WithEvents DecimalBtn As Button
    Public WithEvents Label1 As Label
End Class
