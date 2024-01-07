# Use the .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project files to the container
COPY StreamFlex.DownloadWorker.Api/StreamFlex.DownloadWorker.Api.csproj .
COPY StreamFlex.DownloadWorker.Services/StreamFlex.DownloadWorker.Services.csproj .

# Restore the NuGet packages
RUN dotnet restore

# Copy the rest of the project files to the container
COPY . .

# Build the project
RUN dotnet build -c Release --no-restore

# Publish the project
RUN dotnet publish StreamFlex.DownloadWorker.Api/StreamFlex.DownloadWorker.Api.csproj -c Release -o /app/publish --no-restore

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
