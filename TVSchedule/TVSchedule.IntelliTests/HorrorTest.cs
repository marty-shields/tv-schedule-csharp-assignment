// <copyright file="HorrorTest.cs">Copyright ©  2016</copyright>

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
        public Horror ConstructorTest(
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

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeUnderTest]Horror target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method HorrorTest.AddProgramTest(Horror)
        }

        /// <summary>Test stub for get_HorrorGenre()</summary>
        [PexMethod]
        public string HorrorGenreGetTest([PexAssumeUnderTest]Horror target)
        {
            string result = target.HorrorGenre;
            return result;
            // TODO: add assertions to method HorrorTest.HorrorGenreGetTest(Horror)
        }

        /// <summary>Test stub for set_HorrorGenre(String)</summary>
        [PexMethod]
        public void HorrorGenreSetTest([PexAssumeUnderTest]Horror target, string value)
        {
            target.HorrorGenre = value;
            // TODO: add assertions to method HorrorTest.HorrorGenreSetTest(Horror, String)
        }
    }
}
