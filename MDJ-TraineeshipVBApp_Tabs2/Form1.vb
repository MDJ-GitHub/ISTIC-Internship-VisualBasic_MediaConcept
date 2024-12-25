Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class Form1
    Public sendtab As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Modele.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Panel1.Width = 176
            Panel1.Height = 665

            Dim int_row As Integer = DataGridView1.Rows.Count
            DataGridView1.Rows.Add()
        DataGridView1.Rows(int_row - 1).Cells("Modelex").Value = Modele.SelectedItem
        DataGridView1.Rows(int_row - 1).Cells("Taillex").Value = Taille.SelectedItem
            DataGridView1.Rows(int_row - 1).Cells("Destinationx").Value = Destination.SelectedItem
            DataGridView1.Rows(int_row - 1).Cells("Saisonx").Value = Saison.SelectedItem
        DataGridView1.Rows(int_row - 1).Cells("Datex").Value = Datee.Value
        DataGridView1.Rows(int_row - 1).Cells("Clientx").Value = Client.SelectedItem
        DataGridView1.Rows(int_row - 1).Cells("Variantex").Value = Variante.SelectedItem
        DataGridView1.Rows(int_row - 1).Cells("Commandex").Value = Commande.SelectedItem


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Panel1.Width = 176
        Panel1.Height = 665



        Dim int_row As Integer = DataGridView1.Rows.Count - 1
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Columns.Clear()
        DataGridView3.Rows.Clear()
        Dim int_k As Integer = 0
        Dim int_k2 As Integer = 0
        Dim int_k3 As Integer = 0
        For i As Integer = 0 To int_row - 1

            Dim int_y As Integer = DataGridView1.Rows(i).Cells("Paquet").Value
            Dim int_x As Integer = DataGridView1.Rows(i).Cells("Valeur").Value
            Dim int_d As Integer = Math.Floor(int_x / int_y)
            For j As Integer = 0 To int_d - 1
                Dim str_x As String = DataGridView1.Rows(i).Cells("Modelex").Value + " : " + CStr(int_y)
                DataGridView2.Columns.Add("col" + str_x + CStr(int_k), str_x)
                If DataGridView2.Columns.Count = 1 Then
                    DataGridView2.Rows.Add()
                End If

                DataGridView2.Rows(0).Cells("col" + str_x + CStr(int_k)).Value = CStr(int_k + 1)
                int_k = int_k + 1

                DataSet1.EtiquetteExport.AddEtiquetteExportRow(DataGridView1.Rows(i).Cells("Modelex").Value, int_k, DataGridView1.Rows(i).Cells("Paquet").Value, DataGridView1.Rows(i).Cells("Variantex").Value, DataGridView1.Rows(i).Cells("Clientx").Value, DataGridView1.Rows(i).Cells("Saisonx").Value, DataGridView1.Rows(i).Cells("Datex").Value, DataGridView1.Rows(i).Cells("Commandex").Value, DataGridView1.Rows(i).Cells("Destinationx").Value, DataGridView1.Rows(i).Cells("Taillex").Value)

                int_k3 = int_k3 + 1

            Next
            If Not (int_x Mod int_y = 0) Then
                Dim str_x As String = DataGridView1.Rows(i).Cells("Modelex").Value
                Dim int_m As Integer = int_x Mod int_y
                DataGridView3.Columns.Add("dcol" + str_x, str_x)
                If DataGridView3.Columns.Count = 1 Then
                    DataGridView3.Rows.Add()
                End If

                DataGridView3.Rows(0).Cells("dcol" + str_x).Value = CStr(int_m)

                DataSet1.EtiquetteExportR.AddEtiquetteExportRRow(DataGridView1.Rows(i).Cells("Modelex").Value, DataGridView1.Rows(i).Cells("Paquet").Value, int_m, DataGridView1.Rows(i).Cells("Variantex").Value, DataGridView1.Rows(i).Cells("Clientx").Value, DataGridView1.Rows(i).Cells("Saisonx").Value, DataGridView1.Rows(i).Cells("Datex").Value, DataGridView1.Rows(i).Cells("Commandex").Value, DataGridView1.Rows(i).Cells("Destinationx").Value, DataGridView1.Rows(i).Cells("Taillex").Value)

                int_k2 = int_k2 + 1






            Else

            End If

        Next



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Panel1.Width = 176 Then
            Panel1.Width = 1200
            Panel1.Height = 612

            Dim rpt As New ETQExport
            rpt.SetDataSource(DataSet1)

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

        Else
            Panel1.Width = 176
            Panel1.Height = 665
        End If







    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Labelc.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Destination.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Client.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Saison.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Commande.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel1.Width = 176 Then
            Panel1.Width = 1200
            Panel1.Height = 612

            Dim rpt As New ETQRExport
            rpt.SetDataSource(DataSet1)

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

        Else
            Panel1.Width = 176
            Panel1.Height = 665
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class