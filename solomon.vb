public Class Form1

    ' ========== CALCULATE FEES (Part a) ==========
    Private Sub btnCalculateFees_Click(sender As Object, e As EventArgs) Handles btnCalculateFees.Click
        Try
            Dim monthlySalary As Double = CDbl(txtMonthlySalary.Text)
            Dim numberOfDependents As Integer = CInt(txtNumberOfDependents.Text)
            Dim schoolFeesPerTerm As Double = CDbl(txtSchoolFeesPerTerm.Text)

            ' Total expenses = four dependents * school fees
            Dim totalSchoolFees As Double = numberOfDependents * schoolFeesPerTerm

            ' Take home balance = monthly salary - Total expenses
            Dim takeHomeBalance As Double = monthlySalary - totalSchoolFees

            ' Display results
            txtTotalSchoolFees.Text = totalSchoolFees.ToString("N0")
            txtTakeHomeBalance.Text = takeHomeBalance.ToString("N0")

        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers only!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========== CALCULATE DEDUCTION (Part b) ==========
    Private Sub btnCalculateDeduction_Click(sender As Object, e As EventArgs) Handles btnCalculateDeduction.Click
        Try
            Dim monthlySalary As Double = CDbl(txtMonthlySalary.Text)

            ' Rates from the question
            Dim nssfAmount As Double = 0.1 * monthlySalary    ' 10% NSSF
            Dim payeAmount As Double = 0.09 * monthlySalary   ' 9% PAYE
            Dim saccoAmount As Double = 0.05 * monthlySalary  ' 5% SACCO

            ' Total deductions
            Dim totalDeductions As Double = nssfAmount + payeAmount + saccoAmount

            ' Balance after deductions = salary - total deductions
            Dim balanceAfter As Double = monthlySalary - totalDeductions

            ' Display all results
            txtNSSF.Text = nssfAmount.ToString("N0")
            txtPAYE.Text = payeAmount.ToString("N0")
            txtSACCO.Text = saccoAmount.ToString("N0")
            txtBalanceAfterDeduction.Text = balanceAfter.ToString("N0")

        Catch ex As Exception
            MessageBox.Show("Please enter a valid Monthly Salary!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========== CLEAR BUTTON ==========
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMonthlySalary.Clear()
        txtNumberOfDependents.Clear()
        txtSchoolFeesPerTerm.Clear()

        txtTotalSchoolFees.Clear()
        txtTakeHomeBalance.Clear()
        txtBalanceAfterDeduction.Clear()

        txtNSSF.Clear()
        txtPAYE.Clear()
        txtSACCO.Clear()

        txtMonthlySalary.Focus()
    End Sub

End Class
