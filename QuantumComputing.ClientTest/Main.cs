using System.ComponentModel;

namespace QuantumComputing.ClientTest
{
	public partial class Main : Form
	{
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public App _App { get; set; }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public PatientFile PatientFile { get; set; }

		public Main()
		{
			InitializeComponent();

			this._App = new App();
			this._App.QuantumCube.OnResultReady += QuantumCube_OnResultReady;

			this.PatientFile = new PatientFile();
			this.PatientFile.Name = "Patient a";
		}

		private void button1_ClickAsync(object sender, EventArgs e)
		{
			decimal sugar;
			decimal choslestorol;
			decimal oxygen;

			decimal.TryParse(this.txtSugar.Text, out sugar);
			decimal.TryParse(this.txtChoslestorol.Text, out choslestorol);
			decimal.TryParse(this.txtOxygen.Text, out oxygen);

			this.PatientFile.Sugar = sugar;
			this.PatientFile.Choslestorol = choslestorol;
			this.PatientFile.Oxygen = oxygen;

			this._App.Run(this.PatientFile);
		}


		private void QuantumCube_OnResultReady(State<PatientFile> quantumCube)
		{
			MessageBox.Show(quantumCube.Name);
		}
	}
}
