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
            this.labelScaleTest = new System.Windows.Forms.Label();
            this.trackBarScaleTest = new System.Windows.Forms.TrackBar();
            this.labelNumSampleTest = new System.Windows.Forms.Label();
            this.panelSample = new System.Windows.Forms.Panel();
            this.pictureBoxSample = new System.Windows.Forms.PictureBox();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.labelScale = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.labelNumTest = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxPresentation = new System.Windows.Forms.PictureBox();
            this.pictureBoxMask = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
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
            this.panelMain.Size = new System.Drawing.Size(760, 538);
            this.panelMain.TabIndex = 0;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(435, 505);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(210, 30);
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
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(754, 496);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX1.Controls.Add(this.labelDescription);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(746, 467);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Инструкция";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(4, 4);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(739, 463);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX2.Controls.Add(this.labelScaleTest);
            this.tabPageEX2.Controls.Add(this.trackBarScaleTest);
            this.tabPageEX2.Controls.Add(this.labelNumSampleTest);
            this.tabPageEX2.Controls.Add(this.panelSample);
            this.tabPageEX2.Enabled = false;
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(746, 467);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Пробный тест";
            // 
            // labelScaleTest
            // 
            this.labelScaleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScaleTest.Location = new System.Drawing.Point(216, 415);
            this.labelScaleTest.Name = "labelScaleTest";
            this.labelScaleTest.Size = new System.Drawing.Size(309, 43);
            this.labelScaleTest.TabIndex = 4;
            this.labelScaleTest.Text = "Оценка: 0";
            // 
            // trackBarScaleTest
            // 
            this.trackBarScaleTest.Location = new System.Drawing.Point(3, 367);
            this.trackBarScaleTest.Maximum = 100;
            this.trackBarScaleTest.Minimum = -100;
            this.trackBarScaleTest.Name = "trackBarScaleTest";
            this.trackBarScaleTest.Size = new System.Drawing.Size(740, 45);
            this.trackBarScaleTest.TabIndex = 1;
            this.trackBarScaleTest.Scroll += new System.EventHandler(this.trackBarScaleTest_Scroll);
            // 
            // labelNumSampleTest
            // 
            this.labelNumSampleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSampleTest.Location = new System.Drawing.Point(219, 10);
            this.labelNumSampleTest.Name = "labelNumSampleTest";
            this.labelNumSampleTest.Size = new System.Drawing.Size(306, 23);
            this.labelNumSampleTest.TabIndex = 3;
            this.labelNumSampleTest.Text = "Предъявление 1 из 5";
            this.labelNumSampleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSample
            // 
            this.panelSample.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSample.Controls.Add(this.pictureBoxSample);
            this.panelSample.Location = new System.Drawing.Point(219, 54);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(306, 306);
            this.panelSample.TabIndex = 2;
            // 
            // pictureBoxSample
            // 
            this.pictureBoxSample.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSample.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxSample.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSample.Name = "pictureBoxSample";
            this.pictureBoxSample.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSample.TabIndex = 0;
            this.pictureBoxSample.TabStop = false;
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX3.Controls.Add(this.labelScale);
            this.tabPageEX3.Controls.Add(this.trackBarScale);
            this.tabPageEX3.Controls.Add(this.labelNumTest);
            this.tabPageEX3.Controls.Add(this.labelNum);
            this.tabPageEX3.Controls.Add(this.panel);
            this.tabPageEX3.Enabled = false;
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(746, 467);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Тест";
            // 
            // labelScale
            // 
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(216, 417);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(309, 43);
            this.labelScale.TabIndex = 8;
            this.labelScale.Text = "Оценка: 0";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(3, 369);
            this.trackBarScale.Maximum = 100;
            this.trackBarScale.Minimum = -100;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(740, 45);
            this.trackBarScale.TabIndex = 7;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // labelNumTest
            // 
            this.labelNumTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumTest.Location = new System.Drawing.Point(220, 11);
            this.labelNumTest.Name = "labelNumTest";
            this.labelNumTest.Size = new System.Drawing.Size(306, 23);
            this.labelNumTest.TabIndex = 6;
            this.labelNumTest.Text = "Опыт 1 из n";
            this.labelNumTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(220, 34);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(306, 23);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "Предъявление 1 из n";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel.Controls.Add(this.pictureBoxPresentation);
            this.panel.Controls.Add(this.pictureBoxMask);
            this.panel.Location = new System.Drawing.Point(220, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(306, 306);
            this.panel.TabIndex = 4;
            // 
            // pictureBoxPresentation
            // 
            this.pictureBoxPresentation.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPresentation.Name = "pictureBoxPresentation";
            this.pictureBoxPresentation.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxPresentation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPresentation.TabIndex = 3;
            this.pictureBoxPresentation.TabStop = false;
            this.pictureBoxPresentation.Visible = false;
            // 
            // pictureBoxMask
            // 
            this.pictureBoxMask.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMask.Image = global::StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
            this.pictureBoxMask.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMask.Name = "pictureBoxMask";
            this.pictureBoxMask.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMask.TabIndex = 0;
            this.pictureBoxMask.TabStop = false;
            this.pictureBoxMask.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(653, 505);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 30);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormExperiment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormExperiment5";
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
    }
}