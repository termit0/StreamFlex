# StreamFlex

## Description
StreamFlex is a comprehensive web video management system designed to streamline the process of video content handling, from upload to processing and viewing. It integrates various technologies to provide a seamless user experience for both content creators and consumers.

- [StreamFlex](#streamflex)
  - [Description](#description)
  - [Key Features](#key-features)
  - [Technologies](#technologies)
  - [Architecture](#architecture)
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