using System;
using System.Collections.Generic;

namespace MobileStore.Object
{
    public class MobilePhone  
    {
        public MobilePhone()
        {
            opList = new List<string>();   // инициализация списка опций данного телефона в конструкторе             
        }
        public List<string> opList { get; private set; } //список опций данного телефона
        
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string osName;

        public string OsName
        {
            get { return osName; }
            set { osName = value; }
        }
        public double processor;

        public double Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        private string imgPath; 

        public string ImgPath //путь к картинке
        {
            get { return imgPath; }
            set { imgPath = value; }
        }
        private string OpPath; //путь к опциям

        public string opPath
        {
            get { return OpPath; }
            set { OpPath = value; }
        }
        /// <summary>
        /// добавляет опцию в opList(список опций данного телефона)
        /// </summary>
        /// <param name="Option"></param>
        public void AddOption(string Option)
        {
            opList.Add(Option);  
        }
        /// <summary>
        /// удаляет опции из списка опций телефона
        /// </summary>
        public void RemoveOptions()
        {
            opList.Clear();
        }

        public override string ToString()
        {
            return String.Format("{0}. {1} - {2}. Цена - {3}", name,osName,processor,price);
        }
    }
}
