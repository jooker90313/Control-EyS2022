Imports ClosedXML.Excel
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Grid
'TODO' PLUS SOLO PARA DESMOTRAR VER SI PODIA PROGRAMARLO, TABLAS CON ENCABEZADOS MALO, PERO FUNCIONAL 
Public Class FrmExportar
    Dim Emple As New BDQUICKIEDataSetTableAdapters.QEmpleadoTableAdapter
    Dim Depa As New BDQUICKIEDataSetTableAdapters.QDepartamentoTableAdapter
    Dim Cargo As New BDQUICKIEDataSetTableAdapters.QCargoTableAdapter
    Dim taRegAsis As New BDQUICKIEDataSetTableAdapters.Registro_de_asistenciaTableAdapter


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
                        Workbook.Worksheets.Add(Me.Depa.GetData())
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
                        Workbook.Worksheets.Add(Me.Cargo.GetData())
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
                        Workbook.Worksheets.Add(Me.Emple.GetData())
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

        Dim data As DataTable = Depa.GetData()
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

        Dim data As DataTable = Emple.GetData
        GeneratePdf(data)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim data As DataTable = Cargo.GetData
        GeneratePdf(data)
    End Sub

    Private Sub FrmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim data As DataTable = taRegAsis.GetDataBy2
        GeneratePdf(data)
    End Sub

    Private Sub ReporteDeHoraEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeHoraEntradaYSalidaToolStripMenuItem.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using Workbook As XLWorkbook = New XLWorkbook()
                        Workbook.Worksheets.Add(Me.taRegAsis.GetDataBy2())
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