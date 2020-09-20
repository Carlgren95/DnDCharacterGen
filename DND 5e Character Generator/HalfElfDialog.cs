using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_5e_Character_Generator.UtilityClasses
{
	public partial class HalfElfDialog : Form
	{
		// Integers used to pass values to the main form based on selections within this form.
		public int r1;
		public int r2;
		public HalfElfDialog()
		{
			InitializeComponent();
			// Setting comboboxes to default values in case the user doesn't change any of them.
			cbxAbility1.SelectedIndex = 0;
			cbxAbility2.SelectedIndex = 0;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (cbxAbility1.SelectedIndex == cbxAbility2.SelectedIndex)
			{
				MessageBox.Show("Please select two different ability scores.");
			}
			else
			{
				r1 = cbxAbility1.SelectedIndex;
				r2 = cbxAbility2.SelectedIndex;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			r1 = 0;
			r2 = 0;
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
