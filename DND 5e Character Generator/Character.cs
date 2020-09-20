using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_5e_Character_Generator
{
	static class Character
	{
		// Inititalizes all variables with default values to avoid errors.
		public static string name = "";
		public static string playerName = "";
		public static string race = "";
		public static string subRace = "";
		public static string characterClass = "";
		public static string characterSubClass = "";
		public static string alignment = "";

		public static int proficiency = 2;
		public static int level = 1;
		public static int[] abilityScores = new int[] { 0, 0, 0, 0, 0, 0 };
		public static int[] abilityModifiers = new int[] { 0, 0, 0, 0, 0, 0}; 
		public static int[] abilityBonuses = new int[] { 0, 0, 0, 0, 0, 0 };
		public static int armorClass = 0;
		public static int arnorClassBonus = 0;
		public static int initiative = 0;
		public static int hitPoints = 0;
		public static int hitDice = 0;
		public static int hitDiceType = 0;
		public static int speed = 0;

		public static int[] saves = new int[] { 0, 0, 0, 0, 0, 0 };
		public static bool[] saveProficiencies = new bool[] { false, false, false, false, false, false };

		public static int[] skills = new int[] { 0, 0, 0, 0, 0, 0,
												 0, 0, 0, 0, 0, 0,
												 0, 0, 0, 0, 0, 0, };
		public static bool[] skillProficiencies = new bool[] { false, false, false, false, false, false,
															   false, false, false, false, false, false,
															   false, false, false, false, false, false };

		public static List<string> Inventory = new List<string>();
		public static List<string> Proficiencies = new List<string>();
		public static List<string> Features = new List<string>();

	}
}
