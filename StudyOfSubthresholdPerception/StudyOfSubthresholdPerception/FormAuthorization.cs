using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    public partial class FormAuthorization : Form
    {
        private bool checkSecond = false; //если выбрали экспериментатора, то true

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void radioButtonExaminee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSecond == true)
            {
                panelExamenee.Visible = true;
                panelExperimenter.Visible = false;
                checkSecond = false;
            }
        }

        private void radioButtonExperimenter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSecond == false)
            {
                panelExamenee.Visible = false;
                panelExperimenter.Visible = true;
                checkSecond = true;
            }
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if (checkSecond == true)
            {
                if (textBoxPassword.Text == (new DB().getPassword()))
                {
                    Hide();
                    new FormMain(true).ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введен неверный пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (textBoxName.Text != String.Empty && comboBoxGender.Text != String.Empty
                    && textBoxAge.Text != String.Empty && textBoxGroup.Text != String.Empty)
                {
                    new DB().createUser(textBoxName.Text, comboBoxGender.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToInt32(textBoxGroup.Text));
                    Hide();
                    new FormMain(false).ShowDialog();
                    Close();
                }
                else 
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxesInt_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxesInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true; 
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 'А' || e.KeyChar > 'ё'))
                //(e.KeyChar < 128 || e.KeyChar > 175) && (e.KeyChar < 224 || e.KeyChar > 241))
                e.Handled = true; 
        }
    }
}
