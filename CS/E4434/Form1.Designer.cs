namespace E4434 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.unboundGridControl1 = new CustomGrid.CustomGrid.UnboundGridControl();
            this.unboundGridView1 = new CustomGrid.CustomGrid.UnboundGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unboundGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // unboundGridControl1
            // 
            this.unboundGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unboundGridControl1.Location = new System.Drawing.Point(0, 0);
            this.unboundGridControl1.MainView = this.unboundGridView1;
            this.unboundGridControl1.Name = "unboundGridControl1";
            this.unboundGridControl1.Size = new System.Drawing.Size(527, 399);
            this.unboundGridControl1.TabIndex = 0;
            this.unboundGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.unboundGridView1});
            // 
            // unboundGridView1
            // 
            this.unboundGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.unboundGridView1.GridControl = this.unboundGridControl1;
            this.unboundGridView1.Name = "unboundGridView1";
            this.unboundGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "String";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Int";
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Date";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 399);
            this.Controls.Add(this.unboundGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.unboundGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGrid.CustomGrid.UnboundGridControl unboundGridControl1;
        private CustomGrid.CustomGrid.UnboundGridView unboundGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;


    }
}

