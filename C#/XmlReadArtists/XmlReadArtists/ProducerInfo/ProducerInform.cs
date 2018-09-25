using System;

namespace XmlReadArtists.ProducerInfo
{
    public class ProducerInform
    {
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
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private int fee;

        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }
    }
}
