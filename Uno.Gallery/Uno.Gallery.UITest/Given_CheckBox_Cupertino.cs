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
	public class Given_CheckBox_Cupertino : TestBase
	{
		/*     
		 * This function is to test the Checked option in checkbox for Cupertino.    
		 */
		[Test]
		public void When_ClickCupertinoChecked()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before UnChecked");

			var cupertinoCheckedBox = App.WaitThenTap("Cupertino_Checked").ToQueryEx();

			TakeScreenshot("After UnChecked");

			Assert.IsFalse(cupertinoCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}
		/*     
        * This function is to test the Indeterminate for uncheck, recheck and indeterminate option  in checkbox for Cupertino
        */
		[Test]
		public void When_ClickCupertinoIndeterminate()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before UnChecked");

			var cupertinoCheckedIndeterminateBox = App.WaitThenTap("Cupertino_Indeterminate").ToQueryEx();

			TakeScreenshot("After UnChecked");

			Assert.IsFalse(cupertinoCheckedIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));

			var cupertinoRecheckIndeterminateBox = App.WaitThenTap("Cupertino_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsTrue(cupertinoRecheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));

			var cupertinoReUncheckIndeterminateBox = App.WaitThenTap("Cupertino_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsFalse(cupertinoReUncheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}
		/*     
        * This function is to test the Unchecked option  in checkbox for Cupertino 
        */
		[Test]
		public void When_ClickCupertinoUnchecked()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before Checked");

			var cupertinoUncheckedBox = App.WaitThenTap("Cupertino_Unchecked").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsFalse(cupertinoUncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}
		/*     
        * This function is to test the DisabledChecked option  in checkbox for Cupertino, 
        */
		[Test]
		public void When_CupertinoDisabledChecked()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before Checked");

			var cupertinoDisabledCheckedBox = App.WaitThenTap("Cupertino_Disabled_Checked").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsFalse(cupertinoDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
		}
		/*     
        * This function is to test the DisabledUnchecked option  in checkbox for Cupertino.
        */
		[Test]
		public void When_CupertinoDisabledUnchecked()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before Checked");

			var cupertinoDisabledUncheckedBox = App.WaitThenTap("Cupertino_Disabled_Unchecked").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsFalse(cupertinoDisabledUncheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
		}
		/*     
        * This function is to test the DisabledIndeterminate option  in checkbox for material.
        */
		[Test]
		public void When_CupertinoDisabledIndeterminate()
		{
			NavigateToSample("CheckBox");
			ShowCupertinoTheme();

			TakeScreenshot("Before Checked");

			var cupertinoDisabledIndeterminateBox = App.WaitThenTap("Cupertino_Disabled_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			Assert.IsFalse(cupertinoDisabledIndeterminateBox.GetDependencyPropertyValue<bool>("IsEnabled"));
		}
	}
}
