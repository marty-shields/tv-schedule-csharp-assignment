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
    public partial class MovieTest
    {

[TestMethod]
[PexGeneratedBy(typeof(MovieTest))]
[PexRaisedException(typeof(IDAlreadyTakenException))]
public void AddProgramTestThrowsIDAlreadyTakenException374()
{
    Horror horror;
    string s;
    horror = new Horror((string)null, (string)null, (string)null, (string)null, 
                        0, 0, 0, (string)null);
    s = this.AddProgramTest((Movie)horror);
}
    }
}
