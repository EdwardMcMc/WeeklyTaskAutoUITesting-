﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace WeeklyTaskAutoUITestingCodedUITestProject
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    

    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void SimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(49, 10));

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(35, 13));
        }
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UIMainWindowWindowExePath, this.RecordedMethod1Params.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(27, 17));

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.RecordedMethod1Params.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(17, 2));
        }
        
        #region Properties
        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }
        
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private SimpleAppTestParams mSimpleAppTestParams;
        
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\Documents\\GitHub\\WeeklyTaskAutoUITesting-\\WeeklyTaskAutoUITestin" +
            "gWPFApp\\bin\\Debug\\WeeklyTaskAutoUITestingWPFApp.exe";
        
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Documents\\GitHub\\WeeklyTaskAutoUITesting-\\WeeklyTaskAutoUITestingWP" +
            "FApp\\bin\\Debug\\WeeklyTaskAutoUITestingWPFApp.exe";
        
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\Documents\\GitHub\\WeeklyTaskAutoUITesting-\\WeeklyTaskAutoUITestin" +
            "gWPFApp\\bin\\Debug\\WeeklyTaskAutoUITestingWPFApp.exe";
        
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\GitHub\WeeklyTaskAutoUITesting-\WeeklyTaskAutoUITestingWPFApp\bin\Debug\WeeklyTaskAutoUITestingWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Documents\\GitHub\\WeeklyTaskAutoUITesting-\\WeeklyTaskAutoUITestingWP" +
            "FApp\\bin\\Debug\\WeeklyTaskAutoUITestingWPFApp.exe";
        
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "button1";
                    this.mUIStartButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        
        public WpfCheckBox UICheckBoxCheckBox
        {
            get
            {
                if ((this.mUICheckBoxCheckBox == null))
                {
                    this.mUICheckBoxCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUICheckBoxCheckBox.SearchProperties[WpfCheckBox.PropertyNames.AutomationId] = "checkBox1";
                    this.mUICheckBoxCheckBox.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICheckBoxCheckBox;
            }
        }
        
        public WpfButton UIStartButton1
        {
            get
            {
                if ((this.mUIStartButton1 == null))
                {
                    this.mUIStartButton1 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton1.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
                    this.mUIStartButton1.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton1;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIStartButton;
        
        private WpfCheckBox mUICheckBoxCheckBox;
        
        private WpfButton mUIStartButton1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}