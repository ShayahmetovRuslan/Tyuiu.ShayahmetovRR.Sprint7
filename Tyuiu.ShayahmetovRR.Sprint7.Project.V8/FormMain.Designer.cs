namespace Tyuiu.ShayahmetovRR.Sprint7.Project.V8
{
	partial class FormMain
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

		private void InitializeComponent()
		{
			this.dataGridViewDataBase_SRR = new System.Windows.Forms.DataGridView();
			this.buttonOpenFile_SRR = new System.Windows.Forms.Button();
			this.openFileDialogDatabase_SRR = new System.Windows.Forms.OpenFileDialog();
			this.textBoxSearch_SRR = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_SRR)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewDataBase_SRR
			// 
			this.dataGridViewDataBase_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDataBase_SRR.Location = new System.Drawing.Point(99, 106);
			this.dataGridViewDataBase_SRR.Name = "dataGridViewDataBase_SRR";
			this.dataGridViewDataBase_SRR.Size = new System.Drawing.Size(635, 326);
			this.dataGridViewDataBase_SRR.TabIndex = 0;
			// 
			// buttonOpenFile_SRR
			// 
			this.buttonOpenFile_SRR.Location = new System.Drawing.Point(99, 77);
			this.buttonOpenFile_SRR.Name = "buttonOpenFile_SRR";
			this.buttonOpenFile_SRR.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenFile_SRR.TabIndex = 1;
			this.buttonOpenFile_SRR.Text = "Open";
			this.buttonOpenFile_SRR.UseVisualStyleBackColor = true;
			this.buttonOpenFile_SRR.Click += new System.EventHandler(this.buttonOpenFile_SRR_Click);
			// 
			// openFileDialogDatabase_SRR
			// 
			this.openFileDialogDatabase_SRR.FileName = "openFileDialogDatabase_SRR";
			// 
			// textBoxSearch_SRR
			// 
			this.textBoxSearch_SRR.Location = new System.Drawing.Point(181, 77);
			this.textBoxSearch_SRR.Name = "textBoxSearch_SRR";
			this.textBoxSearch_SRR.Size = new System.Drawing.Size(553, 20);
			this.textBoxSearch_SRR.TabIndex = 2;
			this.textBoxSearch_SRR.TextChanged += new System.EventHandler(this.textBoxSearch_SRR_TextChanged_1);
			// 
			// FormMain
			// 
			this.ClientSize = new System.Drawing.Size(903, 508);
			this.Controls.Add(this.textBoxSearch_SRR);
			this.Controls.Add(this.buttonOpenFile_SRR);
			this.Controls.Add(this.dataGridViewDataBase_SRR);
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_SRR)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.DataGridView dataGridViewDataBase_SRR;
		private System.Windows.Forms.Button buttonOpenFile_SRR;
		private System.Windows.Forms.OpenFileDialog openFileDialogDatabase_SRR;
		private System.Windows.Forms.TextBox textBoxSearch_SRR;
	}
}

