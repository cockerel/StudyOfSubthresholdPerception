namespace StudyOfSubthresholdPerception
{
    partial class FormResults
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
            this.tabControlResults = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewResults1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberExperiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePresentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypedAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coincided = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.tabControlResults.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlResults
            // 
            this.tabControlResults.Controls.Add(this.tabPage1);
            this.tabControlResults.Controls.Add(this.tabPage2);
            this.tabControlResults.Controls.Add(this.tabPage3);
            this.tabControlResults.Controls.Add(this.tabPage4);
            this.tabControlResults.Controls.Add(this.tabPage5);
            this.tabControlResults.Location = new System.Drawing.Point(12, 47);
            this.tabControlResults.Name = "tabControlResults";
            this.tabControlResults.SelectedIndex = 0;
            this.tabControlResults.Size = new System.Drawing.Size(760, 457);
            this.tabControlResults.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewResults1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Эксперимент 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResults1
            // 
            this.dataGridViewResults1.AllowUserToAddRows = false;
            this.dataGridViewResults1.AllowUserToDeleteRows = false;
            this.dataGridViewResults1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Id,
            this.UserId,
            this.NumberExperiment,
            this.TimeMask,
            this.TimePresentation,
            this.DataTime,
            this.Anagram,
            this.CorrectAnswer,
            this.TypedAnswer,
            this.Coincided});
            this.dataGridViewResults1.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewResults1.Name = "dataGridViewResults1";
            this.dataGridViewResults1.ReadOnly = true;
            this.dataGridViewResults1.Size = new System.Drawing.Size(739, 419);
            this.dataGridViewResults1.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id испытуемого";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 50;
            // 
            // NumberExperiment
            // 
            this.NumberExperiment.HeaderText = "Номер эксперимента";
            this.NumberExperiment.Name = "NumberExperiment";
            this.NumberExperiment.ReadOnly = true;
            // 
            // TimeMask
            // 
            this.TimeMask.HeaderText = "Время маски";
            this.TimeMask.Name = "TimeMask";
            this.TimeMask.ReadOnly = true;
            // 
            // TimePresentation
            // 
            this.TimePresentation.HeaderText = "Время предъявления";
            this.TimePresentation.Name = "TimePresentation";
            this.TimePresentation.ReadOnly = true;
            // 
            // DataTime
            // 
            this.DataTime.HeaderText = "Дата и время";
            this.DataTime.Name = "DataTime";
            this.DataTime.ReadOnly = true;
            // 
            // Anagram
            // 
            this.Anagram.HeaderText = "Анаграмма";
            this.Anagram.Name = "Anagram";
            this.Anagram.ReadOnly = true;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.HeaderText = "Правильный ответ";
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.ReadOnly = true;
            // 
            // TypedAnswer
            // 
            this.TypedAnswer.HeaderText = "Введенный ответ";
            this.TypedAnswer.Name = "TypedAnswer";
            this.TypedAnswer.ReadOnly = true;
            // 
            // Coincided
            // 
            this.Coincided.HeaderText = "Совпал";
            this.Coincided.Name = "Coincided";
            this.Coincided.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Эксперимент 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Эксперимент 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(752, 431);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Эксперимент 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 431);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Эксперимент 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(13, 13);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(300, 28);
            this.comboBoxUsers.TabIndex = 1;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Location = new System.Drawing.Point(320, 9);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(452, 35);
            this.labelUserInfo.TabIndex = 2;
            this.labelUserInfo.Text = "label1";
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.Location = new System.Drawing.Point(12, 510);
            this.buttonClearTable.Name = "buttonClearTable";
            this.buttonClearTable.Size = new System.Drawing.Size(180, 40);
            this.buttonClearTable.TabIndex = 3;
            this.buttonClearTable.Text = "Очистить таблицу рерультатов";
            this.buttonClearTable.UseVisualStyleBackColor = true;
            this.buttonClearTable.Click += new System.EventHandler(this.buttonClearTable_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(592, 510);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(180, 40);
            this.buttonSaveToFile.TabIndex = 4;
            this.buttonSaveToFile.Text = "Сохранить данные в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // FormResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonClearTable);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.tabControlResults);
            this.Name = "FormResults";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.FormResults_Load);
            this.tabControlResults.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewResults1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberExperiment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePresentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypedAnswer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Coincided;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}