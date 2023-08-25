using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple =true, Inherited =true)]

	internal class ModifyFieldAttribute : Attribute
	{
		public Type? TargetType { get; set; } = null;
		public object? TargetModificationValue { get; set; } = null;
	}
}
