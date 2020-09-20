namespace DND_5e_Character_Generator.UtilityClasses
{
	partial class HalfElfDialog
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
			this.lblHalfElfPrompt = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbxAbility1 = new System.Windows.Forms.ComboBox();
			this.cbxAbility2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblHalfElfPrompt
			// 
			this.lblHalfElfPrompt.AutoSize = true;
			this.lblHalfElfPrompt.Location = new System.Drawing.Point(12, 9);
			this.lblHalfElfPrompt.Name = "lblHalfElfPrompt";
			this.lblHalfElfPrompt.Size = new System.Drawing.Size(364, 13);
			this.lblHalfElfPrompt.TabIndex = 0;
			this.lblHalfElfPrompt.Text = "Please select an additional two non-Charisma abiltiy scores to increase by 1:";
			// 
			// btnConfirm
			// 
			this.btnConfirm.Enabled = false;
			this.btnConfirm.Location = new System.Drawing.Point(218, 36);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 12;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(299, 36);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbxAbility1
			// 
			this.cbxAbility1.FormattingEnabled = true;
			this.cbxAbility1.Items.AddRange(new object[] {
            "Str",
            "Dex",
            "Con",
            "Int",
            "Wis"});
			this.cbxAbility1.Location = new System.Drawing.Point(12, 38);
			this.cbxAbility1.Name = "cbxAbility1";
			this.cbxAbility1.Size = new System.Drawing.Size(36, 21);
			this.cbxAbility1.TabIndex = 14;
			// 
			// cbxAbility2
			// 
			this.cbxAbility2.FormattingEnabled = true;
			this.cbxAbility2.Items.AddRange(new object[] {
            "Str",
            "Dex",
            "Con",
            "Int",
            "Wis"});
			this.cbxAbility2.Location = new System.Drawing.Point(54, 38);
			this.cbxAbility2.Name = "cbxAbility2";
			this.cbxAbility2.Size = new System.Drawing.Size(36, 21);
			this.cbxAbility2.TabIndex = 15;
			// 
			// HalfElfDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 71);
			this.Controls.Add(this.cbxAbility2);
			this.Controls.Add(this.cbxAbility1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.lblHalfElfPrompt);
			this.Name = "HalfElfDialog";
			this.Text = "Half Elf Ability Score Bonuses";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHalfElfPrompt;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbxAbility1;
		private System.Windows.Forms.ComboBox cbxAbility2;
	}
}