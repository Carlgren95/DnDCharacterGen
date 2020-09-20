using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND_5e_Character_Generator.UtilityClasses;

namespace DND_5e_Character_Generator
{
	public partial class MainForm : Form
	{
		List<CheckBox> SkillProficiencyList = new List<CheckBox>();
		public MainForm()
		{
			InitializeComponent();

			// Subscribes the more generic AbilityTextChanged method to all relevant events.
			tbxStr.TextChanged += Utility.AbilityTextChanged;
			tbxDex.TextChanged += Utility.AbilityTextChanged;
			tbxCon.TextChanged += Utility.AbilityTextChanged;
			tbxInt.TextChanged += Utility.AbilityTextChanged;
			tbxWis.TextChanged += Utility.AbilityTextChanged;
			tbxCha.TextChanged += Utility.AbilityTextChanged;

			// Hides Windows Forms elements that refer to unfinished features from the user.
			gbxSkills.Hide();
			gbxProficiencies.Hide();
		}

		// Since different races have different ability bonuses, this method sets the values of the corresponding indexes in the abilityBonuses array to the correct values. 
		private void cbxRace_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Passes the value of the race combobox to the CalculateAbilityBonus method in the utility class.
			Utility.RaceSelection(cbxRace.Text);
		}

		private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Passes the value of the class combobox to assign saving throws and skill proficiencies.
			Utility.ClassSelection(cbxClass.Text);
		}

		private void menuItem3_Click(object sender, EventArgs e)
		{

		}

		// These methods are used to determine the values of the character's ability scores.
		// They just randomize a set of numbers, but do not assign them to any of the ability scores, as different character builds want different ability distributions.

		// One method for determining ability scores is the use of a standard array of set numbers. 
		private void btnStandardArray_Click(object sender, EventArgs e)
		{
			tbxStatRandom1.Text = "15";
			tbxStatRandom2.Text = "14";
			tbxStatRandom3.Text = "13";
			tbxStatRandom4.Text = "12";
			tbxStatRandom5.Text = "10";
			tbxStatRandom6.Text = "8";
		}

		// This method assigns random values based on a set of rules to the ability scores.
		// 3d6 adds 3 random numbers between 1 and 6 to determine the scores (rolling 3 6 sided dice).
		// 4-drop-1 randomizes 4 random numbers between 1 and 6, and drops the lowest one (rolling 4 6 sided dice). This leads to more consistent ability scores. 
		private void btnRandomize_Click(object sender, EventArgs e)
		{
			switch (cbxRandomize.GetItemText(cbxRandomize.SelectedItem))
			{
				case "3d6":
					{
						Utility.RandomizeStats(false, tbxStatRandom1);
						Utility.RandomizeStats(false, tbxStatRandom2);
						Utility.RandomizeStats(false, tbxStatRandom3);
						Utility.RandomizeStats(false, tbxStatRandom4);
						Utility.RandomizeStats(false, tbxStatRandom5);
						Utility.RandomizeStats(false, tbxStatRandom6);
						break;
					}
				case "4-drop-1":
					{
						Utility.RandomizeStats(true, tbxStatRandom1);
						Utility.RandomizeStats(true, tbxStatRandom2);
						Utility.RandomizeStats(true, tbxStatRandom3);
						Utility.RandomizeStats(true, tbxStatRandom4);
						Utility.RandomizeStats(true, tbxStatRandom5);
						Utility.RandomizeStats(true, tbxStatRandom6);
						break;
					}
				default:
					{
						MessageBox.Show("Please select a method for randomizing stats.");
						break;
					}

			}
		}

		// Assigns the generated values to random ability scores
		private void btnAssignRandom_Click(object sender, EventArgs e)
		{
			List<int> l = new List<int>();
			int i = 0;
			// Parse the randomized values in the ability randomizer textboxes as integers, and adding them to a a list. If the value can't be converted into an integer, it defaults to adding 0.
			foreach (Control t in pnlRandomizer.Controls.OfType<TextBox>())
			{
				try
				{
					l.Add(Int32.Parse(t.Text));
				}
				catch 
				{
					l.Add(0);
				}
			}

			// Shuffles the list and iterates through all textboxes in the appropriate panel, and sets their values to one of the indexes in the shuffled list.
			// i is used to keep track of list indexes to make sure that the same index isn't used twice.
			Utility.Shuffle(l);
			foreach (TextBox t in pnlAbilityScores.Controls.OfType<TextBox>())
			{
				t.Text = l[i].ToString();
				Utility.CalculateAbilityTotal(t);
				i++;
			}
		}
	}
}
