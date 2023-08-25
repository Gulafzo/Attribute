using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	internal class Task1Beater
	{
		public void ChangeUnchangable(object @class)
		{
			var type= @class.GetType();

			var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			foreach (var field in fields)
			{
				field.SetValue(@class, 999);
			}
			
		}
	}
}
