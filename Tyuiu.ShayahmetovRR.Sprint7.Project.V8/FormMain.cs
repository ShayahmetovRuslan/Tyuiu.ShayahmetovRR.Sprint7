using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShayahmetovRR.Sprint7.Project.V8
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		static string openFilePath;
		static int column;

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
		{
			openFileDialogDatabase_SRR.ShowDialog();
			openFilePath = openFileDialogDatabase_SRR.FileName;
			column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;

			dataGridViewDataBase_SRR.ColumnCount = column;
			using (var reader = new StreamReader(openFilePath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(',');

					dataGridViewDataBase_SRR.Rows.Add(values);
				}
			}
		}

		private void textBoxSearch_SRR_TextChanged_1(object sender, EventArgs e)
		{
			string searchValue = textBoxSearch_SRR.Text.ToLower();

			foreach (DataGridViewRow row in dataGridViewDataBase_SRR.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
					{
						cell.Style.BackColor = Color.Yellow; // Цвет подсветки найденной ячейки
					}
					else
					{
						cell.Style.BackColor = Color.White; // Возврат цвета по умолчанию
					}
				}
			}
		}
	}
}
