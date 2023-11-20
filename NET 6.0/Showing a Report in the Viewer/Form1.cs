using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showing_a_Report_in_the_Viewer
{
    public partial class Form1 : Form
    {
        const string PathToMrtFile = @"Reports\MasterReportWithSubReports3.mrt";

        public Form1()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
            Stimulsoft.Base.StiLicense.Key = Environment.GetEnvironmentVariable("Reporting:StimulsoftLicenceKey");

            InitializeComponent();
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            StiReport report = CreateFromMrtFile(PathToMrtFile);

            report.Render();
            stiViewerControl1.Report = report;
        }

        private void buttonDialog_Click(object sender, EventArgs e)
        {
            StiReport report = CreateFromMrtFile(PathToMrtFile);

            report.Show();
            //report.ShowWithRibbonGUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private StiReport CreateFromMrtFile(string pathToMrtFile)
        {
            var report = new StiReport();
            report.GetSubReport += new StiGetSubReportEventHandler(Report_GetSubReport);
            report.Load(pathToMrtFile);
            return report;
        }

        private void Report_GetSubReport(object sender, StiGetSubReportEventArgs e)
        {
            e.Report = CreateFromMrtFile(@"Reports\TinySnippetReportHeader1.mrt");
        }
    }
}
