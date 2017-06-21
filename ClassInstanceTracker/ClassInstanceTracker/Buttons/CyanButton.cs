using System.Drawing;

namespace ClassInstanceTracker.Buttons
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// 
	/// This button inherits from BaseButton and has its own customization.
	/// </summary>
	public class CyanButton : BaseButton
	{
		private const string BUTTON_TEXT = "Cyan";

		public CyanButton()
		{
			Text = BUTTON_TEXT;
			BackColor = Color.Cyan;
		}
	}
}
