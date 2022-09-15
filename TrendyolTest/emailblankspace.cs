﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TrendyolTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The emailblankspace recording.
    /// </summary>
    [TestModule("e1dcd9df-b57a-444e-b2db-e08aa60185e9", ModuleType.Recording, 1)]
    public partial class emailblankspace : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static emailblankspace instance = new emailblankspace();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public emailblankspace()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static emailblankspace Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // email alanına bosluk karakteri girildi
            Report.Log(ReportLevel.Info, "Keyboard", "email alanına bosluk karakteri girildi\r\nKey sequence '        ' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("        ");
            Delay.Milliseconds(0);
            
            // uye ol butonuna basıldı
            Report.Log(ReportLevel.Info, "Mouse", "uye ol butonuna basıldı\r\nMouse Left Click item 'ApplicationUnderTest.UyeOl2' at Center.", repo.ApplicationUnderTest.UyeOl2Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.UyeOl2.Click();
            Delay.Milliseconds(0);
            
            // hata mesajı alındı
            Report.Log(ReportLevel.Info, "Validation", "hata mesajı alındı\r\nValidating Exists on item 'ApplicationUnderTest.ErrorBoxWrapper'.", repo.ApplicationUnderTest.ErrorBoxWrapperInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ApplicationUnderTest.ErrorBoxWrapperInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}