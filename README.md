# Globo Ticket REST API

## About the application
Application represents simulation of a ticket management system.
User should be able to manage events (add new event, update existing one or delete event) and see all events in their categories. Appart from events, user should have an overview of orders for the different events. 

## Tools for testing
 - Swagger, which is available on https://localhost:17030/swagger and starts when application is started
 
## Tech decisions
- [Web API written in .Net Core 31](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-3.1)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)

## Project structure
- GloboTicket.TicketManagement.API 
- GloboTicket.TicketManagement.Core
  - GloboTicket.TicketManagement.Application
    - Contracts
      - Persistance
  - GloboTicket.TicketManagement.Domain 
    - Entities
    - Common
- GloboTicket.TicketManagement.Infrastructure
