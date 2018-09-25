using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XmlReadArtists.CDREpository;
using XmlReadArtists.ProducerRepository1;

namespace XmlReadArtists
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var queryResult = listOfDisc.Where(el => el.Year > 1991).Select(el=>new
            {
                Artist =el.Artist
            }).ToList();
            dataGridView1.DataSource = queryResult;        
        }      

        private void btnQuery2_Click_1(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var queryResult = listOfDisc.Select(el => new
            {
                Country = el.Country
            }).Distinct().ToList();
            dataGridView1.DataSource = queryResult;            
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var queryResult = listOfDisc.Where(el=>el.Country=="USA").OrderBy(el=>el.Year).Select(el => new
            {
                Title = el.Title
            }).ToList();
            dataGridView1.DataSource = queryResult;            
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var queryResult = listOfDisc.GroupBy(el =>el.Country).Select(g=> new { Country = g.Key, TotalPrice = Math.Round(g.Sum(el => el.Price),2) }).ToList();
            dataGridView1.DataSource = queryResult;            
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");            
            var queryResult = listOfDisc.GroupBy(el => new { el.Company, el.Year }).Select(g => new {  Company = g.Key.Company, Count = g.Count(),Year = g.Key.Year }).OrderBy(el => el.Year).ToList();
            dataGridView1.DataSource = queryResult;
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var listOfProducers = ProducerRepository.ReadXmlCallProd("cd_catalog _2.xml");
            var maxValue = (from p in listOfProducers select p.Fee).Max();
            var info = from d in listOfDisc
                       join p in listOfProducers
                       on d.Producer equals p.Id
                       where p.Fee ==maxValue 
                       select new
                       {
                           Title = d.Title,
                           Name = p.Name
                       };
            var queryResult = info.ToList();            
            dataGridView2.DataSource = queryResult;
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var listOfProducers = ProducerRepository.ReadXmlCallProd("cd_catalog _2.xml");
            var info = from d in listOfDisc
                       join p in listOfProducers
                       on d.Producer equals p.Id
                       where d.Year>=1988&&d.Year<=1990
                       group p by p.Name into g
                       select new
                       {
                           Name = g.Key,
                           Count =g.Count()
                       };
            var queryResult = info.ToList();
            dataGridView2.DataSource = queryResult;
            #region Equal with method(My example)
            //var info2 = listOfDisc.Where(d => d.Year >= 1988 && d.Year <= 1990).GroupBy(d => d.Producer).Select(g => new { Producer = g.Key, Count = g.Count() })
            //    .Join(listOfProducers,d=>d.Producer,p=>p.Id, (d, p) => new {p.Name,d.Count}).ToList();
            #endregion
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var listOfProducers = ProducerRepository.ReadXmlCallProd("cd_catalog _2.xml");
            var lastFee = (from p in listOfProducers select p.Date).Max();
            var queryResult = listOfProducers.Where(p => p.Date == lastFee).Select(el=>new
            {
                Name = el.Name,
                Date = el.Date
            }).ToList();
            dataGridView2.DataSource = queryResult;
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var listOfProducers = ProducerRepository.ReadXmlCallProd("cd_catalog _2.xml");
            var cheapestAlbum = (from p in listOfDisc select p.Price).Min();
            var info = from d in listOfDisc
                       join p in listOfProducers
                       on d.Producer equals p.Id
                       where d.Price == cheapestAlbum
                       select new
                       {
                           Title = d.Title,
                           Artist = d.Artist,
                           Producer = p.Name
                       };
            var queryResult = info.ToList();
            dataGridView2.DataSource = queryResult;
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            DatagridClear();
            var listOfDisc = CdRepository.ReadXmlToCollection("cd_catalog _1.xml");
            var listOfProducers = ProducerRepository.ReadXmlCallProd("cd_catalog _2.xml");
            var queryResult = listOfDisc.OrderBy(el => el.Year).ThenBy(el => el.Price).ThenBy(el => el.Title).Join(listOfProducers, d => d.Producer, p => p.Id, (d, p) => new { listOfDisc = d, listOfProducers = p }).Select(el => new
            {
                Title = el.listOfDisc.Title,
                Artist = el.listOfDisc.Artist,
                Country = el.listOfDisc.Country,
                Company = el.listOfDisc.Company,
                Price = el.listOfDisc.Price,
                Year = el.listOfDisc.Year,
                Producer = el.listOfProducers.Name
            }).ToList();
            dataGridView1.DataSource = queryResult;
        }
        /// <summary>
        /// Method that clear datagrid 1 and datagrid 2
        /// </summary>
        public void DatagridClear()
        {
            dataGridView1.DataSource = new object();
            dataGridView2.DataSource = new object();
        } 
    }
}