using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor
{
    public partial class Form1 : Form
    {
        List<Vendor> data = new List<Vendor>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVendorName.Clear();
            txtVendorEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            data.Add(new Vendor { Name=txtVendorName.Text, Email=txtVendorEmail.Text});
            var b = new BindingList<Vendor>(data);
            BindingSource vendorsource = new BindingSource(b,null);
            dataGridView1.DataSource=vendorsource;
            //dataGridView1.DisplayMember = "Name";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vendor vendorToRemove = new Vendor();
            var isfound = false;
            foreach (var vendor in data)
            {
                if (vendor.Name==txtFindVendor.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult==DialogResult.Yes)
                    {
                        vendorToRemove = vendor;
                    }
                }
                isfound = true;
                break;
            }
            data.Remove(vendorToRemove);
            var b = new BindingList<Vendor>(data);
            BindingSource vendorsource = new BindingSource(b, null);
            dataGridView1.DataSource = vendorsource;
            //if ()
            //{
            //    DialogResult dialogResult = MessageBox.Show("Delete", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //}
        }
    }
}
