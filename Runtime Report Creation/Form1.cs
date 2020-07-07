using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace RuntimeReportCreation
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string path = string.Empty;

		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Button button1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			// How to Activate
			//Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
			//Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
			//Stimulsoft.Base.StiLicense.LoadFromStream(stream);

			InitializeComponent();

            if (File.Exists("..\\Data\\Demo.xsd")) dataSet1.ReadXmlSchema("..\\Data\\Demo.xsd");
			else MessageBox.Show("File \"Demo.xsd\" not found");

			if (File.Exists("..\\Data\\Demo.xsd")) dataSet1.ReadXml("..\\Data\\Demo.xml");
			else MessageBox.Show("File \"Demo.xml\" not found");

			dataSet1.DataSetName = "Demo";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build Report";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 349);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runtime Report Creation";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			// Enable HiDPI mode
			Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			var report = new StiReport();

			//Add data to datastore
			report.RegData(dataSet1);

			//Fill dictionary
			report.Dictionary.Synchronize();

			var page = report.Pages[0];

			//Create HeaderBand
			var headerBand = new StiHeaderBand();
			headerBand.Height = 0.5;
			headerBand.Name = "HeaderBand";
			page.Components.Add(headerBand);

			//Create text on header
			var headerText = new StiText(new RectangleD(0, 0, 5, 0.5));
			headerText.Text = "CompanyName";
			headerText.HorAlignment = StiTextHorAlignment.Center;
			headerText.Name = "HeaderText";
			headerText.Brush = new StiSolidBrush(Color.LightGreen);
			headerBand.Components.Add(headerText);
			
			//Create Databand
			var dataBand = new StiDataBand();
			dataBand.DataSourceName = "Customers";
			dataBand.Height = 0.5;
			dataBand.Name = "DataBand";
			page.Components.Add(dataBand);

			//Create text
			var dataText = new StiText(new RectangleD(0, 0, 5, 0.5));
			dataText.Text = "{Line}.{Customers.CompanyName}";
			dataText.Name = "DataText";
			dataBand.Components.Add(dataText);

			//Create FooterBand
			var footerBand = new StiFooterBand();
			footerBand.Height = 0.5;
			footerBand.Name = "FooterBand";
			page.Components.Add(footerBand);

			//Create text on footer
			var footerText = new StiText(new RectangleD(0, 0, 5, 0.5));
			footerText.Text = "Count - {Count()}";
			footerText.HorAlignment = StiTextHorAlignment.Right;
			footerText.Name = "FooterText";
			footerText.Brush = new StiSolidBrush(Color.LightGreen);
			footerBand.Components.Add(footerText);

			report.Show();
		}
	}
}
