using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace CustomGrid.CustomGrid {
    public class UnboundGridControl : GridControl {
        public UnboundGridControl() {
            this.DataSource = new UnboundDataSource();
        }

        protected override BaseView CreateDefaultView() {
            return CreateView("UnboundGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new UnboundGridViewInfoRegistrator());
        }

        [Browsable(false)]
        public new UnboundDataSource DataSource {
            get {
                return base.DataSource as UnboundDataSource;
            }
            set {
                base.DataSource = value;
            }
        }
    }
}
