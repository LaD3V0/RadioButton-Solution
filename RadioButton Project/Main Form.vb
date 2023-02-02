' Name:         RadioButton Project
' Purpose:      Create two groups of radio buttons.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub radCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles radCoffee.CheckedChanged

    End Sub

    Private Sub radTea_CheckedChanged(sender As Object, e As EventArgs) Handles radTea.CheckedChanged

    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged

    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged

    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged

    End Sub
End Class
