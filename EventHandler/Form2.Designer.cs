namespace EventHandler
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonExit = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelNumber = new System.Windows.Forms.Label();
			this.labelDateTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(185, 187);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "&Close";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelNumber
			// 
			this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNumber.BackColor = System.Drawing.Color.Transparent;
			this.labelNumber.Location = new System.Drawing.Point(12, 70);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(248, 19);
			this.labelNumber.TabIndex = 1;
			this.labelNumber.Text = "labelNumber";
			this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDateTime
			// 
			this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDateTime.Location = new System.Drawing.Point(12, 126);
			this.labelDateTime.Name = "labelDateTime";
			this.labelDateTime.Size = new System.Drawing.Size(247, 17);
			this.labelDateTime.TabIndex = 2;
			this.labelDateTime.Text = "labelDateTime";
			this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(272, 222);
			this.Controls.Add(this.labelDateTime);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.buttonExit);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Label labelDateTime;
	}
}