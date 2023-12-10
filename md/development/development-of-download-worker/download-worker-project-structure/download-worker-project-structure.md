# Download Worker Project Structure

## Projects

### StreamFlex.DownloadWorker.Core
- Domain logic and models.
- Classes: `Video`, `DownloadTask`.

### StreamFlex.DownloadWorker.Services
- Business logic and domain services.
- Classes: `DownloadService`, `DownloadTaskHandler`.

### StreamFlex.DownloadWorker.Infrastructure
- Infrastructure including database interaction and external services.
- Classes: `VideoRepository`, `DownloadTaskRepository`.

### StreamFlex.DownloadWorker.Api
- API interface for interaction with other system parts.
- Includes controllers and DTOs.

### StreamFlex.DownloadWorker.Application
- Application services and configuration management.
- Classes: `LoggerService`, `ConfigurationService`.

### StreamFlex.DownloadWorker.Tests
- Unit and integration tests for all components.
- Classes: `DownloadWorkerTests`, `VideoRepositoryTests`, etc.

[Go back](../development-of-download-worker.md#download-worker-project-structure)