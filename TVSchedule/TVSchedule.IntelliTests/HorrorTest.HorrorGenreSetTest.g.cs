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
    public partial class HorrorTest
    {

[TestMethod]
[PexGeneratedBy(typeof(HorrorTest))]
public void HorrorGenreSetTest406()
{
    Horror horror;
    horror = new Horror((string)null, (string)null, (string)null, (string)null, 
                        0, 0, 0, (string)null);
    this.HorrorGenreSetTest(horror, (string)null);
    Assert.IsNotNull((object)horror);
    Assert.AreEqual<string>((string)null, horror.HorrorGenre);
    Assert.AreEqual<string>((string)null, ((Movie)horror).Title);
    Assert.AreEqual<string>((string)null, ((Movie)horror).Description);
    Assert.AreEqual<int>(0, ((Movie)horror).RunTime);
    Assert.AreEqual<int>(0, ((Movie)horror).AgeRating);
    Assert.AreEqual<int>(0, ((Movie)horror).ReleaseYear);
    Assert.AreEqual<string>((string)null, ((Movie)horror).MainActor);
    Assert.AreEqual<string>((string)null, ((Movie)horror).Id);
}
    }
}
