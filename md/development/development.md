# Development

- [Development](#development)
  - [Development of StreamFlex components](#development-of-streamflex-components)
    - [Development of Download Worker](#development-of-download-worker)

## Development of StreamFlex components
### Development of Download Worker
[Download Worker page](development-of-download-worker/development-of-download-worker.md)


```
FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["StreamFlex.DownloadWorker/StreamFlex.DownloadWorker.csproj", "StreamFlex.DownloadWorker/"]
RUN dotnet restore "StreamFlex.DownloadWorker/StreamFlex.DownloadWorker.csproj"
COPY . .
WORKDIR "/src/StreamFlex.DownloadWorker"
RUN dotnet build "StreamFlex.DownloadWorker.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "StreamFlex.DownloadWorker.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StreamFlex.DownloadWorker.dll"]
```


<!-- 
## Docker and Deployment
## API versions

## Update dependencies.
Possibility to update the project to versions C# 8.0 and dotnet-ef to version 8.0.

## Code quality -->

[Go back](../../README.md#development)