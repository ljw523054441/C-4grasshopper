using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Hellosparial
{
	public class HellosparialInfo : GH_AssemblyInfo
	{
		public override string Name
		{
			get
			{
				return "Hellosparial";
			}
		}
		public override Bitmap Icon
		{
			get
			{
				//Return a 24x24 pixel bitmap to represent this GHA library.
				return null;
			}
		}
		public override string Description
		{
			get
			{
				//Return a short string describing the purpose of this GHA library.
				return "";
			}
		}
		public override Guid Id
		{
			get
			{
				return new Guid("7669cc7b-449c-4962-b285-45ad83914909");
			}
		}

		public override string AuthorName
		{
			get
			{
				//Return a string identifying you or your company.
				return "";
			}
		}
		public override string AuthorContact
		{
			get
			{
				//Return a string representing your preferred contact details.
				return "";
			}
		}
	}
}
