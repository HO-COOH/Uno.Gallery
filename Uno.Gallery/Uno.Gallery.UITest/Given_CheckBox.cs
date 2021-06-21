﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;

namespace Uno.Gallery.UITests
{
	public class Given_CheckBox : TestBase
	{
		[Test]
		public void When_ClickMaterial()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");

			var uncheckedBox = App.WaitThenTap("Material_Unchecked").ToQueryEx();
			
			TakeScreenshot("After Checked");

			Assert.IsTrue(uncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		} 

		[Test]
		public void When_ClickCheckedMaterial()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");

			var CheckedBox = App.WaitThenTap("Material_Checked").ToQueryEx();

			TakeScreenshot("After UnChecked");

			Assert.IsFalse(CheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}
	}
}
