﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experimac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (usuario == null)
            {
                var login = new Experimac.Views.Login();
                this.Hide();
                login.ShowDialog();
                if (usuario != null)
                {
                    this.Show();
                }
                else
                {
                    MessageBox.Show("NECESITA LOGIARSE");
                }
            }
        }
        Experimac.Models.Usuarios usuario = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RBInico_CheckedChanged(object sender, EventArgs e) //handles RBInicio.checkedChanged
        {
            tabControlPrincipal.SelectTab(1);
            //tabControlPrincipal.SelectTab = tabPage1;
            
           // tabpage1.SelectTab=tabPage1;
            //tabControl1.SelectTab = tabPage1;
            //tabPage1.SelectNextControl = tabPage1.Tag.GetType(0);
           // RBInico.Select = RBInico.Select.item(0);

        }
    }
}
