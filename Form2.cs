﻿using System;
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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();

        public static Form2 instance;
        public TextBox tbx1;
        
        public Form2()
        {
            InitializeComponent();
            instance = this;
            tbx1 = tbx_form2;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
