# Lab#1
## Topics Involved
- N Layered Architecture (N=3)
  - Presentation Layer
    - API Endpoints using Minimal API
  - Business Logic Layer
    - Services
  - Data Access Layer
    - Repositories
- Database
- ORM
  - EF Core
  - Migrations
- DTO
- Infrastructure As a Code
  - Docker (docker-compose)

## Task
1. Create and apply migration adding VinCode to Car entity
2. Hide VinCode from `/cars` API endpoint
3. Fix Bugs:
   1. Color is not saved
   2. Price is not caved
4. Update `POST /car` endpoint to update existing car if the car with the same VinCode already exists
5. Mark `VinCode` as unique in database, add and apply migration. [Doc](https://learn.microsoft.com/en-us/ef/core/modeling/indexes?tabs=data-annotations#index-uniqueness)


## Time Limit
45 minutes

## Grading
- 1 point - Task 1
- 1 point - Task 2
- 1 point - Task 3
- 1 point - Task 4
- 1 point - Task 5

## How to submit
1. Fork this repository (https://github.com/podkolzzzin/SDPLabs)
2. Create a new branch with your name
3. Commit your changes to the new branch
4. Create a pull request to the `main` branch of this repository