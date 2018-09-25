using MobileStore.Object;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace MobileStore.Repository
{
    public static class MobileRepository
    {
        private static BindingList<MobilePhone> phones;
        private static BindingList<string> options;
        static MobileRepository()
        {
            phones = new BindingList<MobilePhone>() { };        
            options = new BindingList<string>() { };            
        }
        /// <summary>
        /// возвращает лист телефонов
        /// </summary>
        /// <returns></returns>
        public static BindingList<MobilePhone> GetPhones()
        {
            return phones;
        }
        /// <summary>
        /// добавить телефон в коллекцию
        /// </summary>
        /// <param name="phone"></param>
        public static void AddPhone(MobilePhone phone)
        {
            phones.Add(phone);
        }
        /// <summary>
        /// возвращает лист опции
        /// </summary>
        /// <returns></returns>
        public static BindingList<string> GetOptions() 
        {            
            return options;
        }
        /// <summary>
        /// очистить список телефонов(phones)
        /// </summary>
        public static void DeletAllPhones()
        {
            phones.Clear();           
        }
        /// <summary>
        /// очистить список опций
        /// </summary>
        public static void DelOptionsFromLst()
        {
            options.Clear();
        }
        /// <summary>
        /// удаляет 1 телефон
        /// </summary>
        /// <param name="phone"></param>
        public static void DeletePhone(MobilePhone phone)
        { 
            if (phones.Count > 0)            
             phones.Remove(phone);
                
            
        }
        /// <summary>
        /// сохранить объект MobileDataBase в котором лист телефонов со своими опциями и лист всех опций в xml
        /// </summary>
        public static void Save(string filePath)
        {
            if(File.Exists(filePath))
            {
                File.Copy(filePath, Path.Combine(filePath,"_"+ DateTime.Now.ToString("yyyyMMddHHmmss")));//Backup
            }            
            using (FileStream file = new FileStream(filePath, FileMode.Create))
            {
                var db = new MobileDataBase() { MobilePhones = phones.ToList(), Options = options.ToList()  };
                XmlSerializer Formatter = new XmlSerializer(typeof(MobileDataBase));
                Formatter.Serialize(file, db);
            }
        }
        /// <summary>
        /// загружает из xml лист телефонов со своими опциями и лист всех опций в phones и в options
        /// </summary>
        public static void Load(string filePath)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer Formatter = new XmlSerializer(typeof(MobileDataBase));
                var db = Formatter.Deserialize(file) as MobileDataBase;
                phones = new BindingList<MobilePhone>(db.MobilePhones);
                options = new BindingList<string>(db.Options);
            }
        }
    }
}