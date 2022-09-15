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
    ///The OdemeSayfasinaGec recording.
    /// </summary>
    [TestModule("94e587e5-018d-4bee-96bc-f2108e1abc7e", ModuleType.Recording, 1)]
    public partial class OdemeSayfasinaGec : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static OdemeSayfasinaGec instance = new OdemeSayfasinaGec();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OdemeSayfasinaGec()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OdemeSayfasinaGec Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginEmail' at 111;25.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LoginEmail.Click("111;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qa.assurance.test{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}gmail.com' with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LoginEmail.PressKeys("qa.assurance.test{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginPasswordInput' at 94;12.", repo.ApplicationUnderTest.LoginPasswordInputInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LoginPasswordInput.Click("94;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '●●●●●●●●●●' with focus on 'ApplicationUnderTest.LoginPasswordInput'.", repo.ApplicationUnderTest.LoginPasswordInputInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LoginPasswordInput.PressKeys("19901990a.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.QButtonQButtonMediumQFluidQPrima' at 187;11.", repo.ApplicationUnderTest.QButtonQButtonMediumQFluidQPrimaInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.QButtonQButtonMediumQFluidQPrima.Click("187;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
