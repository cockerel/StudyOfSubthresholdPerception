namespace StudyOfSubthresholdPerception
{
    partial class FormAuthorization
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
            this.radioButtonExaminee = new System.Windows.Forms.RadioButton();
            this.radioButtonExperimenter = new System.Windows.Forms.RadioButton();
            this.panelExamenee = new System.Windows.Forms.Panel();
            this.label1Age = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.panelExperimenter = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelExamenee.SuspendLayout();
            this.panelExperimenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonExaminee
            // 
            this.radioButtonExaminee.AutoSize = true;
            this.radioButtonExaminee.Checked = true;
            this.radioButtonExaminee.Location = new System.Drawing.Point(98, 14);
            this.radioButtonExaminee.Name = "radioButtonExaminee";
            this.radioButtonExaminee.Size = new System.Drawing.Size(91, 17);
            this.radioButtonExaminee.TabIndex = 0;
            this.radioButtonExaminee.TabStop = true;
            this.radioButtonExaminee.Text = "Испытуемый";
            this.radioButtonExaminee.UseVisualStyleBackColor = true;
            this.radioButtonExaminee.CheckedChanged += new System.EventHandler(this.radioButtonExaminee_CheckedChanged);
            // 
            // radioButtonExperimenter
            // 
            this.radioButtonExperimenter.AutoSize = true;
            this.radioButtonExperimenter.Location = new System.Drawing.Point(98, 37);
            this.radioButtonExperimenter.Name = "radioButtonExperimenter";
            this.radioButtonExperimenter.Size = new System.Drawing.Size(116, 17);
            this.radioButtonExperimenter.TabIndex = 1;
            this.radioButtonExperimenter.Text = "Экспериментатор";
            this.radioButtonExperimenter.UseVisualStyleBackColor = true;
            this.radioButtonExperimenter.CheckedChanged += new System.EventHandler(this.radioButtonExperimenter_CheckedChanged);
            // 
            // panelExamenee
            // 
            this.panelExamenee.Controls.Add(this.label1Age);
            this.panelExamenee.Controls.Add(this.labelGender);
            this.panelExamenee.Controls.Add(this.textBoxAge);
            this.panelExamenee.Controls.Add(this.comboBoxGender);
            this.panelExamenee.Controls.Add(this.textBoxGroup);
            this.panelExamenee.Controls.Add(this.textBoxName);
            this.panelExamenee.Controls.Add(this.labelGroup);
            this.panelExamenee.Controls.Add(this.labelName);
            this.panelExamenee.Location = new System.Drawing.Point(12, 75);
            this.panelExamenee.Name = "panelExamenee";
            this.panelExamenee.Size = new System.Drawing.Size(260, 110);
            this.panelExamenee.TabIndex = 2;
            // 
            // label1Age
            // 
            this.label1Age.AutoSize = true;
            this.label1Age.Location = new System.Drawing.Point(49, 86);
            this.label1Age.Name = "label1Age";
            this.label1Age.Size = new System.Drawing.Size(52, 13);
            this.label1Age.TabIndex = 7;
            this.label1Age.Text = "Возраст:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(71, 59);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 13);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Пол:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(107, 83);
            this.textBoxAge.MaxLength = 2;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(150, 20);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxesInt_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesInt_KeyPress);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "женский",
            "мужской"});
            this.comboBoxGender.Location = new System.Drawing.Point(107, 56);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(150, 21);
            this.comboBoxGender.TabIndex = 4;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(107, 29);
            this.textBoxGroup.MaxLength = 6;
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(150, 20);
            this.textBoxGroup.TabIndex = 3;
            this.textBoxGroup.TextChanged += new System.EventHandler(this.textBoxesInt_TextChanged);
            this.textBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesInt_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(56, 32);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Группа:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ф.И.О.:";
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(98, 191);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(91, 23);
            this.buttonAuthorization.TabIndex = 3;
            this.buttonAuthorization.Text = "Войти";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // panelExperimenter
            // 
            this.panelExperimenter.Controls.Add(this.textBoxPassword);
            this.panelExperimenter.Controls.Add(this.labelPassword);
            this.panelExperimenter.Location = new System.Drawing.Point(12, 75);
            this.panelExperimenter.Name = "panelExperimenter";
            this.panelExperimenter.Size = new System.Drawing.Size(260, 29);
            this.panelExperimenter.TabIndex = 8;
            this.panelExperimenter.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "admin";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(53, 6);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль:";
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.panelExperimenter);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.panelExamenee);
            this.Controls.Add(this.radioButtonExperimenter);
            this.Controls.Add(this.radioButtonExaminee);
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panelExamenee.ResumeLayout(false);
            this.panelExamenee.PerformLayout();
            this.panelExperimenter.ResumeLayout(false);
            this.panelExperimenter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonExaminee;
        private System.Windows.Forms.RadioButton radioButtonExperimenter;
        private System.Windows.Forms.Panel panelExamenee;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1Age;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Panel panelExperimenter;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}

