﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Lab9_CodedUITestProject
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Addition1();
            this.UIMap.AssertAddition1();

            this.UIMap.Addition2();
            this.UIMap.AssertError();

            this.UIMap.Addition3();
            this.UIMap.AssertError();

            this.UIMap.Substraction1();
            this.UIMap.AssertSubstraction1();

            this.UIMap.Substraction2();
            this.UIMap.AssertError();

            this.UIMap.Substraction3();
            this.UIMap.AssertError();

            this.UIMap.Multiply1();
            this.UIMap.AssertMultiply1();

            this.UIMap.Multiply2();
            this.UIMap.AssertError();

            this.UIMap.Multiply3();
            this.UIMap.AssertError();

            this.UIMap.Divine1();
            this.UIMap.AssertDivine1();

            this.UIMap.DivisionByZero();
            this.UIMap.AssertDivisionByZero();

            this.UIMap.Division3();
            this.UIMap.AssertError();

            this.UIMap.Division2();
            this.UIMap.AssertError();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
