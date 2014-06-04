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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabControlEx3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlEx3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(512, 510);
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
            this.buttonNext.Location = new System.Drawing.Point(730, 510);
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
            this.tabControlEx3.Location = new System.Drawing.Point(12, 12);
            this.tabControlEx3.Name = "tabControlEx3";
            this.tabControlEx3.SelectedIndex = 0;
            this.tabControlEx3.Size = new System.Drawing.Size(818, 492);
            this.tabControlEx3.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инструкция";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пробный тест";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Основная часть эксперимента";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(421, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(276, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // FormExperiment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 552);
            this.Controls.Add(this.tabControlEx3);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonNext);
            this.Name = "FormExperiment3";
            this.Text = "Эксперимент 3";
            this.tabControlEx3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabControl tabControlEx3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}