using System;
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
			t.mode = !radioButtonSi.Checked;
		}

		private void radioButtonGe_CheckedChanged(object sender, EventArgs e)
		{
			t.mode = radioButtonGe.Checked;
		}

		private void textBoxBV_TextChanged(object sender, EventArgs e)
		{
			try 
			{	        
				t.b.v = Convert.ToDouble(textBoxBV.Text);
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
				t.c.v = Convert.ToDouble(textBoxCV.Text);
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
				t.e.v = Convert.ToDouble(textBoxEV.Text);
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
				t.beta = Convert.ToDouble(textBoxBeta.Text);
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
				t.b.r = Convert.ToDouble(textBoxBR.Text);
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
				t.c.r = Convert.ToDouble(textBoxCR.Text);
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
				t.e.r = Convert.ToDouble(textBoxER.Text);
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
						w.WriteLine(Convert.ToDouble(Convert.ToDouble(t.mode)));
						w.WriteLine(t.beta);
						w.WriteLine(t.b.v);
						w.WriteLine(t.b.r); 
						w.WriteLine(t.c.v);
						w.WriteLine(t.c.r); 
						w.WriteLine(t.e.v);
						w.WriteLine(t.e.r);
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
		public double v = 0;
		public double r = 0;
		public Node() { }
	}

	public class Transistor
	{
		public const bool SI = false;
		public const bool GE = true;

		public bool mode = SI;
		public double beta = 1.0;
		public Node b,
			c,
			e;
		public Transistor()
		{
			b = new Node();
			c = new Node();
			e = new Node();
		}

		public String isAmplification()
		{
			if ((mode == SI && b.v > e.v && c.v > e.v)
				|| (mode == GE && b.v < e.v && c.v < e.v))
			{
				if ((Math.Abs(b.v - e.v) - 0.7) * (beta * c.r + (beta + 1) * e.r)
					/ (b.r + (beta + 1) * e.r) <= Math.Abs(c.v - e.v))
				{
					return "Amplification";
				}
				else return "Saturation";
			}
			else if ((mode == SI && b.v < e.v && c.v < e.v)
				|| (mode == GE && b.v > e.v && c.v > e.v))
			{ return "Invertion"; }
			else { return "Cut-off"; }
		}
	}

}
