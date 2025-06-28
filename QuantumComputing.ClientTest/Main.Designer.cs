namespace QuantumComputing.ClientTest
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnAnalize = new Button();
			txtSugar = new TextBox();
			lblSugar = new Label();
			lblCholestorol = new Label();
			txtChoslestorol = new TextBox();
			lblOxygen = new Label();
			txtOxygen = new TextBox();
			SuspendLayout();
			// 
			// btnAnalize
			// 
			btnAnalize.Location = new Point(326, 158);
			btnAnalize.Name = "btnAnalize";
			btnAnalize.Size = new Size(75, 23);
			btnAnalize.TabIndex = 0;
			btnAnalize.Text = "Analize";
			btnAnalize.UseVisualStyleBackColor = true;
			btnAnalize.Click += button1_ClickAsync;
			// 
			// txtSugar
			// 
			txtSugar.Location = new Point(157, 71);
			txtSugar.Name = "txtSugar";
			txtSugar.Size = new Size(244, 23);
			txtSugar.TabIndex = 1;
			// 
			// lblSugar
			// 
			lblSugar.AutoSize = true;
			lblSugar.Location = new Point(83, 74);
			lblSugar.Name = "lblSugar";
			lblSugar.Size = new Size(37, 15);
			lblSugar.TabIndex = 2;
			lblSugar.Text = "Sugar";
			// 
			// lblCholestorol
			// 
			lblCholestorol.AutoSize = true;
			lblCholestorol.Location = new Point(83, 103);
			lblCholestorol.Name = "lblCholestorol";
			lblCholestorol.Size = new Size(68, 15);
			lblCholestorol.TabIndex = 4;
			lblCholestorol.Text = "Cholestorol";
			// 
			// txtChoslestorol
			// 
			txtChoslestorol.Location = new Point(157, 100);
			txtChoslestorol.Name = "txtChoslestorol";
			txtChoslestorol.Size = new Size(244, 23);
			txtChoslestorol.TabIndex = 3;
			// 
			// lblOxygen
			// 
			lblOxygen.AutoSize = true;
			lblOxygen.Location = new Point(83, 132);
			lblOxygen.Name = "lblOxygen";
			lblOxygen.Size = new Size(48, 15);
			lblOxygen.TabIndex = 6;
			lblOxygen.Text = "Oxygen";
			// 
			// txtOxygen
			// 
			txtOxygen.Location = new Point(157, 129);
			txtOxygen.Name = "txtOxygen";
			txtOxygen.Size = new Size(244, 23);
			txtOxygen.TabIndex = 5;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(561, 321);
			Controls.Add(lblOxygen);
			Controls.Add(txtOxygen);
			Controls.Add(lblCholestorol);
			Controls.Add(txtChoslestorol);
			Controls.Add(lblSugar);
			Controls.Add(txtSugar);
			Controls.Add(btnAnalize);
			Name = "Main";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAnalize;
		private TextBox txtSugar;
		private Label lblSugar;
		private Label lblCholestorol;
		private TextBox txtChoslestorol;
		private Label lblOxygen;
		private TextBox txtOxygen;
	}
}
