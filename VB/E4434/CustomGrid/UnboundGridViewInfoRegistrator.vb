Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator

Namespace CustomGrid.CustomGrid
	Public Class UnboundGridViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "UnboundGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New UnboundGridView(TryCast(grid, GridControl))
		End Function
	End Class
End Namespace
