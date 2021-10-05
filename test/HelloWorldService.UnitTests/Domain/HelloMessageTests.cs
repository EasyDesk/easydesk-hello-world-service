using EasyDesk.CleanArchitecture.Domain.Time;
using EasyDesk.CleanArchitecture.Testing;
using EasyDesk.Tools.PrimitiveTypes.DateAndTime;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using Shouldly;
using Xunit;

namespace HelloWorldService.UnitTests.Domain
{
    public class HelloMessageTests
    {
        private readonly ITimestampProvider _timestampProvider;
        private Subject _testSubject;

        public HelloMessageTests()
        {
            _testSubject = Subject.From("Name");
            _timestampProvider = new SettableTimestampProvider(Timestamp.Now);
        }

        [Fact]
        public void From_ShouldReturnHelloMessage_IfInputIsCorrect()
        {
            var hm = HelloMessage.From(_testSubject, _timestampProvider.Now);
            hm.Message.ShouldContain(_testSubject);
            hm.Timestamp.ShouldBe(_timestampProvider.Now);
        }

        [Fact]
        public void ToString_ShouldReturnContent()
        {
            var hm = HelloMessage.From(_testSubject, _timestampProvider.Now);
            hm.ToString().ShouldBe(hm.Message);
        }
    }
}
