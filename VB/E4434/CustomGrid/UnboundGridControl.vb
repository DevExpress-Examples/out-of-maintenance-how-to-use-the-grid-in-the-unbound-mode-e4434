Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports System.ComponentModel

Namespace CustomGrid.CustomGrid
	Public Class UnboundGridControl
		Inherits GridControl
		Public Sub New()
			Me.DataSource = New UnboundDataSource()
		End Sub

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("UnboundGridView")
		End Function

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New UnboundGridViewInfoRegistrator())
		End Sub

		<Browsable(False)> _
		Public Shadows Property DataSource() As UnboundDataSource
			Get
				Return TryCast(MyBase.DataSource, UnboundDataSource)
			End Get
			Set(ByVal value As UnboundDataSource)
				MyBase.DataSource = value
			End Set
		End Property
	End Class
End Namespace
