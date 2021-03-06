// <copyright file="FantasyTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Fantasy</summary>
    [TestClass]
    [PexClass(typeof(Fantasy))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FantasyTest
    {

        /// <summary>Test stub for .ctor(String, String, String, String, Int32, Int32, Int32, String, String)</summary>
        [PexMethod]
        public Fantasy ConstructorTest(
            string id,
            string title,
            string description,
            string mainActor,
            int runTime,
            int ageRating,
            int releaseYear,
            string supportingActor,
            string fantasyType
        )
        {
            Fantasy target = new Fantasy(id, title, description, mainActor,
                                         runTime, ageRating, releaseYear, supportingActor, fantasyType);
            return target;
            // TODO: add assertions to method FantasyTest.ConstructorTest(String, String, String, String, Int32, Int32, Int32, String, String)
        }

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeUnderTest]Fantasy target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method FantasyTest.AddProgramTest(Fantasy)
        }

        /// <summary>Test stub for get_FantasyType()</summary>
        [PexMethod]
        public string FantasyTypeGetTest([PexAssumeUnderTest]Fantasy target)
        {
            string result = target.FantasyType;
            return result;
            // TODO: add assertions to method FantasyTest.FantasyTypeGetTest(Fantasy)
        }

        /// <summary>Test stub for get_SupportingActor()</summary>
        [PexMethod]
        public string SupportingActorGetTest([PexAssumeUnderTest]Fantasy target)
        {
            string result = target.SupportingActor;
            return result;
            // TODO: add assertions to method FantasyTest.SupportingActorGetTest(Fantasy)
        }

        /// <summary>Test stub for set_FantasyType(String)</summary>
        [PexMethod]
        public void FantasyTypeSetTest([PexAssumeUnderTest]Fantasy target, string value)
        {
            target.FantasyType = value;
            // TODO: add assertions to method FantasyTest.FantasyTypeSetTest(Fantasy, String)
        }

        /// <summary>Test stub for set_SupportingActor(String)</summary>
        [PexMethod]
        public void SupportingActorSetTest([PexAssumeUnderTest]Fantasy target, string value)
        {
            target.SupportingActor = value;
            // TODO: add assertions to method FantasyTest.SupportingActorSetTest(Fantasy, String)
        }
    }
}
