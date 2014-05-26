namespace StudyOfSubthresholdPerception
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveDB = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonExperiment5 = new System.Windows.Forms.Button();
			this.buttonExperiment4 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonExperiment3 = new System.Windows.Forms.Button();
			this.buttonExperiment2 = new System.Windows.Forms.Button();
			this.buttonExperiment1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonSetting = new System.Windows.Forms.Button();
			this.buttonSetEditor = new System.Windows.Forms.Button();
			this.menuStripMain.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(624, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveDB,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// toolStripMenuItemSaveDB
			// 
			this.toolStripMenuItemSaveDB.Name = "toolStripMenuItemSaveDB";
			this.toolStripMenuItemSaveDB.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItemSaveDB.Text = "Сохранить БД";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItemExit.Text = "Выход";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// инструментыToolStripMenuItem
			// 
			this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
			this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.инструментыToolStripMenuItem.Text = "Инструменты";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.infoToolStripMenuItem.Text = "Справка";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonExperiment5);
			this.groupBox3.Controls.Add(this.buttonExperiment4);
			this.groupBox3.Location = new System.Drawing.Point(12, 332);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(600, 98);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Исследование эмоциональных аспектов";
			// 
			// buttonExperiment5
			// 
			this.buttonExperiment5.Location = new System.Drawing.Point(228, 31);
			this.buttonExperiment5.Name = "buttonExperiment5";
			this.buttonExperiment5.Size = new System.Drawing.Size(144, 47);
			this.buttonExperiment5.TabIndex = 4;
			this.buttonExperiment5.Text = "Эксперимент 5";
			this.buttonExperiment5.UseVisualStyleBackColor = true;
			this.buttonExperiment5.Click += new System.EventHandler(this.buttonExperiment5_Click);
			// 
			// buttonExperiment4
			// 
			this.buttonExperiment4.Location = new System.Drawing.Point(22, 31);
			this.buttonExperiment4.Name = "buttonExperiment4";
			this.buttonExperiment4.Size = new System.Drawing.Size(144, 47);
			this.buttonExperiment4.TabIndex = 3;
			this.buttonExperiment4.Text = "Эксперимент 4";
			this.buttonExperiment4.UseVisualStyleBackColor = true;
			this.buttonExperiment4.Click += new System.EventHandler(this.buttonExperiment4_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonExperiment3);
			this.groupBox2.Controls.Add(this.buttonExperiment2);
			this.groupBox2.Controls.Add(this.buttonExperiment1);
			this.groupBox2.Location = new System.Drawing.Point(12, 190);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(600, 99);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Исследоваие семантических аспектов";
			// 
			// buttonExperiment3
			// 
			this.buttonExperiment3.Location = new System.Drawing.Point(428, 33);
			this.buttonExperiment3.Name = "buttonExperiment3";
			this.buttonExperiment3.Size = new System.Drawing.Size(144, 47);
			this.buttonExperiment3.TabIndex = 2;
			this.buttonExperiment3.Text = "Эксперимент 3";
			this.buttonExperiment3.UseVisualStyleBackColor = true;
			this.buttonExperiment3.Click += new System.EventHandler(this.buttonExperiment3_Click);
			// 
			// buttonExperiment2
			// 
			this.buttonExperiment2.Location = new System.Drawing.Point(228, 33);
			this.buttonExperiment2.Name = "buttonExperiment2";
			this.buttonExperiment2.Size = new System.Drawing.Size(144, 47);
			this.buttonExperiment2.TabIndex = 1;
			this.buttonExperiment2.Text = "Эксперимент 2";
			this.buttonExperiment2.UseVisualStyleBackColor = true;
			this.buttonExperiment2.Click += new System.EventHandler(this.buttonExperiment2_Click);
			// 
			// buttonExperiment1
			// 
			this.buttonExperiment1.Location = new System.Drawing.Point(22, 33);
			this.buttonExperiment1.Name = "buttonExperiment1";
			this.buttonExperiment1.Size = new System.Drawing.Size(144, 47);
			this.buttonExperiment1.TabIndex = 0;
			this.buttonExperiment1.Tag = "";
			this.buttonExperiment1.Text = "Эксперимент 1";
			this.buttonExperiment1.UseMnemonic = false;
			this.buttonExperiment1.UseVisualStyleBackColor = true;
			this.buttonExperiment1.Click += new System.EventHandler(this.buttonExperiment1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.buttonSetting);
			this.groupBox1.Controls.Add(this.buttonSetEditor);
			this.groupBox1.Location = new System.Drawing.Point(12, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 98);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Управление экспериментом";
			this.groupBox1.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(428, 28);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 47);
			this.button3.TabIndex = 2;
			this.button3.Text = "Обработка результатов";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// buttonSetting
			// 
			this.buttonSetting.Location = new System.Drawing.Point(228, 28);
			this.buttonSetting.Name = "buttonSetting";
			this.buttonSetting.Size = new System.Drawing.Size(144, 47);
			this.buttonSetting.TabIndex = 1;
			this.buttonSetting.Text = "Настройки";
			this.buttonSetting.UseVisualStyleBackColor = true;
			this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
			// 
			// buttonSetEditor
			// 
			this.buttonSetEditor.Location = new System.Drawing.Point(22, 28);
			this.buttonSetEditor.Name = "buttonSetEditor";
			this.buttonSetEditor.Size = new System.Drawing.Size(144, 47);
			this.buttonSetEditor.TabIndex = 0;
			this.buttonSetEditor.Text = "Редактор набора стимулов";
			this.buttonSetEditor.UseVisualStyleBackColor = true;
			this.buttonSetEditor.Click += new System.EventHandler(this.buttonSetEditor_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.Text = "Исследование подпорогового восприятия";
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExperiment5;
        private System.Windows.Forms.Button buttonExperiment4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExperiment3;
        private System.Windows.Forms.Button buttonExperiment2;
        private System.Windows.Forms.Button buttonExperiment1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonSetEditor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}