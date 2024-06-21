namespace TodoApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textTask = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.listTasks = new System.Windows.Forms.ListBox();
			this.completeBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textTask
			// 
			this.textTask.Location = new System.Drawing.Point(63, 44);
			this.textTask.Name = "textTask";
			this.textTask.Size = new System.Drawing.Size(237, 20);
			this.textTask.TabIndex = 0;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(360, 44);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 1;
			this.addBtn.Text = "Add Task";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// listTasks
			// 
			this.listTasks.FormattingEnabled = true;
			this.listTasks.Location = new System.Drawing.Point(63, 123);
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(237, 95);
			this.listTasks.TabIndex = 2;
			// 
			// completeBtn
			// 
			this.completeBtn.Location = new System.Drawing.Point(360, 123);
			this.completeBtn.Name = "completeBtn";
			this.completeBtn.Size = new System.Drawing.Size(75, 34);
			this.completeBtn.TabIndex = 3;
			this.completeBtn.Text = "Completed";
			this.completeBtn.UseVisualStyleBackColor = true;
			this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(360, 183);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 35);
			this.deleteBtn.TabIndex = 4;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 388);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.completeBtn);
			this.Controls.Add(this.listTasks);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.textTask);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textTask;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.ListBox listTasks;
		private System.Windows.Forms.Button completeBtn;
		private System.Windows.Forms.Button deleteBtn;
	}
}

