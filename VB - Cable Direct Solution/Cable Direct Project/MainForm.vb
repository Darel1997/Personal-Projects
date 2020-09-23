Option Explicit On
Option Infer Off
Option Strict On
Public Class frmMain
    Public Function Residential() As Double
        Const dblPROCESSING_FEE As Double = 4.5
        Const intBASIC_SERVICE As Integer = 30
        Const intPREMIUM_CHANNELS As Integer = 5
        Return dblPROCESSING_FEE + intBASIC_SERVICE + (lstPremium.SelectedIndex * intPREMIUM_CHANNELS)
    End Function
    Public Function Business() As Double
        Const dblPROCESSING_FEE As Double = 16.5
        Const intPREMIUM_CHANNELS As Integer = 50
        Dim intBasic_Service As Integer
        If lstConnection.SelectedIndex <= 10 Then
            intBasic_Service = 80
        Else
            intBasic_Service = 80 + (lstConnection.SelectedIndex - 10) * 4
        End If
        Return dblPROCESSING_FEE + (lstPremium.SelectedIndex * intPREMIUM_CHANNELS) + intBasic_Service
    End Function
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblTotal As Double
        If radBusiness.Checked Then
            dblTotal = Business()
        Else
            dblTotal = Residential()
        End If
        lblTotal.Text = dblTotal.ToString("c2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Cable Direct",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For intPremium As Integer = 0 To 20
            lstPremium.Items.Add(intPremium)
        Next intPremium
        For intConnection As Integer = 0 To 100
            lstConnection.Items.Add(intConnection)
        Next intConnection
        lstConnection.SelectedIndex = 0
        lstPremium.SelectedIndex = 0
    End Sub

    Private Sub frmMain_TextChanged(sender As Object, e As EventArgs) Handles radBusiness.CheckedChanged, radResidential.CheckedChanged,
            lstPremium.SelectedIndexChanged, lstConnection.SelectedIndexChanged
        If radBusiness.Checked Then
            If lstConnection.SelectedIndex = 0 Then
                lstConnection.SelectedIndex = 1
            End If
        End If
        lblTotal.Text = String.Empty
    End Sub
End Class
