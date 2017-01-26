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
        Me.boxDoughnut = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.boxCoffee = New System.Windows.Forms.GroupBox()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.TextBox()
        Me.lblTotalDue = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.boxDoughnut.SuspendLayout()
        Me.boxCoffee.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxDoughnut
        '
        Me.boxDoughnut.Controls.Add(Me.radFilled)
        Me.boxDoughnut.Controls.Add(Me.radGlazed)
        Me.boxDoughnut.Controls.Add(Me.radSugar)
        Me.boxDoughnut.Controls.Add(Me.radChocolate)
        Me.boxDoughnut.Location = New System.Drawing.Point(25, 35)
        Me.boxDoughnut.Name = "boxDoughnut"
        Me.boxDoughnut.Size = New System.Drawing.Size(200, 196)
        Me.boxDoughnut.TabIndex = 0
        Me.boxDoughnut.TabStop = False
        Me.boxDoughnut.Text = "Doughnut choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(37, 140)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(85, 17)
        Me.radFilled.TabIndex = 7
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.00)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(37, 36)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(88, 17)
        Me.radGlazed.TabIndex = 4
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($.65)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(37, 71)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(83, 17)
        Me.radSugar.TabIndex = 5
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($.65)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(37, 107)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(103, 17)
        Me.radChocolate.TabIndex = 6
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($.85)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'boxCoffee
        '
        Me.boxCoffee.Controls.Add(Me.radCappuccino)
        Me.boxCoffee.Controls.Add(Me.radNone)
        Me.boxCoffee.Controls.Add(Me.radRegular)
        Me.boxCoffee.Location = New System.Drawing.Point(25, 263)
        Me.boxCoffee.Name = "boxCoffee"
        Me.boxCoffee.Size = New System.Drawing.Size(200, 128)
        Me.boxCoffee.TabIndex = 0
        Me.boxCoffee.TabStop = False
        Me.boxCoffee.Text = "Coffee choices"
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(37, 80)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 10
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Ca&ppuccino ($2.50)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(37, 31)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 8
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(37, 57)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(98, 17)
        Me.radRegular.TabIndex = 9
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.80)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblSalesTax)
        Me.GroupBox3.Controls.Add(Me.lblTotalDue)
        Me.GroupBox3.Location = New System.Drawing.Point(268, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 162)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sales tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total due:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Location = New System.Drawing.Point(67, 36)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.ReadOnly = True
        Me.lblSubtotal.Size = New System.Drawing.Size(60, 20)
        Me.lblSubtotal.TabIndex = 14
        '
        'lblSalesTax
        '
        Me.lblSalesTax.Location = New System.Drawing.Point(67, 78)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.ReadOnly = True
        Me.lblSalesTax.Size = New System.Drawing.Size(60, 20)
        Me.lblSalesTax.TabIndex = 15
        '
        'lblTotalDue
        '
        Me.lblTotalDue.Location = New System.Drawing.Point(67, 120)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.ReadOnly = True
        Me.lblTotalDue.Size = New System.Drawing.Size(60, 20)
        Me.lblTotalDue.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Doughnut_Shoppe_Project.My.Resources.Resources.Doughnut
        Me.PictureBox1.Location = New System.Drawing.Point(268, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(268, 368)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 453)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.boxCoffee)
        Me.Controls.Add(Me.boxDoughnut)
        Me.Name = "Form1"
        Me.Text = "Doughnut Shoppe"
        Me.boxDoughnut.ResumeLayout(False)
        Me.boxDoughnut.PerformLayout()
        Me.boxCoffee.ResumeLayout(False)
        Me.boxCoffee.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxDoughnut As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents boxCoffee As GroupBox
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubtotal As TextBox
    Friend WithEvents lblSalesTax As TextBox
    Friend WithEvents lblTotalDue As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
End Class
