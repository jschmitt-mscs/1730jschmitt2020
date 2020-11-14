Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub dateCalculationButton_Click(sender As Object, e As EventArgs) Handles dateCalculationButton.Click
        TextBox1.Text = "Hello World";
    End Sub
End Class