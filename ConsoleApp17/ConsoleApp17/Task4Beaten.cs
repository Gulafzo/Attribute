using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	[ModifyField(TargetType = typeof(bool), TargetModificationValue ="Inversion")]
    [ModifyField(TargetType = typeof(int), TargetModificationValue ="Add 10")]
    [ModifyField(TargetType = typeof(string), TargetModificationValue ="Prefix fire!")]

	internal class Task4Beaten
	{
		private int _noOneChangeMe = 555;
		[ModifyField]
		private bool _noOneChangeMeForShure = true;
		private string _noOneChangeMeForShureISay = "NO ONE!!! DO NOT TOUCH THIS!!!";
		private int _noOneNoOneChangeMe = 10000000;
		[ModifyField]
		private bool _noOneNoOneChangeMeForShure = false;
		private string _noOneNoOneChangeMeForShureISay = "NO ONE!!! NO ONE!!! NO ONE!!! DO NOT TOUCH THIS!!!";
	}
}

