
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
        public Function<DateTime> BeforeShowDay { get; set; }
        public Function<DateTime> BeforeShowMonth { get; set; }
        public Function<DateTime> BeforeShowYear { get; set; }
        public Function<DateTime> BeforeShowDecade { get; set; }
        public Function<DateTime> BeforeShowCentury { get; set; }
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
        public Date? DefaultViewDate { get; set; }
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
        public StringInt? MaxViewMode { get; set; }
        public StringInt? MinViewMode { get; set; }
        public BoolInt? Multidate { get; set; }
        public char? MultidateSeparator { get; set; }
        public string Orientation { get; set; }
        public bool? ShowOnFocus { get; set; }
        public DateTime? StartDate { get; set; }
        public StringInt? StartView { get; set; }
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
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("datesDisabled", DatesDisabled,Format)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("daysOfWeekDisabled", DaysOfWeekDisabled)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("daysOfWeekHighlighted", DaysOfWeekHighlighted)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("defaultViewDate", DefaultViewDate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("disableTouchKeyboard", DisableTouchKeyboard)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("enableOnReadonly", EnableOnReadonly)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("endDate", EndDate, Format)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("forceParse", ForceParse)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("assumeNearbyYear", AssumeNearbyYear)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("format", Format)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("immediateUpdates", ImmediateUpdates)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("inputs", Inputs)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("keepEmptyValues", KeepEmptyValues)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("keyboardNavigation", KeyboardNavigation)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("language", Language)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("maxViewMode", MaxViewMode)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("minViewMode", MinViewMode)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("multidate", Multidate)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("multidateSeparator", MultidateSeparator)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("orientation", Orientation)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("showOnFocus", ShowOnFocus)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("startDate", StartDate, Format)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("startView", StartView)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("templates", Templates)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("title", Title)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("todayBtn", TodayBtn)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("todayHighlight", TodayHighlight)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("toggleActive", ToggleActive)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("weekStart", WeekStart)));
                builder.AppendLineWithoutNullOrEmpty(Formatted(GetValue("zIndexOffset", ZIndexOffset)));
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
                builder.Append(Formatted(GetValue("datesDisabled", DatesDisabled,Format)));
                builder.Append(Formatted(GetValue("daysOfWeekDisabled", DaysOfWeekDisabled)));
                builder.Append(Formatted(GetValue("daysOfWeekHighlighted", DaysOfWeekHighlighted)));
                builder.Append(Formatted(GetValue("defaultViewDate", DefaultViewDate)));
                builder.Append(Formatted(GetValue("disableTouchKeyboard", DisableTouchKeyboard)));
                builder.Append(Formatted(GetValue("enableOnReadonly", EnableOnReadonly)));
                builder.Append(Formatted(GetValue("endDate", EndDate, Format)));
                builder.Append(Formatted(GetValue("forceParse", ForceParse)));
                builder.Append(Formatted(GetValue("assumeNearbyYear", AssumeNearbyYear)));
                builder.Append(Formatted(GetValue("format", Format)));
                builder.Append(Formatted(GetValue("immediateUpdates", ImmediateUpdates)));
                builder.Append(Formatted(GetValue("inputs", Inputs)));
                builder.Append(Formatted(GetValue("keepEmptyValues", KeepEmptyValues)));
                builder.Append(Formatted(GetValue("keyboardNavigation", KeyboardNavigation)));
                builder.Append(Formatted(GetValue("language", Language)));
                builder.Append(Formatted(GetValue("maxViewMode", MaxViewMode)));
                builder.Append(Formatted(GetValue("minViewMode", MinViewMode)));
                builder.Append(Formatted(GetValue("multidate", Multidate)));
                builder.Append(Formatted(GetValue("multidateSeparator", MultidateSeparator)));
                builder.Append(Formatted(GetValue("orientation", Orientation)));
                builder.Append(Formatted(GetValue("showOnFocus", ShowOnFocus)));
                builder.Append(Formatted(GetValue("startDate", StartDate, Format)));
                builder.Append(Formatted(GetValue("startView", StartView)));
                builder.Append(Formatted(GetValue("templates", Templates)));
                builder.Append(Formatted(GetValue("title", Title)));
                builder.Append(Formatted(GetValue("todayBtn", TodayBtn)));
                builder.Append(Formatted(GetValue("todayHighlight", TodayHighlight)));
                builder.Append(Formatted(GetValue("toggleActive", ToggleActive)));
                builder.Append(Formatted(GetValue("weekStart", WeekStart)));
                builder.Append(Formatted(GetValue("zIndexOffset", ZIndexOffset)));
            }
            builder.Append("})");
            var value = builder.ToString();
            if (value.Equals($".datepicker({{{Environment.NewLine}}})"))
                return ".datepicker({})";
            return value;
        }

        private string GetValue(string title, Date? o)
        {
            if (!o.HasValue)
                return "";
            return $"{title}:\t{{{o}}}";
        }

        private string GetValue(string title, StringInt? o)
        {
            if (!o.HasValue)
                return "";
            return $"{title}:\t{o}";
        }

        private static string GetValue(string title, BoolInt? o)
        {
            if (!o.HasValue)
                return "";
            return $"{title}:\t{o}";
            //TODO : poprawic
        }


        private static string GetValue(string title, Dictionary<string, string> o)
        {
            if (o == null)
                return "";
            return $"{title}:\t{o}";
            //TODO : poprawic
        }

        private static string GetValue(string title, char? o)
        {

            if (o == null)
                return "";
            return $"{title}:\t{o}";
            //TODO : poprawic
        }



        private static string GetValue(string title, Tuple<int, byte, byte> o)
        {
            if (o == null)
                return "";
            return $"{title}:\t{o}";
            //TODO : poprawic
        }

        private static string GetValue(string title, string o)
        {
            return o == null ? "" : $"{title}:\t\"{o}\"";
        }

        private static string GetValue(string title, bool? o)
        {
            if (o == null) return "";
            var value = o.Value ? "true" : "false";
            return $"{title}:\t{value}";
        }

        private static string GetValue(string title, int? o)
        {
            if (o == null)
                return "";
            return $"{title}:\t{o}";
        }
        private static string GetValue(string title, DateTime? o, string format)
        {
            if (o == null)
                return "";
            string date = format == null ? o.Value.ToString("yyy/mm/dd") : o.Value.ToString(format);
            return $"{title}:\t{date}";
        }
        private static string GetValue(string title, Function o)
        {
            if (o == null)
                return "";
            var parametersString = string.Join(",", o.Args);
            string value = $"\t\tfunction{o.Name}({parametersString}){{{Environment.NewLine}\t\t\t{o.Body}{Environment.NewLine}\t\t}}";

            return $"{title}:{Environment.NewLine}{value}";
        }
        private static string GetValue(string title, DateTime[] o, string format)
        {
            if (o == null)
                return "";
            string value = o.Aggregate("", (current, dateTime) => current +", '"+ (format == null ? dateTime.ToString("yyyy-mm-dd") : dateTime.ToString(format))+"'");
            return $"{title}:\t{value}";
            //TODO : poprawa wypisywania
        }
        private static string GetValue(string title, byte[] o)
        {
            if (o == null || o.Length == 0)
                return "";
            var data = $"\t\"{string.Join(", ", o)}\"";
            return $"{title}:\t{data}";
        }

        private static string Formatted(string line)
        {
            if (string.IsNullOrEmpty(line))
                return "";
            return $"\t{line},";
        }
    }
}
