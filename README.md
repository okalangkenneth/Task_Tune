# TaskTune Project
(In progress)

## Overview
TaskTune is a .NET-based application for efficient task management. It combines a robust back-end with a responsive front-end, built using React.

## Features
- **Task Management**: Create, update, and delete tasks.
- **User Authentication**: Secure user registration and login system.
- **Data Persistence**: SQL Server-based data storage.
- **API Integration**: RESTful API for smooth front-end and back-end integration.

## Project Structure
The project is divided into several modules:
- `TaskTune.Core.Persistence`: Manages data storage and retrieval.
- `TaskTune.Core.Services`: Implements the business logic.
- `TaskTune.Entities`: Contains the entity models.
- `TaskTune.Infrastructure`: Sets up infrastructure configurations.
- `TaskTune.Infrastucture.Persistence`: Handles the persistence layer.
- `reactapp`: Front-end React application.
- `webapi`: Web API for client-server communication.

## Prerequisites
- .NET [version]
- SQL Server [version]
- Node.js [version] (for the React app)

## Installation
1. Clone the repository: `git clone [repository-url]`
2. Configure SQL Server and initialize the database.
3. Update the `appsettings.json` with your database connection string.
4. Open `Task_Tune.sln` in Visual Studio and run the solution.
5. For the front-end, navigate to the `reactapp` folder, run `npm install` and `npm start`.

## Usage
- Start the backend server from Visual Studio.
- Access the front-end through `localhost:[port]` in your browser.
- Use the provided UI to manage tasks.

## Contributing
Contributions are welcome! Please read our contributing guidelines for details on how to submit pull requests.

## License
This project is licensed under the [License Name] - see the LICENSE file for details.

## Contact
- Project Maintainer: [Your Name]
- Email: [Your Email]
- GitHub: [Your GitHub Profile]
