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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControlEX1.SuspendLayout();
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
			// tabControlEX1
			// 
			this.tabControlEX1.BackColor = System.Drawing.Color.White;
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.FlatBorderColor = System.Drawing.Color.White;
			this.tabControlEX1.HotColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabControlEX1.Location = new System.Drawing.Point(12, 12);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 2;
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
			this.tabPageEX2.Controls.Add(this.panel2);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(666, 676);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Тренеровочная серия";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Location = new System.Drawing.Point(17, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(632, 636);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox3.Location = new System.Drawing.Point(379, 192);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 200);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::StudyOfSubthresholdPerception.Properties.Resources._1;
			this.pictureBox4.Location = new System.Drawing.Point(59, 192);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(200, 200);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.panel1);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(666, 676);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Основная часть эксперимента";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(17, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 636);
			this.panel1.TabIndex = 2;
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
			// FormExperiment4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 720);
			this.Controls.Add(this.tabControlEX1);
			this.Name = "FormExperiment4";
			this.Text = "Эксперимент 4";
			this.Load += new System.EventHandler(this.FormExperiment2_Load);
			this.tabControlEX1.ResumeLayout(false);
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
        private Dotnetrix.Controls.TabControlEX tabControlEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;

    }
}