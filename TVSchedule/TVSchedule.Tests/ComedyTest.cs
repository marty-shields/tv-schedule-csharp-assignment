// <copyright file="ComedyTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for Comedy</summary>
    [PexClass(typeof(Comedy))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ComedyTest
    {
        /// <summary>Test stub for .ctor(String, String, String, Int32, Int32, String, String)</summary>
        [PexMethod]
        internal Comedy ConstructorTest(
            string id,
            string title,
            string desc,
            int runTime,
            int ageRating,
            string mainActor,
            string comedyType
        )
        {
            Comedy target
               = new Comedy(id, title, desc, runTime, ageRating, mainActor, comedyType);
            return target;
            // TODO: add assertions to method ComedyTest.ConstructorTest(String, String, String, Int32, Int32, String, String)
        }
    }
}
