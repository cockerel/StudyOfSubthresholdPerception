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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 636);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(385, 192);
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
            this.pictureBox1.Location = new System.Drawing.Point(52, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabControlEX1
            // 
            this.tabControlEX1.BackColor = System.Drawing.Color.White;
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.FlatBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControlEX1.HotColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabControlEX1.Location = new System.Drawing.Point(12, 12);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 1;
            this.tabControlEX1.Size = new System.Drawing.Size(674, 705);
            this.tabControlEX1.TabIndex = 1;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(666, 676);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Инструкция";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEX2.Controls.Add(this.panel1);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(666, 676);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Пробный тест";
            // 
            // FormExperiment4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 720);
            this.Controls.Add(this.tabControlEX1);
            this.Name = "FormExperiment4";
            this.Text = "Эксперимент 4";
            this.Load += new System.EventHandler(this.FormExperiment2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;

    }
}