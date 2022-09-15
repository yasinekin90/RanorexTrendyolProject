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
    ///The emailgir recording.
    /// </summary>
    [TestModule("ebfd930c-9f8f-493d-98aa-e8c58251f23f", ModuleType.Recording, 1)]
    public partial class emailgir : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrendyolTestRepository repository.
        /// </summary>
        public static TrendyolTestRepository repo = TrendyolTestRepository.Instance;

        static emailgir instance = new emailgir();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public emailgir()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static emailgir Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginEmail' at 94;37.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LoginEmail.Click("94;37");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qa.assurance.test@gmail.com' with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LoginEmail.PressKeys("qa.assurance.test@gmail.com");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
