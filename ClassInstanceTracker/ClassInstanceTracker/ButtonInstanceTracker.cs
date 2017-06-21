using ClassInstanceTracker.Buttons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInstanceTracker
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// 
	/// The mechanism that counts the number of times a set of classes have been instantiated.
	/// 
	/// This class will track all classes that inherit from the "BaseButton" class.
	/// 
	/// This class will also log out all the button instances currently available.
	/// </summary>
	public class ButtonInstanceTracker
	{
		private static ButtonInstanceTracker _instance;
		private ButtonInstanceTracker() { }
		public static ButtonInstanceTracker Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ButtonInstanceTracker();
				}

				return _instance;
			}
		}

		/// <summary>
		/// String builder used to generate the logs
		/// </summary>
		private StringBuilder _scratchStringBuilder = new StringBuilder();

		/// <summary>
		/// The Dictionary holds all the button instances with the type as the key and the list of buttons as the value.
		/// 
		/// NOTE: The WeakReference is important to make sure we only legitimate references to the button exist.
		/// If a WeakReference item is not alive, we remove it from the list.
		/// </summary>
		private Dictionary<Type, List<WeakReference>> _buttonInstances = new Dictionary<Type, List<WeakReference>>();

		/// <summary>
		/// Add a Button that was just instantiated.
		/// 
		/// This will add the button to the Dictionary
		/// </summary>
		/// <param name="button"></param>
		public void AddButton(BaseButton button)
		{
			Type currentType = button.GetType();

			if (!_buttonInstances.ContainsKey(currentType))
			{
				_buttonInstances.Add(currentType, new List<WeakReference>());
			}

			_buttonInstances[currentType].Add(new WeakReference(button));
		}

		/// <summary>
		/// Get the total alive count for a given type.
		/// </summary>
		/// <param name="type">the type of the instances we care about</param>
		/// <returns>the total alive instances of the given type</returns>
		public int GetCount(Type type)
		{
			int count = 0;

			if (!_buttonInstances.ContainsKey(type))
			{
				// we don't have any of this type
				return 0;
			}

			// track all the buttons that have been killed so that we can remove them from the list afterwards
			List<WeakReference> garbageCollectedList = new List<WeakReference>();
			foreach (WeakReference reference in _buttonInstances[type])
			{
				if (reference.IsAlive)
				{
					// this button is still alive. count it
					count++;
				}
				else
				{
					// this button has been killed. track it so we can remove it afterwards
					garbageCollectedList.Add(reference);
				}
			}

			// remove the killed buttons from the list
			foreach (WeakReference reference in garbageCollectedList)
			{
				_buttonInstances[type].Remove(reference);
			}

			return count;
		}

		/// <summary>
		/// Generate a log of all the types and the amount of instances per type
		/// </summary>
		/// <returns></returns>
		public string GetButtonInstancesInfo()
		{
			_scratchStringBuilder.Clear();

			foreach (var entry in _buttonInstances)
			{
				_scratchStringBuilder.Append(string.Format("{0} {1}", entry.Key.Name, GetCount(entry.Key)));
				_scratchStringBuilder.Append(Environment.NewLine);
			}

			return _scratchStringBuilder.ToString();
		}
	}
}
