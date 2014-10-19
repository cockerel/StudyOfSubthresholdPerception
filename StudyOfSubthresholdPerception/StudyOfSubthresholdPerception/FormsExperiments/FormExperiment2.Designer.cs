namespace StudyOfSubthresholdPerception.FormsExperiments
{
    partial class FormExperiment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabControlEx3 = new Dotnetrix.Controls.TabControlEX();
            this.tabPage3 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNumTest = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new Dotnetrix.Controls.TabPageEX();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumSampleTest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlEx3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(583, 504);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(191, 34);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Закончить тренировочную серию";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Visible = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(780, 504);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(105, 34);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // tabControlEx3
            // 
            this.tabControlEx3.Controls.Add(this.tabPage3);
            this.tabControlEx3.Controls.Add(this.tabPage1);
            this.tabControlEx3.Controls.Add(this.tabPage2);
            this.tabControlEx3.Location = new System.Drawing.Point(11, 6);
            this.tabControlEx3.Name = "tabControlEx3";
            this.tabControlEx3.SelectedIndex = 2;
            this.tabControlEx3.Size = new System.Drawing.Size(874, 496);
            this.tabControlEx3.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.labelNumTest);
            this.tabPage3.Controls.Add(this.labelNum);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(866, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Основная часть эксперимента";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(202, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 292);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(202, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 292);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // labelNumTest
            // 
            this.labelNumTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTest.Location = new System.Drawing.Point(224, 22);
            this.labelNumTest.Name = "labelNumTest";
            this.labelNumTest.Size = new System.Drawing.Size(306, 23);
            this.labelNumTest.TabIndex = 10;
            this.labelNumTest.Text = "Опыт 1 из n";
            this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(224, 62);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(306, 23);
            this.labelNum.TabIndex = 9;
            this.labelNum.Text = "Предъявление 1 из n";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(483, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инструкция";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(798, 460);
            this.label8.TabIndex = 5;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(866, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тренировочная серия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 292);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumSampleTest
            // 
            this.labelNumSampleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSampleTest.Location = new System.Drawing.Point(230, 19);
            this.labelNumSampleTest.Name = "labelNumSampleTest";
            this.labelNumSampleTest.Size = new System.Drawing.Size(306, 23);
            this.labelNumSampleTest.TabIndex = 6;
            this.labelNumSampleTest.Text = "Предъявление 1 из 10";
            this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(483, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 84);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(119, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 84);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlEx3);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.buttonFinish);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(903, 562);
            this.panelMain.TabIndex = 6;
            // 
            // FormExperiment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 574);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExperiment2";
            this.Text = "Эксперимент 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExperiment2_Load);
            this.SizeChanged += new System.EventHandler(this.FormExperiment2_SizeChanged);
            this.tabControlEx3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelNumSampleTest;
		private System.Windows.Forms.Label labelNumTest;
		private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}