using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT.Interop;
using WinUIEx;

namespace FormControl
{
	public sealed partial class MainWindow : WindowEx
	{
		public MainWindow()
		{
			InitializeComponent();

			PersistenceId = "MainWindow";

			EnsureEarlyWindow();
		}

		private void EnsureEarlyWindow()
		{
			// Set title
			AppWindow.Title = "FormControl";

			// Set icon
			AppWindow.SetIcon(Path.Combine(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, "Assets/AppTiles/Release/StoreLogo.scale-400.png"));

			// Extend title bar
			AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;

			// Set window buttons background to transparent
			AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
			AppWindow.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

			// Set min size
			base.MinHeight = 328;
			base.MinWidth = 516;
		}
	}
}
