Imports ClosedXML.Excel

Public Class FrmExportar
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmInicioAdmin.Show()
        Me.Hide()


    End Sub

    Private Sub btnPdf_Paint(sender As Object, e As PaintEventArgs) Handles btnPdf.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnPdf.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnPdf.Region = New Region(buttonPath)
    End Sub

    Private Sub btnExcel_Paint(sender As Object, e As PaintEventArgs) Handles btnExcel.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnExcel.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnExcel.Region = New Region(buttonPath)
    End Sub


    Private Sub FrmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using Workbook As XLWorkbook = New XLWorkbook()
                        Workbook.Worksheets.Add(Me.depa.GetData())
                        Workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Se ha importado de forma exitosa el archivo Excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

    End Sub
End Class