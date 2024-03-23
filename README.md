# WebApiCICDWorkFlow

![publish workflow](https://github.com/Andronovo-bit/WebApiCICDWorkFlow/actions/workflows/publish.yaml/badge.svg)

## About The Project

`WebApiCICDWorkFlow` is a demonstration project built with .NET Core, showcasing the fundamentals of Continuous Integration and Continuous Deployment (CI/CD) for a Web API. This project is ideal for developers looking to understand or implement basic CI/CD practices in their .NET Core applications.

### Features

- **Program.cs:** The entry point for the Web API application.
- **Calculator:** A class library implementing basic arithmetic operations (add, subtract, multiply, divide).
- **DiceRolling:** A class simulating dice rolls, demonstrating random number generation.
- **MSTest:** Integration for unit testing, ensuring code reliability and quality.
- **CI/CD Workflows:** Includes GitHub Actions workflows for pull requests, labeling, and publishing to Azure Web Apps.
- **Code Quality:** Integrated with DeepSource for automated code analysis, ensuring adherence to best practices and coding standards.
- **Pull Request Template:** A predefined template for pull requests to streamline contributions and code reviews.

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- An Azure account (for deployment)

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/yourusername/WebApiCICDWorkFlow.git
   ```
2. Navigate to the project directory
   ```sh
   cd WebApiCICDWorkFlow
   ```
3. Restore dependencies
   ```sh
   dotnet restore
   ```
4. Run the application
   ```sh
   dotnet run
   ```

## CI/CD Workflows

- **Pull Request Workflow (`pull_request.yaml`):** Automates testing and code quality checks upon pull request submissions.
- **PR Labeler (`pr-labeler.yml`):** Automatically labels pull requests based on the content and paths affected.
- **Publish Workflow (`publish.yml`):** Handles the deployment of the application to Azure Web Apps upon merging to the main branch.
- **Labeler Workflow (`labeler.yml`):** Automatically labels issues and pull requests based on defined criteria.
- **Semantic Versioning (`semantic.yml`):** Enforces semantic versioning rules for commits and pull request merges.
- **DeepSource Integration:** Performs automated code analysis to identify issues and ensure code quality.

## Azure Web App Setup and GitHub Secrets

### Creating an Azure Web App

1. Sign in to the [Azure Portal](https://portal.azure.com/).
2. From the Azure portal menu, select "Create a resource".
3. In the "Search the Marketplace" field, type 'Web App' and press enter.
4. Select "Web App" from the results, then click "Create".
5. Fill in the details for your web app, such as Subscription, Resource Group, Name, Publish (Code), and Runtime Stack (.NET Core).
6. Click "Review + create" and then "Create" after verifying your details.

### Configuring GitHub Secrets for Azure Deployment

1. Navigate to your GitHub repository.
2. Go to "Settings" > "Secrets" > "Actions".
3. Click on "New repository secret".
4. Add the following secrets required for Azure deployment:
   - `AZURE_PUBLISH_PROFILE`: The publish profile XML content. (You can download this from your Azure Web App's "Deployment Center".)
5. Use these secrets in your `publish.yml` GitHub Action workflow to deploy your application.

## Adding Semantic Pull Requests to Your GitHub Repository

1. Go to the [Semantic Pull Requests app](https://github.com/marketplace/semantic-pull-requests) page on GitHub Marketplace.
2. Click "Install it for free" > "Complete order and begin installation".
3. Select the repository where you want to add the Semantic Pull Requests app.
4. After installation, the app will automatically check if your pull requests follow semantic versioning guidelines.

## Setting Up DeepSource for Code Analysis

### Creating a DeepSource Account

1. Visit [DeepSource](https://deepsource.io/) and sign up for an account. You can sign up using your GitHub account for easier integration.
2. Once signed up, you'll be prompted to add a new repository.

### Adding Your GitHub Project to DeepSource

1. In the DeepSource dashboard, click on "Add repository".
2. Select your GitHub repository from the list.
3. DeepSource will provide a `.deepsource.toml` configuration file. Add this file to your repository to specify analysis settings.
4. Activate analysis on your repository. DeepSource will now analyze your code on each commit and pull request.

By following these additional steps, you'll enhance your project with automated deployments, enforced semantic versioning, and continuous code quality checks.

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.
