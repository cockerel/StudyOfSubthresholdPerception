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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiment3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabControlEx3 = new Dotnetrix.Controls.TabControlEX();
            this.tabPage1 = new Dotnetrix.Controls.TabPageEX();
            this.tabPage2 = new Dotnetrix.Controls.TabPageEX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new Dotnetrix.Controls.TabPageEX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlEx3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(503, 501);
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
            this.buttonNext.Location = new System.Drawing.Point(721, 501);
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
            this.tabControlEx3.SelectedIndex = 0;
            this.tabControlEx3.Size = new System.Drawing.Size(818, 492);
            this.tabControlEx3.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.label8);
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
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пробный тест";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(97, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(642, 172);
            this.label5.TabIndex = 5;
            this.label5.Text = "Нажмите закончить тренеровочную серию";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(423, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 84);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(145, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 84);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Основная часть эксперимента";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 172);
            this.label4.TabIndex = 3;
            this.label4.Text = "Нажмите далее для старта нового эксперимента";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(418, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlEx3);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.buttonFinish);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(831, 538);
            this.panelMain.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(798, 460);
            this.label8.TabIndex = 5;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // FormExperiment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 552);
            this.Controls.Add(this.panelMain);
            this.Name = "FormExperiment3";
            this.Text = "Эксперимент 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExperiment3_Load);
            this.SizeChanged += new System.EventHandler(this.FormExperiment3_SizeChanged);
            this.tabControlEx3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label8;
    }
}