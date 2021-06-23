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
	public class Given_CheckBox_01_Material : TestBase
	{
		/*     
		* This function is to test the Unchecked option  in checkbox for material, 
		*/
		[Test]
		public void WhenMaterialClick_01_Unchecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");
			var uncheckedBox = new QueryEx(x => x.Marked("Material_Unchecked"));
			uncheckedBox.Tap();
			TakeScreenshot("After Checked");
			Assert.IsTrue(uncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
		/* This function is to test the DisabledUnchecked option  in checkbox for material.	*/
		[Test]
		public void WhenMaterialClick_02_DisabledUnchecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");
			var materialDisabledUncheckedBox = new QueryEx(x => x.Marked("Material_Disabled_Unchecked"));
			materialDisabledUncheckedBox.Tap();
			TakeScreenshot("After Checked");
			Assert.IsFalse(materialDisabledUncheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsFalse(materialDisabledUncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
		 /* This function is to test the Checked option in checkbox for material.	*/	 
		[Test]
		public void WhenMaterialClick_03_Checked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");
			var checkedBox = new QueryEx(x => x.Marked("Material_Checked"));
			checkedBox.Tap();
			TakeScreenshot("After UnChecked");
			Assert.IsFalse(checkedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
        /* This function is to test the DisabledChecked option  in checkbox for material */       
		[Test]
		public void WhenMaterialClick_04_DisabledChecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");
			var materialDisabledCheckedBox = new QueryEx(x => x.Marked("Material_Disabled_Checked"));
			materialDisabledCheckedBox.Tap();
			TakeScreenshot("After UnChecked");
			Assert.IsFalse(materialDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsTrue(materialDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
        /*This function is to test the Indeterminate for uncheck, recheck and indeterminate option  in checkbox for material   */     
		[Test]
		public void WhenMaterialClick_05_Indeterminate()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");
			var checkedIndeterminateBox = new QueryEx(x => x.Marked("Material_Indeterminate"));
			checkedIndeterminateBox.Tap();
			TakeScreenshot("After UnChecked");
			Assert.IsFalse(checkedIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));

			checkedIndeterminateBox.Tap();
			TakeScreenshot("After Checked");
			Assert.IsTrue(checkedIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));

			checkedIndeterminateBox.Tap();
			TakeScreenshot("After Checked");
			var isChecked = checkedIndeterminateBox.GetDependencyPropertyValue("IsChecked");
			Assert.IsTrue(isChecked == null || string.IsNullOrWhiteSpace(isChecked as string));			
		}

		/*     
        * This function is to test the DisabledIndeterminate option  in checkbox for material.*/
        
		[Test]
		public void WhenMaterialClick_06_DisabledIndeterminate()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");
			var materialDisabledIndeterminateBox = App.WaitThenTap("Material_Disabled_Indeterminate").ToQueryEx();
			TakeScreenshot("After Checked");

			Assert.IsFalse(materialDisabledIndeterminateBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			var isChecked = materialDisabledIndeterminateBox.GetDependencyPropertyValue("IsChecked");
			Assert.IsTrue(isChecked == null || string.IsNullOrWhiteSpace(isChecked as string));
		}
	}
}
