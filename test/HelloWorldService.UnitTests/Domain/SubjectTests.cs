using System;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using Shouldly;
using Xunit;

namespace HelloWorldService.UnitTests.Domain
{
    public class SubjectTests
    {
        private string _testName = "test";

        [Fact]
        public void From_ToString_ShouldReturnTheName()
        {
            Subject.From(_testName).ToString().ShouldBe(_testName);
        }

        [Fact]
        public void From_ShouldFail_IfInputIsNull()
        {
            Should.Throw<ArgumentException>(() => Subject.From(null));
        }

        [Fact]
        public void From_ShouldFail_IfInputIsEmpty()
        {
            Should.Throw<ArgumentException>(() => Subject.From(string.Empty));
        }
    }
}
