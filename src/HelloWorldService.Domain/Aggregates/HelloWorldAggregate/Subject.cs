using EasyDesk.CleanArchitecture.Domain.Metamodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService.Domain.Aggregates.HelloWorldAggregate
{
    public record Subject : ValueWrapper<string>
    {
        private Subject(string value) : base(value)
        {
        }

        protected override void Validate(string value)
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Subject name can't be an empty string", nameof(value));
            }
        }

        public static Subject From(string name) => new(name);

        public override string ToString() => Value;
    }
}
