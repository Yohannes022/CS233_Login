using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string paswd = "123";

            Form2 form2 = new Form2();
            ErrorProvider erp = new ErrorProvider();

            if (string.IsNullOrEmpty(tbx_name.Text) && string.IsNullOrEmpty(tbx_paswd.Text))
            {
                erp.SetError(tbx_name, Name);
                erp.SetError(tbx_paswd, paswd);
            }
            else
            {
                if (!string.Equals(paswd, tbx_paswd.Text))
                {
                    erp.SetError(tbx_paswd, "Wrong Password!");
                }                 
                else
                {
                    this.Hide();
                    form2.Show();
                    Form2.instance.tbx1.Text = "Hello, " + tbx_name.Text;
                }
                                   
            }               
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
