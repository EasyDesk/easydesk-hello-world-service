using EasyDesk.CleanArchitecture.Domain.Time;
using EasyDesk.CleanArchitecture.Testing;
using EasyDesk.CleanArchitecture.Testing.Requests;
using EasyDesk.Tools.Options;
using EasyDesk.Tools.PrimitiveTypes.DateAndTime;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System.Threading.Tasks;
using Xunit;
using static HelloWorldService.Application.Queries.GetHelloWorldMessage;

namespace HelloWorldService.UnitTests.Application
{
    public class GetHelloWorldMessageTests : RequestHandlerTestsBase<Handler, Query, HelloMessage>
    {
        private string _testSubject = "fabio";

        protected override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddSingleton<ITimestampProvider>(new SettableTimestampProvider(Timestamp.Now));
        }

        [Fact]
        public async Task Subject_ShouldMatch()
        {
            var result = await Send(new(OptionImports.Some(_testSubject)));
            result.ReadValue().Message.ShouldBe("Hello fabio!");
        }

        [Fact]
        public async Task Subject_ShouldDefaultToWorld()
        {
            var result = await Send(new(OptionImports.None));
            result.ReadValue().Message.ShouldBe("Hello World!");
        }
    }
}
