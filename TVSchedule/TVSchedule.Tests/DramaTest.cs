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
        internal Drama ConstructorTest(
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
    }
}
