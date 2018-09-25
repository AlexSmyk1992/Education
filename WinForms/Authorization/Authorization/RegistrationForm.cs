using Authorization.Repository;
using Authorization.UsersInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Authorization
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Action for 'Cancel' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            CloseCurrOpenMainForm();
        }
        /// <summary>
        /// Action for 'OK' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegOk_Click(object sender, EventArgs e)
        {
            var checkingList = UsersRepository.LoadForChecking();
            var  checkRepeatLogin = checkingList.Where(user => user.Login == tbRegLogin.Text).FirstOrDefault();
            var checkRepeatEmail = checkingList.Where(user => user.Email == tbRegEmail.Text).FirstOrDefault();
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex regex = new Regex(emailPattern);
            Match match = regex.Match(tbRegEmail.Text);                     
            if (checkRepeatLogin == null)
            {
                CheckEnteredInfo(checkRepeatEmail, match);
            }
            else
            {
                MessageBox.Show("Такой логин уже зарегистрирован!");
                tbRegLogin.Focus();
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
        /// Add user in users repository and save in file
        /// </summary>
        private void AddSaveNewUser()
        {
            UserInfo newUser = new UserInfo()
            {
                Login = tbRegLogin.Text,
                Password = tbRegPass.Text,
                Email = tbRegEmail.Text,
                Name = tbRegName.Text,
                Surname = tbRegSurname.Text
            };
            UsersRepository.AddUser(newUser);
            UsersRepository.Save();
        }
        /// <summary>
        /// Method that checked the entered data from textboxes
        /// </summary>
        /// <param name="checkRepeatEmail"></param>
        /// <param name="match"></param>
        private void CheckEnteredInfo(UserInfo checkRepeatEmail,Match match)
        {
            if (tbRegPass.Text.Length >= 6)
            {
                if (tbRegName.Text != String.Empty)
                {
                    if (tbRegSurname.Text != String.Empty)
                    {
                        if (tbRegEmail.Text != String.Empty && checkRepeatEmail == null)
                        {
                            if (tbRegPass.Text == tbRegRepeatPas.Text)
                            {
                                if (match.Success)
                                {
                                    AddSaveNewUser();
                                    CloseCurrOpenMainForm();
                                }
                                else
                                {
                                    MessageBox.Show("Некорректный email!");
                                    tbRegEmail.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пароли не совпадают!");
                                tbRegPass.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такой email уже зарегистрирован!");
                            tbRegEmail.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле 'Фамилия'!");
                        tbRegSurname.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле 'Имя'!");
                    tbRegName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Пароль должен быть более 6-ти символов!");
                tbRegPass.Focus();
            }
        }
    }
}
