using System;
using System.Windows.Forms;

namespace DM
{
	enum Methods{
		HalfDivision,
		ChordMethod,
		TangentMethod,
		CombinedMethod
	}
	public partial class Form1 : Form
	{
		double inaccuracy, left, right, result = 0;
		public Form1()
		{
			InitializeComponent();
		}
		double Func(double x) => Math.Sin(x);//Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 11 * x - 6;
		private void button1_Click(object sender, EventArgs e)
		{
			Methods method;
			Enum.TryParse(comboBox1.SelectedItem.ToString(), out method);
			if (
				double.TryParse(dataGridView1.Rows[0].Cells[2].Value.ToString().Replace(".", ","), out inaccuracy) &&
				double.TryParse(dataGridView1.Rows[0].Cells[0].Value.ToString().Replace(".", ","), out left) &&
				double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString().Replace(".", ","), out right) && inaccuracy > 0
			)
			{
				switch (method)
				{
					case Methods.HalfDivision:
						result = RefinementRoots.HalfDivisionMethod(inaccuracy, left, right, Func);
						break;
					case Methods.ChordMethod:
						result = RefinementRoots.ChordMethod(inaccuracy, left, right, Func);
						break;
					case Methods.TangentMethod:
						result = RefinementRoots.TangentMethod(inaccuracy, left, right, Func, 0.01F);
						break;
					case Methods.CombinedMethod:
						result = RefinementRoots.CombinedMethod(inaccuracy, left, right, Func, 0.01F);
						break;
				}
				textBox1.Text = result.ToString();
			}
			else
			{
				MessageBox.Show("Вы Хороший человек, но значения неправильные");
			}

			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach(var i in Enum.GetValues(typeof(Methods)))
			{
				comboBox1.Items.Add(i);
			}
			comboBox1.SelectedIndex = 0;
			dataGridView1.Rows.Add(new DataGridViewRow());
			chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.1;
			chart1.ChartAreas["ChartArea1"].AxisY.Interval = 2;
			chart1.Series["Series1"].BorderWidth = 2;
			
			for (double i = 0; i < 4; i += 0.1)
			{
				chart1.Series["Series1"].Points.AddXY(i, Func(i));
			}
			
			/*Function func = new Function(Func);
			double result = RefinementRoots.HalfDivisionMethod(0.1, 0, 1.5, func);
			Console.WriteLine(result);*/
		}

	}
}
