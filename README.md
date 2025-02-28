# Basic Login and Registration System

This project implements a basic login and registration system with role-based access control using ASP.NET MVC. Users can register as either an attendee or an event host, and upon login, they are redirected to their respective dashboards with customized messages.

## Features
- 🛡️ **Single Login Page**: Unified login page for all users.
- 🔄 **Role-Based Redirection**: Redirects users to attendee or event host dashboards based on their role.
- 📝 **User Registration**: Simple registration process with role selection.
- 💬 **Custom Messages**: Displays role-specific messages on dashboards.

## Technologies Used
- ASP.NET MVC
- Entity Framework Core
- SQL Server

## Getting Started

### Prerequisites
- .NET SDK
- SQL Server
- Visual Studio or any C# IDE

### Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/Basic_Login_Registration.git
    cd Basic_Login_Registration
    ```

2. **Set up the database**:
    - Update the connection string in `appsettings.json`:
        ```json
        {
          "ConnectionStrings": {
            "DefaultConnection": "YourConnectionStringHere"
          }
        }
        ```

3. **Run migrations**:
    ```bash
    dotnet ef database update
    ```

4. **Run the application**:
    ```bash
    dotnet run
    ```

## Usage

### Registration
1. Navigate to `/Authentication/Register`.
2. Fill in the registration form with username, password, email, and select your role (attendee or event host).
3. Submit the form to create a new account.

### Login
1. Navigate to `/Authentication/Login`.
2. Enter your username and password.
3. Submit the form to log in.
4. Based on your role, you will be redirected to the appropriate dashboard:
    - **Event Host**: `/EventHostDashboard`
    - **Attendee**: `/AttendeeDashboard`

## Project Structure

- **Controllers**: Handles the logic for user registration, login, and role-based redirection.
- **Models**: Defines the `User` model with properties for ID, username, password, email, and role.
- **Views**: Contains the Razor views for registration, login, and dashboards.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.
