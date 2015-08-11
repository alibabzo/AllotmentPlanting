<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllotmentPlanting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllotmentPlanting))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bed1 = New System.Windows.Forms.Button()
        Me.Bed2 = New System.Windows.Forms.Button()
        Me.Bed3 = New System.Windows.Forms.Button()
        Me.BedPerm = New System.Windows.Forms.Button()
        Me.Bed1Content = New System.Windows.Forms.Label()
        Me.Bed2Content = New System.Windows.Forms.Label()
        Me.Bed3Content = New System.Windows.Forms.Label()
        Me.Go = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PermBedContent = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(96, 2)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(73, 21)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Year:"
        '
        'Bed1
        '
        Me.Bed1.Location = New System.Drawing.Point(284, 230)
        Me.Bed1.Name = "Bed1"
        Me.Bed1.Size = New System.Drawing.Size(167, 61)
        Me.Bed1.TabIndex = 2
        Me.Bed1.Text = "Bed 1"
        Me.Bed1.UseVisualStyleBackColor = True
        '
        'Bed2
        '
        Me.Bed2.Location = New System.Drawing.Point(284, 163)
        Me.Bed2.Name = "Bed2"
        Me.Bed2.Size = New System.Drawing.Size(167, 61)
        Me.Bed2.TabIndex = 3
        Me.Bed2.Text = "Bed 2"
        Me.Bed2.UseVisualStyleBackColor = True
        '
        'Bed3
        '
        Me.Bed3.Location = New System.Drawing.Point(284, 29)
        Me.Bed3.Name = "Bed3"
        Me.Bed3.Size = New System.Drawing.Size(167, 61)
        Me.Bed3.TabIndex = 4
        Me.Bed3.Text = "Bed 3"
        Me.Bed3.UseVisualStyleBackColor = True
        '
        'BedPerm
        '
        Me.BedPerm.Location = New System.Drawing.Point(284, 96)
        Me.BedPerm.Name = "BedPerm"
        Me.BedPerm.Size = New System.Drawing.Size(167, 61)
        Me.BedPerm.TabIndex = 5
        Me.BedPerm.Text = "Permenant Bed"
        Me.BedPerm.UseVisualStyleBackColor = True
        '
        'Bed1Content
        '
        Me.Bed1Content.AutoSize = True
        Me.Bed1Content.Location = New System.Drawing.Point(26, 254)
        Me.Bed1Content.Name = "Bed1Content"
        Me.Bed1Content.Size = New System.Drawing.Size(0, 13)
        Me.Bed1Content.TabIndex = 6
        '
        'Bed2Content
        '
        Me.Bed2Content.AutoSize = True
        Me.Bed2Content.Location = New System.Drawing.Point(26, 187)
        Me.Bed2Content.Name = "Bed2Content"
        Me.Bed2Content.Size = New System.Drawing.Size(0, 13)
        Me.Bed2Content.TabIndex = 7
        '
        'Bed3Content
        '
        Me.Bed3Content.AutoSize = True
        Me.Bed3Content.Location = New System.Drawing.Point(26, 53)
        Me.Bed3Content.Name = "Bed3Content"
        Me.Bed3Content.Size = New System.Drawing.Size(0, 13)
        Me.Bed3Content.TabIndex = 8
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(185, 0)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(78, 21)
        Me.Go.TabIndex = 9
        Me.Go.Text = "Go!"
        Me.Go.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PermBedContent)
        Me.GroupBox2.Controls.Add(Me.Go)
        Me.GroupBox2.Controls.Add(Me.Bed3Content)
        Me.GroupBox2.Controls.Add(Me.Bed2Content)
        Me.GroupBox2.Controls.Add(Me.Bed1Content)
        Me.GroupBox2.Controls.Add(Me.BedPerm)
        Me.GroupBox2.Controls.Add(Me.Bed3)
        Me.GroupBox2.Controls.Add(Me.Bed2)
        Me.GroupBox2.Controls.Add(Me.Bed1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 300)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Shed End"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(469, 358)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.DarkRed
        Me.RectangleShape1.Location = New System.Drawing.Point(304, 326)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(114, 29)
        '
        'PermBedContent
        '
        Me.PermBedContent.AutoSize = True
        Me.PermBedContent.Location = New System.Drawing.Point(26, 120)
        Me.PermBedContent.Name = "PermBedContent"
        Me.PermBedContent.Size = New System.Drawing.Size(0, 13)
        Me.PermBedContent.TabIndex = 10
        '
        'AllotmentPlanting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 358)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AllotmentPlanting"
        Me.Text = "Allotment Planting"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bed1 As System.Windows.Forms.Button
    Friend WithEvents Bed2 As System.Windows.Forms.Button
    Friend WithEvents Bed3 As System.Windows.Forms.Button
    Friend WithEvents BedPerm As System.Windows.Forms.Button
    Friend WithEvents Bed1Content As System.Windows.Forms.Label
    Friend WithEvents Bed2Content As System.Windows.Forms.Label
    Friend WithEvents Bed3Content As System.Windows.Forms.Label
    Friend WithEvents Go As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PermBedContent As System.Windows.Forms.Label

End Class
