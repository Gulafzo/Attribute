using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	internal class Task2Beater
	{
		public void ChangeUnchangable(object @class)
		{
			var type =@class.GetType();

			var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			foreach ( var field in fields )
			{
				//switch case по типам
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

