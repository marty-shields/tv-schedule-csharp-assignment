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
    public partial class FantasyTest
    {

[TestMethod]
[PexGeneratedBy(typeof(FantasyTest))]
public void SupportingActorGetTest826()
{
    Fantasy fantasy;
    string s;
    fantasy = new Fantasy((string)null, (string)null, (string)null, (string)null, 
                          0, 0, 0, (string)null, (string)null);
    s = this.SupportingActorGetTest(fantasy);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)fantasy);
    Assert.AreEqual<string>((string)null, fantasy.SupportingActor);
    Assert.AreEqual<string>((string)null, fantasy.FantasyType);
    Assert.AreEqual<string>((string)null, ((Movie)fantasy).Title);
    Assert.AreEqual<string>((string)null, ((Movie)fantasy).Description);
    Assert.AreEqual<int>(0, ((Movie)fantasy).RunTime);
    Assert.AreEqual<int>(0, ((Movie)fantasy).AgeRating);
    Assert.AreEqual<int>(0, ((Movie)fantasy).ReleaseYear);
    Assert.AreEqual<string>((string)null, ((Movie)fantasy).MainActor);
    Assert.AreEqual<string>((string)null, ((Movie)fantasy).Id);
}
    }
}
