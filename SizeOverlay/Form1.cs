﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeOverlay
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			label1.Text = string.Format("{0:###0} x {1:##0}", panel1.Width, panel1.Height);

		}
	}
}
