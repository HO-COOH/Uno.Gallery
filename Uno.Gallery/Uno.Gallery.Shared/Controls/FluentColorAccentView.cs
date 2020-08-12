﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Uno.Gallery.Controls
{
	[ContentProperty(Name = nameof(DescriptiveContent))]
	public partial class FluentColorAccentView : Control
	{
		public FluentColorAccentView()
		{
			DefaultStyleKey = typeof(FluentColorAccentView);
		}

		public string ColorName
		{
			get { return (string)GetValue(ColorNameProperty); }
			set { SetValue(ColorNameProperty, value); }
		}

		public static readonly DependencyProperty ColorNameProperty =
			DependencyProperty.Register("ColorName", typeof(string), typeof(FluentColorAccentView), new PropertyMetadata(string.Empty));

		public DataTemplate DescriptiveContent
		{
			get { return (DataTemplate)GetValue(DescriptiveContentProperty); }
			set { SetValue(DescriptiveContentProperty, value); }
		}

		public static readonly DependencyProperty DescriptiveContentProperty =
			DependencyProperty.Register("DescriptiveContent", typeof(DataTemplate), typeof(FluentColorAccentView), new PropertyMetadata(null));
	}
}
