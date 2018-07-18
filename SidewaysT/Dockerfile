FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 61962
EXPOSE 44368

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY SidewaysT/SidewaysT.csproj SidewaysT/
RUN dotnet restore SidewaysT/SidewaysT.csproj
COPY . .
WORKDIR /src/SidewaysT
RUN dotnet build SidewaysT.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SidewaysT.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SidewaysT.dll"]
