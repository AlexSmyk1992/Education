using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Word = Microsoft.Office.Interop.Word;

namespace BestOil
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();            
        }
        /// <summary>
        /// Method for combobox which contains type of oil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeOfOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TypeOfOil.Text == "АИ-98")
            {
                tb_Price.Text = "1,42";
            }
            if (cmb_TypeOfOil.Text == "АИ-95")
            {
                tb_Price.Text = "1,31";
            }
            if (cmb_TypeOfOil.Text == "АИ-92")
            {
                tb_Price.Text = "1,23";
            }
            if (cmb_TypeOfOil.Text == "ДТ")
            {
                tb_Price.Text = "1,34";
            }
        }     
       /// <summary>
       /// action for checkboxes in cafe group
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double Summa = 0;
                if (chk_HotDog.Checked)
                {
                    Summa += (GetSum(tb_HotDogPrice) * GetSum(tb_HotDogCount)); //заменить на getsum                         
                }  
                if (chk_Hamburger.Checked)
                {
                    Summa += (GetSum(tb_HamburgerPrice) * GetSum(tb_HamburgerCount));
                }   
                if (chk_Cheeseburger.Checked)
                {
                    Summa += (GetSum(tb_CheesburgerPrice) * GetSum(tb_CheesburgerCount));
                }
                if (chk_CocaCola.Checked)
                {
                    Summa += (GetSum(tb_CocaColaPrice) * GetSum(tb_CocaColaCount));
                 } 
                tb_ToPayCafe.Text = Summa.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }            
        }        
        /// <summary>
        /// Action for radiobutton named "Количество" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {            
            ResetSum();
        }        
        /// <summary>
        /// Reset text in textbox and blocked another radiobutton
        /// </summary>
        private void ResetSum()
        {          
            var countChecked = rb_Count.Checked;
            tb_Count.Clear();
            tb_Sum.Clear();
            tb_ToPayPetrol.Clear();
            tb_Count.Enabled = countChecked;// если выбрали , к примеру,radiobutton количество то поле количество
            tb_Sum.Enabled = !countChecked;// заблокировано
            lbl_ToPayPetrol.Text =countChecked? "К оплате" : "К выдаче";            
        }
        /// <summary>
        /// Method which calculate the pay,when radiobutton "Количество" checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Count_TextChanged(object sender, EventArgs e)
        {            
            if (rb_Count.Checked)
            {
                var a = GetSum(tb_Price);
                var b = GetSum(tb_Count);
                double mult = (a * b);
                tb_ToPayPetrol.Text = mult.ToString();
            }
        }
        /// <summary>
        /// Method which calculate the pay,when radiobutton "Сумма" checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Sum_TextChanged(object sender, EventArgs e)
        {           
            if (rb_Sum.Checked)
            {
                var a = GetSum(tb_Sum);
                var b = GetSum(tb_Price);               
                double mult = (a / b);
                Math.Round(mult, 2);
                tb_ToPayPetrol.Text = Math.Round(mult, 2).ToString();
            }
        }
        /// <summary>
        /// Action for "Рассчитать" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            total += GetSum(tb_ToPayPetrol);
            total += GetSum(tb_ToPayCafe);
            tb_Total.Text = total.ToString();            
        }
        /// <summary>
        /// Check checkbox when value is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_HotDogCount_TextChanged(object sender, EventArgs e)
        {
            if ((tb_HotDogCount.Focus()))
            {
                chk_HotDog.Checked = false;
            }
            chk_HotDog.Checked = true;

        }
        /// <summary>
        /// Check checkbox when value is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_HamburgerCount_TextChanged(object sender, EventArgs e)
        {
            if ((tb_HamburgerCount.Focus()))
            {
                chk_Hamburger.Checked = false;
            }
                chk_Hamburger.Checked = true;
        }
        /// <summary>
        /// Check checkbox when value is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_CheesburgerCount_TextChanged(object sender, EventArgs e)
        {
            if((tb_CheesburgerCount.Focus()))
            {
                chk_Cheeseburger.Checked = false;
            }
            chk_Cheeseburger.Checked = true;
        }
        /// <summary>
        /// Check checkbox when value is entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_CocaColaCount_TextChanged(object sender, EventArgs e)
        {
            if((tb_CocaColaCount.Focus()))
            {
                chk_CocaCola.Checked = false;
            }
            chk_CocaCola.Checked = true;
        }
        
        /// <summary>
        /// MSWordMethod export
        /// </summary>
        /// <param name="str"></param>
        private void MsWord(string str)
        { //try catch
            Word.Application wordapp;
        wordapp = new Word.Application(); 
            // Делаем его видимым 
            wordapp.Visible = true;             
            Word.Document doc = new Word.Document();
            // Создание документа 
            object MyTemplate = Type.Missing;
            // имя шаблона, по которому создаѐтся новый документ. 
            // Если значение не указано, то используется шаблон Normal.dot;  
            object NewTemplate = false; // при true новый документ открывается как шаблон. 
                                        // Значение по умолчанию – false; 
            object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;
            //DocumentType – тип документа, может принимать 
            // одно из следующих значений констант типа Word.WdNewDocumentType: 
            // wdNewBlankDocument – документ Word (по умолчанию);  
            object Visible = true; // видимость документа. 
                                   // При true (по умолчанию) документ отображается.
            doc = wordapp.Documents.Add( ref MyTemplate, 
                                 ref NewTemplate,
                                 ref DocumentType, 
                                 ref Visible);
            object pargf = Type.Missing;
            Word.Paragraph wordparagraph = doc.Content.Paragraphs.Add(ref pargf);
            // применение полужирного начертания к тексту 
            wordparagraph.Range.Font.Bold = 1;
            // установка размера текста
            wordparagraph.Range.Font.Size = 14;
            // добавление текста
            wordparagraph.Range.Text = "Автозаправка Б-200";
            // выравнивание текста по центру 
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // вставка параграфа
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "Кассир Морозов А.А";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "-------------------------------------------------------------------------------------------------------------------------------";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            if (!String.IsNullOrEmpty(tb_ToPayPetrol.Text))
            {
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 12;
                wordparagraph.Range.Text = cmb_TypeOfOil.Text + " - " + tb_ToPayPetrol.Text+" руб.";
                wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            }
            if (!String.IsNullOrEmpty(tb_ToPayCafe.Text))
            {
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 12;
                if (chk_HotDog.Checked)
                {
                    double hotDogSum = (GetSum(tb_HotDogPrice) * GetSum(tb_HotDogCount));
                    wordparagraph.Range.Text = chk_HotDog.Text+" - " + hotDogSum.ToString() +" руб.";
                    wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }      
            }
            if (!String.IsNullOrEmpty(tb_ToPayCafe.Text))
            {
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 12;
                if (chk_Hamburger.Checked)
                {
                    double HamSum = (GetSum(tb_HamburgerPrice) * GetSum(tb_HamburgerCount));
                    wordparagraph.Range.Text = chk_Hamburger.Text + " - " + HamSum.ToString() + " руб.";
                    wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
            }
            if (!String.IsNullOrEmpty(tb_ToPayCafe.Text))
            {
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 12;
                if (chk_Cheeseburger.Checked)
                {
                    double CheeseSum = (GetSum(tb_CheesburgerPrice) * GetSum(tb_CheesburgerCount));
                    wordparagraph.Range.Text = chk_Cheeseburger.Text + " - " + CheeseSum.ToString() + " руб.";
                    wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
            }
            if (!String.IsNullOrEmpty(tb_ToPayCafe.Text))
            {
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 12;
                if (chk_CocaCola.Checked)
                {
                    double ColaSum = (GetSum(tb_CocaColaPrice) * GetSum(tb_CocaColaCount));
                    wordparagraph.Range.Text = chk_CocaCola.Text + " - " + ColaSum.ToString() + " руб.";
                    wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
            }
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "-------------------------------------------------------------------------------------------------------------------------------";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "ИТОГ"+"     "+str + " Рублей";   
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "До встречи! You are welcome!";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        }
       
        /// <summary>
        /// Method works when app is сlosing, contains MB with export check to MSWord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Выручка за день: "+tb_Total.Text+" рублей\nДля экспорта чека в MSWord нажмите 'Да'\nДля выхода нажмите 'Нет'","Сообщение", MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            if (result==DialogResult.Yes)
            {
                MsWord(tb_Total.Text);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = false;  
            }
        }
        /// <summary>
        /// Form load method contains default params
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_TypeOfOil.SelectedIndex=0;
            rb_Count.Checked = true;
        }
        /// <summary>
        /// Method which parse textbox text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private double GetSum(TextBox text)
        {
            double res = 0;
            if(!string.IsNullOrWhiteSpace(text.Text))
            {
                if(!double.TryParse(text.Text, out res))
                {
                    text.Clear();
                }                
            }
            return res;
        }
    }
}
