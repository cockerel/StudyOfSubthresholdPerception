namespace StudyOfSubthresholdPerception
{
    partial class FormAddDataToExperiment3
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
            this.openFileDialogSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxEx3Down2 = new System.Windows.Forms.TextBox();
            this.textBoxEx3Down1 = new System.Windows.Forms.TextBox();
            this.textBoxEx3Und = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 123);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 30);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Вариант (несовпадающий):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Вариант (совпадающий):";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Подпороговый:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textBoxEx3Down2
            // 
            this.textBoxEx3Down2.Location = new System.Drawing.Point(159, 79);
            this.textBoxEx3Down2.Name = "textBoxEx3Down2";
            this.textBoxEx3Down2.Size = new System.Drawing.Size(158, 20);
            this.textBoxEx3Down2.TabIndex = 29;
            // 
            // textBoxEx3Down1
            // 
            this.textBoxEx3Down1.Location = new System.Drawing.Point(159, 51);
            this.textBoxEx3Down1.Name = "textBoxEx3Down1";
            this.textBoxEx3Down1.Size = new System.Drawing.Size(158, 20);
            this.textBoxEx3Down1.TabIndex = 28;
            // 
            // textBoxEx3Und
            // 
            this.textBoxEx3Und.Location = new System.Drawing.Point(159, 23);
            this.textBoxEx3Und.Name = "textBoxEx3Und";
            this.textBoxEx3Und.Size = new System.Drawing.Size(158, 20);
            this.textBoxEx3Und.TabIndex = 27;
            // 
            // FormAddDataToExperiment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 174);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxEx3Down2);
            this.Controls.Add(this.textBoxEx3Down1);
            this.Controls.Add(this.textBoxEx3Und);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAddDataToExperiment3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление стимулов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSelectImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxEx3Down2;
        private System.Windows.Forms.TextBox textBoxEx3Down1;
        private System.Windows.Forms.TextBox textBoxEx3Und;
    }
}