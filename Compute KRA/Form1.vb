Public Class Form1

    Private Sub txtsalary_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsalary.Leave
        If txtsalary.Text = "" Or Not IsNumeric(txtsalary.Text) Then
            txtsalary.Text = 0
        End If
    End Sub

    Private Sub txtallowances_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtallowances.Leave
        If txtallowances.Text = "" Or Not IsNumeric(txtallowances.Text) Then
            txtallowances.Text = 0
        End If
    End Sub

    
    
    Private Sub txtbonus_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbonus.Leave
        If txtbonus.Text = "" Or Not IsNumeric(txtbonus.Text) Then
            txtbonus.Text = 0
        End If
    End Sub


   
    Private Sub txtcommission_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcommission.Leave
        If txtcommission.Text = "" Or Not IsNumeric(txtcommission.Text) Then
            txtcommission.Text = 0
        End If
    End Sub

    Private Sub txtadvances_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadvances.Leave
        If txtadvances.Text = "" Or Not IsNumeric(txtadvances.Text) Then
            txtadvances.Text = 0
        End If
    End Sub

    Private Sub txtdeductions_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeductions.Leave
        If txtdeductions.Text = "" Or Not IsNumeric(txtdeductions.Text) Then
            txtdeductions.Text = 0
        End If
    End Sub


  
   
    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        If txtsalary.Text = 0 And txtallowances.Text = 0 And txtbonus.Text = 0 And txtcommission.Text = 0 And txtadvances.Text = 0 And txtdeductions.Text = 0 Then
            clear_text()
            Exit Sub
        Else

            'Calculating tax variables
            Dim sa1 As Integer
            Dim co1 As Integer
            Dim grosspay2 As Double
            Dim PAYE As Long
            Dim PAYE1 As Long
            Dim PAYE2 As Long
            Dim PAYE3 As Long
            Dim PAYE4 As Long
            Dim PAYE5 As Long
            Dim PAYE6 As Long
            Dim q1 As Long 'd1 variables that holds the new salary after deductions are taxed
            Dim q2 As Long
            Dim q3 As Long
            Dim q4 As Long
            Dim bonus As Double
            Dim allowances As Double
            Dim NSSF As Long
            Dim taxrelief As Long
            Dim NHIF As Integer
            Dim advances As Double
            Dim deductions As Double

            Dim netpay As Double
            NSSF = 200
            ' Calculating grosspay
            sa1 = txtsalary.Text
            co1 = txtcommission.Text
            bonus = txtbonus.Text
            allowances = txtallowances.Text
            grosspay2 = sa1 + co1 + bonus + allowances
            txtgpay.Text = grosspay2


            'PAYE
            PAYE1 = grosspay2 - 200
            taxrelief = 1162



            If PAYE1 >= 0 And PAYE1 < 10165 Then

                PAYE = 0
                Txtpaye.Text = PAYE


            Else
                If PAYE1 >= 10165 And PAYE1 < 19741 Then
                    q1 = PAYE1 - 10165
                    PAYE2 = 1016


                    PAYE = (q1 * 0.15) + PAYE2 - taxrelief
                    Txtpaye.Text = PAYE

                Else
                    If PAYE1 >= 19741 And PAYE1 < 29317 Then

                        PAYE2 = 1016
                        q2 = PAYE1 - 19741
                        PAYE3 = 1436


                        PAYE = (q2 * 0.2) + PAYE2 + PAYE3 - taxrelief
                        Txtpaye.Text = PAYE

                    Else
                        If PAYE1 >= 29317 And PAYE1 < 38893 Then

                            PAYE2 = 1016

                            PAYE3 = 1436

                            PAYE4 = 1915
                            q3 = PAYE1 - 29317

                            PAYE = (q3 * 0.25) + (PAYE2 + PAYE3 + PAYE4) - taxrelief
                            Txtpaye.Text = PAYE

                        Else

                            PAYE2 = 1016

                            PAYE3 = 1436

                            PAYE4 = 1915

                            PAYE5 = 2394
                            q4 = PAYE1 - 38893
                            PAYE = (q4 * 0.3) + (PAYE2 + PAYE3 + PAYE4 + PAYE5 + PAYE6) - taxrelief
                            Txtpaye.Text = PAYE

                        End If
                    End If
                End If
            End If


            'calculating nhif
            If grosspay2 >= 100000 Then
                NHIF = 1700
                txtnhiff.Text = NHIF

            Else
                If grosspay2 >= 90000 And grosspay2 < 100000 Then
                    NHIF = 1600
                    txtnhiff.Text = NHIF

                Else
                    If grosspay2 >= 80000 And grosspay2 < 90000 Then
                        NHIF = 1500
                        txtnhiff.Text = NHIF
                    Else
                        If grosspay2 >= 70000 And grosspay2 < 80000 Then
                            NHIF = 1400
                            txtnhiff.Text = NHIF

                        Else
                            If grosspay2 >= 60000 And grosspay2 < 70000 Then
                                NHIF = 1300
                                txtnhiff.Text = NHIF

                            Else
                                If grosspay2 >= 50000 And grosspay2 < 60000 Then
                                    NHIF = 1200
                                    txtnhiff.Text = NHIF

                                Else
                                    If grosspay2 >= 45000 And grosspay2 < 50000 Then
                                        NHIF = 1100
                                        txtnhiff.Text = NHIF

                                    Else
                                        If grosspay2 >= 40000 And grosspay2 < 45000 Then
                                            NHIF = 1000
                                            txtnhiff.Text = NHIF

                                        Else
                                            If grosspay2 >= 35000 And grosspay2 < 40000 Then
                                                NHIF = 950
                                                txtnhiff.Text = NHIF

                                            Else
                                                If grosspay2 >= 30000 And grosspay2 < 35000 Then
                                                    NHIF = 900
                                                    txtnhiff.Text = NHIF

                                                Else
                                                    If grosspay2 >= 25000 And grosspay2 < 30000 Then
                                                        NHIF = 850
                                                        txtnhiff.Text = NHIF

                                                    Else
                                                        If grosspay2 >= 20000 And grosspay2 < 25000 Then
                                                            NHIF = 750
                                                            txtnhiff.Text = NHIF

                                                        Else
                                                            If grosspay2 >= 15000 And grosspay2 < 20000 Then
                                                                NHIF = 600
                                                                txtnhiff.Text = NHIF

                                                            Else
                                                                If grosspay2 >= 12000 And grosspay2 < 15000 Then
                                                                    NHIF = 500
                                                                    txtnhiff.Text = NHIF

                                                                Else
                                                                    If grosspay2 >= 8000 And grosspay2 < 12000 Then
                                                                        NHIF = 400
                                                                        txtnhiff.Text = NHIF
                                                                    Else
                                                                        If grosspay2 >= 6000 And grosspay2 < 8000 Then
                                                                            NHIF = 300
                                                                            txtnhiff.Text = NHIF


                                                                        Else
                                                                            If grosspay2 < 6000 Then
                                                                                NHIF = 150
                                                                                txtnhiff.Text = NHIF

                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Txtnssf.Text = 200
            NHIF = txtnhiff.Text
            advances = txtadvances.Text
            deductions = txtdeductions.Text
            netpay = grosspay2 - PAYE - 200 - NHIF - advances - deductions
            Dim total_deductions As Double
            total_deductions = PAYE + 200 + NHIF + advances + deductions
            Txttotal.Text = total_deductions
            Txtnetpay.Text = netpay
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
       clear_text()

    End Sub
    Private Sub clear_text()
        txtadvances.Text = 0
        txtallowances.Text = 0
        txtbonus.Text = 0
        txtcommission.Text = 0
        txtdeductions.Text = 0
        txtgpay.Text = 0
        Txtnetpay.Text = 0
        txtnhiff.Text = 0
        Txtnssf.Text = 0
        Txtpaye.Text = 0
        txtsalary.Text = 0
        Txttotal.Text = 0
    End Sub
End Class
