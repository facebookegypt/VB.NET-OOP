Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System

Public Class CustomTextBox
    Inherits TextBox

    ' Custom Property Example
    Private _autoUpperCase As Boolean = False

    <Category("Behavior"),
     Description("Automatically convert text to uppercase.")>
    Public Property AutoUpperCase As Boolean
        Get
            Return _autoUpperCase
        End Get
        Set(value As Boolean)
            _autoUpperCase = value
            If _autoUpperCase Then
                Me.Text = Me.Text.ToUpper()
            End If
        End Set
    End Property

    ' Constructor
    Public Sub New()
        MyBase.New()
        ' Modify default properties
        Me.BackColor = Color.LightYellow
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    ' Override OnTextChanged to apply AutoUpperCase
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        If _autoUpperCase AndAlso Me.Text <> Me.Text.ToUpper() Then
            Dim selectionStart = Me.SelectionStart
            Me.Text = Me.Text.ToUpper()
            Me.SelectionStart = selectionStart
        End If
        MyBase.OnTextChanged(e)
    End Sub
End Class
