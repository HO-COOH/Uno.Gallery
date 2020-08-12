﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Uno.Gallery.Views.Samples
{
	[SamplePage(SampleCategory.Components, "BottomNavigationBar", SourceSdk.UnoMaterial, Description = "This control gives you the ability to quickly build a bottom navigation bar with all the features you would expect.")]
	public sealed partial class BottomNavigationBarSamplePage : Page
	{
		public BottomNavigationBarSamplePage()
		{
			this.InitializeComponent();
		}
	}
}
