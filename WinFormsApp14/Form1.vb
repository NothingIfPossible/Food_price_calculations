Public Class frmMenu
    ' declare global variables
    Dim totalCost As Double = 0
    Dim burgerCost As Double = 0
    Dim friesCost As Double = 0
    Dim drinkCost As Double = 0

    ' Make menu items visible when boxes are checked
    Public Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged
        If chkBurgers.Checked = True Then
            grpBurgers.Visible = True
        Else
            grpBurgers.Visible = False
        End If
    End Sub

    Public Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFries.CheckedChanged
        If ChkFries.Checked = True Then
            grpFries.Visible = True
        Else
            grpFries.Visible = False
        End If
    End Sub

    Public Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDrinks.CheckedChanged
        If ChkDrinks.Checked = True Then
            grpDrinks.Visible = True
        Else
            grpDrinks.Visible = False
        End If
    End Sub

    ' Calculate total cost of order
    Public Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        totalCost = 0
        If chkBurgers.Checked = True Then
            If radRegular.Checked = True Then
                burgerCost = 30
            ElseIf (radCheese.Checked = True) Or (radBacon.Checked = True) Then
                burgerCost = 50
            ElseIf (radBoth.Checked = True) Then
                burgerCost = 80
            End If
            totalCost += burgerCost
        End If

        If ChkFries.Checked = True Then
            If radSmall.Checked = True Then
                friesCost = 40
            ElseIf (radMedium.Checked = True) Then
                friesCost = 75
            ElseIf (radLarge.Checked = True) Then
                friesCost = 100
            End If
            totalCost += friesCost
        End If

        If ChkDrinks.Checked = True Then
            If radSoda.Checked = True Then
                drinkCost = 40
            ElseIf radWater.Checked = True Then
                drinkCost = 30
            End If
            totalCost += drinkCost
        End If

        ' output cost of order
        txtCompute.Text = CStr(totalCost.ToString("C"))
    End Sub


End Class
