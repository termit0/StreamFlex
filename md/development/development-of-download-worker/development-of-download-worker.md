# Development of Download Worker

[go back](../development.md#development-of-download-worker)

## Description
The project type is a worker service.

## Current task

Next steps include creating a Dockerfile for the worker service and deploying it on the server.
- [ ] Deploy and run the worker service on the server.
  - [ ] Launch on the portainer
    - [ ] Fix issue with container work
## TimeLine

2023/12/10

- [ ] Deploy and run the worker service on the server.
  - [x] Fixed the Dockerfile (10:19 - 11:11)
    - [x] Checking Dockerfile corrections (11:11)
```bash
cd StreamFlex/src/StreamFlex.Workers/StreamFlex.DownloadWorker
```

```bash
docker build -t streamflex-download-worker .
```
---
- [x] Create a Dockerfile for the worker service.
- [x] Initialized the Download Worker service project using the command:
```bash
dotnet new worker -n StreamFlex.DownloadWorker
```