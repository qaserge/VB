Public Class LuckySeven
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        lblCounter.Text = lblCounter.Text + 1
        If (lblCounter.Text = 5) Then
            btnSpin.Visible = False
        End If

        'Syntax to change the property value
        'object_name.property_name = expression
        'object_name.method_name()

        PicLuckySeven777.Visible = False
        PicLuckySeven.Visible = False


        'create an instance of a class
        Dim randomNumber As New Random()
        lblNumber1.Text = randomNumber.Next(0, 10).ToString()
        lblNumber2.Text = randomNumber.Next(0, 10).ToString()
        lblNumber3.Text = randomNumber.Next(0, 10).ToString()

        'check if the random number is equal to 7, then show the picture

        If (lblNumber1.Text = "7") And (lblNumber2.Text = "7") And (lblNumber3.Text = "7") Then
            PicLuckySeven777.Visible = True
            btnSpin.Visible = False
        End If

        If (lblNumber1.Text = "7") Or (lblNumber2.Text = "7") Or (lblNumber3.Text = "7") Then
            PicLuckySeven.Visible = True
        End If



        'chack when value equals seven
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblNumber1.Text = 0
        lblNumber2.Text = 0
        lblNumber3.Text = 0
        lblCounter.Text = 0
        btnSpin.Visible = True
    End Sub

    Private Sub lblCounter_Click(sender As Object, e As EventArgs) Handles lblCounter.Click



    End Sub
End Class
