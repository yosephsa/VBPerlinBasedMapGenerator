<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMapGenerator
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
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.lblTilesX = New System.Windows.Forms.Label()
        Me.lblTilesY = New System.Windows.Forms.Label()
        Me.txtTilesX = New System.Windows.Forms.TextBox()
        Me.txtTilesY = New System.Windows.Forms.TextBox()
        Me.lblMountain = New System.Windows.Forms.Label()
        Me.lblForest = New System.Windows.Forms.Label()
        Me.lblGrassland = New System.Windows.Forms.Label()
        Me.lblDesert = New System.Windows.Forms.Label()
        Me.lblSwamp = New System.Windows.Forms.Label()
        Me.txtMountain = New System.Windows.Forms.TextBox()
        Me.txtForest = New System.Windows.Forms.TextBox()
        Me.txtDesert = New System.Windows.Forms.TextBox()
        Me.txtGrassland = New System.Windows.Forms.TextBox()
        Me.txtSwamp = New System.Windows.Forms.TextBox()
        Me.txtTropicZone = New System.Windows.Forms.TextBox()
        Me.txtArcticRadius = New System.Windows.Forms.TextBox()
        Me.txtLake = New System.Windows.Forms.TextBox()
        Me.txtRiver = New System.Windows.Forms.TextBox()
        Me.lblTropicZone = New System.Windows.Forms.Label()
        Me.lblArcticRadius = New System.Windows.Forms.Label()
        Me.lblLake = New System.Windows.Forms.Label()
        Me.lblRiver = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblSeed = New System.Windows.Forms.Label()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.pbxMap = New System.Windows.Forms.PictureBox()
        Me.txtMapValues = New System.Windows.Forms.RichTextBox()
        Me.lblCode0 = New System.Windows.Forms.Label()
        Me.lblCode1 = New System.Windows.Forms.Label()
        Me.lblCode2 = New System.Windows.Forms.Label()
        Me.lblCode3 = New System.Windows.Forms.Label()
        Me.lblCode4 = New System.Windows.Forms.Label()
        Me.lblCode5 = New System.Windows.Forms.Label()
        Me.lblCode6 = New System.Windows.Forms.Label()
        Me.lblCode7 = New System.Windows.Forms.Label()
        Me.lblCode8 = New System.Windows.Forms.Label()
        Me.lblCode9 = New System.Windows.Forms.Label()
        Me.lblCodeA = New System.Windows.Forms.Label()
        Me.lblCodeB = New System.Windows.Forms.Label()
        Me.lblCodeC = New System.Windows.Forms.Label()
        Me.lblCodesTitle = New System.Windows.Forms.Label()
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRandomize
        '
        Me.btnRandomize.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandomize.Location = New System.Drawing.Point(38, 396)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(266, 88)
        Me.btnRandomize.TabIndex = 16
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'lblTilesX
        '
        Me.lblTilesX.AutoSize = True
        Me.lblTilesX.Location = New System.Drawing.Point(179, 325)
        Me.lblTilesX.Name = "lblTilesX"
        Me.lblTilesX.Size = New System.Drawing.Size(52, 20)
        Me.lblTilesX.TabIndex = 17
        Me.lblTilesX.Text = "TilesX"
        '
        'lblTilesY
        '
        Me.lblTilesY.AutoSize = True
        Me.lblTilesY.Location = New System.Drawing.Point(179, 359)
        Me.lblTilesY.Name = "lblTilesY"
        Me.lblTilesY.Size = New System.Drawing.Size(52, 20)
        Me.lblTilesY.TabIndex = 18
        Me.lblTilesY.Text = "TilesY"
        '
        'txtTilesX
        '
        Me.txtTilesX.Location = New System.Drawing.Point(237, 322)
        Me.txtTilesX.Name = "txtTilesX"
        Me.txtTilesX.Size = New System.Drawing.Size(68, 26)
        Me.txtTilesX.TabIndex = 19
        Me.txtTilesX.Text = "32"
        '
        'txtTilesY
        '
        Me.txtTilesY.Location = New System.Drawing.Point(237, 359)
        Me.txtTilesY.Name = "txtTilesY"
        Me.txtTilesY.Size = New System.Drawing.Size(67, 26)
        Me.txtTilesY.TabIndex = 20
        Me.txtTilesY.Text = "32"
        '
        'lblMountain
        '
        Me.lblMountain.AutoSize = True
        Me.lblMountain.Location = New System.Drawing.Point(358, 325)
        Me.lblMountain.Name = "lblMountain"
        Me.lblMountain.Size = New System.Drawing.Size(93, 20)
        Me.lblMountain.TabIndex = 21
        Me.lblMountain.Text = "Mountain %"
        '
        'lblForest
        '
        Me.lblForest.AutoSize = True
        Me.lblForest.Location = New System.Drawing.Point(358, 359)
        Me.lblForest.Name = "lblForest"
        Me.lblForest.Size = New System.Drawing.Size(73, 20)
        Me.lblForest.TabIndex = 22
        Me.lblForest.Text = "Forest %"
        '
        'lblGrassland
        '
        Me.lblGrassland.AutoSize = True
        Me.lblGrassland.Location = New System.Drawing.Point(358, 393)
        Me.lblGrassland.Name = "lblGrassland"
        Me.lblGrassland.Size = New System.Drawing.Size(100, 20)
        Me.lblGrassland.TabIndex = 23
        Me.lblGrassland.Text = "Grassland %"
        '
        'lblDesert
        '
        Me.lblDesert.AutoSize = True
        Me.lblDesert.Location = New System.Drawing.Point(358, 427)
        Me.lblDesert.Name = "lblDesert"
        Me.lblDesert.Size = New System.Drawing.Size(75, 20)
        Me.lblDesert.TabIndex = 26
        Me.lblDesert.Text = "Desert %"
        '
        'lblSwamp
        '
        Me.lblSwamp.AutoSize = True
        Me.lblSwamp.Location = New System.Drawing.Point(358, 461)
        Me.lblSwamp.Name = "lblSwamp"
        Me.lblSwamp.Size = New System.Drawing.Size(80, 20)
        Me.lblSwamp.TabIndex = 29
        Me.lblSwamp.Text = "Swamp %"
        '
        'txtMountain
        '
        Me.txtMountain.Location = New System.Drawing.Point(496, 322)
        Me.txtMountain.Name = "txtMountain"
        Me.txtMountain.Size = New System.Drawing.Size(100, 26)
        Me.txtMountain.TabIndex = 30
        Me.txtMountain.Text = "0.00"
        '
        'txtForest
        '
        Me.txtForest.Location = New System.Drawing.Point(496, 356)
        Me.txtForest.Name = "txtForest"
        Me.txtForest.Size = New System.Drawing.Size(100, 26)
        Me.txtForest.TabIndex = 31
        Me.txtForest.Text = "0.00"
        '
        'txtDesert
        '
        Me.txtDesert.Location = New System.Drawing.Point(496, 424)
        Me.txtDesert.Name = "txtDesert"
        Me.txtDesert.Size = New System.Drawing.Size(100, 26)
        Me.txtDesert.TabIndex = 33
        Me.txtDesert.Text = "0.00"
        '
        'txtGrassland
        '
        Me.txtGrassland.Location = New System.Drawing.Point(496, 390)
        Me.txtGrassland.Name = "txtGrassland"
        Me.txtGrassland.Size = New System.Drawing.Size(100, 26)
        Me.txtGrassland.TabIndex = 32
        Me.txtGrassland.Text = "0.40"
        '
        'txtSwamp
        '
        Me.txtSwamp.Location = New System.Drawing.Point(496, 458)
        Me.txtSwamp.Name = "txtSwamp"
        Me.txtSwamp.Size = New System.Drawing.Size(100, 26)
        Me.txtSwamp.TabIndex = 34
        Me.txtSwamp.Text = "0.00"
        '
        'txtTropicZone
        '
        Me.txtTropicZone.Location = New System.Drawing.Point(803, 458)
        Me.txtTropicZone.Name = "txtTropicZone"
        Me.txtTropicZone.Size = New System.Drawing.Size(100, 26)
        Me.txtTropicZone.TabIndex = 44
        Me.txtTropicZone.Text = "0.25"
        '
        'txtArcticRadius
        '
        Me.txtArcticRadius.Location = New System.Drawing.Point(803, 424)
        Me.txtArcticRadius.Name = "txtArcticRadius"
        Me.txtArcticRadius.Size = New System.Drawing.Size(100, 26)
        Me.txtArcticRadius.TabIndex = 43
        Me.txtArcticRadius.Text = "0.25"
        '
        'txtLake
        '
        Me.txtLake.Location = New System.Drawing.Point(803, 356)
        Me.txtLake.Name = "txtLake"
        Me.txtLake.Size = New System.Drawing.Size(100, 26)
        Me.txtLake.TabIndex = 41
        Me.txtLake.Text = "0.00"
        '
        'txtRiver
        '
        Me.txtRiver.Location = New System.Drawing.Point(803, 322)
        Me.txtRiver.Name = "txtRiver"
        Me.txtRiver.Size = New System.Drawing.Size(100, 26)
        Me.txtRiver.TabIndex = 40
        Me.txtRiver.Text = "0.00"
        '
        'lblTropicZone
        '
        Me.lblTropicZone.AutoSize = True
        Me.lblTropicZone.Location = New System.Drawing.Point(665, 461)
        Me.lblTropicZone.Name = "lblTropicZone"
        Me.lblTropicZone.Size = New System.Drawing.Size(111, 20)
        Me.lblTropicZone.TabIndex = 39
        Me.lblTropicZone.Text = "Tropic Zone %"
        '
        'lblArcticRadius
        '
        Me.lblArcticRadius.AutoSize = True
        Me.lblArcticRadius.Location = New System.Drawing.Point(665, 427)
        Me.lblArcticRadius.Name = "lblArcticRadius"
        Me.lblArcticRadius.Size = New System.Drawing.Size(121, 20)
        Me.lblArcticRadius.TabIndex = 38
        Me.lblArcticRadius.Text = "Arctic Radius %"
        '
        'lblLake
        '
        Me.lblLake.AutoSize = True
        Me.lblLake.Location = New System.Drawing.Point(665, 359)
        Me.lblLake.Name = "lblLake"
        Me.lblLake.Size = New System.Drawing.Size(62, 20)
        Me.lblLake.TabIndex = 36
        Me.lblLake.Text = "Lake %"
        '
        'lblRiver
        '
        Me.lblRiver.AutoSize = True
        Me.lblRiver.Location = New System.Drawing.Point(665, 325)
        Me.lblRiver.Name = "lblRiver"
        Me.lblRiver.Size = New System.Drawing.Size(63, 20)
        Me.lblRiver.TabIndex = 35
        Me.lblRiver.Text = "River %"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(925, 396)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(288, 88)
        Me.btnGenerate.TabIndex = 45
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblSeed
        '
        Me.lblSeed.AutoSize = True
        Me.lblSeed.Location = New System.Drawing.Point(921, 322)
        Me.lblSeed.Name = "lblSeed"
        Me.lblSeed.Size = New System.Drawing.Size(166, 20)
        Me.lblSeed.TabIndex = 46
        Me.lblSeed.Text = "Seed (For Generator):"
        '
        'txtSeed
        '
        Me.txtSeed.Location = New System.Drawing.Point(925, 353)
        Me.txtSeed.Name = "txtSeed"
        Me.txtSeed.Size = New System.Drawing.Size(288, 26)
        Me.txtSeed.TabIndex = 47
        '
        'pbxMap
        '
        Me.pbxMap.Location = New System.Drawing.Point(870, 12)
        Me.pbxMap.Name = "pbxMap"
        Me.pbxMap.Size = New System.Drawing.Size(288, 288)
        Me.pbxMap.TabIndex = 48
        Me.pbxMap.TabStop = False
        '
        'txtMapValues
        '
        Me.txtMapValues.Location = New System.Drawing.Point(183, 12)
        Me.txtMapValues.Name = "txtMapValues"
        Me.txtMapValues.Size = New System.Drawing.Size(593, 288)
        Me.txtMapValues.TabIndex = 49
        Me.txtMapValues.Text = ""
        '
        'lblCode0
        '
        Me.lblCode0.AccessibleName = ""
        Me.lblCode0.AutoSize = True
        Me.lblCode0.Location = New System.Drawing.Point(34, 46)
        Me.lblCode0.Name = "lblCode0"
        Me.lblCode0.Size = New System.Drawing.Size(70, 20)
        Me.lblCode0.TabIndex = 2
        Me.lblCode0.Text = "0 = Lake"
        '
        'lblCode1
        '
        Me.lblCode1.AccessibleName = ""
        Me.lblCode1.AutoSize = True
        Me.lblCode1.Location = New System.Drawing.Point(34, 72)
        Me.lblCode1.Name = "lblCode1"
        Me.lblCode1.Size = New System.Drawing.Size(82, 20)
        Me.lblCode1.TabIndex = 3
        Me.lblCode1.Text = "1 = Ocean"
        '
        'lblCode2
        '
        Me.lblCode2.AccessibleName = ""
        Me.lblCode2.AutoSize = True
        Me.lblCode2.Location = New System.Drawing.Point(34, 98)
        Me.lblCode2.Name = "lblCode2"
        Me.lblCode2.Size = New System.Drawing.Size(71, 20)
        Me.lblCode2.TabIndex = 4
        Me.lblCode2.Text = "2 = River"
        '
        'lblCode3
        '
        Me.lblCode3.AccessibleName = ""
        Me.lblCode3.AutoSize = True
        Me.lblCode3.Location = New System.Drawing.Point(34, 124)
        Me.lblCode3.Name = "lblCode3"
        Me.lblCode3.Size = New System.Drawing.Size(57, 20)
        Me.lblCode3.TabIndex = 5
        Me.lblCode3.Text = "3 = Ice"
        '
        'lblCode4
        '
        Me.lblCode4.AccessibleName = ""
        Me.lblCode4.AutoSize = True
        Me.lblCode4.Location = New System.Drawing.Point(34, 150)
        Me.lblCode4.Name = "lblCode4"
        Me.lblCode4.Size = New System.Drawing.Size(88, 20)
        Me.lblCode4.TabIndex = 6
        Me.lblCode4.Text = "4 = Swamp"
        '
        'lblCode5
        '
        Me.lblCode5.AccessibleName = ""
        Me.lblCode5.AutoSize = True
        Me.lblCode5.Location = New System.Drawing.Point(34, 178)
        Me.lblCode5.Name = "lblCode5"
        Me.lblCode5.Size = New System.Drawing.Size(78, 20)
        Me.lblCode5.TabIndex = 7
        Me.lblCode5.Text = "5 = Grass"
        '
        'lblCode6
        '
        Me.lblCode6.AccessibleName = ""
        Me.lblCode6.AutoSize = True
        Me.lblCode6.Location = New System.Drawing.Point(34, 204)
        Me.lblCode6.Name = "lblCode6"
        Me.lblCode6.Size = New System.Drawing.Size(75, 20)
        Me.lblCode6.TabIndex = 8
        Me.lblCode6.Text = "6 = Snow"
        '
        'lblCode7
        '
        Me.lblCode7.AccessibleName = ""
        Me.lblCode7.AutoSize = True
        Me.lblCode7.Location = New System.Drawing.Point(34, 230)
        Me.lblCode7.Name = "lblCode7"
        Me.lblCode7.Size = New System.Drawing.Size(83, 20)
        Me.lblCode7.TabIndex = 9
        Me.lblCode7.Text = "7 = Desert"
        '
        'lblCode8
        '
        Me.lblCode8.AccessibleName = ""
        Me.lblCode8.AutoSize = True
        Me.lblCode8.Location = New System.Drawing.Point(34, 256)
        Me.lblCode8.Name = "lblCode8"
        Me.lblCode8.Size = New System.Drawing.Size(81, 20)
        Me.lblCode8.TabIndex = 10
        Me.lblCode8.Text = "8 = Forest"
        '
        'lblCode9
        '
        Me.lblCode9.AccessibleName = ""
        Me.lblCode9.AutoSize = True
        Me.lblCode9.Location = New System.Drawing.Point(34, 282)
        Me.lblCode9.Name = "lblCode9"
        Me.lblCode9.Size = New System.Drawing.Size(125, 20)
        Me.lblCode9.TabIndex = 11
        Me.lblCode9.Text = "9 = Snow Forest"
        '
        'lblCodeA
        '
        Me.lblCodeA.AccessibleName = ""
        Me.lblCodeA.AutoSize = True
        Me.lblCodeA.Location = New System.Drawing.Point(34, 308)
        Me.lblCodeA.Name = "lblCodeA"
        Me.lblCodeA.Size = New System.Drawing.Size(84, 20)
        Me.lblCodeA.TabIndex = 12
        Me.lblCodeA.Text = "A = Jungle"
        '
        'lblCodeB
        '
        Me.lblCodeB.AccessibleName = ""
        Me.lblCodeB.AutoSize = True
        Me.lblCodeB.Location = New System.Drawing.Point(34, 334)
        Me.lblCodeB.Name = "lblCodeB"
        Me.lblCodeB.Size = New System.Drawing.Size(103, 20)
        Me.lblCodeB.TabIndex = 13
        Me.lblCodeB.Text = "B = Mountain"
        '
        'lblCodeC
        '
        Me.lblCodeC.AccessibleName = ""
        Me.lblCodeC.AutoSize = True
        Me.lblCodeC.Location = New System.Drawing.Point(34, 360)
        Me.lblCodeC.Name = "lblCodeC"
        Me.lblCodeC.Size = New System.Drawing.Size(126, 20)
        Me.lblCodeC.TabIndex = 14
        Me.lblCodeC.Text = "C = Snow Mount"
        '
        'lblCodesTitle
        '
        Me.lblCodesTitle.AutoSize = True
        Me.lblCodesTitle.Location = New System.Drawing.Point(10, 12)
        Me.lblCodesTitle.Name = "lblCodesTitle"
        Me.lblCodesTitle.Size = New System.Drawing.Size(154, 20)
        Me.lblCodesTitle.TabIndex = 15
        Me.lblCodesTitle.Text = "Terrain Codes (Hex):"
        '
        'FormMapGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 506)
        Me.Controls.Add(Me.txtMapValues)
        Me.Controls.Add(Me.pbxMap)
        Me.Controls.Add(Me.txtSeed)
        Me.Controls.Add(Me.lblSeed)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtTropicZone)
        Me.Controls.Add(Me.txtArcticRadius)
        Me.Controls.Add(Me.txtLake)
        Me.Controls.Add(Me.txtRiver)
        Me.Controls.Add(Me.lblTropicZone)
        Me.Controls.Add(Me.lblArcticRadius)
        Me.Controls.Add(Me.lblLake)
        Me.Controls.Add(Me.lblRiver)
        Me.Controls.Add(Me.txtSwamp)
        Me.Controls.Add(Me.txtDesert)
        Me.Controls.Add(Me.txtGrassland)
        Me.Controls.Add(Me.txtForest)
        Me.Controls.Add(Me.txtMountain)
        Me.Controls.Add(Me.lblSwamp)
        Me.Controls.Add(Me.lblDesert)
        Me.Controls.Add(Me.lblGrassland)
        Me.Controls.Add(Me.lblForest)
        Me.Controls.Add(Me.lblMountain)
        Me.Controls.Add(Me.txtTilesY)
        Me.Controls.Add(Me.txtTilesX)
        Me.Controls.Add(Me.lblTilesY)
        Me.Controls.Add(Me.lblTilesX)
        Me.Controls.Add(Me.btnRandomize)
        Me.Controls.Add(Me.lblCodesTitle)
        Me.Controls.Add(Me.lblCodeC)
        Me.Controls.Add(Me.lblCodeB)
        Me.Controls.Add(Me.lblCodeA)
        Me.Controls.Add(Me.lblCode9)
        Me.Controls.Add(Me.lblCode8)
        Me.Controls.Add(Me.lblCode7)
        Me.Controls.Add(Me.lblCode6)
        Me.Controls.Add(Me.lblCode5)
        Me.Controls.Add(Me.lblCode4)
        Me.Controls.Add(Me.lblCode3)
        Me.Controls.Add(Me.lblCode2)
        Me.Controls.Add(Me.lblCode1)
        Me.Controls.Add(Me.lblCode0)
        Me.Name = "FormMapGenerator"
        Me.Text = "Map Generator"
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRandomize As Button
    Friend WithEvents lblTilesX As Label
    Friend WithEvents lblTilesY As Label
    Friend WithEvents txtTilesX As TextBox
    Friend WithEvents txtTilesY As TextBox
    Friend WithEvents lblMountain As Label
    Friend WithEvents lblForest As Label
    Friend WithEvents lblGrassland As Label
    Friend WithEvents lblDesert As Label
    Friend WithEvents lblSwamp As Label
    Friend WithEvents txtMountain As TextBox
    Friend WithEvents txtForest As TextBox
    Friend WithEvents txtDesert As TextBox
    Friend WithEvents txtGrassland As TextBox
    Friend WithEvents txtSwamp As TextBox
    Friend WithEvents txtTropicZone As TextBox
    Friend WithEvents txtArcticRadius As TextBox
    Friend WithEvents txtLake As TextBox
    Friend WithEvents txtRiver As TextBox
    Friend WithEvents lblTropicZone As Label
    Friend WithEvents lblArcticRadius As Label
    Friend WithEvents lblLake As Label
    Friend WithEvents lblRiver As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblSeed As Label
    Friend WithEvents txtSeed As TextBox
    Friend WithEvents pbxMap As PictureBox
    Friend WithEvents txtMapValues As RichTextBox
    Friend WithEvents lblCode0 As Label
    Friend WithEvents lblCode1 As Label
    Friend WithEvents lblCode2 As Label
    Friend WithEvents lblCode3 As Label
    Friend WithEvents lblCode4 As Label
    Friend WithEvents lblCode5 As Label
    Friend WithEvents lblCode6 As Label
    Friend WithEvents lblCode7 As Label
    Friend WithEvents lblCode8 As Label
    Friend WithEvents lblCode9 As Label
    Friend WithEvents lblCodeA As Label
    Friend WithEvents lblCodeB As Label
    Friend WithEvents lblCodeC As Label
    Friend WithEvents lblCodesTitle As Label
End Class
