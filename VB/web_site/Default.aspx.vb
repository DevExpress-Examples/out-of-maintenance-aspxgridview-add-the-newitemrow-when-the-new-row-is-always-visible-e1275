Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            gridView.AddNewRow()
        End If
        DisableUpdateInDemo()
    End Sub
    Protected Sub ASPxGridView1_BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
        If (Not gridView.IsEditing) AndAlso (Not gridView.IsNewRowEditing) Then
            gridView.AddNewRow()
        End If
    End Sub
    Protected Sub gridView_RowDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs)

    End Sub
    Protected Sub gridView_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)

    End Sub


    'Database update is not allowed in online demos
    Private Sub DisableUpdateInDemo()
        AddHandler AccessDataSource1.Updating, AddressOf AccessDataSource1_Cancel
        AddHandler AccessDataSource1.Inserting, AddressOf AccessDataSource1_Cancel
        AddHandler AccessDataSource1.Deleting, AddressOf AccessDataSource1_Cancel
    End Sub

    Private Sub AccessDataSource1_Cancel(ByVal sender As Object, ByVal e As SqlDataSourceCommandEventArgs)
        e.Cancel = True
    End Sub
End Class
