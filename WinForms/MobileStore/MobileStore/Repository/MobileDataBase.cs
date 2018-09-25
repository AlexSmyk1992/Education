using MobileStore.Object;
using System.Collections.Generic;


namespace MobileStore.Repository
{
    public class MobileDataBase
    {
        /// <summary>
        /// //список телефонов
        /// </summary>
        public List<MobilePhone> MobilePhones { get; set; }
        /// <summary>
        /// //общий список опций
        /// </summary>
        public List<string> Options { get; set; }
    }
}
