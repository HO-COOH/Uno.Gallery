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
	public class Given_Card_01 : TestBase
	{
		    
		/*This function is to test the Unchecked option  in checkbox for material */ 		
		[Test]
		public void WhenOutlinedCard_01_Click()
		{
			NavigateToSample("Card", "Material");

			TakeScreenshot("Before Click");
			var outlinedCardClick = new QueryEx(x => x.All().Marked("Outlined_Card"));			
			App.ScrollDownTo("Outlined_Card");
			outlinedCardClick.Tap();
			TakeScreenshot("After Click");
			Assert.IsTrue(outlinedCardClick.GetDependencyPropertyValue<bool>("IsEnabled"));
			/*Assert.IsTrue(App.Query(x => x.All().Marked("Outlined_Card")).);*/
		}
		     
		/* This function is to test the DisabledUnchecked option  in checkbox for material.	*/
		/*[Test]
		public void WhenToggleSwitchMaterialClick_01_On()
		{
			NavigateToSample("ToggleSwitch", "Material");

			TakeScreenshot("Before Off");
			var toggleSwitchOff = new QueryEx(x => x.All().Marked("ToggleSwitch_Material_On"));
			App.ScrollDownTo("ToggleSwitch_Material_On");
			toggleSwitchOff.Tap();
			TakeScreenshot("After Off");
			Assert.IsFalse(toggleSwitchOff.GetDependencyPropertyValue<bool>("IsOn"));						
		}
		     
		 /* This function is to test the Checked option in checkbox for material.	*/	 
		/*[Test]
		public void WhenMaterialClick_03_Checked()
		{
			NavigateToSample("CheckBox", "Material");

			TakeScreenshot("Before UnChecked");
			var checkedBox = new QueryEx(x => x.All().Marked("Material_Checked"));
			App.ScrollDownTo("Material_Checked");
			checkedBox.Tap();
			TakeScreenshot("After UnChecked");
			Assert.IsFalse(checkedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
        /* This function is to test the DisabledChecked option  in checkbox for material */       
		/*[Test]
		public void WhenMaterialClick_04_DisabledChecked()
		{
			NavigateToSample("CheckBox", "Material");

			TakeScreenshot("Before UnChecked");
			var materialDisabledCheckedBox = new QueryEx(x => x.All().Marked("Material_Disabled_Checked"));
			App.ScrollDownTo("Material_Disabled_Checked");
			materialDisabledCheckedBox.Tap();
			TakeScreenshot("After UnChecked");
			Assert.IsFalse(materialDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsTrue(materialDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));			
		}
		     
        /* This function is to test the Indeterminate for uncheck, recheck and indeterminate option in checkbox for material   */     
		/*[Test]
		public void WhenMaterialClick_05_Indeterminate()
		{
			NavigateToSample("CheckBox", "Material");

			TakeScreenshot("Before UnChecked");
			var checkedIndeterminateBox = new QueryEx(x => x.All().Marked("Material_Indeterminate"));
			App.ScrollDownTo("Material_Indeterminate");
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

		     
        /* This function is to test the DisabledIndeterminate option  in checkbox for material.*/
        
		/*[Test]
		public void WhenMaterialClick_06_DisabledIndeterminate()
		{
			NavigateToSample("CheckBox", "Material");

			TakeScreenshot("Before Checked");
			var materialDisabledIndeterminateBox = new QueryEx(x => x.All().Marked("Material_Disabled_Indeterminate"));
			App.ScrollDownTo("Material_Disabled_Indeterminate");
			materialDisabledIndeterminateBox.Tap();
			TakeScreenshot("After Checked");

			Assert.IsFalse(materialDisabledIndeterminateBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			var isChecked = materialDisabledIndeterminateBox.GetDependencyPropertyValue("IsChecked");
			Assert.IsTrue(isChecked == null || string.IsNullOrWhiteSpace(isChecked as string));
		}*/
	}
}
