<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.ChkFries = New System.Windows.Forms.CheckBox()
        Me.ChkDrinks = New System.Windows.Forms.CheckBox()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radBacon = New System.Windows.Forms.RadioButton()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtCompute = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.BackColor = System.Drawing.Color.White
        Me.chkBurgers.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkBurgers.Location = New System.Drawing.Point(88, 39)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(167, 50)
        Me.chkBurgers.TabIndex = 0
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = False
        '
        'ChkFries
        '
        Me.ChkFries.AutoSize = True
        Me.ChkFries.BackColor = System.Drawing.Color.White
        Me.ChkFries.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChkFries.Location = New System.Drawing.Point(88, 282)
        Me.ChkFries.Name = "ChkFries"
        Me.ChkFries.Size = New System.Drawing.Size(117, 50)
        Me.ChkFries.TabIndex = 1
        Me.ChkFries.Text = "Fries"
        Me.ChkFries.UseVisualStyleBackColor = False
        '
        'ChkDrinks
        '
        Me.ChkDrinks.AutoSize = True
        Me.ChkDrinks.BackColor = System.Drawing.Color.White
        Me.ChkDrinks.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChkDrinks.Location = New System.Drawing.Point(88, 537)
        Me.ChkDrinks.Name = "ChkDrinks"
        Me.ChkDrinks.Size = New System.Drawing.Size(146, 50)
        Me.ChkDrinks.TabIndex = 2
        Me.ChkDrinks.Text = "Drinks"
        Me.ChkDrinks.UseVisualStyleBackColor = False
        '
        'grpBurgers
        '
        Me.grpBurgers.BackColor = System.Drawing.Color.Yellow
        Me.grpBurgers.Controls.Add(Me.radRegular)
        Me.grpBurgers.Controls.Add(Me.radCheese)
        Me.grpBurgers.Controls.Add(Me.radBacon)
        Me.grpBurgers.Controls.Add(Me.radBoth)
        Me.grpBurgers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpBurgers.Location = New System.Drawing.Point(296, 39)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(343, 186)
        Me.grpBurgers.TabIndex = 3
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for burgers"
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radRegular.Location = New System.Drawing.Point(25, 43)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(144, 32)
        Me.radRegular.TabIndex = 6
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular(30)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radCheese.Location = New System.Drawing.Point(25, 82)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(164, 32)
        Me.radCheese.TabIndex = 7
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "W/cheese(50)"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radBacon
        '
        Me.radBacon.AutoSize = True
        Me.radBacon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radBacon.Location = New System.Drawing.Point(25, 112)
        Me.radBacon.Name = "radBacon"
        Me.radBacon.Size = New System.Drawing.Size(154, 32)
        Me.radBacon.TabIndex = 8
        Me.radBacon.TabStop = True
        Me.radBacon.Text = "w/Bacon(80)"
        Me.radBacon.UseVisualStyleBackColor = True
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radBoth.Location = New System.Drawing.Point(25, 142)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(242, 32)
        Me.radBoth.TabIndex = 9
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "w/Bacon & cheese(120)"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.BackColor = System.Drawing.Color.Yellow
        Me.grpFries.Controls.Add(Me.radMedium)
        Me.grpFries.Controls.Add(Me.radLarge)
        Me.grpFries.Controls.Add(Me.radSmall)
        Me.grpFries.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpFries.Location = New System.Drawing.Point(296, 271)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(343, 201)
        Me.grpFries.TabIndex = 4
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "choices for fries"
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radMedium.Location = New System.Drawing.Point(29, 91)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(149, 32)
        Me.radMedium.TabIndex = 11
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium(75)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radLarge.Location = New System.Drawing.Point(29, 138)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(135, 32)
        Me.radLarge.TabIndex = 12
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large(100)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radSmall.Location = New System.Drawing.Point(29, 53)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(123, 32)
        Me.radSmall.TabIndex = 10
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small(40)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.BackColor = System.Drawing.Color.Yellow
        Me.grpDrinks.Controls.Add(Me.radSoda)
        Me.grpDrinks.Controls.Add(Me.radWater)
        Me.grpDrinks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpDrinks.Location = New System.Drawing.Point(296, 515)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(343, 190)
        Me.grpDrinks.TabIndex = 5
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for drinks"
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radSoda.Location = New System.Drawing.Point(22, 48)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(117, 32)
        Me.radSoda.TabIndex = 13
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "Soda(40)"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radWater.Location = New System.Drawing.Point(22, 101)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(128, 32)
        Me.radWater.TabIndex = 14
        Me.radWater.TabStop = True
        Me.radWater.Text = "Water(30)"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCompute.Location = New System.Drawing.Point(1102, 151)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(241, 83)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute of cost of meal"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtCompute
        '
        Me.txtCompute.Location = New System.Drawing.Point(1235, 281)
        Me.txtCompute.Name = "txtCompute"
        Me.txtCompute.Size = New System.Drawing.Size(125, 27)
        Me.txtCompute.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1086, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cost of meal"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1436, 743)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompute)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Controls.Add(Me.ChkDrinks)
        Me.Controls.Add(Me.ChkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Name = "frmMenu"
        Me.Text = "/"
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBurgers As CheckBox
    Friend WithEvents ChkFries As CheckBox
    Friend WithEvents ChkDrinks As CheckBox
    Friend WithEvents grpBurgers As GroupBox
    Friend WithEvents grpFries As GroupBox
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radBacon As RadioButton
    Friend WithEvents radBoth As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radSoda As RadioButton
    Friend WithEvents radWater As RadioButton
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtCompute As TextBox
    Friend WithEvents Label1 As Label
End Class
