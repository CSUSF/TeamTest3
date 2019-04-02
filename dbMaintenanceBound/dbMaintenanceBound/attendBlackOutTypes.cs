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
    public partial class attendBlackOutTypes : Form
    {
        public attendBlackOutTypes()
        {
            InitializeComponent();
        }

        private void attendBlackOutTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendBlackOutTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendanceDataSet);

        }

        private void attendBlackOutTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.attendBlackOutTypes' table. You can move, or remove it, as needed.
            this.attendBlackOutTypesTableAdapter.Fill(this.attendanceDataSet.attendBlackOutTypes);

        }
    }
}
