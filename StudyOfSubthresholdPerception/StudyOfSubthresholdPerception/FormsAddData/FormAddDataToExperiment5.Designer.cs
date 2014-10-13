namespace StudyOfSubthresholdPerception
{
    partial class FormAddDataToExperiment5
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
            this.pictureBoxNeutral = new System.Windows.Forms.PictureBox();
            this.pictureBoxPositive = new System.Windows.Forms.PictureBox();
            this.pictureBoxNegative = new System.Windows.Forms.PictureBox();
            this.buttonAddNeutral = new System.Windows.Forms.Button();
            this.buttonAddPositive = new System.Windows.Forms.Button();
            this.buttonAddNegative = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogSelectImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNegative)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNeutral
            // 
            this.pictureBoxNeutral.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxNeutral.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxNeutral.Name = "pictureBoxNeutral";
            this.pictureBoxNeutral.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNeutral.TabIndex = 0;
            this.pictureBoxNeutral.TabStop = false;
            // 
            // pictureBoxPositive
            // 
            this.pictureBoxPositive.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPositive.Location = new System.Drawing.Point(259, 13);
            this.pictureBoxPositive.Name = "pictureBoxPositive";
            this.pictureBoxPositive.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxPositive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPositive.TabIndex = 1;
            this.pictureBoxPositive.TabStop = false;
            // 
            // pictureBoxNegative
            // 
            this.pictureBoxNegative.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxNegative.Location = new System.Drawing.Point(505, 13);
            this.pictureBoxNegative.Name = "pictureBoxNegative";
            this.pictureBoxNegative.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNegative.TabIndex = 2;
            this.pictureBoxNegative.TabStop = false;
            // 
            // buttonAddNeutral
            // 
            this.buttonAddNeutral.Location = new System.Drawing.Point(13, 260);
            this.buttonAddNeutral.Name = "buttonAddNeutral";
            this.buttonAddNeutral.Size = new System.Drawing.Size(240, 40);
            this.buttonAddNeutral.TabIndex = 3;
            this.buttonAddNeutral.Text = "Выбрать нейтральное изображение";
            this.buttonAddNeutral.UseVisualStyleBackColor = true;
            this.buttonAddNeutral.Click += new System.EventHandler(this.buttonAddNeutral_Click);
            // 
            // buttonAddPositive
            // 
            this.buttonAddPositive.Location = new System.Drawing.Point(259, 260);
            this.buttonAddPositive.Name = "buttonAddPositive";
            this.buttonAddPositive.Size = new System.Drawing.Size(240, 40);
            this.buttonAddPositive.TabIndex = 4;
            this.buttonAddPositive.Text = "Выбрать позитивное изображение";
            this.buttonAddPositive.UseVisualStyleBackColor = true;
            this.buttonAddPositive.Click += new System.EventHandler(this.buttonAddPositive_Click);
            // 
            // buttonAddNegative
            // 
            this.buttonAddNegative.Location = new System.Drawing.Point(505, 260);
            this.buttonAddNegative.Name = "buttonAddNegative";
            this.buttonAddNegative.Size = new System.Drawing.Size(240, 40);
            this.buttonAddNegative.TabIndex = 5;
            this.buttonAddNegative.Text = "Выбрать негативное изображение";
            this.buttonAddNegative.UseVisualStyleBackColor = true;
            this.buttonAddNegative.Click += new System.EventHandler(this.buttonAddNegative_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(259, 330);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 40);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogSelectImage
            // 
            this.openFileDialogSelectImage.FileName = "openFileDialog1";
            // 
            // FormAddDataToExperiment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(759, 382);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddNegative);
            this.Controls.Add(this.buttonAddPositive);
            this.Controls.Add(this.buttonAddNeutral);
            this.Controls.Add(this.pictureBoxNegative);
            this.Controls.Add(this.pictureBoxPositive);
            this.Controls.Add(this.pictureBoxNeutral);
            this.Name = "FormAddDataToExperiment5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление стимулов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNegative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNeutral;
        private System.Windows.Forms.PictureBox pictureBoxPositive;
        private System.Windows.Forms.PictureBox pictureBoxNegative;
        private System.Windows.Forms.Button buttonAddNeutral;
        private System.Windows.Forms.Button buttonAddPositive;
        private System.Windows.Forms.Button buttonAddNegative;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectImage;
    }
}