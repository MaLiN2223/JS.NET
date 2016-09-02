namespace JS.NET.Base
{
    public class Function
    {
        public string Body { get; set; }
        public string[] Args { get; set; }
        public string Name { get; set; } = "";
        public override string ToString()
        {
            var parametersString = string.Join(",", Args);
            return $"function {Name}({parametersString}){{{Body}}}";
        }
    }

    public class Function<T> : Function
    {

    }
}
