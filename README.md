# 🎬 Fusca Filmes API

This repository contains an API developed with **.NET 8** using **Entity Framework Core** and **Minimal APIs**, structured with a layered architecture.  
This project was created as a study base, with the goal of understanding how to structure a RESTful API, work with relational databases, manage entity relationships, and apply development best practices in a real-world context.

---

## 🎯 Project Purpose

Although this is a study project, it was designed to simulate a real application, with useful features that can easily be adapted to other scenarios.

Through this project, you can:

- Practice and understand the usage of **Entity Framework Core** in real scenarios  
- Explore how to build **RESTful APIs with .NET**  
- Implement queries, filters, and relationships between entities  
- Learn about **layered project organization**  

---

## 🧱 Project Structure

The project is organized as follows:

1. **API**  
   **Description**: Contains the application's endpoints, general configurations, Swagger documentation, and the `Program.cs` file.  
   **Purpose**: Manage routes and overall API configuration.

2. **Domain**  
   **Description**: Contains the system entities such as `Movie`, `Director`, and `DirectorMovie` (N:N relationship table).  
   **Purpose**: Define the data structure.

3. **Repository**  
   **Description**: Contains the `DbContext`, Migrations, Interfaces, and Repository Implementations.  
   **Purpose**: Handle data access, migrations, and persistence rules.

---

## ⚙️ Features

- **Directors**  
  - Create, update, list (all or by ID), and delete.

- **Movies**  
  - Create, update, list (all, by ID or by title), partial update (PATCH), and delete.

- **Many-to-Many Relationship**  
  - Manage the relationship between Movies and Directors.

- **Optimized Queries**  
  - Filters by title using `Contains` and asynchronous methods.

---

## 💻 How to Use

1. **Clone the repository**:
```bash
git clone https://github.com/GuicesarS/EFCore-API.git
````

---

📄 Available in: [Portuguese](README.pt.md)
