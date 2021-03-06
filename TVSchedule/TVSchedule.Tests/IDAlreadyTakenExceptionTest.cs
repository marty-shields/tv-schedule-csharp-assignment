using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for IDAlreadyTakenException</summary>
    [TestClass]
    [PexClass(typeof(IDAlreadyTakenException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IDAlreadyTakenExceptionTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal IDAlreadyTakenException ConstructorTest()
        {
            IDAlreadyTakenException target = new IDAlreadyTakenException();
            return target;
            // TODO: add assertions to method IDAlreadyTakenExceptionTest.ConstructorTest()
        }
    }
}
