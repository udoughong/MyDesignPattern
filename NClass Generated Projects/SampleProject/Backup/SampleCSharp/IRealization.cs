using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.SampleCSharp
{
	public interface IRealization
	{
		void NewMethod();

		int NewProperty
		{
			get;
			set;
		}

		event EventHandler NewEvent;
	}
}
