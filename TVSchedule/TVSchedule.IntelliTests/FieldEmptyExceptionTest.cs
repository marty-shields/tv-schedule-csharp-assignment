// <copyright file="FieldEmptyExceptionTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for FieldEmptyException</summary>
    [TestClass]
    [PexClass(typeof(FieldEmptyException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FieldEmptyExceptionTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public FieldEmptyException ConstructorTest()
        {
            FieldEmptyException target = new FieldEmptyException();
            return target;
            // TODO: add assertions to method FieldEmptyExceptionTest.ConstructorTest()
        }
    }
}
