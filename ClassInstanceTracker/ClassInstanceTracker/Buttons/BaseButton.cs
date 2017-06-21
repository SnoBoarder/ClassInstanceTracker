using System.Windows.Forms;

namespace ClassInstanceTracker.Buttons
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// 
	/// All sub-classes inherently add themselves to the ButtonInstanceTracker, allowing
	/// the sub-class to focus on its own specific complexity.
	/// </summary>
	public class BaseButton : Button
	{
		private const string BUTTON_TEXT = "Base";

		public BaseButton()
		{
			// add this instance
			ButtonInstanceTracker.Instance.AddButton(this);

			Text = BUTTON_TEXT;
		}
	}
}
