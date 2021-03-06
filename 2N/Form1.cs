﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2N
{
	public partial class Form2N : Form
	{
		protected Transistor t;
		private AboutBox2N a;
		public Form2N()
		{
			InitializeComponent();
			t = new Transistor();
			a = new AboutBox2N();
		}

		private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
		{
			t.Mode = !radioButtonSi.Checked;
		}

		private void radioButtonGe_CheckedChanged(object sender, EventArgs e)
		{
			t.Mode = radioButtonGe.Checked;
		}

		private void textBoxBV_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.b.V = Convert.ToDouble(textBoxBV.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxBV_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void textBoxCV_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.c.V = Convert.ToDouble(textBoxCV.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxCV_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void textBoxEV_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.e.V = Convert.ToDouble(textBoxEV.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxEV_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void textBoxBeta_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.Beta = Convert.ToDouble(textBoxBeta.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxBeta_TextChanged", MessageBoxButtons.OK);
			}

		}

		private void textBoxBR_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.b.R = Convert.ToDouble(textBoxBR.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxBR_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void textBoxCR_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.c.R = Convert.ToDouble(textBoxCR.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxCR_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void textBoxER_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.e.R = Convert.ToDouble(textBoxER.Text);
			}
			catch (FormatException f)
			{
				MessageBox.Show(f.Message, "textBoxER_TextChanged", MessageBoxButtons.OK);
			}
		}

		private void buttonCal_Click(object sender, EventArgs e)
		{
			labelAns.Text = t.isAmplification();
		}

		private void Form2N_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.O:
					openToolStripMenuItem_Click(sender, e);
					break;

				case Keys.S:
					saveAsToolStripMenuItem_Click(sender, e);
					break;

				default:
					break;
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog2N.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamReader r = new StreamReader(openFileDialog2N.FileName, Encoding.Default))
					{
						// Insert code to read the stream here.
						radioButtonGe.Checked = Convert.ToBoolean(Convert.ToDouble(r.ReadLine()));
						radioButtonSi.Checked = !radioButtonGe.Checked;
						textBoxBeta.Text = r.ReadLine();
						textBoxBV.Text = r.ReadLine();
						textBoxBR.Text = r.ReadLine();
						textBoxCV.Text = r.ReadLine();
						textBoxCR.Text = r.ReadLine();
						textBoxEV.Text = r.ReadLine();
						textBoxER.Text = r.ReadLine();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog2N.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamWriter w = new StreamWriter(saveFileDialog2N.FileName, false, Encoding.Default))
					{
						// Insert code to write the stream here.
						w.WriteLine(Convert.ToDouble(Convert.ToDouble(t.Mode)));
						w.WriteLine(t.Beta);
						w.WriteLine(t.b.V);
						w.WriteLine(t.b.R); 
						w.WriteLine(t.c.V);
						w.WriteLine(t.c.R); 
						w.WriteLine(t.e.V);
						w.WriteLine(t.e.R);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not write file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			a.ShowDialog();
		}

		private void viewHelpContentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fill in the blanks and click the \"Cal\" button for answer.", "2N WMI Doc", MessageBoxButtons.OK);
		}
	}

	public class Node
	{
        private double v = 0;
        private double r = 0;

        public double V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public double R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public Node() { }
	}

	public class Transistor
	{
        private const bool sI = false;
        private const bool gE = true;

        private bool mode = SI;
        private double beta = 1.0;
        public Node b,
			c,
			e;

        public static bool SI
        {
            get
            {
                return sI;
            }
        }

        public static bool GE
        {
            get
            {
                return gE;
            }
        }

        public bool Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        public double Beta
        {
            get
            {
                return beta;
            }

            set
            {
                beta = value;
            }
        }

        public Transistor()
		{
			b = new Node();
			c = new Node();
			e = new Node();
		}

		public String isAmplification()
		{
			if ((Mode == SI && b.V > e.V && c.V > e.V)
				|| (Mode == GE && b.V < e.V && c.V < e.V))
			{
				if ((Math.Abs(b.V - e.V) - 0.7) * (Beta * c.R + (Beta + 1) * e.R)
					/ (b.R + (Beta + 1) * e.R) <= Math.Abs(c.V - e.V))
				{
					return "Amplification";
				}
				else return "Saturation";
			}
			else if ((Mode == SI && b.V < e.V && c.V < e.V)
				|| (Mode == GE && b.V > e.V && c.V > e.V))
			{ return "Invertion"; }
			else { return "Cut-off"; }
		}
	}

}
