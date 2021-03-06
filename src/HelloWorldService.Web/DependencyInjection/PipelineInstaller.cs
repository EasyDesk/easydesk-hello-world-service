using System;
using EasyDesk.CleanArchitecture.Web.DependencyInjection;
using HelloWorldService.Application;
using HelloWorldService.Infrastructure;

namespace HelloWorldService.Web.DependencyInjection
{
    /// <summary>
    /// A service installer that configures the pipeline for this service.
    /// </summary>
    public class PipelineInstaller : PipelineInstallerBase
    {
        /// <inheritdoc/>
        protected override Type ApplicationAssemblyMarker => typeof(ApplicationMarker);

        /// <inheritdoc/>
        protected override Type InfrastructureAssemblyMarker => typeof(InfrastructureMarker);

        /// <inheritdoc/>
        protected override Type WebAssemblyMarker => typeof(Startup);

        /// <inheritdoc/>
        protected override bool UsesPublisher => false;

        /// <inheritdoc/>
        protected override bool UsesConsumer => false;
    }
}
