﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// comment for login form
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /// comment for login form
        }
       public string formatStr(string str){
           if( !string.isNullOrEmty(str)){
           return "";
           }
           return str + "-test";
       }
    }
}
