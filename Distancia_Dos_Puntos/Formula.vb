Public Class Formula
    'atributos/ propiedades
    Public x11, x22, y11, y22, distancia1 As Double

    Public Sub New()
    End Sub
    'constructor 
    Public Sub New(x1 As Double, x2 As Double, y1 As Double, y2 As Double, distancia As Double)
        x11 = x1
        x22 = x2
        y11 = y1
        y22 = y2
        distancia1 = distancia
    End Sub
    Public Function Formula(x1 As Double, x2 As Double, y1 As Double, y2 As Double)
        distancia1 = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 3)
        Return distancia1

    End Function

End Class
