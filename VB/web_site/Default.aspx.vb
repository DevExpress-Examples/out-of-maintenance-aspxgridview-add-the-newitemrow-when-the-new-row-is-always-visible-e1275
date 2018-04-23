Imports Microsoft.VisualBasic
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
		If (Not IsPostBack) Then
			gridView.AddNewRow()
		End If
	End Sub
	Protected Sub ASPxGridView1_BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
		If (Not gridView.IsEditing) AndAlso (Not gridView.IsNewRowEditing) Then
			gridView.AddNewRow()
		End If
	End Sub
End Class
