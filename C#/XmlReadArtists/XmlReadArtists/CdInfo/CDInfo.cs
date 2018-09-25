namespace XmlReadArtists.CdInfo
{
    public class CDInfo
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private int producer;

        public int Producer
        {
            get { return producer; }
            set { producer = value; }
        }
    }
}
