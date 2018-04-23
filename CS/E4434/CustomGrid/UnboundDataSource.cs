using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CustomGrid.CustomGrid {
    public class UnboundDataSource : BindingList<object[]>, ITypedList, IBindingList {
        public UnboundDataSource() {
        }

        public void AddRow(object[] rowData) {
            this.Add(rowData);
        }

        public object GetValue(int rowIndex, int columnIndex) {
            if (rowIndex >= this.Count) {
                return null;
            }
            object[] row = this[rowIndex];
            if (columnIndex >= row.Length) {
                return null;
            }
            return row[columnIndex];
        }

        public void SetValue(int rowIndex, int columnIndex, object value) {
            if (rowIndex >= this.Count) {
                return;
            }
            object[] row = this[rowIndex];
            if (columnIndex >= row.Length) {
                row = new object[columnIndex + 1];
                this[rowIndex].CopyTo(row, 0);
                this[rowIndex] = row;
            }
            row[columnIndex] = value;
        }

        #region ITypedList Members

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) {
            return new PropertyDescriptorCollection(new PropertyDescriptor[0]);
        }

        public string GetListName(PropertyDescriptor[] listAccessors) {
            return this.GetType().Name;
        }

        #endregion

        #region IBindingList Members

        bool IBindingList.AllowNew {
            get {
                return true;
            }
        }

        object IBindingList.AddNew() {
            object[] newRow = new object[0];
            this.Add(newRow);
            return newRow;
        }

        #endregion

    }
}
