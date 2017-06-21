using System.Drawing;

namespace ClassInstanceTracker.Buttons
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// 
	/// This button inherits from BaseButton and has its own customization.
	/// </summary>
	public class BlackButton : BaseButton
	{
		private const string BUTTON_TEXT = "Black";

		public BlackButton()
		{
			Text = BUTTON_TEXT;
			ForeColor = Color.White;
			BackColor = Color.Black;
		}
	}
}
