﻿namespace StudyOfSubthresholdPerception.FormsExperiments
{
    partial class FormExperiment3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabControlEx3 = new Dotnetrix.Controls.TabControlEX();
            this.tabPage1 = new Dotnetrix.Controls.TabPageEX();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tabPage2 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumSampleTest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNumTest = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControlEx3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinish.Location = new System.Drawing.Point(501, 605);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(250, 30);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Закончить тренировочную серию";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Visible = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(757, 605);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 30);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // tabControlEx3
            // 
            this.tabControlEx3.Controls.Add(this.tabPage1);
            this.tabControlEx3.Controls.Add(this.tabPage2);
            this.tabControlEx3.Controls.Add(this.tabPage3);
            this.tabControlEx3.Location = new System.Drawing.Point(3, 3);
            this.tabControlEx3.Name = "tabControlEx3";
            this.tabControlEx3.SelectedIndex = 2;
            this.tabControlEx3.Size = new System.Drawing.Size(854, 596);
            this.tabControlEx3.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инструкция";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(8, 4);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(834, 547);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "\r\n      На экране дисплея Вам будут последовательно предъявляться пары слов. В ка" +
    "ждой паре необходимо выбрать наиболее понравившееся слово и указать его щелчком " +
    "левой кнопкой мыши.";
            this.labelDescription.UseCompatibleTextRendering = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.labelNumSampleTest);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тренировочная серия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBox1.Location = new System.Drawing.Point(264, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelNumSampleTest
            // 
            this.labelNumSampleTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSampleTest.Location = new System.Drawing.Point(264, 10);
            this.labelNumSampleTest.Name = "labelNumSampleTest";
            this.labelNumSampleTest.Size = new System.Drawing.Size(360, 41);
            this.labelNumSampleTest.TabIndex = 6;
            this.labelNumSampleTest.Text = "Стимул 1 из 10";
            this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(444, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 100);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(435, 100);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.labelNumTest);
            this.tabPage3.Controls.Add(this.labelNum);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Основная часть эксперимента";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBox3.Location = new System.Drawing.Point(264, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 360);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // labelNumTest
            // 
            this.labelNumTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTest.Location = new System.Drawing.Point(264, 10);
            this.labelNumTest.Name = "labelNumTest";
            this.labelNumTest.Size = new System.Drawing.Size(360, 41);
            this.labelNumTest.TabIndex = 10;
            this.labelNumTest.Text = "Опыт 1 из n";
            this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(264, 48);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(360, 41);
            this.labelNum.TabIndex = 9;
            this.labelNum.Text = "Стимул 1 из n";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 53F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(264, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(444, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlEx3);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.buttonFinish);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(860, 638);
            this.panelMain.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FormExperiment3
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(885, 680);
            this.Name = "FormExperiment3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эксперимент 2. Исследование механизмов осознания подпороговых стимулов.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExperiment3_Load);
            this.SizeChanged += new System.EventHandler(this.FormExperiment3_SizeChanged);
            this.tabControlEx3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private Dotnetrix.Controls.TabControlEX tabControlEx3;
        private Dotnetrix.Controls.TabPageEX tabPage1;
        private Dotnetrix.Controls.TabPageEX tabPage2;
        private Dotnetrix.Controls.TabPageEX tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label labelNumSampleTest;
		private System.Windows.Forms.Label labelNumTest;
		private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label4;
    }
}