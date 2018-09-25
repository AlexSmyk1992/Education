using System;
using System.Drawing;
using System.Windows.Forms;
using MobileStore.Repository;
using MobileStore.Object;
using System.IO;

namespace MobileStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string curDbFile = "data.xml";
                MobileRepository.Load(curDbFile); //загрузка из xml лист телефонов со своими опциями и лист всех опций в phones и в options
                chkLstOptions.DataSource = MobileRepository.GetOptions(); // привязка checklistbox к общему списку опций(возвращает после подгрузки из xml)
                lstPhones.DataSource = MobileRepository.GetPhones();//привязка listphones к общему списку телефонов(возвращает после подгрузки из xml)               
            }
            catch (FileNotFoundException)
            {
               DialogResult dialogResult= MessageBox.Show("База мобильных телефонов 'data.xml' не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }               
        }
        /// <summary>
        /// изменение lstPhones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobilePhone mbPhone = (MobilePhone)lstPhones.SelectedItem; //выделенный телефон из listphones как объект Mobilephone
            if (mbPhone != null)
            {
                SetModelTextBoxes(mbPhone);
                SetEditTextBoxes(mbPhone);
                for (int i = 0; i < chkLstOptions.Items.Count; i++)
                {
                    chkLstOptions.SetItemChecked(i, false);//снять выделение всех галочек в сhklistbox
                }        
                foreach (var option in mbPhone.opList)//проходит по всем опциям в oplist данного телефона(выделенного)
                {
                    lstOptions.Items.Add(option);//добавить в лист опций в форме
                    var optionIndex = MobileRepository.GetOptions().IndexOf(option);//возвращает какой индекс option имеет в коллекции phones
                    chkLstOptions.SetItemChecked(optionIndex, true);//выделить галочкой в chklistbox(список всех опций) опцию по текущему индексу
                }         
            }
        }
        /// <summary>
        /// кнопка "прочитать из файла"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files(*.xml;)|*.xml;|All files(*.*)|*.*"; 
            ofd.InitialDirectory = ("");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MobileRepository.Load(ofd.FileName);
                    chkLstOptions.DataSource = MobileRepository.GetOptions(); // привязка checklistbox к общему списку опций(возвращает после подгрузки из xml)
                    lstPhones.DataSource = MobileRepository.GetPhones();//привязка listphones к общему списку телефонов(возвращает после подгрузки из xml)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно открыть файл: "+ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Кнопка "сохранить в файл"
        /// </summary>
        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File(*.xml;)|*.xml;";
            sfd.InitialDirectory = ("");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MobileRepository.Save(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно сохранить файл: "+ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// кнопка добавить опцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOpt_Click(object sender, EventArgs e)
        {
            MobilePhone mbPhone = (MobilePhone)lstPhones.SelectedItem;
            MobileRepository.GetOptions().Add(tbOptName.Text);
            chkLstOptions.DataSource = MobileRepository.GetOptions();
            CheckCheckedListChanging(mbPhone);
        }
        /// <summary>
        /// кнопка удалить опцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelOpt_Click(object sender, EventArgs e)
        {
            MobilePhone mbPhone = (MobilePhone)lstPhones.SelectedItem;
            string opt = chkLstOptions.SelectedItem.ToString();
            MobileRepository.GetOptions().Remove(chkLstOptions.SelectedItem.ToString());
            
            if (!mbPhone.opList.Contains(opt))
            {
                chkLstOptions.DataSource = MobileRepository.GetOptions();
                CheckCheckedListChanging(mbPhone);
            }    
            else if (mbPhone.opList.Contains(opt))
            {
                mbPhone.opList.Remove(opt); 
                chkLstOptions.DataSource = MobileRepository.GetOptions();
                CheckCheckedListChanging(mbPhone);
            }        
        }
        /// <summary>
        /// кнопка "удалить текущую"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelPhone_Click(object sender, EventArgs e) 
        {
            if (MobileRepository.GetPhones().Count != 0 && lstPhones.Items.Count!=0) 
            {     
                    MobileRepository.DeletePhone(lstPhones.SelectedItem as MobilePhone);
                    ClearEditTextBoxes();
                    ClearModelTextBoxes();
                    lstPhones.SelectedIndex =0;
                    lstOptions.Items.Clear();                               
            }
            else
            {
                MessageBox.Show("Список телефонов пуст! Добавьте список телефонов из xml-файла, либо добавьте вручную, в разделе 'редактирование информации'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        /// <summary>
        /// кнопка "очистить список"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (MobileRepository.GetPhones().Count != 0)//тоже самое что и удалить текущую
            {
                try
                {
                    MobileRepository.DeletAllPhones();
                    ClearModelTextBoxes();
                    ClearEditTextBoxes();
                    MobileRepository.DelOptionsFromLst();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Список телефонов пуст! Добавьте список телефонов из xml-файла, либо добавьте вручную, в разделе 'редактирование информации'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         }
        /// <summary>
        /// кнопка "Сохранить изменения"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e) 
        {
            MobilePhone mbPhone = lstPhones.SelectedItem as MobilePhone;
            if (mbPhone != null)
            {
                EditInfo(mbPhone);
                mbPhone.RemoveOptions();//удаляет опции из списка опций телефона
                foreach (string item in chkLstOptions.CheckedItems) //проходит по строчкам(галочкам), которые польз-ль выделил
                {
                    mbPhone.AddOption(item);//добавляет текущую опцию в список опций текущего телефона 
                }
                MobileRepository.Save("data.xml"); //сохранить объект MobileDataBase в котором находится лист телефонов со своими опциями и лист всех опций в xml 
                MobileRepository.Load("data.xml");
                //chkLstOptions.DataSource = MobileRepository.GetOptions(); // привязка checklistbox к общему списку опций(возвращает после подгрузки из xml)
                lstPhones.DataSource = MobileRepository.GetPhones();
            }                 
        } 
        /// <summary>
        /// кнопка "очистить список"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEditTextBoxes();
        }        
        /// <summary>
        /// кнопка "Добавить новый телефон"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            MobilePhone newMbPhone = new MobilePhone()
            { Name = tbModelEdit.Text, Price = Convert.ToDecimal(tbEditPrice.Text), OsName = tbEditOs.Text, Processor = Convert.ToDouble(tbEditProc.Text),ImgPath = tbEditPct.Text };
            MobileRepository.GetPhones().Add(newMbPhone);
            foreach (string item in chkLstOptions.CheckedItems) //проходит по строчкам(галочкам), которые польз-ль выделил
            {
                newMbPhone.AddOption(item);//добавляет текущую опцию в список опций текущего телефона 
            }
            lstPhones.DataSource = MobileRepository.GetPhones();//привязка listphones к общему списку телефонов(возвращает после подгрузки из xml)
        }
        /// <summary>
        /// Кнопка загрузки картинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG*;.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG*;.GIF;*.PNG|All files(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    tbEditPct.Text = ofd.FileName;
                }
                catch (Exception)
                {

                    MessageBox.Show("Невозможно открыть файл","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }       

        #region supportMethods for Form tools
        private void ClearEditTextBoxes()
        {
            tbModelEdit.Clear();
            tbEditProc.Clear();
            tbEditPrice.Clear();
            tbEditOs.Clear();
            tbEditPct.Clear();
        }
        private void ClearModelTextBoxes()
        {
            tbModel.Clear();
            tbOptName.Clear();
            tbPrice.Clear();
            tbProcessor.Clear();
            tbOS.Clear();
            pctPhone.Image = null;
            
        }
        /// <summary>
        /// возвращает состояние отметок chkLstOptions до удаления/добавления
        /// </summary>
        /// <param name="mbPhone"></param>
        private void CheckCheckedListChanging(MobilePhone mbPhone)
        {
            foreach (string option in mbPhone.opList)//проходит по всем опциям в oplist данного телефона(выделенного)
            {
                var optionIndex = MobileRepository.GetOptions().IndexOf(option);//возвращает какой индекс option имеет в коллекции phones .
                chkLstOptions.SetItemChecked(optionIndex, true);//чекает
            }
        }
        private void SetEditTextBoxes(MobilePhone mbPhone)
        {
            tbModelEdit.Text = mbPhone.Name;
            tbEditProc.Text = mbPhone.Processor.ToString();
            tbEditPrice.Text = mbPhone.Price.ToString();
            tbEditOs.Text = mbPhone.OsName;
            tbEditPct.Text = mbPhone.ImgPath;
        }
        private void SetModelTextBoxes(MobilePhone mbPhone)
        {
            lstOptions.Items.Clear(); // очищает lstoptions, чтобы при переключении показывались уникальные опции каждого ,а не суммировались
            tbModel.Text = mbPhone.Name;
            tbPrice.Text = mbPhone.Price.ToString();
            tbOS.Text = mbPhone.OsName;
            tbProcessor.Text = mbPhone.Processor.ToString();
            pctPhone.Image = new Bitmap(mbPhone.ImgPath);            
        }

        private void EditInfo(MobilePhone mbPhone)
        {
            mbPhone.Name = tbModelEdit.Text;
            mbPhone.ImgPath = tbEditPct.Text;
            mbPhone.OsName = tbEditOs.Text;
            mbPhone.Processor = Convert.ToDouble(tbEditProc.Text);
            mbPhone.Price = Convert.ToDecimal(tbEditPrice.Text);
            tbModel.Text = tbModelEdit.Text;
            tbOS.Text = tbEditOs.Text;
            tbProcessor.Text = tbEditProc.Text;
            tbPrice.Text = tbEditPrice.Text;            
        }

        #endregion     
    }
}