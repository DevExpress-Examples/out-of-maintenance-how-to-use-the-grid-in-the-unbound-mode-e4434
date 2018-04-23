using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace CustomGrid.CustomGrid {
    public class UnboundGridView : GridView {
        public UnboundGridView()
            : this(null) {
        }

        public UnboundGridView(GridControl grid)
            : base(grid) {
            this.CustomUnboundColumnData += UnboundGridView_CustomUnboundColumnData;
        }

        private void UnboundGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.IsGetData) {
                e.Value = GridControl.DataSource.GetValue(e.ListSourceRowIndex, e.Column.AbsoluteIndex);
            }
            else {
                GridControl.DataSource.SetValue(e.ListSourceRowIndex, e.Column.AbsoluteIndex, e.Value);
            }
        }

        public void AppendRow(object[] rowData) {
            GridControl.DataSource.AddRow(rowData);
        }

        protected override string ViewName {
            get {
                return "UnboundGridView";
            }
        }

        [Browsable(false)]
        public new UnboundGridControl GridControl {
            get {
                return base.GridControl as UnboundGridControl;
            }
            set {
                base.GridControl = value;
            }
        }

        public override void AddNewRow() {
            base.AddNewRow();
        }
    }
}
