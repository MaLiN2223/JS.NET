using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendLineWithoutNullOrEmpty(this StringBuilder builder, string value)
        {
            if (string.IsNullOrEmpty(value))
                return builder;
            return builder.AppendLine(value);
        }
    }
}
