using ClassInstanceTracker.Buttons;
using System;
using System.Windows.Forms;

namespace ClassInstanceTracker
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// 
	/// The MainForm holds the UI, creates the test buttons, and logs the button instances.
	/// </summary>
	public partial class MainForm : Form
	{
		private const string DEFAULT_LOG_TEXT = "Refresh Log...";

		private Random rnd = new Random();
		
		/// <summary>
		/// Instantiate the Form and immediately setup the buttons
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			SetupButtons();
		}

		/// <summary>
		/// Completely clear the flow layout panel and random add the four button types.
		/// 
		/// Once instantiated, log the button instances
		/// </summary>
		private void SetupButtons()
		{
			_flowLayoutPanel.Controls.Clear();

			int cyanCount = rnd.Next(0, 8);
			int magentaCount = rnd.Next(0, 8);
			int yellowCount = rnd.Next(0, 8);
			int blackCount = rnd.Next(0, 8);

			InstantiateButton<CyanButton>(cyanCount);
			InstantiateButton<MagentaButton>(magentaCount);
			InstantiateButton<YellowButton>(yellowCount);
			InstantiateButton<BlackButton>(blackCount);

			LogButtonInstances();
		}

		/// <summary>
		/// Helper function to instantiate a sub-class of BaseButton, add its Click listener, and add to the flow layout panel.
		/// </summary>
		/// <typeparam name="T">The sub-class of BaseButton</typeparam>
		/// <param name="count">The amount of instances we want of the specified sub-class</param>
		private void InstantiateButton<T>(int count) where T : BaseButton, new()
		{
			// instantiate all buttons up to the count
			for (int i = 0; i < count; ++i)
			{
				BaseButton button = new T();
				button.Click += OnButtonClick;
				_flowLayoutPanel.Controls.Add(button);
			}
		}

		/// <summary>
		/// Log the button instances by passing the data to the logger.
		/// </summary>
		private void LogButtonInstances()
		{
			// NOTE: We force the Garbage Collection to prove that the ButtonInstanceTracker Singleton
			// is only keeping track of instances that are still alive.
			// THIS IS NOT IDEAL IN A REAL PRODUCT.
			GC.Collect();

			// log the button instances info
			_logger.Text = ButtonInstanceTracker.Instance.GetButtonInstancesInfo();
		}

		/// <summary>
		/// Clear the current log
		/// </summary>
		private void ClearLog()
		{
			_logger.Text = DEFAULT_LOG_TEXT;
		}

		#region Event Listeners

		/// <summary>
		/// Button click handler where the button is removed from the list,
		/// unsubscribes from the Click event, and disposes itself.
		/// </summary>
		/// <param name="sender">The button that was clicked</param>
		/// <param name="e"></param>
		private void OnButtonClick(object sender, EventArgs e)
		{
			var button = (BaseButton)sender;

			_flowLayoutPanel.Controls.Remove(button);
			button.Click -= OnButtonClick;
			button.Dispose();

			ClearLog();
		}

		/// <summary>
		/// Setup the buttons with a new setup.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRandmomizeClick(object sender, EventArgs e)
		{
			SetupButtons();
		}

		/// <summary>
		/// Refresh the Log of the Button Instances
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRefreshClick(object sender, EventArgs e)
		{
			LogButtonInstances();
		}

		#endregion
	}
}
