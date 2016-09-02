namespace Tests.Bootstrap
{
    using System;
    using global::Bootstrap.NET;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DatepickerTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            var builder = new DatepickerBuilder();
            Assert.AreEqual(".datepicker({})", builder.Build());
        }

        [TestMethod]
        public void DisbaledDaysOfWeek()
        {
            var builder = new DatepickerBuilder { DaysOfWeekDisabled = new byte[] { 0, 1, 2, 3, 4, 5, 6 } };
            Assert.AreEqual($".datepicker({{{Environment.NewLine}\tdaysOfWeekDisabled:\t\"0, 1, 2, 3, 4, 5, 6\"{Environment.NewLine}}})", builder.Build());
            builder = new DatepickerBuilder { DaysOfWeekDisabled = new byte[] { 1, 4, 5 } };
            Assert.AreEqual($".datepicker({{{Environment.NewLine}\tdaysOfWeekDisabled:\t\"1, 4, 5\"{Environment.NewLine}}})", builder.Build());
            builder = new DatepickerBuilder { DaysOfWeekDisabled = new byte[] { } };
            Assert.AreEqual(".datepicker({})", builder.Build());
        }
    }
}
