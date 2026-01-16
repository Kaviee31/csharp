using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Rectangle
    {
		private int lenght;

		public int Length
		{
			get { return lenght; }
			set { lenght = value; }
		}

		private int width;

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public int GetArea()
		{
			return Length * Width;
		}


	}
}
