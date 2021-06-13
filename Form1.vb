'Name: Eric
'Date: June 30th, 2020
'Program: Average Units Shipped
'Program Description: This program averages the average units shipped per day for 3 employees, using arrays.

Option Strict On

Public Class Form1

    'Declare constants for array bounds
    Const NUM_EMPLOYEES As Integer = 4
    Const NUM_DAYS As Integer = 7

    'Declare 2D array
    Private _UnitsShipped(NUM_EMPLOYEES, NUM_DAYS) As Integer

    'When form loads call functions 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call initiateUnitsArray()
        Call displayUnitsShipped()
    End Sub

    Private Sub initiateUnitsArray()
        For Each Element As Integer In _UnitsShipped
            Element = 0
        Next
    End Sub

    ' Private Sub displayUnitsShipped()

    '    For Employee As Integer = 1 To NUM_EMPLOYEES

    'DirectCast(Me.Controls("tbOutput" & (Employee).ToString), TextBox).Item.Clear()

    'For Day As Integer = 1 To NUM_DAYS
    'DirectCast(Me.Controls("tbOutput" & (Employee).ToString), TextBox).Item.Add(_UnitsShipped(Employee, Day))
    'Next

    'Next
    '    End Sub


End Class