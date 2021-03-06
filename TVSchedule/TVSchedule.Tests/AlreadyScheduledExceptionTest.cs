using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for AlreadyScheduledException</summary>
    [TestClass]
    [PexClass(typeof(AlreadyScheduledException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AlreadyScheduledExceptionTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal AlreadyScheduledException ConstructorTest()
        {
            AlreadyScheduledException target = new AlreadyScheduledException();
            return target;
            // TODO: add assertions to method AlreadyScheduledExceptionTest.ConstructorTest()
        }
    }
}
