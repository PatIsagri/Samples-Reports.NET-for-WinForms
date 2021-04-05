using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace SelectingColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema("..\\Data\\Demo.xsd");
            data.ReadXml("..\\Data\\Demo.xml");

            var report = new StiReport();
            report.Load("..\\SelectingColumns.mrt");
            report.RegData(data);
            report.Design();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema("..\\Data\\Demo.xsd");
            data.ReadXml("..\\Data\\Demo.xml");

            var report = new StiReport();
            report.Load("..\\SelectingColumns.mrt");
            report.RegData(data);
            report.Show();
        }
    }
}