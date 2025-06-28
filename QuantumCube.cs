


namespace QuantumComputing
{
	public class QuantumCube<TValue>
	{
		public delegate void ResultReady(State<TValue> quantumCube);
		public event ResultReady OnResultReady;

		public List<State<TValue>> States { get; set; }

		public TValue Value { get; set; }

		public State<TValue> Result { get; set; }

		public QuantumCube()
		{
			this.States = new List<State<TValue>>();
		}

		public QuantumCube<TValue> SetValue(TValue val)
		{
			this.Value = val;

			this.States.ForEach(i => i.Value = val);

			return this;
		}

		public void AddState(TValue val)
		{
			if(val != null)
			{
				State<TValue> state = new State<TValue>();
				state.Parent = this;
				state.Value = state.Parent.Value;

				this.States.Add(state);
			}
		}

		public void AddState(State<TValue> state)
		{
			if(state != null)
			{
				state.Parent = this;
				state.Value = state.Parent.Value;

				this.States.Add(state);
			}
		}

		public void Exit()
		{
			if (this.States.Any())
			{
				this.States.ForEach(i => i.Exit());
			}
		}

		public void Run()
		{
			this.States.ForEach(i => i.Run());
		}

		public State<TValue> Find(string name)
		{
			if(this.States.Any())
				return this.States.FirstOrDefault(i => i.Name == name);

			return null;
		}

		public void SetResult(State<TValue> state)
		{
			this.Result = state;

			if (this.OnResultReady != null)
				this.OnResultReady(state);
		}
	}

	public class State<TValue>
	{
		public virtual string Name { get; set; }

		public Thread Thread { get; set; }
		public QuantumCube<TValue> Parent { get; set; }

		public TValue Value { get; set; }

		public virtual void Run()
		{
			Thread = new Thread(new ThreadStart(Operation));
			Thread.Start();
		}

		public virtual void Exit()
		{

		}

		public virtual void Operation()
		{
			//(object)this.Value;
			
		}

		public virtual State<TValue> Find(string name)
		{
			return this.Parent.Find(name);
		}

		public void SetResult(State<TValue> state)
		{
			this.Parent.SetResult(state);
		}
	}
}
