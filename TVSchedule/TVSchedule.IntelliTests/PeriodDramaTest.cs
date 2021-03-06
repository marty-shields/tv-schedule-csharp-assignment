// <copyright file="PeriodDramaTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for PeriodDrama</summary>
    [TestClass]
    [PexClass(typeof(PeriodDrama))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PeriodDramaTest
    {

        /// <summary>Test stub for .ctor(String, String, String, Int32, Int32, String, String, Int32)</summary>
        [PexMethod]
        public PeriodDrama ConstructorTest(
            string id,
            string title,
            string desc,
            int runTime,
            int ageRating,
            string mainActor,
            string supportingActor,
            int periodDate
        )
        {
            PeriodDrama target
               = new PeriodDrama(id, title, desc, runTime, ageRating, mainActor, supportingActor, periodDate);
            return target;
            // TODO: add assertions to method PeriodDramaTest.ConstructorTest(String, String, String, Int32, Int32, String, String, Int32)
        }

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeUnderTest]PeriodDrama target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method PeriodDramaTest.AddProgramTest(PeriodDrama)
        }

        /// <summary>Test stub for get_PeriodDate()</summary>
        [PexMethod]
        public int PeriodDateGetTest([PexAssumeUnderTest]PeriodDrama target)
        {
            int result = target.PeriodDate;
            return result;
            // TODO: add assertions to method PeriodDramaTest.PeriodDateGetTest(PeriodDrama)
        }

        /// <summary>Test stub for set_PeriodDate(Int32)</summary>
        [PexMethod]
        public void PeriodDateSetTest([PexAssumeUnderTest]PeriodDrama target, int value)
        {
            target.PeriodDate = value;
            // TODO: add assertions to method PeriodDramaTest.PeriodDateSetTest(PeriodDrama, Int32)
        }
    }
}
