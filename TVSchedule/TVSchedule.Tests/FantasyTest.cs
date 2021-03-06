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
        internal Fantasy ConstructorTest(
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
    }
}
