Imports ClosedXML.Excel
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Grid

Public Class FrmExportar

    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmInicioAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ReporteDeDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeDepartamentoToolStripMenuItem.Click
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

    Private Sub ReporteDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCargoToolStripMenuItem.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using Workbook As XLWorkbook = New XLWorkbook()
                        Workbook.Worksheets.Add(Me.carg.GetData())
                        Workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Se ha importado de forma exitosa el archivo Excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End Using

    End Sub

    Private Sub ReporteDeEmpleadoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReporteDeEmpleadoToolStripMenuItem.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using Workbook As XLWorkbook = New XLWorkbook()
                        Workbook.Worksheets.Add(Me.regEmpl.GetData())
                        Workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Se ha importado de forma exitosa el archivo Excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End Using
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Dim data As DataTable = depa.GetData()
        GeneratePdf(data)

    End Sub

    Private Sub GeneratePdf(data As DataTable)


        Dim doc As PdfDocument = New PdfDocument()
        Dim page As PdfPage = doc.Pages.Add()
        Dim pdfGrid As PdfGrid = New PdfGrid()
        pdfGrid.DataSource = data
        Dim gridStyle As PdfGridStyle = New PdfGridStyle()
        gridStyle.CellPadding = New PdfPaddings(5, 5, 5, 5)
        pdfGrid.Style = gridStyle
        pdfGrid.Draw(page, New PointF(10, 10))
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "PDF |*.pdf"}
            If sfd.ShowDialog() = DialogResult.OK Then

                doc.Save(sfd.FileName)

                doc.Close(True)

            End If
        End Using
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Dim data As DataTable = regEmpl.GetData
        GeneratePdf(data)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim data As DataTable = carg.GetData
        GeneratePdf(data)
    End Sub
End Class