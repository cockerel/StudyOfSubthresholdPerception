namespace StudyOfSubthresholdPerception.FormsExperiments
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
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Location = new System.Drawing.Point(12, 12);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 1;
			this.tabControlEX1.Size = new System.Drawing.Size(818, 479);
			this.tabControlEX1.TabIndex = 0;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(810, 450);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Инструкция";
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.label3);
			this.tabPageEX2.Controls.Add(this.label2);
			this.tabPageEX2.Controls.Add(this.label1);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(810, 450);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Пробный тест";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(199, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 80);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(23, 255);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(286, 69);
			this.label2.TabIndex = 1;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(472, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(286, 69);
			this.label3.TabIndex = 2;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// FormExperiment3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 503);
			this.Controls.Add(this.tabControlEX1);
			this.Name = "FormExperiment3";
			this.Text = "Эксперимент 3";
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
    }
}