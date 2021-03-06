// <copyright file="MovieTest.cs">Copyright ©  2016</copyright>

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
        public string AddProgramTest([PexAssumeNotNull]Movie target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method MovieTest.AddProgramTest(Movie)
        }

        /// <summary>Test stub for get_AgeRating()</summary>
        [PexMethod]
        public int AgeRatingGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.AgeRating;
            return result;
            // TODO: add assertions to method MovieTest.AgeRatingGetTest(Movie)
        }

        /// <summary>Test stub for get_Description()</summary>
        [PexMethod]
        public string DescriptionGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Description;
            return result;
            // TODO: add assertions to method MovieTest.DescriptionGetTest(Movie)
        }

        /// <summary>Test stub for get_Id()</summary>
        [PexMethod]
        public string IdGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Id;
            return result;
            // TODO: add assertions to method MovieTest.IdGetTest(Movie)
        }

        /// <summary>Test stub for get_MainActor()</summary>
        [PexMethod]
        public string MainActorGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.MainActor;
            return result;
            // TODO: add assertions to method MovieTest.MainActorGetTest(Movie)
        }

        /// <summary>Test stub for get_ReleaseYear()</summary>
        [PexMethod]
        public int ReleaseYearGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.ReleaseYear;
            return result;
            // TODO: add assertions to method MovieTest.ReleaseYearGetTest(Movie)
        }

        /// <summary>Test stub for get_RunTime()</summary>
        [PexMethod]
        public int RunTimeGetTest([PexAssumeNotNull]Movie target)
        {
            int result = target.RunTime;
            return result;
            // TODO: add assertions to method MovieTest.RunTimeGetTest(Movie)
        }

        /// <summary>Test stub for get_Title()</summary>
        [PexMethod]
        public string TitleGetTest([PexAssumeNotNull]Movie target)
        {
            string result = target.Title;
            return result;
            // TODO: add assertions to method MovieTest.TitleGetTest(Movie)
        }

        /// <summary>Test stub for set_AgeRating(Int32)</summary>
        [PexMethod]
        public void AgeRatingSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.AgeRating = value;
            // TODO: add assertions to method MovieTest.AgeRatingSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_Description(String)</summary>
        [PexMethod]
        public void DescriptionSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Description = value;
            // TODO: add assertions to method MovieTest.DescriptionSetTest(Movie, String)
        }

        /// <summary>Test stub for set_Id(String)</summary>
        [PexMethod]
        public void IdSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Id = value;
            // TODO: add assertions to method MovieTest.IdSetTest(Movie, String)
        }

        /// <summary>Test stub for set_MainActor(String)</summary>
        [PexMethod]
        public void MainActorSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.MainActor = value;
            // TODO: add assertions to method MovieTest.MainActorSetTest(Movie, String)
        }

        /// <summary>Test stub for set_ReleaseYear(Int32)</summary>
        [PexMethod]
        public void ReleaseYearSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.ReleaseYear = value;
            // TODO: add assertions to method MovieTest.ReleaseYearSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_RunTime(Int32)</summary>
        [PexMethod]
        public void RunTimeSetTest([PexAssumeNotNull]Movie target, int value)
        {
            target.RunTime = value;
            // TODO: add assertions to method MovieTest.RunTimeSetTest(Movie, Int32)
        }

        /// <summary>Test stub for set_Title(String)</summary>
        [PexMethod]
        public void TitleSetTest([PexAssumeNotNull]Movie target, string value)
        {
            target.Title = value;
            // TODO: add assertions to method MovieTest.TitleSetTest(Movie, String)
        }
    }
}
