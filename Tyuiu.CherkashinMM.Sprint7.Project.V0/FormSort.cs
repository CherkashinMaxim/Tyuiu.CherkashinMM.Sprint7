using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    public partial class FormSort : Form
    {
        public string SelectedColumn { get; private set; }
        public string SortOrder { get; private set; }

        public FormSort()
        {
            InitializeComponent();
            comboBoxOrder_CMM.SelectedIndex = 0;
            comboBoxSort_CMM.SelectedIndex = 0;
        }

        private void buttonDone_CMM_Click(object sender, EventArgs e)
        {
            SortOrder = comboBoxOrder_CMM.SelectedItem?.ToString();
            SelectedColumn = comboBoxSort_CMM.SelectedItem?.ToString();

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
