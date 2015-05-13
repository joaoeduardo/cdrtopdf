using System;
using Corel.Interop.CorelDRAW;

namespace CdrToPdf
{
	class Program
	{
		public static void Main(String[] args)
		{
			String source = args[0];
			
			String release = args[1];
			
			Application application = new Application();
			
			Document document = application.OpenDocument(source, 1);
			
			document.PublishToPDF(release);
			
			document.Close();
		}
	}
}