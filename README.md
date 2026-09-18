# shopping-cart-service

## Problem description

Create the application shopping-cart using .net. Through a Rest API, the system should be able to manage the shopping cart. That means that we can add and remove items to and from shopping carts as well as getting the state of it. The idea is that the candidate develops an application that manages the cart using coding best practices for rest services in a multi-layered architecture. This is an example of the shopping cart rendered through a UI (UI is out of scope).

Quantity |  Product   | Unit Price | Subtotal |
|:--------:|:----------:|:----------:|:--------:|
|    2     |   Banana   |  2,000.00  | 4,000.00 |
|    3     |   Orange   |  1,000.00  | 3,000.00 |
|    3     | Strawberry |  2,000.00  | 6,000.00 |

Total shopping cart: 13,000.00
Total payment: 14,060.00

The application should:
- The logic for the total and the total payment is given by the class com.perficient.shoppingcart.domain.ShoppingCart.
- Expose the operations through a Rest API that follows the Rest API best practices. ✅
- Have persistence including database scripts and configurations required for it. ✅
- Contain unit tests as well as integration tests that follow the testing best practices. ✅
- Have a README file that explains how to start the application and consume the services. If the API has a live specification like Swagger, it must specify the endpoint. ✅
- Allow to get the total payment based on the payment method specified through the API. Remember that different payment methods derive in different values. ✅
- Allow to add new payment methods by following design best practices and patterns. ✅
- Implement security for the API and OWASP best practices. ⚠️
- In general, have design and architecture best practices. ✅
- Make assumptions and explain them in the README. ✅

## Project structure

The solution follows Clean Architecture, with one project per layer so that the
compiler enforces the dependency rule (dependencies always point inward, toward
the domain).

```text
.
├── docker-compose.yml                  # Local PostgreSQL service
├── README.md                           # Project documentation
├── ShoppingCart.slnx                   # Solution file (groups all projects)
└── src/
    ├── ShoppingCart.Domain/            # Core business model (no dependencies)
    │   ├── Entities/                   # Domain objects with guarded invariants
    │   ├── Exceptions/                 # Domain-specific exceptions
    │   └── Services/                   # Business rules and domain service interfaces
    │
    ├── ShoppingCart.Application/       # Application use cases and orchestration
    │   └── UseCases/                   # Business workflows (one folder per entity)
    │
    ├── ShoppingCart.Infrastructure/    # Framework and persistence concerns
    │   ├── Entities/                   # EF Core entities mapped to DB tables
    │   ├── Mappers/                    # Mappers between domain and EF Core entities
    │   ├── Migrations/                 # EF Core database migrations
    │   ├── Persistence/                # DbContext configuration
    │   └── Services/                   # Database service implementations
    │
    ├── ShoppingCart.InterfaceAdapters/ # API contract and layer-to-layer adapters
    │   ├── Dtos/                       # Request/response payloads
    │   └── Mappers/                    # DTO-to-domain mappers
    │
    └── ShoppingCart.Api/               # Web host (executable entry point)
        ├── Controllers/                # REST controllers
        └── Program.cs                  # Startup, DI registration, middleware pipeline
```

Dependency direction between projects:

```text
Api ──> InterfaceAdapters ──> Application ──> Domain
 │                                             ▲
 └──────> Infrastructure ─────────────────────┘
```

This structure follows a layered approach:

- `Application` coordinates use cases and application flows.
- `Domain` contains the business model and business rules.
- `Infrastructure` handles persistence, security, and framework-specific code.
- `InterfaceAdapters` exposes the API and transforms incoming/outgoing data.

## Requirements

- .NET SDK 10.0+
- ASP.NET Core runtime (included with the .NET SDK)
- Docker + Docker Compose

## Run PostgreSQL with Docker

Start the database container:

```bash
docker compose up -d
```

Check container status:

```bash
docker compose ps
```

View PostgreSQL logs:

```bash
docker compose logs -f postgres-db
```

Stop containers:

```bash
docker compose down
```

Recreate database volume (data reset):

```bash
docker compose down -v
docker compose up -d
```

## Compile the project

```bash
dotnet build
```

## Run the application

```bash
dotnet run --project src/ShoppingCart.Api
dotnet watch --project src/ShoppingCart.Api // Watch mode
```

The app starts on http://localhost:5101 by default.

## Scalar - UI API Documentation

http://localhost:5101/scalar/v1

