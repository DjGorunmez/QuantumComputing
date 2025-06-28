Quantum code your applications. You can define any state where every state lives in the Quantum app.
You can for example create ai.vision projects. Is example where it has been used.

#####################################################################################################

Define a Quatum app.

<pre>
  public class App
  {
  	public QuantumCube<PatientFile> QuantumCube { get; set; }
  
  	public App()
  	{
  		this.QuantumCube = new QuantumCube<PatientFile>();
  		this.QuantumCube.OnResultReady += QuantumCube_OnResultReady;
  
  		this.QuantumCube.AddState(new COPD());
  		this.QuantumCube.AddState(new Sugar());
  		this.QuantumCube.AddState(new Flu());
  	}
  
  	private void QuantumCube_OnResultReady(State<PatientFile> quantumCube)
  	{
  		if(quantumCube is COPD)
  		{
  			// Do COPD stuff here.
  		}
  
  		if (quantumCube is Sugar) 
  		{
  			// Do Suger stuff here.
  		}
  
  		if(quantumCube is Flu)
  		{
  			// Do Flu stuff here.
  		}
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
</pre>

Here we define a quantum cube with different illness domains. Where a patient file is set, to the states, on app run.
Each quantum state is checked. If present it will be returned to QuantumCube_OnResultReady event. You handle your code here.

In the example, the form project handles the ready event.

<pre>
  this._App = new App();
  this._App.QuantumCube.OnResultReady += QuantumCube_OnResultReady;
</pre>

<pre>
  private void QuantumCube_OnResultReady(State<PatientFile> quantumCube)
  {
  	MessageBox.Show(quantumCube.Name);
  }
</pre>

############################################################################################################################

Different state have been created here.

<pre>
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
</pre>

3 different states. You can define your own and add to the Quantum App.

#################################################################################################

This is the patient model file.

<pre>
  public class PatientFile
  {
  	public string Name { get; set; }
  
  	public decimal Sugar { get; set; }
  	public decimal Choslestorol { get; set; }
  	public decimal Oxygen { get; set; }
  }
</pre>

Run the app.
