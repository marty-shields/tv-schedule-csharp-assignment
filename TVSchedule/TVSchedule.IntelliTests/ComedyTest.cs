// <copyright file="ComedyTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Comedy</summary>
    [TestClass]
    [PexClass(typeof(Comedy))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ComedyTest
    {

        /// <summary>Test stub for .ctor(String, String, String, Int32, Int32, String, String)</summary>
        [PexMethod]
        public Comedy ConstructorTest(
            string id,
            string title,
            string desc,
            int runTime,
            int ageRating,
            string mainActor,
            string comedyType
        )
        {
            Comedy target = new Comedy(id, title, desc, runTime, ageRating, mainActor, comedyType);
            return target;
            // TODO: add assertions to method ComedyTest.ConstructorTest(String, String, String, Int32, Int32, String, String)
        }

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeUnderTest]Comedy target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method ComedyTest.AddProgramTest(Comedy)
        }

        /// <summary>Test stub for get_ComdeyType()</summary>
        [PexMethod]
        public string ComdeyTypeGetTest([PexAssumeUnderTest]Comedy target)
        {
            string result = target.ComdeyType;
            return result;
            // TODO: add assertions to method ComedyTest.ComdeyTypeGetTest(Comedy)
        }

        /// <summary>Test stub for get_MainActor()</summary>
        [PexMethod]
        public string MainActorGetTest([PexAssumeUnderTest]Comedy target)
        {
            string result = target.MainActor;
            return result;
            // TODO: add assertions to method ComedyTest.MainActorGetTest(Comedy)
        }

        /// <summary>Test stub for set_ComdeyType(String)</summary>
        [PexMethod]
        public void ComdeyTypeSetTest([PexAssumeUnderTest]Comedy target, string value)
        {
            target.ComdeyType = value;
            // TODO: add assertions to method ComedyTest.ComdeyTypeSetTest(Comedy, String)
        }

        /// <summary>Test stub for set_MainActor(String)</summary>
        [PexMethod]
        public void MainActorSetTest([PexAssumeUnderTest]Comedy target, string value)
        {
            target.MainActor = value;
            // TODO: add assertions to method ComedyTest.MainActorSetTest(Comedy, String)
        }
    }
}
