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
    public partial class EpisodeTest
    {

[TestMethod]
[PexGeneratedBy(typeof(EpisodeTest))]
public void AgeRatingGetTest267()
{
    Drama drama;
    int i;
    drama = new Drama((string)null, (string)null, (string)null, 
                      0, 0, (string)null, (string)null);
    i = this.AgeRatingGetTest((Episode)drama);
    Assert.AreEqual<int>(0, i);
}
    }
}
