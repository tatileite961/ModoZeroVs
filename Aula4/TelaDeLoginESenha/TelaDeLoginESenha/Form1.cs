﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TelaDeLoginESenha
{
    public partial class Form1 : Form
    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ana" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt = TryApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
        }

        private Thread TryApartmentState(ApartmentState sTA)
        {
            throw new NotImplementedException();
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
