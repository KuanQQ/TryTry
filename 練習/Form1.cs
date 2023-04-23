using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 練習
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var student = new Student();
			student.Name = "考試超人";
			student.English = 80;
			student.Chinese = 77;
			student.MathScore = 55;
			textBox1.Text = student.Score();
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
            
        }

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
	}
}
