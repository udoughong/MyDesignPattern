using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.SampleCSharp
{
	public class CRealization : IRealization
	{
		public void NewMethod()
		{
			throw new NotImplementedException();
		}

		public int NewProperty
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public event EventHandler NewEvent;
	}
}
