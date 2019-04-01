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

namespace time
{
    public partial class Form1 : Form
    {
        private object DelayThreadExecution;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => DelayThread());
            task.Start();
            DelayThreadExecution.Enabled = true;
            print.Enabled = true;

        }

        private void print_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 5; i++)
                richTextBox1.Text(i.ToString());
        }

        private void DelayThread()
        {
           Thread.Sleep(5000);
        }
    }
}
