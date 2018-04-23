Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel

Namespace CustomGrid.CustomGrid
	Public Class UnboundGridView
		Inherits GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			AddHandler Me.CustomUnboundColumnData, AddressOf UnboundGridView_CustomUnboundColumnData
		End Sub

		Private Sub UnboundGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
			If e.IsGetData Then
				e.Value = GridControl.DataSource.GetValue(e.ListSourceRowIndex, e.Column.AbsoluteIndex)
			Else
				GridControl.DataSource.SetValue(e.ListSourceRowIndex, e.Column.AbsoluteIndex, e.Value)
			End If
		End Sub

		Public Sub AppendRow(ByVal rowData() As Object)
			GridControl.DataSource.AddRow(rowData)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "UnboundGridView"
			End Get
		End Property

		<Browsable(False)> _
		Public Shadows Property GridControl() As UnboundGridControl
			Get
				Return TryCast(MyBase.GridControl, UnboundGridControl)
			End Get
			Set(ByVal value As UnboundGridControl)
				MyBase.GridControl = value
			End Set
		End Property

		Public Overrides Sub AddNewRow()
			MyBase.AddNewRow()
		End Sub
	End Class
End Namespace
