using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Documentary</summary>
    [TestClass]
    [PexClass(typeof(Documentary))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DocumentaryTest
    {

        /// <summary>Test stub for .ctor(String, String, String, Int32, Int32, String, String)</summary>
        [PexMethod]
        internal Documentary ConstructorTest(
            string id,
            string title,
            string desc,
            int runTime,
            int ageRating,
            string documentaryType,
            string narrator
        )
        {
            Documentary target = new Documentary(id, title, desc, runTime, ageRating, documentaryType, narrator)
              ;
            return target;
            // TODO: add assertions to method DocumentaryTest.ConstructorTest(String, String, String, Int32, Int32, String, String)
        }

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        internal string AddProgramTest([PexAssumeUnderTest]Documentary target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method DocumentaryTest.AddProgramTest(Documentary)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Documentary target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method DocumentaryTest.ToStringTest(Documentary)
        }

        /// <summary>Test stub for get_DocumentaryType()</summary>
        [PexMethod]
        internal string DocumentaryTypeGetTest([PexAssumeUnderTest]Documentary target)
        {
            string result = target.DocumentaryType;
            return result;
            // TODO: add assertions to method DocumentaryTest.DocumentaryTypeGetTest(Documentary)
        }

        /// <summary>Test stub for get_Narrator()</summary>
        [PexMethod]
        internal string NarratorGetTest([PexAssumeUnderTest]Documentary target)
        {
            string result = target.Narrator;
            return result;
            // TODO: add assertions to method DocumentaryTest.NarratorGetTest(Documentary)
        }

        /// <summary>Test stub for set_DocumentaryType(String)</summary>
        [PexMethod]
        internal void DocumentaryTypeSetTest([PexAssumeUnderTest]Documentary target, string value)
        {
            target.DocumentaryType = value;
            // TODO: add assertions to method DocumentaryTest.DocumentaryTypeSetTest(Documentary, String)
        }

        /// <summary>Test stub for set_Narrator(String)</summary>
        [PexMethod]
        internal void NarratorSetTest([PexAssumeUnderTest]Documentary target, string value)
        {
            target.Narrator = value;
            // TODO: add assertions to method DocumentaryTest.NarratorSetTest(Documentary, String)
        }
    }
}
