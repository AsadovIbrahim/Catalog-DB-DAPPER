using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Catalog_WinForm
{
    public partial class productForm : Form
    {
        public int ProductID { get; set; }
        public string ProductNamee
        {
            get { return productNameTxtBox.Text; }
            set { productNameTxtBox.Text = value; }
        }

        public string Origin
        {
            get { return originTxtBox.Text; }
            set { originTxtBox.Text = value; }
        }

        public decimal ProductCost
        {
            get
            {
                if (decimal.TryParse(productCostTxtBox.Text, out decimal cost))
                    return cost;
                else
                    return 0;
            }
            set { productCostTxtBox.Text = value.ToString(); }
        }

        public productForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(productNameTxtBox.Text!="" && originTxtBox.Text!="" && productCostTxtBox.Text!="" ) {
            
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Blanks!","Fill All Blanks",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
