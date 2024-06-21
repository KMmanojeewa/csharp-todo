using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(textTask.Text))
			{
				listTasks.Items.Add(textTask.Text);
				textTask.Clear();
			} else
			{
				MessageBox.Show("Task cannot be empty.");
			}
		}

		private void completeBtn_Click(object sender, EventArgs e)
		{
			if(listTasks.SelectedItem != null)
			{
				int selectedIndex = listTasks.SelectedIndex;
				string selectedTask = listTasks.SelectedItem.ToString();
				listTasks.Items[selectedIndex] = $"{selectedTask} (Completed)";
			} else
			{
				MessageBox.Show("Please select a task.");
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if(listTasks.SelectedItem != null)
			{
				listTasks.Items.Remove(listTasks.SelectedItem);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadTasks();
		}

		private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
		{
			SaveTasks();
		}

		private void SaveTasks()
		{
			using (StreamWriter writer = new StreamWriter("tasks.txt"))
			{
				foreach (var item in listTasks.Items)
				{
					writer.WriteLine(item.ToString());
				}
			}
		}

		private void LoadTasks()
		{
			if (File.Exists("tasks.txt"))
			{
				using (StreamReader reader = new StreamReader("tasks.txt"))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						listTasks.Items.Add(line);
					}
				}
			}
		}



	}
}
