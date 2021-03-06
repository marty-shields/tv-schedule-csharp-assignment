// <copyright file="EpisodeTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Episode</summary>
    [TestClass]
    [PexClass(typeof(Episode))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EpisodeTest
    {

        /// <summary>Test stub for AddProgram()</summary>
        [PexMethod]
        public string AddProgramTest([PexAssumeNotNull]Episode target)
        {
            string result = target.AddProgram();
            return result;
            // TODO: add assertions to method EpisodeTest.AddProgramTest(Episode)
        }

        /// <summary>Test stub for get_AgeRating()</summary>
        [PexMethod]
        public int AgeRatingGetTest([PexAssumeNotNull]Episode target)
        {
            int result = target.AgeRating;
            return result;
            // TODO: add assertions to method EpisodeTest.AgeRatingGetTest(Episode)
        }

        /// <summary>Test stub for get_Description()</summary>
        [PexMethod]
        public string DescriptionGetTest([PexAssumeNotNull]Episode target)
        {
            string result = target.Description;
            return result;
            // TODO: add assertions to method EpisodeTest.DescriptionGetTest(Episode)
        }

        /// <summary>Test stub for get_Id()</summary>
        [PexMethod]
        public string IdGetTest([PexAssumeNotNull]Episode target)
        {
            string result = target.Id;
            return result;
            // TODO: add assertions to method EpisodeTest.IdGetTest(Episode)
        }

        /// <summary>Test stub for get_RunTime()</summary>
        [PexMethod]
        public int RunTimeGetTest([PexAssumeNotNull]Episode target)
        {
            int result = target.RunTime;
            return result;
            // TODO: add assertions to method EpisodeTest.RunTimeGetTest(Episode)
        }

        /// <summary>Test stub for get_Title()</summary>
        [PexMethod]
        public string TitleGetTest([PexAssumeNotNull]Episode target)
        {
            string result = target.Title;
            return result;
            // TODO: add assertions to method EpisodeTest.TitleGetTest(Episode)
        }

        /// <summary>Test stub for set_AgeRating(Int32)</summary>
        [PexMethod]
        public void AgeRatingSetTest([PexAssumeNotNull]Episode target, int value)
        {
            target.AgeRating = value;
            // TODO: add assertions to method EpisodeTest.AgeRatingSetTest(Episode, Int32)
        }

        /// <summary>Test stub for set_Description(String)</summary>
        [PexMethod]
        public void DescriptionSetTest([PexAssumeNotNull]Episode target, string value)
        {
            target.Description = value;
            // TODO: add assertions to method EpisodeTest.DescriptionSetTest(Episode, String)
        }

        /// <summary>Test stub for set_Id(String)</summary>
        [PexMethod]
        public void IdSetTest([PexAssumeNotNull]Episode target, string value)
        {
            target.Id = value;
            // TODO: add assertions to method EpisodeTest.IdSetTest(Episode, String)
        }

        /// <summary>Test stub for set_RunTime(Int32)</summary>
        [PexMethod]
        public void RunTimeSetTest([PexAssumeNotNull]Episode target, int value)
        {
            target.RunTime = value;
            // TODO: add assertions to method EpisodeTest.RunTimeSetTest(Episode, Int32)
        }

        /// <summary>Test stub for set_Title(String)</summary>
        [PexMethod]
        public void TitleSetTest([PexAssumeNotNull]Episode target, string value)
        {
            target.Title = value;
            // TODO: add assertions to method EpisodeTest.TitleSetTest(Episode, String)
        }
    }
}
