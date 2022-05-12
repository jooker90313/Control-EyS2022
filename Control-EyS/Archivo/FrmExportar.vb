Imports ClosedXML.Excel
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

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
        Dim pdfTable As PdfPTable = New PdfPTable(Me.depa.GetData.Columns.Count)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 2



    End Sub
End Class