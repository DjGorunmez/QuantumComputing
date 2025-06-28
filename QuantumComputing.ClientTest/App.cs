namespace QuantumComputing.ClientTest
{
	public class App
	{
		public QuantumCube<PatientFile> QuantumCube { get; set; }

		public App()
		{
			this.QuantumCube = new QuantumCube<PatientFile>();

			this.QuantumCube.AddState(new COPD());
			this.QuantumCube.AddState(new Sugar());
			this.QuantumCube.AddState(new Flu());
		}

		public void Run(PatientFile value)
		{
			this.QuantumCube.SetValue(value);
			this.QuantumCube.Run();
		}

		public void Exit()
		{
			this.QuantumCube.Exit();
		}
	}

	public class PatientFile
	{
		public string Name { get; set; }

		public decimal Sugar { get; set; }
		public decimal Choslestorol { get; set; }
		public decimal Oxygen { get; set; }
	}

	public class COPD : State<PatientFile>
	{
		public override string Name { get; set; } = "COPD";

		public override void Operation()
		{
			if(this.Value.Oxygen < 60 || this.Value.Choslestorol > 60)
			{
				this.SetResult(this);
			}
		}
	}

	public class Sugar : State<PatientFile>
	{
		public override string Name { get; set; } = "Sugar";

		public override void Operation()
		{
			if(this.Value.Sugar > 50)
			{
				State<PatientFile> fluState = this.Find("Flu");
				if(fluState != null)
				{

				}

				this.SetResult(this);
			}
		}
	}

	public class Flu : State<PatientFile>
	{
		public override string Name { get; set; } = "Flu";

		public override void Operation()
		{
			if (this.Value.Oxygen < 70)
			{
				this.SetResult(this);
			}
		}
	}
}
