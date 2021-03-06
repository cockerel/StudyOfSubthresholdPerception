﻿namespace StudyOfSubthresholdPerception
{
    partial class FormExperiment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.tabControl = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumSampleTest = new System.Windows.Forms.Label();
            this.panelSample = new System.Windows.Forms.Panel();
            this.labelSampleAnagram = new System.Windows.Forms.Label();
            this.textBoxSampleAnswer = new System.Windows.Forms.TextBox();
            this.pictureBoxSample = new System.Windows.Forms.PictureBox();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumTest = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxPresentation = new System.Windows.Forms.PictureBox();
            this.labelAnagram = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBoxMask = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.panelSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).BeginInit();
            this.tabPageEX3.SuspendLayout();
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
            // 
            // buttonFinish
            // 
            this.buttonFinish.Enabled = false;
            this.buttonFinish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinish.Location = new System.Drawing.Point(501, 605);
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
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPageEX1.Controls.Add(this.label3);
            this.tabPageEX1.Controls.Add(this.labelDescription);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Инструкция";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(9, 4);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(834, 547);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            this.labelDescription.UseCompatibleTextRendering = true;
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX2.Controls.Add(this.label1);
            this.tabPageEX2.Controls.Add(this.labelNumSampleTest);
            this.tabPageEX2.Controls.Add(this.panelSample);
            this.tabPageEX2.Enabled = false;
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Тренировочная серия";
            this.tabPageEX2.Click += new System.EventHandler(this.tabPageEX2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // labelNumSampleTest
            // 
            this.labelNumSampleTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSampleTest.Location = new System.Drawing.Point(250, 10);
            this.labelNumSampleTest.Name = "labelNumSampleTest";
            this.labelNumSampleTest.Size = new System.Drawing.Size(400, 40);
            this.labelNumSampleTest.TabIndex = 3;
            this.labelNumSampleTest.Text = "Стимул 1 из 10";
            this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSample
            // 
            this.panelSample.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSample.Controls.Add(this.labelSampleAnagram);
            this.panelSample.Controls.Add(this.textBoxSampleAnswer);
            this.panelSample.Controls.Add(this.pictureBoxSample);
            this.panelSample.Location = new System.Drawing.Point(250, 80);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(400, 450);
            this.panelSample.TabIndex = 2;
            // 
            // labelSampleAnagram
            // 
            this.labelSampleAnagram.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleAnagram.Location = new System.Drawing.Point(20, 165);
            this.labelSampleAnagram.Name = "labelSampleAnagram";
            this.labelSampleAnagram.Size = new System.Drawing.Size(360, 80);
            this.labelSampleAnagram.TabIndex = 2;
            this.labelSampleAnagram.Text = "ololo";
            this.labelSampleAnagram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSampleAnagram.Visible = false;
            // 
            // textBoxSampleAnswer
            // 
            this.textBoxSampleAnswer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSampleAnswer.Location = new System.Drawing.Point(98, 401);
            this.textBoxSampleAnswer.Name = "textBoxSampleAnswer";
            this.textBoxSampleAnswer.Size = new System.Drawing.Size(200, 29);
            this.textBoxSampleAnswer.TabIndex = 1;
            this.textBoxSampleAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesAnswer_KeyPress);
            // 
            // pictureBoxSample
            // 
            this.pictureBoxSample.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxSample.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxSample.Location = new System.Drawing.Point(20, 3);
            this.pictureBoxSample.Name = "pictureBoxSample";
            this.pictureBoxSample.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSample.TabIndex = 0;
            this.pictureBoxSample.TabStop = false;
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX3.Controls.Add(this.label2);
            this.tabPageEX3.Controls.Add(this.labelNumTest);
            this.tabPageEX3.Controls.Add(this.labelNum);
            this.tabPageEX3.Controls.Add(this.panel);
            this.tabPageEX3.Enabled = false;
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(846, 567);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Основная часть эксперимента";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Для перехода далее нажмите \"Enter\" или соответствующую кнопку.";
            // 
            // labelNumTest
            // 
            this.labelNumTest.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTest.Location = new System.Drawing.Point(240, 19);
            this.labelNumTest.Name = "labelNumTest";
            this.labelNumTest.Size = new System.Drawing.Size(400, 23);
            this.labelNumTest.TabIndex = 6;
            this.labelNumTest.Text = "Опыт 1 из n";
            this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(241, 52);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(400, 34);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "Стимул 1 из n";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel.Controls.Add(this.pictureBoxPresentation);
            this.panel.Controls.Add(this.labelAnagram);
            this.panel.Controls.Add(this.textBoxAnswer);
            this.panel.Controls.Add(this.pictureBoxMask);
            this.panel.Location = new System.Drawing.Point(244, 89);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 450);
            this.panel.TabIndex = 4;
            // 
            // pictureBoxPresentation
            // 
            this.pictureBoxPresentation.Location = new System.Drawing.Point(18, 3);
            this.pictureBoxPresentation.Name = "pictureBoxPresentation";
            this.pictureBoxPresentation.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxPresentation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPresentation.TabIndex = 3;
            this.pictureBoxPresentation.TabStop = false;
            this.pictureBoxPresentation.Visible = false;
            // 
            // labelAnagram
            // 
            this.labelAnagram.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnagram.Location = new System.Drawing.Point(3, 165);
            this.labelAnagram.Name = "labelAnagram";
            this.labelAnagram.Size = new System.Drawing.Size(394, 80);
            this.labelAnagram.TabIndex = 2;
            this.labelAnagram.Text = "ololo";
            this.labelAnagram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnagram.Visible = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(98, 401);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(200, 29);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesAnswer_KeyPress);
            // 
            // pictureBoxMask
            // 
            this.pictureBoxMask.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMask.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxMask.Location = new System.Drawing.Point(18, 3);
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
            // FormExperiment1
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(885, 680);
            this.Name = "FormExperiment1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эксперимент 1. Исследование влияния подпороговых стимулов на решение анаграмм.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExperiment1_FormClosing);
            this.Load += new System.EventHandler(this.FormExperiment1_Load);
            this.SizeChanged += new System.EventHandler(this.FormExperiment1_SizeChanged);
            this.panelMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.panelSample.ResumeLayout(false);
            this.panelSample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).EndInit();
            this.tabPageEX3.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
        private System.Windows.Forms.Label labelSampleAnagram;
        private System.Windows.Forms.TextBox textBoxSampleAnswer;
        private System.Windows.Forms.PictureBox pictureBoxSample;
        private Dotnetrix.Controls.TabPageEX tabPageEX3;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelNumSampleTest;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelAnagram;
        private System.Windows.Forms.PictureBox pictureBoxMask;
        private System.Windows.Forms.Label labelNumTest;
        private System.Windows.Forms.PictureBox pictureBoxPresentation;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}