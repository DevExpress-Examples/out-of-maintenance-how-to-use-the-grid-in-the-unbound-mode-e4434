Imports Microsoft.VisualBasic
Imports System
Namespace E4434
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.unboundGridControl1 = New CustomGrid.CustomGrid.UnboundGridControl()
			Me.unboundGridView1 = New CustomGrid.CustomGrid.UnboundGridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.unboundGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unboundGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' unboundGridControl1
			' 
			Me.unboundGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.unboundGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.unboundGridControl1.MainView = Me.unboundGridView1
			Me.unboundGridControl1.Name = "unboundGridControl1"
			Me.unboundGridControl1.Size = New System.Drawing.Size(527, 399)
			Me.unboundGridControl1.TabIndex = 0
			Me.unboundGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.unboundGridView1})
			' 
			' unboundGridView1
			' 
			Me.unboundGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.unboundGridView1.GridControl = Me.unboundGridControl1
			Me.unboundGridView1.Name = "unboundGridView1"
			Me.unboundGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "String"
			Me.gridColumn1.FieldName = "gridColumn1"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Int"
			Me.gridColumn2.FieldName = "gridColumn2"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Date"
			Me.gridColumn3.FieldName = "gridColumn3"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(527, 399)
			Me.Controls.Add(Me.unboundGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.unboundGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unboundGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private unboundGridControl1 As CustomGrid.CustomGrid.UnboundGridControl
		Private unboundGridView1 As CustomGrid.CustomGrid.UnboundGridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn


	End Class
End Namespace

