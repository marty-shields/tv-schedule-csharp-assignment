using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Movie</summary>
    [TestClass]
    [PexClass(typeof(Movie))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieTest
    {

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        internal string AddProgramTest([PexAssumeNotNull]Movie target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method MovieTest.AddProgramTest(Movie)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeNotNull]Movie target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method MovieTest.ToStringTest(Movie)
        }

        /// <summary>Test stub for get_AgeRating()</summary>
        [PexMethod]
        internal int AgeRatingGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.AgeRating;
            return result;
            // TODO: add assertions to method MovieTest.AgeRatingGetTest(Movie)
        }

        /// <summary>Test stub for get_Description()</summary>
        [PexMethod]
        internal string DescriptionGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Description;
            return result;
            // TODO: add assertions to method MovieTest.DescriptionGetTest(Movie)
        }

        /// <summary>Test stub for get_Id()</summary>
        [PexMethod]
        internal string IdGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Id;
            return result;
            // TODO: add assertions to method MovieTest.IdGetTest(Movie)
        }

        /// <summary>Test stub for get_MainActor()</summary>
        [PexMethod]
        internal string MainActorGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.MainActor;
            return result;
            // TODO: add assertions to method MovieTest.MainActorGetTest(Movie)
        }

        /// <summary>Test stub for get_ReleaseYear()</summary>
        [PexMethod]
        internal int ReleaseYearGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.ReleaseYear;
            return result;
            // TODO: add assertions to method MovieTest.ReleaseYearGetTest(Movie)
        }

        /// <summary>Test stub for get_RunTime()</summary>
        [PexMethod]
        internal int RunTimeGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.RunTime;
            return result;
            // TODO: add assertions to method MovieTest.RunTimeGetTest(Movie)
        }

        /// <summary>Test stub for get_Title()</summary>
        [PexMethod]
        internal string TitleGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Title;
            return result;
            // TODO: add assertions to method MovieTest.TitleGetTest(Movie)
        }

        /// <summary>Test stub for set_AgeRating(Int32)</summary>
        [PexMethod]
        internal void AgeRatingSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.AgeRating = value;
            // TODO: add assertions to method MovieTest.AgeRatingSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_Description(String)</summary>
        [PexMethod]
        internal void DescriptionSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Description = value;
            // TODO: add assertions to method MovieTest.DescriptionSetTest(Movie, String)
        }

        /// <summary>Test stub for set_Id(String)</summary>
        [PexMethod]
        internal void IdSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Id = value;
            // TODO: add assertions to method MovieTest.IdSetTest(Movie, String)
        }

        /// <summary>Test stub for set_MainActor(String)</summary>
        [PexMethod]
        internal void MainActorSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.MainActor = value;
            // TODO: add assertions to method MovieTest.MainActorSetTest(Movie, String)
        }

        /// <summary>Test stub for set_ReleaseYear(Int32)</summary>
        [PexMethod]
        internal void ReleaseYearSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.ReleaseYear = value;
            // TODO: add assertions to method MovieTest.ReleaseYearSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_RunTime(Int32)</summary>
        [PexMethod]
        internal void RunTimeSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.RunTime = value;
            // TODO: add assertions to method MovieTest.RunTimeSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_Title(String)</summary>
        [PexMethod]
        internal void TitleSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Title = value;
            // TODO: add assertions to method MovieTest.TitleSetTest(Movie, String)
        }
    }
}
