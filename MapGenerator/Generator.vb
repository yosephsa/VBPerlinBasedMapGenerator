Public Class Generator
    ' This Modified Perlin Matrix Generator Works as such.
    '   It starts by generating a matrix of random numbers based on a given seed. Then it creates n number of
    '   layers (as specified). Each layer is tiled, with the first layer containing the largest sized tiles.
    '   For each layer the values of the tiles' four vertices are aquired from the random matrix, while the
    '   values within each tile are an interpulation of all four vertices. Each proceeding layer's tiles are 
    '   smaller. After all layers are generated, they are all added together to create a smooth random matrix
    '   of values between a given min and max.
    '
    ' @param seed: A unique seed used to generate random numbers
    ' @param width: Width of matrix
    ' @param height: Height of matrix
    ' @param initCellCountX: The starting number of cells on the x axis
    ' @param initCellCountY: The starting number of cells on the y axis
    ' @param cellChangeFactor: The multiplying factor to increase the cells per layer
    ' @param lyers: The total number of layers used to generate the perlin map.
    ' @param min: the minimum value to store in each point of the matrix
    ' @param max: the maximum value to store in each point of the matrix
    ' @return A perlin map generated using
    Public Function GenerateModifiedPerlinMatrix(seed As Long, width As Integer, height As Integer, initCellCountX As Integer, initCellCountY As Integer, cellChangeFactor As Integer, layers As Integer, min As Integer, max As Integer) As Integer(,)
        'Decleration of variables
        Dim matrices(layers)
        Dim randMatrix
        Dim resultMatrix
        Dim rand

        'Initialize Variables
        randMatrix = New Integer(height, width) {}
        resultMatrix = New Integer(height, width) {}
        rand = New Random(seed)


        'Create Random Matrix For Generating Perlin Maps
        For y As Integer = 0 To height - 1 ' Fill matrix with random values
            For x As Integer = 0 To width - 1
                randMatrix(y, x) = rand.Next(min, max)
            Next
        Next

        'Generate Each Layer of Perlin Map
        For i As Integer = 0 To layers - 1
            matrices(i) = New Integer(height, width) {}
            Dim cellWidth As Integer = width / (initCellCountX * cellChangeFactor * (i + 1))
            Dim cellHeight As Integer = height / (initCellCountY * cellChangeFactor * (i + 1))
            If cellWidth = 0 Then
                cellWidth = 1
            End If
            If cellHeight = 0 Then
                cellHeight = 1
            End If

            ' Fills the current matrix with the Interpolation of values from a random matrix
            For y As Integer = 0 To height - 1
                For x As Integer = 0 To width - 1
                    'Use Bilinear Sine Interpulation
                    matrices(i)(y, x) = BilinearSineInterpolate(randMatrix, x, y, cellWidth, cellHeight)
                    resultMatrix(y, x) = resultMatrix(y, x) * (1.0 - CDbl(layers - i) / CDbl(layers)) + matrices(i)(y, x) * (CDbl(layers - i) / CDbl(layers))
                Next
            Next
        Next

        Return resultMatrix
    End Function

    Private Function MeanInterpolate(randMatrix As Integer(,), x As Integer, y As Integer, cellWidth As Integer, cellHeight As Integer)
        Dim upperCord = CInt(y / cellHeight)
        Dim lowerCord = CInt(y / cellHeight) + 1
        Dim leftCord = CInt(x / cellWidth)
        Dim rightCord = CInt(y / cellWidth) + 1

        'Compute Interpulation
        Dim upperVal = (1 - CDec(x - leftCord) / CDec(cellWidth)) * randMatrix(upperCord, leftCord) + (1 - CDec(rightCord - x) / CDec(cellWidth)) * randMatrix(upperCord, leftCord)

        Dim lowerVal = (1 - CDec(x - leftCord) / CDec(cellWidth)) * randMatrix(lowerCord, leftCord) + (1 - CDec(rightCord - x) / CDec(cellWidth)) * randMatrix(lowerCord, leftCord)

        Dim value = (1 - CDec(y - upperCord) / CDec(cellHeight)) * upperVal + (1 - CDec(lowerCord - y) / CDec(cellHeight)) * lowerVal

        Return value
    End Function


    Private Function BilinearInterpolate(randMatrix As Integer(,), x As Integer, y As Integer, cellWidth As Integer, cellHeight As Integer) As Integer
        Dim upperCord = CInt(y / cellHeight)
        Dim lowerCord = CInt(y / cellHeight) + 1
        Dim leftCord = CInt(x / cellWidth)
        Dim rightCord = CInt(x / cellWidth) + 1

        Dim A = randMatrix(upperCord, leftCord)  ' Top Left
        Dim B = randMatrix(upperCord, rightCord) ' Top Right
        Dim C = randMatrix(lowerCord, leftCord)  ' Bottom Left
        Dim D = randMatrix(lowerCord, rightCord) ' Bottom Right

        Dim FracX = CDec(rightCord - leftCord) / CDec(cellWidth)
        Dim FracY = CDec(lowerCord - upperCord) / CDec(cellHeight)

        Dim AB = A + FracX * (B - A)
        Dim CD = C + FracX * (D - C)

        Dim value = AB + FracY * (CD - AB)
        Return value

    End Function

    Private Function BilinearSineInterpolate(randMatrix As Integer(,), x As Integer, y As Integer, cellWidth As Integer, cellHeight As Integer) As Integer
        Dim upperCord = CInt(y / cellHeight)
        Dim lowerCord = CInt(y / cellHeight) + 1
        Dim leftCord = CInt(x / cellWidth)
        Dim rightCord = CInt(x / cellWidth) + 1

        Dim A = randMatrix(upperCord, leftCord)  ' Top Left
        Dim B = randMatrix(upperCord, rightCord) ' Top Right
        Dim C = randMatrix(lowerCord, leftCord)  ' Bottom Left
        Dim D = randMatrix(lowerCord, rightCord) ' Bottom Right

        Dim FracX = CDec(rightCord - leftCord) / CDec(cellWidth)
        Dim FracY = CDec(lowerCord - upperCord) / CDec(cellHeight)

        Dim AB = A + Math.Sin(FracX * Math.PI / 2) * (B - A)
        Dim CD = C + Math.Sin(FracX * Math.PI / 2) * (D - C)

        Dim value = AB + Math.Sin(FracY * Math.PI / 2) * (CD - AB)

        If (value < 0) Then
            value = value
        End If
        Return value

    End Function

End Class
