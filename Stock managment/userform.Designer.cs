namespace Stock_managment
{
    partial class userform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userform));
            dataGridViewuser = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewuser
            // 
            dataGridViewuser.AllowUserToAddRows = false;
            dataGridViewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewuser.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewuser.Dock = DockStyle.Fill;
            dataGridViewuser.Location = new Point(0, 0);
            dataGridViewuser.Name = "dataGridViewuser";
            dataGridViewuser.RowHeadersWidth = 51;
            dataGridViewuser.RowTemplate.Height = 29;
            dataGridViewuser.Size = new Size(1117, 611);
            dataGridViewuser.TabIndex = 0;
            dataGridViewuser.CellContentClick += dataGridViewuser_CellContentClick_1;
            // 
            // Column7
            // 
            Column7.HeaderText = "No";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "username";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 102;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "fullname";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "phonenumber";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 131;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "password";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 101;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "edit";
            Column5.Image = (Image)resources.GetObject("Column5.Image");
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 41;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "delete";
            Column6.Image = (Image)resources.GetObject("Column6.Image");
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 57;
            // 
            // userform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 611);
            Controls.Add(dataGridViewuser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userform";
            Load += userform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewuser;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}