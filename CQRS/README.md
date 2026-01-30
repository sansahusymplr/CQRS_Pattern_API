# CQRS Pattern API

ASP.NET Core Web API implementing CQRS (Command Query Responsibility Segregation) pattern for product management.

## Features

- CQRS pattern implementation with Commands, Queries, and Handlers
- 100 pre-loaded test products
- CORS enabled for Angular frontend (port 5001)
- In-memory data store

## API Endpoints

### CQRS Endpoints
- `GET /api/products` - Get all products (CQRS)
- `GET /api/products/{id}` - Get product by ID
- `POST /api/products` - Create product
- `PUT /api/products/{id}` - Update product
- `DELETE /api/products/{id}` - Delete product

### Non-CQRS Endpoint
- `GET /api/products/getallwithoutcqrs` - Get all products (direct access)

## Product Model

```json
{
  "id": 1,
  "name": "Product Name",
  "price": 99.99,
  "stock": 100
}
```

## Run the API

```bash
cd CQRS/CQRS
dotnet run
```

API runs on: `http://localhost:4000`

## Technology Stack

- .NET 10.0
- ASP.NET Core Web API
- CQRS Pattern
