Public Class theme13
    Private Sub Theme13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        DataGridView1.Rows.Add("John", "Doe", "EU", "john@doe.com", "+1111111111")
        Me.DataGridView1.ContextMenuStrip = Me.cmenu
    End Sub

    Private Sub PrimeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GggToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        If (e.PaintParts And DataGridViewPaintParts.Background) =
            DataGridViewPaintParts.Background Then
            Dim bColor1, bColor2 As Color
            If (e.PaintParts And DataGridViewPaintParts.SelectionBackground) =
                    DataGridViewPaintParts.SelectionBackground AndAlso
                (e.State And DataGridViewElementStates.Selected) =
                    DataGridViewElementStates.Selected Then
                bColor1 = e.InheritedRowStyle.SelectionBackColor
                bColor2 = Color.FromArgb(189, 138, 247)
            Else
                bColor1 = e.InheritedRowStyle.BackColor
                bColor2 = Color.FromArgb(253, 46, 47)
            End If

            Dim dgv As DataGridView = CType(sender, DataGridView)
            Dim rectLeft2 As Integer = IIf(dgv.RowHeadersVisible, dgv.RowHeadersWidth, 0)
            Dim rectLeft As Integer = rectLeft2 - dgv.HorizontalScrollingOffset
            Dim rectWidth As Integer = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
            Dim rect As New Rectangle(rectLeft, e.RowBounds.Top, rectWidth, e.RowBounds.Height - 1)

            Using b As New System.Drawing.Drawing2D.LinearGradientBrush(rect, bColor1, bColor2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
                rect.X = rectLeft2
                rect.Width -= dgv.HorizontalScrollingOffset
                e.Graphics.FillRectangle(b, rect)
            End Using
            e.PaintHeader(True)
            e.PaintParts =
                e.PaintParts And Not DataGridViewPaintParts.Background
        End If
    End Sub

    Private Sub dgv1_ColumnWidthChanged(ByVal sender As Object,
            ByVal e As DataGridViewColumnEventArgs) _
            Handles DataGridView1.ColumnWidthChanged
        Dim dgv As DataGridView = CType(sender, DataGridView)
        dgv.Invalidate()
    End Sub

End Class