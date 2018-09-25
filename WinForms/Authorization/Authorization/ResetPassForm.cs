using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authorization.Repository;
using Authorization.UsersInfo;

namespace Authorization
{
    public partial class ResetPassForm : Form
    {
        public ResetPassForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Action for 'Cancel' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form mainAuthForm = Application.OpenForms[0];
            this.Close();
            mainAuthForm.Show();
        }
        /// <summary>
        /// Action for 'OK' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            var checkingList = UsersRepository.LoadForChecking();
            var checkRepeatEmail = checkingList.Where(user => user.Email == tbResetEmail.Text).FirstOrDefault();
            if (checkRepeatEmail != null)
            {
                if(tbResetPass.Text.Length>=6)
                {
                    if (tbResetPass.Text == tbResetRepeatPass.Text)
                    {
                        SaveSetUserPass(checkRepeatEmail);
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                        tbResetPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Пароль должен быть более 6-ти символов!");
                    tbResetPass.Focus();
                }               
            }
            else
            {
                MessageBox.Show("Данный email не зарегистрирован!");
                CloseCurrOpenMainForm();
            }
        }
        /// <summary>
        /// Close current form and open Main Form
        /// </summary>
        private void CloseCurrOpenMainForm()
        {
            Form mainAuthForm = Application.OpenForms[0];
            this.Close();
            mainAuthForm.Show();
        }
        /// <summary>
        /// Set new password for user and save
        /// </summary>
        /// <param name="checkRepeatEmail"></param>
        private void SaveSetUserPass(UserInfo checkRepeatEmail)
        {
            checkRepeatEmail.Password = tbResetRepeatPass.Text;
            UsersRepository.Save();
            CloseCurrOpenMainForm();
        }
    }
}
