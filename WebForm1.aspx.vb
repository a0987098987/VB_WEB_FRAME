Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        '中斷GridView與sqlDataSource的「綁定,Binding」，讓GridView進入EmptyDataTemplate樣板
        If e.CommandName = "GridInsert" Then
            GridView1.DataSourceID = Nothing
        End If
        If e.CommandName = "GridSelect" Then
            GridView1.DataSourceID = Nothing
        End If
    End Sub

    Protected Sub LBtn_Back_Click(sender As Object, e As EventArgs)
        'sqlDSNW請修改為自己的名稱
        GridView1.DataSourceID = "SqlDataSource1"
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs)
        'sqlDSNW請修改為自己的名稱
        GridView1.DataSourceID = "SqlDataSource1"
    End Sub
End Class