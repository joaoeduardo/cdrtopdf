using System;

using IApplication = Corel.Interop.VGCore.IVGApplication;
using IDocument    = Corel.Interop.VGCore.IVGDocument;
using Application  = Corel.Interop.CorelDRAW.ApplicationClass;

namespace CdrToPdf
{
	class Program
	{
		public static void Main(String[] args)
		{
			String source = args[0];
			
			String release = args[1];
			
			IApplication application = new Application();
			
			IDocument document = application.OpenDocument(source);
			
			document.PublishToPDF(release);
			
			document.Close();
			
			application.Quit();
		}
	}
}