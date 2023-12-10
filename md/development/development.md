# Development

- [Development](#development)
  - [Development of StreamFlex components](#development-of-streamflex-components)
    - [Development of Download Worker](#development-of-download-worker)

## Development of StreamFlex components
### Development of Download Worker
[Download Worker page](development-of-download-worker/development-of-download-worker.md)


```
├── StreamFlex.DownloadWorker/                 # Download worker project
│   ├── Services/                              # Services specific to the download worker
│   ├── Models/                                # Data models for the download worker
│   ├── Dockerfile                             # Dockerfile for the download worker
│   └── StreamFlex.DownloadWorker.csproj       # Project file
├── StreamFlex.EncodingWorker/                 # Encoding worker project
│   └── ...                                    # Similar structure as DownloadWorker
└── StreamFlex.PreviewGenerationWorker/        # Preview generation worker project
    └── ...                                    # Similar structure as DownloadWorker
```
<!-- 
## Docker and Deployment
## API versions

## Update dependencies.
Possibility to update the project to versions C# 8.0 and dotnet-ef to version 8.0.

## Code quality -->

[Go back](../../README.md#development)