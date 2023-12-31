# Use the .NET Core SDK image as the base image for building the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
# Copy the project file and restore the dependencies
COPY ["StreamFlex.DownloadWorker.csproj", "./"]
RUN dotnet restore "StreamFlex.DownloadWorker.csproj"
# Copy the rest of the source code
COPY . .
# Build the application
RUN dotnet build "StreamFlex.DownloadWorker.csproj" -c Release -o /app/build
# Publish the application
FROM build AS publish
RUN dotnet publish "StreamFlex.DownloadWorker.csproj" -c Release -o /app/publish
# Use the .NET Core Runtime image as the final image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
# Copy the published application to the final image for running the application
COPY --from=publish /app/publish .
# Set the entry point for the application
ENTRYPOINT ["dotnet", "StreamFlex.DownloadWorker.dll"]