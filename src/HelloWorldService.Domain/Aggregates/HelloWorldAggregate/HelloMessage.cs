using EasyDesk.CleanArchitecture.Domain.Metamodel;
using EasyDesk.Tools.PrimitiveTypes.DateAndTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService.Domain.Aggregates.HelloWorldAggregate
{
    public record HelloMessage
    {
        public string Message { get; }

        public Timestamp Timestamp { get; }

        private HelloMessage(string value, Timestamp timestamp)
        {
            if (!value.Contains("hello", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("A Hello Message must contain the word \"hello\"", nameof(value));
            }
            Message = value;
            Timestamp = timestamp;
        }

        public static HelloMessage From(Subject subject, Timestamp timestamp) => new("Hello " + subject + "!", timestamp);

        public override string ToString() => Message;
    }
}
