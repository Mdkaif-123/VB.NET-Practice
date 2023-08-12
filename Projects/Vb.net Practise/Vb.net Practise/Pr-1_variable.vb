Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim sCarName As String
        Dim dCarPrice As Double
        Dim sCarColor As String
        Dim bTax As Boolean
        Dim dFuelCostPerYear As Decimal

        sCarName = "Toyota"
        dCarPrice = 12000000
        sCarColor = "Black"
        bTax = True
        dFuelCostPerYear = 99.9



        MsgBox("My car is " & sCarName & dCarPrice & sCarColor & bTax & dFuelCostPerYear)




    End Sub

End Class
