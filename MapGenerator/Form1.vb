Public Class FormMapGenerator

    Private hasPainted As Boolean = False
    Private bitMap As Bitmap

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        Dim rnd As New Random()
        txtMountain.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtForest.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtGrassland.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtDesert.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtSwamp.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtRiver.Text = CStr(CDec(rnd.Next(0, 100)) / 100)
        txtLake.Text = CStr(CDec(rnd.Next(0, 100)) / 100)

        txtArcticRadius.Text = CStr(CDec(rnd.Next(10, 40)) / 100)
        txtTropicZone.Text = CStr(CDec(rnd.Next(10, 40)) / 100)

        txtSeed.Text = CStr(CLng(rnd.Next(0, 2147483647)))

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim seed = 0
        Try
            seed = CLng(txtSeed.Text)
        Catch x As Exception

        End Try

        Dim map = New Map(seed, CInt(txtTilesX.Text), CInt(txtTilesY.Text), CDbl(txtArcticRadius.Text), CDbl(txtTropicZone.Text), CDbl(txtMountain.Text), CDbl(txtForest.Text), CDbl(txtGrassland.Text), CDbl(txtDesert.Text), CDbl(txtSwamp.Text), CDbl(txtRiver.Text), CDbl(txtLake.Text))
        Dim initTime As Long = CLng((DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds)
        map.GeneratePerlinMatrix()

        txtMapValues.Text = " Done " & txtTilesX.Text & txtTilesY.Text & Environment.NewLine()
        'Return
        Dim matrix As Integer(,) = map.GetMapMatrix()
        For y As Integer = 0 To map.GetHeight()
            For x As Integer = 0 To map.GetWidth()
                txtMapValues.Text &= " " & matrix(y, x)
            Next
            txtMapValues.Text &= Environment.NewLine()
        Next

        bitMap = New Bitmap(CInt(txtTilesX.Text), CInt(txtTilesY.Text))
        For y As Integer = 0 To CInt(txtTilesY.Text) - 1
            For x As Integer = 0 To CInt(txtTilesX.Text) - 1
                Dim color = New Color()
                color = Color.FromArgb(matrix(y, x), matrix(y, x), matrix(y, x))
                bitMap.SetPixel(x, y, color)
            Next
        Next
        hasPainted = Not hasPainted
        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (hasPainted) Then
            Dim image As Image = bitMap
            pbxMap.CreateGraphics().DrawImage(image, 0, 0, pbxMap.Width, pbxMap.Height)
            hasPainted = False
        End If
    End Sub

End Class
