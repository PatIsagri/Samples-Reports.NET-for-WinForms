using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;

namespace CustomComponent
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Run Designer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			AddCustomComponent();

			Application.Run(new Form1());
		}

		private static void AddCustomComponent()
		{
			StiConfig.Load();

			StiOptions.Engine.ReferencedAssemblies
				 = new string[]{
							"System.Dll",
							"System.Drawing.Dll",
							"System.Windows.Forms.Dll",
							"System.Data.Dll",
							"System.Xml.Dll",
							"Stimulsoft.Controls.Dll",
							"Stimulsoft.Base.Dll",
							"Stimulsoft.Report.Dll",

							#region Add reference to your assembly
							"CustomComponent.exe"
							#endregion
						};

			StiConfig.Services.Add(new MyCustomComponent());
			StiConfig.Services.Add(new MyCustomComponentWithDataSource());
			StiConfig.Save();


		}

		private void button1_Click(object sender, System.EventArgs e)
		{			
            StiReport report = new StiReport();
			report.Design();
		}
	}
}