using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public struct StringInt
    {
        private int? @int { get; set; }
        private string @string { get; set; }
        public static implicit operator StringInt(int i)
        {
            return new StringInt { @int = i, @string = null };
        }
        public static implicit operator StringInt(int? i)
        {
            return new StringInt { @int = i, @string = null };
        }
        public static implicit operator StringInt(string i)
        {
            return new StringInt { @string = i, @int = null };
        }
        public static implicit operator int(StringInt obj)
        {
            if (obj.@int.HasValue)
                return obj.@int.Value;
            throw new InvalidCastException("This object is not an integer");
        }
        public static implicit operator int? (StringInt obj)
        {
            return obj.@int;
        }
        public static implicit operator string(StringInt obj)
        {
            if (obj.@string != null)
                return obj.@string;
            throw new InvalidCastException("This object is not a string");

        }

        public override string ToString()
        {
            if (@int.HasValue)
                return @int.ToString();
            if (@string != null)
                return @string.ToString();
            return "";
        }
    }
}
