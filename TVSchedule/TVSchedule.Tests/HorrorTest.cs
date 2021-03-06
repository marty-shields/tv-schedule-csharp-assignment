using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Horror</summary>
    [TestClass]
    [PexClass(typeof(Horror))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HorrorTest
    {

        /// <summary>Test stub for .ctor(String, String, String, String, Int32, Int32, Int32, String)</summary>
        [PexMethod]
        internal Horror ConstructorTest(
            string id,
            string title,
            string description,
            string mainActor,
            int runTime,
            int ageRating,
            int releaseYear,
            string horrorGenre
        )
        {
            Horror target
               = new Horror(id, title, description, mainActor, runTime, ageRating, releaseYear, horrorGenre);
            return target;
            // TODO: add assertions to method HorrorTest.ConstructorTest(String, String, String, String, Int32, Int32, Int32, String)
        }
    }
}
