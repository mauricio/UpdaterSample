using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.Sparkle;

namespace UpdaterSample
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;
		
		public AppDelegate ()
		{
		}

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);

			var updater = SUUpdater.SharedUpdater;
			updater.AutomaticallyDownloadsUpdates = true;
			updater.CheckForUpdates();

		}
	}
}