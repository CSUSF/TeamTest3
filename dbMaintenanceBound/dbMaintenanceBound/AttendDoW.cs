using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbMaintenanceBound
{
    public partial class AttendDoW : Form
    {
        public AttendDoW()
        {
            InitializeComponent();
        }

        private void attendDoWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendDoWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendanceDataSet);

        }

        private void AttendDoW_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.attendDoW' table. You can move, or remove it, as needed.
            this.attendDoWTableAdapter.Fill(this.attendanceDataSet.attendDoW);

        }
    }
}
