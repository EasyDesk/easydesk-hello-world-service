FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HelloWorldService.Web/HelloWorldService.Web.csproj", "HelloWorldService.Web/"]
COPY ["HelloWorldService.Infrastructure/HelloWorldService.Infrastructure.csproj", "HelloWorldService.Infrastructure/"]
COPY ["HelloWorldService.Application/HelloWorldService.Application.csproj", "HelloWorldService.Application/"]
COPY ["HelloWorldService.Domain/HelloWorldService.Domain.csproj", "HelloWorldService.Domain/"]
RUN dotnet restore "HelloWorldService.Web/HelloWorldService.Web.csproj"
COPY . .
WORKDIR "/src/HelloWorldService.Web"
RUN dotnet build "HelloWorldService.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWorldService.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorldService.Web.dll"]