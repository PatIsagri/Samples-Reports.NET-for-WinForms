using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Components;

namespace Using_the_Report_Page_Canvas_for_the_Copyrights
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		public enum Position
		{
			Front,
			Behind
		}

		public enum Place
		{
			TopLeft,
			TopRight,
			Center,
			BottomLeft,
			BottomRight
		}

		private string path = string.Empty;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbCopyright;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbBehind;
		private System.Windows.Forms.RadioButton rbFront;
		private System.Windows.Forms.RadioButton rbTopRight;
		private System.Windows.Forms.RadioButton rbBottomLeft;
		private System.Windows.Forms.RadioButton rbBottomRight;
		private System.Windows.Forms.RadioButton rbCenter;
		private System.Windows.Forms.RadioButton rbTopLeft;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbRectClient;
		private System.Windows.Forms.RadioButton rbRectFull;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbDesigner;
		private System.Windows.Forms.CheckBox cbPreview;
		private System.Windows.Forms.CheckBox cbPrinter;
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

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            dataSet1.ReadXmlSchema("..\\Data\\Demo.xsd");
            dataSet1.ReadXml("..\\Data\\Demo.xml");

            tbCopyright.Text = "(C) " + DateTime.Now.Year.ToString() + " My Company";
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
            this.tbCopyright = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBehind = new System.Windows.Forms.RadioButton();
            this.rbFront = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTopRight = new System.Windows.Forms.RadioButton();
            this.rbBottomLeft = new System.Windows.Forms.RadioButton();
            this.rbBottomRight = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbTopLeft = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbRectClient = new System.Windows.Forms.RadioButton();
            this.rbRectFull = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new System.Data.DataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDesigner = new System.Windows.Forms.CheckBox();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCopyright
            // 
            this.tbCopyright.Location = new System.Drawing.Point(128, 8);
            this.tbCopyright.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCopyright.Name = "tbCopyright";
            this.tbCopyright.Size = new System.Drawing.Size(186, 20);
            this.tbCopyright.TabIndex = 0;
            this.tbCopyright.Text = "(C) 2010 MyCompany";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright string";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Preview";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBehind);
            this.groupBox1.Controls.Add(this.rbFront);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(144, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // rbBehind
            // 
            this.rbBehind.Location = new System.Drawing.Point(8, 38);
            this.rbBehind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBehind.Name = "rbBehind";
            this.rbBehind.Size = new System.Drawing.Size(104, 23);
            this.rbBehind.TabIndex = 1;
            this.rbBehind.Text = "Behind";
            // 
            // rbFront
            // 
            this.rbFront.Checked = true;
            this.rbFront.Location = new System.Drawing.Point(8, 16);
            this.rbFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFront.Name = "rbFront";
            this.rbFront.Size = new System.Drawing.Size(104, 23);
            this.rbFront.TabIndex = 0;
            this.rbFront.TabStop = true;
            this.rbFront.Text = "Front";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTopRight);
            this.groupBox2.Controls.Add(this.rbBottomLeft);
            this.groupBox2.Controls.Add(this.rbBottomRight);
            this.groupBox2.Controls.Add(this.rbCenter);
            this.groupBox2.Controls.Add(this.rbTopLeft);
            this.groupBox2.Location = new System.Drawing.Point(168, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(144, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Place";
            // 
            // rbTopRight
            // 
            this.rbTopRight.Location = new System.Drawing.Point(8, 38);
            this.rbTopRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTopRight.Name = "rbTopRight";
            this.rbTopRight.Size = new System.Drawing.Size(104, 23);
            this.rbTopRight.TabIndex = 1;
            this.rbTopRight.Text = "TopRight";
            // 
            // rbBottomLeft
            // 
            this.rbBottomLeft.Location = new System.Drawing.Point(8, 84);
            this.rbBottomLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBottomLeft.Name = "rbBottomLeft";
            this.rbBottomLeft.Size = new System.Drawing.Size(104, 23);
            this.rbBottomLeft.TabIndex = 3;
            this.rbBottomLeft.Text = "BottomLeft";
            // 
            // rbBottomRight
            // 
            this.rbBottomRight.Location = new System.Drawing.Point(8, 108);
            this.rbBottomRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBottomRight.Name = "rbBottomRight";
            this.rbBottomRight.Size = new System.Drawing.Size(104, 23);
            this.rbBottomRight.TabIndex = 4;
            this.rbBottomRight.Text = "BottomRight";
            // 
            // rbCenter
            // 
            this.rbCenter.Location = new System.Drawing.Point(8, 61);
            this.rbCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(104, 23);
            this.rbCenter.TabIndex = 2;
            this.rbCenter.Text = "Center";
            // 
            // rbTopLeft
            // 
            this.rbTopLeft.Checked = true;
            this.rbTopLeft.Location = new System.Drawing.Point(8, 16);
            this.rbTopLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTopLeft.Name = "rbTopLeft";
            this.rbTopLeft.Size = new System.Drawing.Size(104, 23);
            this.rbTopLeft.TabIndex = 0;
            this.rbTopLeft.TabStop = true;
            this.rbTopLeft.Text = "TopLeft";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbRectClient);
            this.groupBox3.Controls.Add(this.rbRectFull);
            this.groupBox3.Location = new System.Drawing.Point(8, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(144, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paint Rectangle";
            // 
            // rbRectClient
            // 
            this.rbRectClient.Location = new System.Drawing.Point(8, 38);
            this.rbRectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRectClient.Name = "rbRectClient";
            this.rbRectClient.Size = new System.Drawing.Size(104, 23);
            this.rbRectClient.TabIndex = 1;
            this.rbRectClient.Text = "Client";
            // 
            // rbRectFull
            // 
            this.rbRectFull.Checked = true;
            this.rbRectFull.Location = new System.Drawing.Point(8, 16);
            this.rbRectFull.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRectFull.Name = "rbRectFull";
            this.rbRectFull.Size = new System.Drawing.Size(104, 23);
            this.rbRectFull.TabIndex = 0;
            this.rbRectFull.TabStop = true;
            this.rbRectFull.Text = "Full";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 216);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Close";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDesigner);
            this.groupBox4.Controls.Add(this.cbPreview);
            this.groupBox4.Controls.Add(this.cbPrinter);
            this.groupBox4.Location = new System.Drawing.Point(8, 177);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(304, 31);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // cbDesigner
            // 
            this.cbDesigner.Checked = true;
            this.cbDesigner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDesigner.Location = new System.Drawing.Point(8, 9);
            this.cbDesigner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDesigner.Name = "cbDesigner";
            this.cbDesigner.Size = new System.Drawing.Size(80, 19);
            this.cbDesigner.TabIndex = 0;
            this.cbDesigner.Text = "Designer";
            // 
            // cbPreview
            // 
            this.cbPreview.Checked = true;
            this.cbPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreview.Location = new System.Drawing.Point(104, 9);
            this.cbPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(72, 19);
            this.cbPreview.TabIndex = 0;
            this.cbPreview.Text = "Preview";
            // 
            // cbPrinter
            // 
            this.cbPrinter.Checked = true;
            this.cbPrinter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrinter.Location = new System.Drawing.Point(192, 9);
            this.cbPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(104, 19);
            this.cbPrinter.TabIndex = 0;
            this.cbPrinter.Text = "Printer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 250);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCopyright);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using the Report Page Canvas for the Copyrights";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

            StiPage.PagePainting += new StiPagePaintEventHandler(OnPagePainting);
			StiPage.PagePainted += new StiPagePaintEventHandler(OnPagePainted);

            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private static string Using_the_Report_Page_Canvas_for_the_Copyrightstring = "";
		private static Position copyrightPosition;
		private static Place copyrightPlace;
		private static bool rectClient = false;
		private static bool rectFull = false;
		private static bool printer = false;
		private static bool preview = false;
		private static bool designer = false;

		private static void OnPagePainting(StiPage sender, StiPagePaintEventArgs e)
		{
			if (copyrightPosition == Position.Behind)
			{
				var page = sender as StiPage;
				DrawCopyright(page, e);
			}

		}

		private static void OnPagePainted(StiPage sender, StiPagePaintEventArgs e)
		{
			if (copyrightPosition == Position.Front)
			{
				var page = sender as StiPage;
				DrawCopyright(page, e);
			}

		}

		private static void DrawCopyright(StiPage page, StiPagePaintEventArgs e)
		{
			if (e.IsPrinting && (!printer)) return;
			if (e.IsDesigning && (!designer)) return;
			if ((!e.IsDesigning) && (!e.IsPrinting) && (!preview)) return;

			var rect = e.FullRectangle;
			if (rectClient)rect = e.ClientRectangle;

			using (Font font = new Font("Arial", 20 * (float)page.Zoom))
			using (StringFormat sf = new StringFormat())
			{
				switch (copyrightPlace)
				{
					case Place.TopLeft:
						sf.Alignment = StringAlignment.Near;
						sf.LineAlignment = StringAlignment.Near;
						break;

					case Place.TopRight:
						sf.Alignment = StringAlignment.Far;
						sf.LineAlignment = StringAlignment.Near;
						break;

					case Place.Center:
						sf.Alignment = StringAlignment.Center;
						sf.LineAlignment = StringAlignment.Center;
						break;

					case Place.BottomLeft:
						sf.Alignment = StringAlignment.Near;
						sf.LineAlignment = StringAlignment.Far;
						break;

					case Place.BottomRight:
						sf.Alignment = StringAlignment.Far;
						sf.LineAlignment = StringAlignment.Far;
						break;
				}

				e.Graphics.DrawString(Using_the_Report_Page_Canvas_for_the_Copyrightstring, font, Brushes.Red, rect, sf);
			}
		}

		private void FillCopyrightParam()
		{
			Using_the_Report_Page_Canvas_for_the_Copyrightstring = tbCopyright.Text;
			if (rbBehind.Checked)copyrightPosition = Position.Behind;
			else copyrightPosition = Position.Front;

            if (rbTopLeft.Checked) copyrightPlace = Place.TopLeft;
            else if (rbTopRight.Checked) copyrightPlace = Place.TopRight;
            else if (rbCenter.Checked) copyrightPlace = Place.Center;			
            else if (rbBottomLeft.Checked) copyrightPlace = Place.BottomLeft;
            else if (rbBottomRight.Checked) copyrightPlace = Place.BottomRight;

			rectFull = rbRectFull.Checked;
			rectClient = rbRectClient.Checked;

			printer = cbPrinter.Checked;
			preview = cbPreview.Checked;
			designer = cbDesigner.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			FillCopyrightParam();
			
			var report = new StiReport();
			report.RegData(dataSet1);
			report.Load("..\\Copyrights.mrt");
			report.Design();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			FillCopyrightParam();

			var report = new StiReport();
			report.RegData(dataSet1);
			report.Load("..\\Copyrights.mrt");
			report.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
