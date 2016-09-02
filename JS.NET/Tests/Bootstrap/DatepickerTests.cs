namespace Tests.Bootstrap
{
    using System;
    using global::Bootstrap.NET;
    using JS.NET.Base;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Utils;

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

        [TestMethod]
        public void Format()
        {
            var builder = new DatepickerBuilder() { Format = "dd/mm/yyyy" };
            AssertPicker("format", "dd/mm/yyyy", builder);
        }

        private void AssertPicker(string type, string inside, DatepickerBuilder builder)
        {
            Assert.AreEqual($".datepicker({{{Environment.NewLine}\t{type}:\t\"{inside}\"{Environment.NewLine}}})", builder.Build());
        }
        private void AssertPicker(string type, int inside, DatepickerBuilder builder)
        {
            Assert.AreEqual($".datepicker({{{Environment.NewLine}\t{type}:\t{inside}{Environment.NewLine}}})", builder.Build());
        }

        [TestMethod]
        public void BigTest()
        {
            var expected =
@".datepicker({
    autoclose: true,
    beforeShowDay: 
        function(date){
            test;   
        },
    beforeShowMonth: 
        function(date2){
            text;
        },
    beforeShowYear: 
        function(date3){
            test
        },
    calendarWeeks:  true,
    clearBtn:   true,
    datesDisabled: ['09/06/2016', '09/21/2016'],
    daysOfWeekDisabled: ""0,2,3,4,6"",
    daysOfWeekHighlighted: ""1,2"",
    defaultViewDate: { year: 1977, month: 04, day: 25 }
    endDate: ""2/3/1990"",
    format: ""dd / mm / yyyy"",
    language: ""it"",
    minViewMode: 2,
    maxViewMode: 2,
    multidate: true,
    multidateSeparator: ""."",
    orientation: ""bottom auto"",
    startDate: ""1/1/1990"",
    startView: 2,
    todayBtn: true,
    todayHighlight: true,
    toggleActive: true,
    weekStart: 3,
})";
            var builder = new DatepickerBuilder
            {
                Format = "dd / mm / yyyy",
                WeekStart = 3,
                StartDate = new DateTime(1990, 1, 1),
                EndDate = new DateTime(1990, 3, 2),
                StartView = 2,
                MinViewMode = 2,
                MaxViewMode = 2,
                TodayBtn = true,
                ClearBtn = true,
                Language = "it",
                Orientation = "bottom auto",
                Multidate = true,
                MultidateSeparator = '.',
                DaysOfWeekDisabled = new byte[] { 0, 2, 3, 4, 6 },
                DaysOfWeekHighlighted = new byte[] { 1, 2 },
                CalendarWeeks = true,
                Autoclose = true,
                BeforeShowDay = new Function<DateTime> { Args = new[] { "date" }, Body = "test;" },
                BeforeShowMonth = new Function<DateTime> { Args = new[] { "date2" }, Body = "text;" },
                BeforeShowYear = new Function<DateTime> { Args = new[] { "date3" }, Body = "test" },
                DatesDisabled = new DateTime[] { new DateTime(2016, 9, 6), new DateTime(2016, 09, 21) },
                ToggleActive = true,
                TodayHighlight =  true,
                DefaultViewDate = new Date() { Year = 1977, Month = 4, Day = 25 }
        };
        Assert.AreEqual(expected, builder.Build());

        }
}
}
