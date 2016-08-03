using String      = System.String;
using Environment = System.Environment;
using Path        = System.IO.Path;

using IApplication = Corel.Interop.VGCore.IVGApplication;
using IDocument    = Corel.Interop.VGCore.IVGDocument;
using Application  = Corel.Interop.CorelDRAW.ApplicationClass;

namespace CdrToPdf
{
	class Program
	{
		public static void Main(String[] args)
		{
			String currentDirectoryPath = Environment.CurrentDirectory;
			
			String sourceFile  = args[0];			
			String releaseFile = args[1];
			
			String sourcePath  = Path.IsPathRooted(sourceFile)  ? sourceFile  : Path.Combine(currentDirectoryPath, sourceFile);			
			String releasePath = Path.IsPathRooted(releaseFile) ? releaseFile : Path.Combine(currentDirectoryPath, releaseFile);
			
			IApplication application = new Application();
			
			IDocument document = application.OpenDocument(sourcePath);
			
			document.PublishToPDF(releasePath);
			
			document.Close();
			
			application.Quit();
		}
	}
}