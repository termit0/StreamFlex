2023/12/10

- [x] Added logo for termit (16:20-16:45)
---
- [x] Development DownloadWorker Project Architecture (12:30-16:20)
  - [x] Project structure (15:00)
    - [x] Create the project structure (16:20)
  - [x] documentation (14:20)
    - [x] File structure
---
Next steps include creating a Dockerfile for the worker service and deploying it on the server.
- [x] Deploy and run the worker service on the server.
  - [x] Launch on Portainer (12:30)
    - [x] Fix issue with container operation
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

+ created docker file
+ dotnet sln StreamFlex.sln add StreamFlex.DownloadWorker/StreamFlex.DownloadWorker.csproj
+ dotnet new worker -n StreamFlex.DownloadWorker (08:30)
