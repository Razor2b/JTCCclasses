﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void RBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            var GameWindow = new GameWindow();
            GameWindow.Show();
            //MainWindow.Close();

        }

        private void RBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
