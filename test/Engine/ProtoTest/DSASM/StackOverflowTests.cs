using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.DSASM
{
    [TestFixture]
    class StackOverflowTests
    {
        readonly TestFrameWork thisTest = new TestFrameWork();
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        [Ignore]
        [Category("StackOverflow")]
        public void StackOverflow_DNL_1467365()
        {
            string code =
                @"class test
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Ignore]
        [Category("StackOverflow")]
        public void StackOverflow_DNL_1467354()
        {
            string code =
                @"class A {
            thisTest.RunScriptSource(code);
            thisTest.Verify("Y", null);
        }
    }
}