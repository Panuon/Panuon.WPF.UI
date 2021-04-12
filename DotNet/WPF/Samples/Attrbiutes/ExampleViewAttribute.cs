using System;

namespace Samples
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExampleViewAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public string Screenshot { get; set; }
    }
}
