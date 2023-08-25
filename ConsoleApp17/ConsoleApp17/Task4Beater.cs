using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	internal class Task4Beater
	{
		public void ChangeUnchangable(object @class)
		{
			var type = @class.GetType();

			var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);


			foreach (var field in fields)
			{
				ModifyFieldAttribute[] attributes = field.GetCustomAttributes<ModifyFieldAttribute>(true).ToArray();

				foreach (ModifyFieldAttribute attribute in attributes)
				{
					if (attribute.TargetType == null || attribute.TargetType == field.FieldType)
					{
						object newValue = attribute.TargetModificationValue;

						if (newValue == null)
						{
							if (field.FieldType == typeof(bool))
							{
								newValue = !(bool)field.GetValue(@class);
							}
							else if (field.FieldType == typeof(int))
							{
								newValue = (int)field.GetValue(@class) + 10;
							}

						}

						field.SetValue(@class, newValue);
					}
				}
			}

		}
	}
}



public class Task4Beater
{
	public void ChangeUnchangable(object obj)
	{
		var type = obj.GetType();
		var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

		foreach (var field in fields)
		{
			ModifyFieldAttribute[] attributes = field.GetCustomAttributes<ModifyFieldAttribute>(true).ToArray();

			foreach (ModifyFieldAttribute attribute in attributes)
			{
				if (attribute.TargetType == null || attribute.TargetType == field.FieldType)
				{
					object fieldValue = field.GetValue(obj);
					object newValue = attribute.TargetModificationValue;

					field.SetValue(obj, newValue);
				}
			}
		}
	}
}