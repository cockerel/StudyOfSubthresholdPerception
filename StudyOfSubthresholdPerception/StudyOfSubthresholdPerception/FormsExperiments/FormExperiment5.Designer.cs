namespace StudyOfSubthresholdPerception
{
    partial class FormExperiment5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment5));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.tabControl = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScaleTest = new System.Windows.Forms.Label();
            this.trackBarScaleTest = new System.Windows.Forms.TrackBar();
            this.labelNumSampleTest = new System.Windows.Forms.Label();
            this.panelSample = new System.Windows.Forms.Panel();
            this.pictureBoxSample = new System.Windows.Forms.PictureBox();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.labelNumTest = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxPresentation = new System.Windows.Forms.PictureBox();
            this.pictureBoxMask = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleTest)).BeginInit();
            this.panelSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).BeginInit();
            this.tabPageEX3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMask)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonFinish);
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(860, 638);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Enabled = false;
            this.buttonFinish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinish.Location = new System.Drawing.Point(496, 605);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(250, 30);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "Закончить тренировочную серию";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Visible = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.White;
            this.tabControl.Controls.Add(this.tabPageEX1);
            this.tabControl.Controls.Add(this.tabPageEX2);
            this.tabControl.Controls.Add(this.tabPageEX3);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ItemSize = new System.Drawing.Size(280, 21);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(854, 596);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX1.Controls.Add(this.label13);
            this.tabPageEX1.Controls.Add(this.labelDescription);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Инструкция";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(13, 4);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(834, 552);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            this.labelDescription.UseCompatibleTextRendering = true;
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX2.Controls.Add(this.label11);
            this.tabPageEX2.Controls.Add(this.label8);
            this.tabPageEX2.Controls.Add(this.label7);
            this.tabPageEX2.Controls.Add(this.label3);
            this.tabPageEX2.Controls.Add(this.label2);
            this.tabPageEX2.Controls.Add(this.label1);
            this.tabPageEX2.Controls.Add(this.labelScaleTest);
            this.tabPageEX2.Controls.Add(this.trackBarScaleTest);
            this.tabPageEX2.Controls.Add(this.labelNumSampleTest);
            this.tabPageEX2.Controls.Add(this.panelSample);
            this.tabPageEX2.Enabled = false;
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Тренировочная серия";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(271, 541);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Позитивная оценка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Негативная оценка";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(434, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(657, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "100";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(192, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "-100";
            // 
            // labelScaleTest
            // 
            this.labelScaleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScaleTest.Location = new System.Drawing.Point(365, 496);
            this.labelScaleTest.Name = "labelScaleTest";
            this.labelScaleTest.Size = new System.Drawing.Size(309, 35);
            this.labelScaleTest.TabIndex = 4;
            this.labelScaleTest.Text = "Оценка: 0";
            // 
            // trackBarScaleTest
            // 
            this.trackBarScaleTest.Location = new System.Drawing.Point(191, 448);
            this.trackBarScaleTest.Maximum = 100;
            this.trackBarScaleTest.Minimum = -100;
            this.trackBarScaleTest.Name = "trackBarScaleTest";
            this.trackBarScaleTest.Size = new System.Drawing.Size(500, 45);
            this.trackBarScaleTest.TabIndex = 1;
            this.trackBarScaleTest.Scroll += new System.EventHandler(this.trackBarScaleTest_Scroll);
            // 
            // labelNumSampleTest
            // 
            this.labelNumSampleTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSampleTest.Location = new System.Drawing.Point(250, 10);
            this.labelNumSampleTest.Name = "labelNumSampleTest";
            this.labelNumSampleTest.Size = new System.Drawing.Size(400, 41);
            this.labelNumSampleTest.TabIndex = 3;
            this.labelNumSampleTest.Text = "Предъявление 1 из 5";
            this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSample
            // 
            this.panelSample.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSample.Controls.Add(this.pictureBoxSample);
            this.panelSample.Location = new System.Drawing.Point(267, 54);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(360, 360);
            this.panelSample.TabIndex = 2;
            // 
            // pictureBoxSample
            // 
            this.pictureBoxSample.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSample.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxSample.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSample.Name = "pictureBoxSample";
            this.pictureBoxSample.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSample.TabIndex = 0;
            this.pictureBoxSample.TabStop = false;
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX3.Controls.Add(this.label12);
            this.tabPageEX3.Controls.Add(this.label9);
            this.tabPageEX3.Controls.Add(this.label10);
            this.tabPageEX3.Controls.Add(this.label4);
            this.tabPageEX3.Controls.Add(this.label5);
            this.tabPageEX3.Controls.Add(this.label6);
            this.tabPageEX3.Controls.Add(this.labelScale);
            this.tabPageEX3.Controls.Add(this.labelNumTest);
            this.tabPageEX3.Controls.Add(this.labelNum);
            this.tabPageEX3.Controls.Add(this.panel);
            this.tabPageEX3.Controls.Add(this.trackBarScale);
            this.tabPageEX3.Enabled = false;
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Основная часть эксперимента";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(271, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(354, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Позитивная оценка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Негативная оценка";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(438, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(659, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(199, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "-100";
            // 
            // labelScale
            // 
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(365, 502);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(309, 33);
            this.labelScale.TabIndex = 8;
            this.labelScale.Text = "Оценка: 0";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(195, 453);
            this.trackBarScale.Maximum = 100;
            this.trackBarScale.Minimum = -100;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(500, 45);
            this.trackBarScale.TabIndex = 7;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // labelNumTest
            // 
            this.labelNumTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTest.Location = new System.Drawing.Point(250, 8);
            this.labelNumTest.Name = "labelNumTest";
            this.labelNumTest.Size = new System.Drawing.Size(400, 23);
            this.labelNumTest.TabIndex = 6;
            this.labelNumTest.Text = "Опыт 1 из n";
            this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(250, 30);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(400, 25);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "Предъявление 1 из n";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel.Controls.Add(this.pictureBoxPresentation);
            this.panel.Controls.Add(this.pictureBoxMask);
            this.panel.Location = new System.Drawing.Point(270, 58);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(360, 360);
            this.panel.TabIndex = 4;
            // 
            // pictureBoxPresentation
            // 
            this.pictureBoxPresentation.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPresentation.Name = "pictureBoxPresentation";
            this.pictureBoxPresentation.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxPresentation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPresentation.TabIndex = 3;
            this.pictureBoxPresentation.TabStop = false;
            this.pictureBoxPresentation.Visible = false;
            // 
            // pictureBoxMask
            // 
            this.pictureBoxMask.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMask.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxMask.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMask.Name = "pictureBoxMask";
            this.pictureBoxMask.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMask.TabIndex = 0;
            this.pictureBoxMask.TabStop = false;
            this.pictureBoxMask.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(757, 605);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 30);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(271, 541);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(354, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // FormExperiment5
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(885, 680);
            this.Name = "FormExperiment5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эксперимент 5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExperiment5_Load);
            this.SizeChanged += new System.EventHandler(this.FormExperiment5_SizeChanged);
            this.panelMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScaleTest)).EndInit();
            this.panelSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).EndInit();
            this.tabPageEX3.ResumeLayout(false);
            this.tabPageEX3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonNext;
        private Dotnetrix.Controls.TabControlEX tabControl;
        private Dotnetrix.Controls.TabPageEX tabPageEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX2;
        private System.Windows.Forms.Panel panelSample;
        private System.Windows.Forms.PictureBox pictureBoxSample;
        private Dotnetrix.Controls.TabPageEX tabPageEX3;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelNumSampleTest;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxMask;
        private System.Windows.Forms.Label labelNumTest;
        private System.Windows.Forms.PictureBox pictureBoxPresentation;
        private System.Windows.Forms.Label labelScaleTest;
        private System.Windows.Forms.TrackBar trackBarScaleTest;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}