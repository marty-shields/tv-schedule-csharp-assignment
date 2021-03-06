// <copyright file="DramaTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Drama</summary>
    [TestClass]
    [PexClass(typeof(Drama))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DramaTest
    {

        /// <summary>Test stub for .ctor(String, String, String, Int32, Int32, String, String)</summary>
        [PexMethod]
        public Drama ConstructorTest(
            string id,
            string title,
            string desc,
            int runTime,
            int ageRating,
            string mainActor,
            string supportingActor
        )
        {
            Drama target = new Drama(id, title, desc, runTime, ageRating, mainActor, supportingActor);
            return target;
            // TODO: add assertions to method DramaTest.ConstructorTest(String, String, String, Int32, Int32, String, String)
        }

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeUnderTest]Drama target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method DramaTest.AddProgramTest(Drama)
        }

        /// <summary>Test stub for get_MainActor()</summary>
        [PexMethod]
        public string MainActorGetTest([PexAssumeUnderTest]Drama target)
        {
            string result = target.MainActor;
            return result;
            // TODO: add assertions to method DramaTest.MainActorGetTest(Drama)
        }

        /// <summary>Test stub for get_SupportingActor()</summary>
        [PexMethod]
        public string SupportingActorGetTest([PexAssumeUnderTest]Drama target)
        {
            string result = target.SupportingActor;
            return result;
            // TODO: add assertions to method DramaTest.SupportingActorGetTest(Drama)
        }

        /// <summary>Test stub for set_MainActor(String)</summary>
        [PexMethod]
        public void MainActorSetTest([PexAssumeUnderTest]Drama target, string value)
        {
            target.MainActor = value;
            // TODO: add assertions to method DramaTest.MainActorSetTest(Drama, String)
        }

        /// <summary>Test stub for set_SupportingActor(String)</summary>
        [PexMethod]
        public void SupportingActorSetTest([PexAssumeUnderTest]Drama target, string value)
        {
            target.SupportingActor = value;
            // TODO: add assertions to method DramaTest.SupportingActorSetTest(Drama, String)
        }
    }
}
