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
    public partial class DocumentaryTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DocumentaryTest))]
public void DocumentaryTypeGetTest489()
{
    Documentary documentary;
    string s;
    documentary = new Documentary((string)null, (string)null, (string)null, 
                                  0, 0, (string)null, (string)null);
    s = this.DocumentaryTypeGetTest(documentary);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)documentary);
    Assert.AreEqual<string>((string)null, documentary.DocumentaryType);
    Assert.AreEqual<string>((string)null, documentary.Narrator);
    Assert.AreEqual<string>((string)null, ((Episode)documentary).Title);
    Assert.AreEqual<string>((string)null, ((Episode)documentary).Description);
    Assert.AreEqual<int>(0, ((Episode)documentary).RunTime);
    Assert.AreEqual<int>(0, ((Episode)documentary).AgeRating);
    Assert.AreEqual<string>((string)null, ((Episode)documentary).Id);
}
    }
}
