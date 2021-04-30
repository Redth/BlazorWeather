﻿using Microsoft.Maui;
using Windows.ApplicationModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BlazorWeather.Maui.Windows
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class WindowsApp : MiddleApp
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public WindowsApp()
        {
            this.InitializeComponent();
        }
    }

    // TODO: this is not nice.
    public class MiddleApp : MauiWinUIApplication<BlazorWeather.Maui.Startup>
    {
    }

}
