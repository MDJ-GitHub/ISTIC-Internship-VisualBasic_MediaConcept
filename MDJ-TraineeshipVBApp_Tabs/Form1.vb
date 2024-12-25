Imports System.Windows.Forms

Public Class Form1

    Dim int_row As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            int_row = DataGridView1.Rows.Count - 1
            DataGridView2.Columns.Clear()
            DataGridView2.Rows.Clear()
            DataGridView3.Columns.Clear()
            DataGridView3.Rows.Clear()
            Dim int_k As Integer = 0
            Dim int_k2 As Integer = 0
            For i As Integer = 0 To int_row - 1
                Dim int_y As Integer = DataGridView1.Rows(i).Cells(2).Value
                Dim int_x As Integer = DataGridView1.Rows(i).Cells(1).Value
                Dim int_d As Integer = Math.Floor(int_x / int_y)
                For j As Integer = 0 To int_d - 1
                    DataGridView2.Columns.Add("col" + CStr(int_k), int_y)
                    DataGridView2.Rows.Add()
                    DataGridView2.Rows(0).Cells("col" + CStr(int_k)).Value = CStr(int_k + 1)
                    int_k = int_k + 1
                Next
                If Not (int_x Mod int_y = 0) Then
                    Dim str_x As String = DataGridView1.Rows(i).Cells(0).Value
                    Dim int_m As Integer = int_x Mod int_y
                    DataGridView3.Columns.Add("dcol" + str_x, str_x)
                    DataGridView3.Rows.Add()
                    DataGridView3.Rows(0).Cells("dcol" + str_x).Value = CStr(int_m)
                    int_k2 = int_k2 + 1


                Else

                End If
            Next

        Catch
            DataGridView2.Columns.Clear()
            DataGridView2.Rows.Clear()
            DataGridView3.Columns.Clear()
            DataGridView3.Rows.Clear()
            MessageBox.Show("Erreur, assurez-vous que les informations insérées sont correctes. ")

        End Try


    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class