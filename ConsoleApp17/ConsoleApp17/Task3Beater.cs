using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	internal class Task3Beater
	{
		public void ChangeUnchangable(object @class)
		{
			var type = @class.GetType();
			var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			foreach (var field in fields)
			{
				if (field.GetCustomAttribute<ModifyFieldAttribute>() != null)
				{
					switch (field.GetValue(@class))
					{
						case int value:
							field.SetValue(@class, value + 10);
							break;
						case string value:
							field.SetValue(@class, value + "broken");
							break;
						case bool value:
							field.SetValue(@class, !value);
							break;
					}
				}
			}
		}
	}
}
