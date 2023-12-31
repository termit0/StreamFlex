﻿# StreamFlex

## Description
StreamFlex is a comprehensive web video management system designed to streamline the process of video content handling, from upload to processing and viewing. It integrates various technologies to provide a seamless user experience for both content creators and consumers.

- [StreamFlex](#streamflex)
  - [Description](#description)
  - [Key Features](#key-features)
  - [Technologies](#technologies)
  - [Architecture](#architecture)
  - [Environment](#environment)
  - [Development](#development)
  - [License](#license)

![StreamFlex](md/img/StreamFlex.png)

## Key Features
- User authentication through external providers like Google, GitHub, etc.
- Video upload, viewing, editing, and deletion capabilities.
- Real-time video processing and encoding for various formats and platforms.
- Asynchronous task processing for non-blocking operations.
- Efficient caching system for quick access to videos and user information.
- Mobile application support for iOS devices.

## Technologies
- **Front-end**: Blazor for User Interface
- **Back-end**: ASP.NET Core, supported by MySQL database
- **Caching**: Redis for fast data retrieval
- **Messaging and Queue Management**: RabbitMQ for asynchronous task handling
- **Reverse Proxy**: Nginx for managing incoming requests
- **Static File Management**: Dedicated server for storing video files and other static content
- **Background Services**: Various workers for video processing, encoding, and preview generation

## Architecture
1. **Web Server (Blazor)**: Manages user interactions and sessions, including OAuth 2.0 authentication.
2. **Database (MySQL)**: Stores data about videos, users, comments, and other necessary information.
3. **Cache (Redis)**: Speeds up the loading of frequently requested data.
4. **Message Queue Server (RabbitMQ)**: Handles tasks that should not block the main workflow.
5. **Reverse Proxy**: Manages incoming HTTP/HTTPS requests.
6. **Static File Server**: Stores and serves video files and other static resources.
7. **Worker Services**: Perform background tasks like video uploading, processing, and encoding.
     - **Download Worker**
       - Downloading video files, including receiving files from users.
     - **Encoding Worker**
       - Encoding video files for various formats and platforms.
     - **Preview Generation Worker**
       - Creating previews for videos.
8. **Logging Service**: Log Management and Analysis Service
9. **OS Client (iOS)** Mobile Application

```
StreamFlex/
│
├── md/                                         # Markdown files
│   ├── img/                                    # Images for markdown files
│   │   └── StreamFlex.png
│   └── noPublishNotes.md
│
├── docker-compose.yml                          # Docker-compose configuration
│
├── src/                                        # Source code
│   ├── StreamFlex/                             # StreamFlex project files
│   ├── StreamFlex.Web/                         # Web server (Blazor)
│   │   ├── wwwroot/                            # Static files for the web application
│   │   ├── Controllers/                        # Controllers for handling web requests
│   │   ├── Views/                              # Razor views for UI
│   │   ├── appsettings.json                    # Configuration files
│   │   └── Dockerfile                          # Dockerfile for the web server
│   │
│   ├── StreamFlex.Api/                         # Back-end (ASP.NET Core)
│   │   ├── Controllers/                        # API controllers
│   │   ├── DTOs/                               # Data Transfer Object
│   │   └── Dockerfile                          # Dockerfile for the back-end
│   │
│   ├── StreamFlex.Workers/                     # Worker services
│   │   ├── StreamFlex.DownloadWorker/
│   │   │   ├── Services/                       # Services specific to the download worker
│   │   │   ├── Models/                         # Data models for the download worker
│   │   │   └── Dockerfile                      # Dockerfile for the download worker
│   │   │
│   │   ├── StreamFlex.EncodingWorker/
│   │   │   └── Dockerfile                      # Dockerfile for the encoding worker
│   │   │
│   │   └── StreamFlex.PreviewGenerationWorker/
│   │       └── Dockerfile                      # Dockerfile for the preview generation worker
│   │
│   ├── StreamFlex.Mobile/                      # Mobile client application
│   │   ├── StreamFlex.iOS/                     # iOS specific project
│   │   └── StreamFlex.Android/                 # Android specific project
│   │
│   └── StreamFlex.sln                          # Solution file
│
├── resources/                                  # Static resources
│   ├── videos/                                 # Video files
│   └── images/                                 # Image files
│
├── scripts/                                    # Scripts for building, deployment, etc.
│
├── tests/                                      # Test code
│   ├── StreamFlex.Web.Tests/
│   ├── StreamFlex.Api.Tests/
│   ├── StreamFlex.Workers/
│   │   └── StreamFlex.DownloadWorker/
│   └── StreamFlex.Mobile/
│
├── StreamFlex.Infrastructure/                  # Infrastructure code
│   ├── Database/                               # Database related code
│   ├── Messaging/                              # Code for handling message queues
│   └── Caching/                                # Caching mechanis

│
├── StreamFlex.Common/                          # Shared code across different projects
│   ├── Utilities/                              # Common utilities
│   └── Interfaces/                             # Common interfaces
│
├── logs/                                       # Log files
│
├── .gitignore                                  # Specifies intentionally untracked files to ignore
└── README.md                                   # Readme file
```


## Environment
This document outlines the steps for setting up a development environment.  
[Environment page](md/environment/environment.md)

## Development
[Development page](md/development/development.md)

<!--
## Getting Started
- Detailed instructions on setting up the StreamFlex environment.
- Guidelines for configuring each component of the system.

## Contributions

- Guidelines for developers interested in contributing to StreamFlex.
- How to submit pull requests, report bugs, and suggest features.

## Support

- Details on how to get support, including contact information for the development team.
- Links to community forums or discussion boards.

## User Scenario
## Development and Deployment
-->

## License

- Information about the open-source license under which StreamFlex is distributed.