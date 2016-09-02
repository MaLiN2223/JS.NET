namespace Utils
{
    using System;

    public struct BoolInt
    {
        private int? @int { get; set; }
        private bool? @bool { get; set; }
        public static implicit operator BoolInt(int i)
        {
            return new BoolInt { @int = i, @bool = null };
        }
        public static implicit operator BoolInt(int? i)
        {
            return new BoolInt { @int = i, @bool = null };
        }
        public static implicit operator BoolInt(bool i)
        {
            return new BoolInt { @bool = i, @int = null };
        }
        public static implicit operator BoolInt(bool? i)
        {
            return new BoolInt { @bool = i, @int = null };
        }
        public static implicit operator int(BoolInt obj)
        {
            if (obj.@int.HasValue)
                return obj.@int.Value;
            throw new InvalidCastException("This object is not an integer");
        }
        public static implicit operator int? (BoolInt obj)
        {
            return obj.@int;
        }
        public static implicit operator bool(BoolInt obj)
        {
            if (obj.@bool.HasValue)
                return obj.@bool.Value;
            throw new InvalidCastException("This object is not an boolean");
        }
        public static implicit operator bool? (BoolInt obj)
        {
            return obj.@bool;
        }

        public override string ToString()
        {
            if (@int.HasValue)
                return @int.ToString();
            if (@bool.HasValue)
                return @bool.ToString();
            return "";
        }
    }
}
