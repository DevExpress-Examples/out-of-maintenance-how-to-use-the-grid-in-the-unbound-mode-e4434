using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;

namespace CustomGrid.CustomGrid {
    public class UnboundGridViewInfoRegistrator : GridInfoRegistrator {
        public override string ViewName {
            get {
                return "UnboundGridView";
            }
        }

        public override BaseView CreateView(GridControl grid) {
            return new UnboundGridView(grid as GridControl);
        }
    }
}
