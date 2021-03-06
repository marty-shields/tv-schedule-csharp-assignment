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
        internal PeriodDrama ConstructorTest(
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
    }
}
