using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSchedule;

namespace TVSchedule.Tests
{
    /// <summary>This class contains parameterized unit tests for TVSchedule</summary>
    [TestClass]
    [PexClass(typeof(global::TVSchedule.TVSchedule))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TVScheduleTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal global::TVSchedule.TVSchedule ConstructorTest()
        {
            global::TVSchedule.TVSchedule target = new global::TVSchedule.TVSchedule();
            return target;
            // TODO: add assertions to method TVScheduleTest.ConstructorTest()
        }

        /// <summary>Test stub for AddToDirectoryList(iRecordableItem)</summary>
        [PexMethod]
        internal void AddToDirectoryListTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target, iRecordableItem show)
        {
            target.AddToDirectoryList(show);
            // TODO: add assertions to method TVScheduleTest.AddToDirectoryListTest(TVSchedule, iRecordableItem)
        }

        /// <summary>Test stub for LoadDirectoryList()</summary>
        [PexMethod]
        internal void LoadDirectoryListTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            target.LoadDirectoryList();
            // TODO: add assertions to method TVScheduleTest.LoadDirectoryListTest(TVSchedule)
        }

        /// <summary>Test stub for LoadScheduleList()</summary>
        [PexMethod]
        internal void LoadScheduleListTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            target.LoadScheduleList();
            // TODO: add assertions to method TVScheduleTest.LoadScheduleListTest(TVSchedule)
        }

        /// <summary>Test stub for RemoveFromSchedule(String)</summary>
        [PexMethod]
        internal void RemoveFromScheduleTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target, string id)
        {
            target.RemoveFromSchedule(id);
            // TODO: add assertions to method TVScheduleTest.RemoveFromScheduleTest(TVSchedule, String)
        }

        /// <summary>Test stub for ScheduleShow(String)</summary>
        [PexMethod]
        internal void ScheduleShowTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target, string id)
        {
            target.ScheduleShow(id);
            // TODO: add assertions to method TVScheduleTest.ScheduleShowTest(TVSchedule, String)
        }

        /// <summary>Test stub for WriteDirectoryListToFile()</summary>
        [PexMethod]
        internal void WriteDirectoryListToFileTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            target.WriteDirectoryListToFile();
            // TODO: add assertions to method TVScheduleTest.WriteDirectoryListToFileTest(TVSchedule)
        }

        /// <summary>Test stub for WriteScheduleListToFile()</summary>
        [PexMethod]
        internal void WriteScheduleListToFileTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            target.WriteScheduleListToFile();
            // TODO: add assertions to method TVScheduleTest.WriteScheduleListToFileTest(TVSchedule)
        }

        /// <summary>Test stub for get_RecordableItems()</summary>
        [PexMethod]
        internal List<iRecordableItem> RecordableItemsGetTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            List<iRecordableItem> result = target.RecordableItems;
            return result;
            // TODO: add assertions to method TVScheduleTest.RecordableItemsGetTest(TVSchedule)
        }

        /// <summary>Test stub for get_ScheduledItems()</summary>
        [PexMethod]
        internal List<iRecordableItem> ScheduledItemsGetTest([PexAssumeUnderTest]global::TVSchedule.TVSchedule target)
        {
            List<iRecordableItem> result = target.ScheduledItems;
            return result;
            // TODO: add assertions to method TVScheduleTest.ScheduledItemsGetTest(TVSchedule)
        }
    }
}
