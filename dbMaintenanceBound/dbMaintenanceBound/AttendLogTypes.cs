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
    public partial class AttendLogTypes : Form
    {
        public AttendLogTypes()
        {
            InitializeComponent();
        }

        private void attendLogTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendLogTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendanceDataSet);

        }

        private void AttendLogTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.attendLogTypes' table. You can move, or remove it, as needed.
            this.attendLogTypesTableAdapter.Fill(this.attendanceDataSet.attendLogTypes);

        }
    }
}
