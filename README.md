# shopping-cart-service

## Problem description

Create the application shopping-cart using Spring Boot. Through a Rest API, the system should be able to manage the shopping cart. That means that we can add and remove items to and from shopping carts as well as getting the state of it. The idea is that the candidate develops an application that manages the cart using coding best practices for rest services in a multi-layered architecture. This is an example of the shopping cart rendered through a UI (UI is out of scope).

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

To be defined
```text
.
├── docker-compose.yml                  # Local PostgreSQL service
├── README.md                           # Project documentation
├── To be defined
```

This structure follows a layered approach:

- `application` coordinates use cases and application flows.
- `domain` contains the business model and business rules.
- `infrastructure` handles persistence, security, and framework-specific code.
- `interfaceadapters` exposes the API and transforms incoming/outgoing data.

## Requirements

- To be defined according to .net and ASP.NET
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
to be defined
```

## Run the application

```bash
to be defined
```

The app starts on http://localhost:5220 by default.

## Swagger

to be defined
