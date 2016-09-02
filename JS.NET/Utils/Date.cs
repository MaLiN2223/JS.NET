using System;

namespace Utils
{
    using System.Text;

    public struct Date
    {
        public bool HasValue => Month.HasValue || Day.HasValue || Year.HasValue;
        
        public uint? Year { get; set; }

        public byte? Month { get; set; }

        public byte? Day { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (HasValue)
            {
                if (Year.HasValue)
                {
                    builder.Append($"year: {Year}");
                    if (Month.HasValue || Day.HasValue)
                        builder.Append(',');
                }
                if (Month.HasValue)
                {
                    builder.Append($"month: {Month}");
                    if (Day.HasValue)
                        builder.Append(',');
                }
                if (Day.HasValue)
                {
                    builder.Append($"day: {Day}"); 
                }

            }
            return builder.ToString();
        }
    }
}
