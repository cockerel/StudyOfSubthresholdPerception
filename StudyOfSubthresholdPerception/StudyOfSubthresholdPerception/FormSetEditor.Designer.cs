namespace StudyOfSubthresholdPerception
{
    partial class FormSetEditor
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewExperiment1 = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Anagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewExperiment4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewExperiment5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.orderEx4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp4Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp4Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 389);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewExperiment1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Эксперимент 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExperiment1
            // 
            this.dataGridViewExperiment1.AllowUserToAddRows = false;
            this.dataGridViewExperiment1.AllowUserToDeleteRows = false;
            this.dataGridViewExperiment1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperiment1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Id,
            this.Image,
            this.Anagram,
            this.Answer1,
            this.Answer2});
            this.dataGridViewExperiment1.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewExperiment1.Name = "dataGridViewExperiment1";
            this.dataGridViewExperiment1.ReadOnly = true;
            this.dataGridViewExperiment1.RowHeadersVisible = false;
            this.dataGridViewExperiment1.RowTemplate.Height = 200;
            this.dataGridViewExperiment1.Size = new System.Drawing.Size(580, 351);
            this.dataGridViewExperiment1.TabIndex = 2;
            // 
            // Position
            // 
            this.Position.HeaderText = "№";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.HeaderText = "Изображение";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Anagram
            // 
            this.Anagram.HeaderText = "Анаграмма";
            this.Anagram.Name = "Anagram";
            this.Anagram.ReadOnly = true;
            this.Anagram.Width = 80;
            // 
            // Answer1
            // 
            this.Answer1.HeaderText = "Ответ 1";
            this.Answer1.Name = "Answer1";
            this.Answer1.ReadOnly = true;
            this.Answer1.Width = 80;
            // 
            // Answer2
            // 
            this.Answer2.HeaderText = "Ответ 2";
            this.Answer2.Name = "Answer2";
            this.Answer2.ReadOnly = true;
            this.Answer2.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Эксперимент 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Эксперимент 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewExperiment4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(592, 363);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Эксперимент 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExperiment4
            // 
            this.dataGridViewExperiment4.AllowUserToAddRows = false;
            this.dataGridViewExperiment4.AllowUserToDeleteRows = false;
            this.dataGridViewExperiment4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperiment4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderEx4,
            this.Exp4Id,
            this.Exp4Img});
            this.dataGridViewExperiment4.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewExperiment4.Name = "dataGridViewExperiment4";
            this.dataGridViewExperiment4.ReadOnly = true;
            this.dataGridViewExperiment4.RowHeadersVisible = false;
            this.dataGridViewExperiment4.RowTemplate.Height = 200;
            this.dataGridViewExperiment4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExperiment4.Size = new System.Drawing.Size(580, 357);
            this.dataGridViewExperiment4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewExperiment5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(592, 363);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Эксперимент 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExperiment5
            // 
            this.dataGridViewExperiment5.AllowUserToAddRows = false;
            this.dataGridViewExperiment5.AllowUserToDeleteRows = false;
            this.dataGridViewExperiment5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperiment5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewExperiment5.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewExperiment5.Name = "dataGridViewExperiment5";
            this.dataGridViewExperiment5.ReadOnly = true;
            this.dataGridViewExperiment5.RowHeadersVisible = false;
            this.dataGridViewExperiment5.RowTemplate.Height = 200;
            this.dataGridViewExperiment5.Size = new System.Drawing.Size(580, 351);
            this.dataGridViewExperiment5.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Нейтральное изображение";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Позитивное изображение";
            this.dataGridViewTextBoxColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Негативное изображение";
            this.dataGridViewTextBoxColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(537, 407);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 407);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // orderEx4
            // 
            this.orderEx4.HeaderText = "№";
            this.orderEx4.Name = "orderEx4";
            this.orderEx4.ReadOnly = true;
            // 
            // Exp4Id
            // 
            this.Exp4Id.HeaderText = "Id";
            this.Exp4Id.Name = "Exp4Id";
            this.Exp4Id.ReadOnly = true;
            // 
            // Exp4Img
            // 
            this.Exp4Img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exp4Img.HeaderText = "Изображение";
            this.Exp4Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Exp4Img.Name = "Exp4Img";
            this.Exp4Img.ReadOnly = true;
            this.Exp4Img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Exp4Img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSetEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор набора стимулов";
            this.Load += new System.EventHandler(this.FormSetEditor_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiment5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewExperiment1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewExperiment5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer2;
        private System.Windows.Forms.DataGridView dataGridViewExperiment4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderEx4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp4Id;
        private System.Windows.Forms.DataGridViewImageColumn Exp4Img;
    }
}