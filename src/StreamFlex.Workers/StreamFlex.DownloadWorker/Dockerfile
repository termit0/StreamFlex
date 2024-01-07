# Use the .NET SDK image as the base image for building the project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory inside the container
WORKDIR /src

# Copy the entire project to the container
COPY . .

# Restore the NuGet packages
RUN dotnet restore "StreamFlex.DownloadWorker.Api/StreamFlex.DownloadWorker.Api.csproj"

# Build the project
RUN dotnet build "StreamFlex.DownloadWorker.Api/StreamFlex.DownloadWorker.Api.csproj" -c Release --no-restore

# Publish the project
RUN dotnet publish "StreamFlex.DownloadWorker.Api/StreamFlex.DownloadWorker.Api.csproj" -c Release -o /app/publish --no-restore

# Use the ASP.NET Core runtime image as the final image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final

# Set the working directory inside the container
WORKDIR /app

# Copy the published files from the build image to the final image
COPY --from=build /app/publish .

# Expose the port that the application listens on
EXPOSE 80

# Set the entry point for the container
ENTRYPOINT ["dotnet", "StreamFlex.DownloadWorker.Api.dll"]
