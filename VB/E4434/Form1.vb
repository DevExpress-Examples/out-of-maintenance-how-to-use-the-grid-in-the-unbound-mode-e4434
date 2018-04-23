Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace E4434
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddRows(5)
		End Sub

		Private Sub AddRows(ByVal rowCount As Integer)
			For i As Integer = 0 To rowCount - 1
				unboundGridView1.AppendRow(New Object() { String.Format("String {0}", i), i, DateTime.Today.AddDays(i) })
			Next i
		End Sub
	End Class
End Namespace
