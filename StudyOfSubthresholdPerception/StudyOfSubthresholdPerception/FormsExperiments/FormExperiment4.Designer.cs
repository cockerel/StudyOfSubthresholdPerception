namespace StudyOfSubthresholdPerception.FormsExperiments
{
    partial class FormExperiment4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment4));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.panelMain = new System.Windows.Forms.Panel();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelNumSampleTest = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelNumTest = new System.Windows.Forms.Label();
			this.labelNum = new System.Windows.Forms.Label();
			this.labelExp = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonFinish = new System.Windows.Forms.Button();
			this.buttonNext = new System.Windows.Forms.Button();
			this.panelMain.SuspendLayout();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.tabPageEX3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.tabControlEX1);
			this.panelMain.Controls.Add(this.buttonFinish);
			this.panelMain.Controls.Add(this.buttonNext);
			this.panelMain.Location = new System.Drawing.Point(12, 12);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(738, 756);
			this.panelMain.TabIndex = 5;
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.BackColor = System.Drawing.Color.White;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.FlatBorderColor = System.Drawing.Color.White;
			this.tabControlEX1.HotColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabControlEX1.Location = new System.Drawing.Point(3, 0);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 2;
			this.tabControlEX1.Size = new System.Drawing.Size(707, 720);
			this.tabControlEX1.TabIndex = 2;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(699, 643);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Инструкция";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(644, 537);
			this.label2.TabIndex = 4;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageEX2.Controls.Add(this.panel2);
			this.tabPageEX2.Enabled = false;
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(699, 691);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Тренеровочная серия";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.labelNumSampleTest);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Location = new System.Drawing.Point(17, 11);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(661, 666);
			this.panel2.TabIndex = 3;
			// 
			// labelNumSampleTest
			// 
			this.labelNumSampleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNumSampleTest.Location = new System.Drawing.Point(173, 127);
			this.labelNumSampleTest.Name = "labelNumSampleTest";
			this.labelNumSampleTest.Size = new System.Drawing.Size(306, 23);
			this.labelNumSampleTest.TabIndex = 4;
			this.labelNumSampleTest.Text = "Предъявление 1 из 10";
			this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(182, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 139);
			this.label1.TabIndex = 3;
			this.label1.Text = "Нажмите закончить эксперимент";
			this.label1.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox3.Location = new System.Drawing.Point(401, 200);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 200);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox4.Location = new System.Drawing.Point(51, 200);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(200, 200);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageEX3.Controls.Add(this.panel1);
			this.tabPageEX3.Enabled = false;
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(699, 691);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Основная часть эксперимента";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.labelNumTest);
			this.panel1.Controls.Add(this.labelNum);
			this.panel1.Controls.Add(this.labelExp);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(19, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(661, 666);
			this.panel1.TabIndex = 2;
			// 
			// labelNumTest
			// 
			this.labelNumTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNumTest.Location = new System.Drawing.Point(178, 75);
			this.labelNumTest.Name = "labelNumTest";
			this.labelNumTest.Size = new System.Drawing.Size(306, 23);
			this.labelNumTest.TabIndex = 8;
			this.labelNumTest.Text = "Опыт 1 из n";
			this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNum
			// 
			this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNum.Location = new System.Drawing.Point(178, 115);
			this.labelNum.Name = "labelNum";
			this.labelNum.Size = new System.Drawing.Size(306, 23);
			this.labelNum.TabIndex = 7;
			this.labelNum.Text = "Предъявление 1 из n";
			this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelExp
			// 
			this.labelExp.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExp.Location = new System.Drawing.Point(175, 213);
			this.labelExp.Name = "labelExp";
			this.labelExp.Size = new System.Drawing.Size(314, 139);
			this.labelExp.TabIndex = 2;
			this.labelExp.Text = "Нажмите далее для старта следующего эксперимента";
			this.labelExp.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox2.Location = new System.Drawing.Point(395, 200);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 200);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox1.Location = new System.Drawing.Point(49, 200);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// buttonFinish
			// 
			this.buttonFinish.Location = new System.Drawing.Point(391, 726);
			this.buttonFinish.Name = "buttonFinish";
			this.buttonFinish.Size = new System.Drawing.Size(210, 30);
			this.buttonFinish.TabIndex = 4;
			this.buttonFinish.Text = "Закончить тренировочную серию";
			this.buttonFinish.UseVisualStyleBackColor = true;
			this.buttonFinish.Visible = false;
			this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
			// 
			// buttonNext
			// 
			this.buttonNext.Location = new System.Drawing.Point(609, 726);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(100, 30);
			this.buttonNext.TabIndex = 3;
			this.buttonNext.Text = "Далее";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// FormExperiment4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 772);
			this.Controls.Add(this.panelMain);
			this.Name = "FormExperiment4";
			this.Text = "Эксперимент 4";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormExperiment2_Load);
			this.SizeChanged += new System.EventHandler(this.FormExperiment4_SizeChanged);
			this.panelMain.ResumeLayout(false);
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.tabPageEX3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panelMain;
        private Dotnetrix.Controls.TabControlEX tabControlEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Dotnetrix.Controls.TabPageEX tabPageEX3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelNumSampleTest;
		private System.Windows.Forms.Label labelNumTest;
		private System.Windows.Forms.Label labelNum;

    }
}