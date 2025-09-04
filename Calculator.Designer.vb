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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        TableLayoutPanel1 = New TableLayoutPanel()
        CeBtn = New Button()
        PreviousResultLabel = New Label()
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
        CurrentResultLabel = New Label()
        Button1 = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(CeBtn, 0, 2)
        TableLayoutPanel1.Controls.Add(PreviousResultLabel, 0, 0)
        TableLayoutPanel1.Controls.Add(DecimalBtn, 0, 6)
        TableLayoutPanel1.Controls.Add(BackspaceBtn, 2, 2)
        TableLayoutPanel1.Controls.Add(ClrBtn, 1, 2)
        TableLayoutPanel1.Controls.Add(DivideBtn, 3, 5)
        TableLayoutPanel1.Controls.Add(EqualBtn, 2, 6)
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
        TableLayoutPanel1.Controls.Add(CurrentResultLabel, 0, 1)
        TableLayoutPanel1.Controls.Add(Button1, 0, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2, 4, 2, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.1906481F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.1906481F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.32374F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.32374F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.32374F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.32374F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3237391F))
        TableLayoutPanel1.Size = New Size(483, 724)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' CeBtn
        ' 
        CeBtn.BackColor = SystemColors.GrayText
        CeBtn.Dock = DockStyle.Fill
        CeBtn.FlatAppearance.BorderSize = 0
        CeBtn.FlatStyle = FlatStyle.Flat
        CeBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CeBtn.ForeColor = SystemColors.ControlLightLight
        CeBtn.Location = New Point(0, 204)
        CeBtn.Margin = New Padding(0)
        CeBtn.Name = "CeBtn"
        CeBtn.Size = New Size(120, 103)
        CeBtn.TabIndex = 21
        CeBtn.TabStop = False
        CeBtn.Text = "CE"
        CeBtn.UseVisualStyleBackColor = False
        ' 
        ' PreviousResultLabel
        ' 
        PreviousResultLabel.AutoSize = True
        PreviousResultLabel.BackColor = Color.Transparent
        TableLayoutPanel1.SetColumnSpan(PreviousResultLabel, 4)
        PreviousResultLabel.Dock = DockStyle.Fill
        PreviousResultLabel.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PreviousResultLabel.ForeColor = SystemColors.ControlLight
        PreviousResultLabel.Location = New Point(2, 0)
        PreviousResultLabel.Margin = New Padding(2, 0, 2, 0)
        PreviousResultLabel.Name = "PreviousResultLabel"
        PreviousResultLabel.Size = New Size(479, 102)
        PreviousResultLabel.TabIndex = 20
        PreviousResultLabel.TextAlign = ContentAlignment.BottomRight
        ' 
        ' DecimalBtn
        ' 
        DecimalBtn.BackColor = Color.Gray
        DecimalBtn.Dock = DockStyle.Fill
        DecimalBtn.FlatAppearance.BorderSize = 0
        DecimalBtn.FlatStyle = FlatStyle.Flat
        DecimalBtn.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        DecimalBtn.ForeColor = SystemColors.ControlLightLight
        DecimalBtn.Location = New Point(0, 616)
        DecimalBtn.Margin = New Padding(0)
        DecimalBtn.Name = "DecimalBtn"
        DecimalBtn.Size = New Size(120, 108)
        DecimalBtn.TabIndex = 19
        DecimalBtn.TabStop = False
        DecimalBtn.Text = "."
        DecimalBtn.UseVisualStyleBackColor = False
        ' 
        ' BackspaceBtn
        ' 
        BackspaceBtn.BackColor = SystemColors.GrayText
        BackspaceBtn.Dock = DockStyle.Fill
        BackspaceBtn.FlatAppearance.BorderSize = 0
        BackspaceBtn.FlatStyle = FlatStyle.Flat
        BackspaceBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BackspaceBtn.ForeColor = SystemColors.ControlLightLight
        BackspaceBtn.Location = New Point(240, 204)
        BackspaceBtn.Margin = New Padding(0)
        BackspaceBtn.Name = "BackspaceBtn"
        BackspaceBtn.Size = New Size(120, 103)
        BackspaceBtn.TabIndex = 18
        BackspaceBtn.TabStop = False
        BackspaceBtn.Text = "←"
        BackspaceBtn.UseVisualStyleBackColor = False
        ' 
        ' ClrBtn
        ' 
        ClrBtn.BackColor = SystemColors.GrayText
        ClrBtn.Dock = DockStyle.Fill
        ClrBtn.FlatAppearance.BorderSize = 0
        ClrBtn.FlatStyle = FlatStyle.Flat
        ClrBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ClrBtn.ForeColor = SystemColors.ControlLightLight
        ClrBtn.Location = New Point(120, 204)
        ClrBtn.Margin = New Padding(0)
        ClrBtn.Name = "ClrBtn"
        ClrBtn.Size = New Size(120, 103)
        ClrBtn.TabIndex = 17
        ClrBtn.TabStop = False
        ClrBtn.Text = "C"
        ClrBtn.UseVisualStyleBackColor = False
        ' 
        ' DivideBtn
        ' 
        DivideBtn.BackColor = SystemColors.GrayText
        DivideBtn.Dock = DockStyle.Fill
        DivideBtn.FlatAppearance.BorderSize = 0
        DivideBtn.FlatStyle = FlatStyle.Flat
        DivideBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DivideBtn.ForeColor = SystemColors.ControlLightLight
        DivideBtn.Location = New Point(360, 513)
        DivideBtn.Margin = New Padding(0)
        DivideBtn.Name = "DivideBtn"
        DivideBtn.Size = New Size(123, 103)
        DivideBtn.TabIndex = 16
        DivideBtn.TabStop = False
        DivideBtn.Text = "÷"
        DivideBtn.UseVisualStyleBackColor = False
        ' 
        ' EqualBtn
        ' 
        EqualBtn.BackColor = Color.IndianRed
        TableLayoutPanel1.SetColumnSpan(EqualBtn, 2)
        EqualBtn.Dock = DockStyle.Fill
        EqualBtn.FlatAppearance.BorderSize = 0
        EqualBtn.FlatStyle = FlatStyle.Flat
        EqualBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        EqualBtn.ForeColor = SystemColors.ControlLightLight
        EqualBtn.Location = New Point(240, 616)
        EqualBtn.Margin = New Padding(0)
        EqualBtn.Name = "EqualBtn"
        EqualBtn.Size = New Size(243, 108)
        EqualBtn.TabIndex = 15
        EqualBtn.TabStop = False
        EqualBtn.Text = "="
        EqualBtn.UseVisualStyleBackColor = False
        ' 
        ' Button0
        ' 
        Button0.BackColor = Color.Gray
        Button0.Dock = DockStyle.Fill
        Button0.FlatAppearance.BorderSize = 0
        Button0.FlatStyle = FlatStyle.Flat
        Button0.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button0.ForeColor = SystemColors.ControlLightLight
        Button0.Location = New Point(120, 616)
        Button0.Margin = New Padding(0)
        Button0.Name = "Button0"
        Button0.Size = New Size(120, 108)
        Button0.TabIndex = 14
        Button0.TabStop = False
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = False
        ' 
        ' MultiplyBtn
        ' 
        MultiplyBtn.BackColor = SystemColors.GrayText
        MultiplyBtn.Dock = DockStyle.Fill
        MultiplyBtn.FlatAppearance.BorderSize = 0
        MultiplyBtn.FlatStyle = FlatStyle.Flat
        MultiplyBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MultiplyBtn.ForeColor = SystemColors.ControlLightLight
        MultiplyBtn.Location = New Point(360, 410)
        MultiplyBtn.Margin = New Padding(0)
        MultiplyBtn.Name = "MultiplyBtn"
        MultiplyBtn.Size = New Size(123, 103)
        MultiplyBtn.TabIndex = 12
        MultiplyBtn.TabStop = False
        MultiplyBtn.Text = "×"
        MultiplyBtn.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Gray
        Button9.Dock = DockStyle.Fill
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Location = New Point(240, 513)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.Size = New Size(120, 103)
        Button9.TabIndex = 11
        Button9.TabStop = False
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Gray
        Button8.Dock = DockStyle.Fill
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Location = New Point(120, 513)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(120, 103)
        Button8.TabIndex = 10
        Button8.TabStop = False
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Gray
        Button7.Dock = DockStyle.Fill
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button7.ForeColor = SystemColors.ControlLightLight
        Button7.Location = New Point(0, 513)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(120, 103)
        Button7.TabIndex = 9
        Button7.TabStop = False
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' MinusBtn
        ' 
        MinusBtn.BackColor = SystemColors.GrayText
        MinusBtn.Dock = DockStyle.Fill
        MinusBtn.FlatAppearance.BorderSize = 0
        MinusBtn.FlatStyle = FlatStyle.Flat
        MinusBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MinusBtn.ForeColor = SystemColors.ControlLightLight
        MinusBtn.Location = New Point(360, 307)
        MinusBtn.Margin = New Padding(0)
        MinusBtn.Name = "MinusBtn"
        MinusBtn.Size = New Size(123, 103)
        MinusBtn.TabIndex = 8
        MinusBtn.TabStop = False
        MinusBtn.Text = "-"
        MinusBtn.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Gray
        Button6.Dock = DockStyle.Fill
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.ControlLightLight
        Button6.Location = New Point(240, 410)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(120, 103)
        Button6.TabIndex = 7
        Button6.TabStop = False
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gray
        Button5.Dock = DockStyle.Fill
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(120, 410)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(120, 103)
        Button5.TabIndex = 6
        Button5.TabStop = False
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gray
        Button4.Dock = DockStyle.Fill
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(0, 410)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(120, 103)
        Button4.TabIndex = 5
        Button4.TabStop = False
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PlusBtn
        ' 
        PlusBtn.BackColor = SystemColors.GrayText
        PlusBtn.Dock = DockStyle.Fill
        PlusBtn.FlatAppearance.BorderSize = 0
        PlusBtn.FlatStyle = FlatStyle.Flat
        PlusBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        PlusBtn.ForeColor = SystemColors.ControlLightLight
        PlusBtn.Location = New Point(360, 204)
        PlusBtn.Margin = New Padding(0)
        PlusBtn.Name = "PlusBtn"
        PlusBtn.Size = New Size(123, 103)
        PlusBtn.TabIndex = 4
        PlusBtn.TabStop = False
        PlusBtn.Text = "+"
        PlusBtn.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gray
        Button3.Dock = DockStyle.Fill
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(240, 307)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 103)
        Button3.TabIndex = 3
        Button3.TabStop = False
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.Gray
        Button2.Dock = DockStyle.Fill
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(120, 307)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 103)
        Button2.TabIndex = 2
        Button2.TabStop = False
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CurrentResultLabel
        ' 
        CurrentResultLabel.AutoEllipsis = True
        CurrentResultLabel.AutoSize = True
        CurrentResultLabel.BackColor = Color.Transparent
        TableLayoutPanel1.SetColumnSpan(CurrentResultLabel, 4)
        CurrentResultLabel.Dock = DockStyle.Fill
        CurrentResultLabel.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentResultLabel.ForeColor = SystemColors.ControlLightLight
        CurrentResultLabel.Location = New Point(2, 102)
        CurrentResultLabel.Margin = New Padding(2, 0, 2, 0)
        CurrentResultLabel.Name = "CurrentResultLabel"
        CurrentResultLabel.Size = New Size(479, 102)
        CurrentResultLabel.TabIndex = 0
        CurrentResultLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.Dock = DockStyle.Fill
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(0, 307)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 103)
        Button1.TabIndex = 1
        Button1.TabStop = False
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.WindowFrame
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(483, 724)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        Margin = New Padding(2, 4, 2, 4)
        MinimumSize = New Size(505, 780)
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Yzekeil & Aedri - Calculator"
        TransparencyKey = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents CurrentResultLabel As Label
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
    Public WithEvents PreviousResultLabel As Label
    Friend WithEvents CeBtn As Button
End Class
