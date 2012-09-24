using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using System.IO;

namespace UpdaterSample
{
	class MainClass
	{
		static void Main (string[] args)
		{
			var baseAppPath = Directory.GetParent (Directory.GetParent (System.AppDomain.CurrentDomain.BaseDirectory).ToString ());
			var sparkleFrameworkPath = baseAppPath + "/Frameworks/Sparkle.framework/Sparkle";
			
			Dlfcn.dlopen (sparkleFrameworkPath, 0);

			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}