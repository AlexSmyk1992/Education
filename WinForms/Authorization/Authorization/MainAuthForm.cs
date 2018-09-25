using Authorization.Repository;
using Authorization.UsersInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class MainAuthForm : Form
    {
        public MainAuthForm()
        {
            InitializeComponent();
            tbUserName.GotFocus += TbUserName_GotFocus;
            tbUserName.LostFocus +=TbUserName_LostFocus;
            tbPassword.GotFocus += TbPassword_GotFocus;
            tbPassword.LostFocus +=TbPassword_LostFocus;           
        }
        /// <summary>
        /// Action for 'Enter' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            lbChecking.Visible = true;            
            timer1.Enabled = true;
        }        
        /// <summary>
        /// Timer action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {            
            progressBar1.Value = progressBar1.Value + 10;
            if(progressBar1.Value==100)
            {                
                timer1.Enabled = false;               
                lbChecking.Visible = false;                
                
                progressBar1.Value = 0;                
                DataCheking();              
            }
        }
        /// <summary>
        /// Action if TB username got focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUserName_GotFocus(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            lbWrongData.Visible = false;
            if (tbUserName.Text == "Имя пользователя")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Action if TB username lost focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUserName_LostFocus(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Имя пользователя";
                tbUserName.ForeColor = Color.Silver;
            }
        }
        /// <summary>
        /// Action if TB password lost focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPassword_LostFocus(object sender,EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Пароль";
                tbPassword.PasswordChar = '\0';
                tbPassword.ForeColor = Color.Silver;
            }
        }
        /// <summary>
        /// Action if TB password got focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPassword_GotFocus(object sender,EventArgs e)
        {
            progressBar1.Visible = false;
            lbWrongData.Visible = false;
            if (tbPassword.Text == "Пароль")
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
                tbPassword.ForeColor = Color.Silver;
            }
        }
        /// <summary>
        /// Action when linklabel Registration pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLbRegirstration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();            
            regForm.Show();
            this.Hide();            
        }
        /// <summary>
        /// Action when linklabel ForgotPassword pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLbForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassForm ResetWF = new ResetPassForm();
            ResetWF.Show();
            this.Hide();
        }
        /// <summary>
        /// Method whick checking entering data from user
        /// </summary>
        private void DataCheking()
        {            
            var checkingList = UsersRepository.LoadForChecking();
            var userNameCheck = checkingList.Where(user => user.Login == tbUserName.Text).FirstOrDefault();
            if (userNameCheck != null)
            {
                CheckTrue(userNameCheck);
            }
            else
            {
                ShowInccorData();
            }
        }
        /// <summary>
        /// Method which check the password
        /// </summary>
        /// <param name="userNameCheck"></param>
        private void CheckTrue(UserInfo userNameCheck)
        {
            if (userNameCheck.Password == tbPassword.Text)
            {
                MainWindowAppForm MainWF = new MainWindowAppForm(userNameCheck.Name + " " + userNameCheck.Surname);                
                MainWF.Show();
            }
            else
            {
                ShowInccorData();
            }
        }
        /// <summary>
        /// Method which show incorrect data label
        /// </summary>
        private void ShowInccorData()
        {
            lbChecking.Visible = false;                       
            lbWrongData.Visible = true;
        }       
    }
}