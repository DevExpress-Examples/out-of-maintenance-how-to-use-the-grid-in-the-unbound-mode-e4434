using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E4434 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            AddRows(5);
        }

        private void AddRows(int rowCount) {
            for (int i = 0; i < rowCount; i++) {
                unboundGridView1.AppendRow(new object[] { string.Format("String {0}", i), i, DateTime.Today.AddDays(i) });
            }
        }
    }
}
