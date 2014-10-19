namespace StudyOfSubthresholdPerception
{
    partial class FormAddDataToExperiment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDataToExperiment1));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialogSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.textBoxAnagram = new System.Windows.Forms.TextBox();
            this.labelAnagram = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 394);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 30);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Location = new System.Drawing.Point(159, 350);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(153, 20);
            this.textBoxAnswer2.TabIndex = 12;
            this.textBoxAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnagram_KeyPress);
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Location = new System.Drawing.Point(159, 324);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(153, 20);
            this.textBoxAnswer1.TabIndex = 11;
            this.textBoxAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnagram_KeyPress);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Location = new System.Drawing.Point(9, 353);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(144, 13);
            this.labelAnswer2.TabIndex = 10;
            this.labelAnswer2.Text = "Вариант (несовпадающий):";
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Location = new System.Drawing.Point(9, 327);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(132, 13);
            this.labelAnswer1.TabIndex = 9;
            this.labelAnswer1.Text = "Вариант (совпадающий):";
            this.labelAnswer1.Click += new System.EventHandler(this.labelAnswer1_Click);
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(12, 268);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(300, 23);
            this.buttonSelectImage.TabIndex = 8;
            this.buttonSelectImage.Text = "Выбрать изображение";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialogSelectImage
            // 
            this.openFileDialogSelectImage.FileName = "openFileDialogSelectImage";
            this.openFileDialogSelectImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSelectImage_FileOk);
            // 
            // textBoxAnagram
            // 
            this.textBoxAnagram.Location = new System.Drawing.Point(159, 298);
            this.textBoxAnagram.Name = "textBoxAnagram";
            this.textBoxAnagram.Size = new System.Drawing.Size(153, 20);
            this.textBoxAnagram.TabIndex = 14;
            this.textBoxAnagram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnagram_KeyPress);
            // 
            // labelAnagram
            // 
            this.labelAnagram.AutoSize = true;
            this.labelAnagram.Location = new System.Drawing.Point(9, 301);
            this.labelAnagram.Name = "labelAnagram";
            this.labelAnagram.Size = new System.Drawing.Size(68, 13);
            this.labelAnagram.TabIndex = 15;
            this.labelAnagram.Text = "Анаграмма:";
            // 
            // FormAddDataToExperiment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 431);
            this.Controls.Add(this.labelAnagram);
            this.Controls.Add(this.textBoxAnagram);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddDataToExperiment1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление стимулов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectImage;
        private System.Windows.Forms.TextBox textBoxAnagram;
        private System.Windows.Forms.Label labelAnagram;
    }
}