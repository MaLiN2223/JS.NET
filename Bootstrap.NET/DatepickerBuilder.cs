
namespace Bootstrap.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using JS.NET.Base;
    using Utils;

    public class DatepickerBuilder
    {
        public bool AllProperitesInNewLine { get; set; } = true;
        public bool? Autoclose { get; set; }
        private Function<DateTime> BeforeShowDay { get; set; }
        private Function<DateTime> BeforeShowMonth { get; set; }
        private Function<DateTime> BeforeShowYear { get; set; }
        private Function<DateTime> BeforeShowDecade { get; set; }
        private Function<DateTime> BeforeShowCentury { get; set; }
        public bool? CalendarWeeks { get; set; }
        public bool? ClearBtn { get; set; }
        public string Container { get; set; }
        public DateTime[] DatesDisabled { get; set; }
        private byte[] daysOfWeekDisbaled { get; set; }
        public byte[] DaysOfWeekDisabled
        {
            get { return daysOfWeekDisbaled; }
            set
            {
                if (value.Any(t => t > 6))
                {
                    throw new ArgumentException("All days must be smaller than 7");
                }
                daysOfWeekDisbaled = value;
            }
        }
        public byte[] DaysOfWeekHighlighted { get; set; }
        Tuple<int, byte, byte> DefaultViewDate { get; set; }
        public bool? DisableTouchKeyboard { get; set; }
        public bool? EnableOnReadonly { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? ForceParse { get; set; }
        public BoolInt? AssumeNearbyYear { get; set; }
        public string Format { get; set; }
        public bool? ImmediateUpdates { get; set; }
        public string Inputs { get; set; }
        public bool? KeepEmptyValues { get; set; }
        public bool? KeyboardNavigation { get; set; }
        public string Language { get; set; }
        public Tuple<int, string> MaxViewMode { get; set; }
        public Tuple<int, string> MinViewMode { get; set; }
        public BoolInt? Multidate { get; set; }
        public char? MultidateSeparator { get; set; }
        public string Orientation { get; set; }
        public bool? ShowOnFocus { get; set; }
        public DateTime? StartDate { get; set; }
        public Tuple<int, string> StartView { get; set; }
        public Dictionary<string, string> Templates { get; set; }
        public string Title { get; set; }
        public bool? TodayBtn { get; set; }
        public bool? TodayHighlight { get; set; }
        public bool? ToggleActive { get; set; }
        public int? WeekStart { get; set; }
        public int? ZIndexOffset { get; set; }
        public string Build()
        {
            var builder = new StringBuilder(".datepicker({");
            if (AllProperitesInNewLine)
            {
                builder.AppendLine("");
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("autoclose", Autoclose)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("beforeShowDay", BeforeShowDay)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("beforeShowMonth", BeforeShowMonth)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("beforeShowYear", BeforeShowYear)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("beforeShowDecade", BeforeShowDecade)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("beforeShowCentury", BeforeShowCentury)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("calendarWeeks", CalendarWeeks)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("clearBtn", ClearBtn)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("container", Container)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("datesDisabled", DatesDisabled)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("daysOfWeekDisabled", DaysOfWeekDisabled)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("daysOfWeekHighlighted", DaysOfWeekHighlighted)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("defaultViewDate", DefaultViewDate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("disableTouchKeyboard", DisableTouchKeyboard)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", EnableOnReadonly)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", EndDate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", ForceParse)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", AssumeNearbyYear)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Format)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", ImmediateUpdates)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Inputs)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", KeepEmptyValues)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", KeyboardNavigation)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Language)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", MaxViewMode)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", MinViewMode)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Multidate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", MultidateSeparator)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Orientation)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", ShowOnFocus)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", StartDate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", StartView)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Templates)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", Title)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", TodayBtn)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", TodayHighlight)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", ToggleActive)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", WeekStart)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", ZIndexOffset)));
            }
            else
            {
                builder.Append(Formatted(GetValue("autoclose", Autoclose)));
                builder.Append(Formatted(GetValue("beforeShowDay", BeforeShowDay)));
                builder.Append(Formatted(GetValue("beforeShowMonth", BeforeShowMonth)));
                builder.Append(Formatted(GetValue("beforeShowYear", BeforeShowYear)));
                builder.Append(Formatted(GetValue("beforeShowDecade", BeforeShowDecade)));
                builder.Append(Formatted(GetValue("beforeShowCentury", BeforeShowCentury)));
                builder.Append(Formatted(GetValue("calendarWeeks", CalendarWeeks)));
                builder.Append(Formatted(GetValue("clearBtn", ClearBtn)));
                builder.Append(Formatted(GetValue("container", Container)));
                builder.Append(Formatted(GetValue("datesDisabled", DatesDisabled)));
                builder.Append(Formatted(GetValue("daysOfWeekDisabled", DaysOfWeekDisabled)));
                builder.Append(Formatted(GetValue("daysOfWeekHighlighted", DaysOfWeekHighlighted)));
                builder.Append(Formatted(GetValue("defaultViewDate", DefaultViewDate)));
                builder.Append(Formatted(GetValue("disableTouchKeyboard", DisableTouchKeyboard)));
                builder.Append(Formatted(GetValue("enableOnReadonly", EnableOnReadonly)));
                builder.Append(Formatted(GetValue("enableOnReadonly", EndDate)));
                builder.Append(Formatted(GetValue("enableOnReadonly", ForceParse)));
                builder.Append(Formatted(GetValue("enableOnReadonly", AssumeNearbyYear)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Format)));
                builder.Append(Formatted(GetValue("enableOnReadonly", ImmediateUpdates)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Inputs)));
                builder.Append(Formatted(GetValue("enableOnReadonly", KeepEmptyValues)));
                builder.Append(Formatted(GetValue("enableOnReadonly", KeyboardNavigation)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Language)));
                builder.Append(Formatted(GetValue("enableOnReadonly", MaxViewMode)));
                builder.Append(Formatted(GetValue("enableOnReadonly", MinViewMode)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Multidate)));
                builder.Append(Formatted(GetValue("enableOnReadonly", MultidateSeparator)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Orientation)));
                builder.Append(Formatted(GetValue("enableOnReadonly", ShowOnFocus)));
                builder.Append(Formatted(GetValue("enableOnReadonly", StartDate)));
                builder.Append(Formatted(GetValue("enableOnReadonly", StartView)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Templates)));
                builder.Append(Formatted(GetValue("enableOnReadonly", Title)));
                builder.Append(Formatted(GetValue("enableOnReadonly", TodayBtn)));
                builder.Append(Formatted(GetValue("enableOnReadonly", TodayHighlight)));
                builder.Append(Formatted(GetValue("enableOnReadonly", ToggleActive)));
                builder.Append(Formatted(GetValue("enableOnReadonly", WeekStart)));
                builder.Append(Formatted(GetValue("enableOnReadonly", ZIndexOffset)));
            }
            builder.Append("})");
            var value = builder.ToString();
            if (value.Equals($".datepicker({{{Environment.NewLine}}})"))
                return ".datepicker({})";
            return value;
        }

        private static string GetValue(string title, BoolInt? o)
        {
            if (!o.HasValue)
                return "";
            return $"{title}:{o}";
            //TODO : poprawic
        }


        private static string GetValue(string title, Dictionary<string, string> o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
            //TODO : poprawic
        }

        private static string GetValue(string title, char? o)
        {

            if (o == null)
                return "";
            return $"{title}:{o}";
            //TODO : poprawic
        }

        private static string GetValue(string title, Tuple<int, string> o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
            //TODO : poprawic
        }


        private static string GetValue(string title, Tuple<int, byte, byte> o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
            //TODO : poprawic
        }

        private static string GetValue(string title, string o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
        }

        private static string GetValue(string title, bool? o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
        }
        private static string GetValue(string title, int? o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
        }
        private static string GetValue(string title, DateTime? o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
        }
        private static string GetValue<T>(string title, Function<T> o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
        }
        private static string GetValue(string title, DateTime[] o)
        {
            if (o == null)
                return "";
            return $"{title}:{o}";
            //TODO : poprawa wypisywania
        }
        private static string GetValue(string title, byte[] o)
        {
            if (o == null || o.Length == 0)
                return "";
            var data = $"\t\"{string.Join(", ", o)}\"";
            return $"{title}:{data}";
        }

        private static string Formatted(string line)
        {
            if (string.IsNullOrEmpty(line))
                return "";
            return $"\t{line}";
        }
    }
}
