using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TVSchedule.Tests
{
    public partial class FieldEmptyExceptionTest
    {

[TestMethod]
[PexGeneratedBy(typeof(FieldEmptyExceptionTest))]
public void ConstructorTest966()
{
    FieldEmptyException fieldEmptyException;
    fieldEmptyException = this.ConstructorTest();
    Assert.IsNotNull((object)fieldEmptyException);
    Assert.IsNull(((Exception)fieldEmptyException).InnerException);
    Assert.AreEqual<int>(-2146233088, ((Exception)fieldEmptyException).HResult);
}
    }
}
