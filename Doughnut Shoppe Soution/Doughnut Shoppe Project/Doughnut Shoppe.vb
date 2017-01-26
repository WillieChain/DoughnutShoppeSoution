' Name:         Doughnut Shoppe Project
' Purpose:      Display the subtotal, sales tax, and total due
' Programmer:   Willie Chain on 12/6/2016

Public Class Form1
    Private Sub ClearLabels()
        lblSubtotal.Text = String.Empty
        lblSalesTax.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the subtotal, sales tax, and total due



        Dim decDough As Decimal
        Dim decCoffee As Decimal
        Dim decTotalDue As Decimal
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal

        ' assign doughnut price
        Select Case True
            Case radGlazed.Checked
                decDough = 0.65
            Case radSugar.Checked
                decDough = 0.65
            Case radChocolate.Checked
                decDough = 0.85
            Case radFilled.Checked
                decDough = 1
        End Select

        ' assign coffee price
        Select Case True
            Case radNone.Checked
                decCoffee = 0
            Case radRegular.Checked
                decCoffee = 1.8
            Case radCappuccino.Checked
                decCoffee = 2.5
        End Select

        ' calculate subtotal
        decSubtotal = decDough + decCoffee

        ' calculate sales tax
        decSalesTax = decSubtotal * 0.03

        ' calculate total due
        decTotalDue = decSubtotal + decSalesTax

        ' display subtotal, salestax, and total due
        lblSubtotal.Text = decSubtotal.ToString("N2")
        lblSalesTax.Text = decSalesTax.ToString("N2")
        lblTotalDue.Text = decTotalDue.ToString("N2")
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub radCappuccino_CheckedChanged(sender As Object, e As EventArgs) Handles radCappuccino.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radChocolate_CheckedChanged(sender As Object, e As EventArgs) Handles radChocolate.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radFilled_CheckedChanged(sender As Object, e As EventArgs) Handles radFilled.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radNone_CheckedChanged(sender As Object, e As EventArgs) Handles radNone.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        ClearLabels()
    End Sub

    Private Sub radSugar_CheckedChanged(sender As Object, e As EventArgs) Handles radSugar.CheckedChanged
        ClearLabels()
    End Sub
End Class
