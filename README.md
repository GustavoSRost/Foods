# Foods

Foods is a backend project developed using ASP.Net Core MVC with Entity Framework Code-First. It provides functionality for managing a list of foods and their types.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
- [Usage](#usage)

## Introduction

Food Tracker API is a practice project focused on backend development skills. It is built with ASP.Net Core MVC and uses Entity Framework Code-First to manage a collection of foods and their types. The primary goal is to implement CRUD operations for food items and support the creation of different types of foods.

## Features

1. **Register a Food**
   - Endpoint: `POST /api/foods`
   - Add a new food item to the database.

2. **Delete a Food**
   - Endpoint: `DELETE /api/foods/{id}`
   - Remove a food item from the database based on its ID.

3. **Modify a Food**
   - Endpoint: `PUT /api/foods/{id}`
   - Update the details of a specific food item.

4. **Create Types of Foods**
   - Endpoint: `POST /api/foodtypes`
   - Define and add new types of foods.

5. **Consult Lists of Foods**
   - Endpoint: `GET /api/foods`
   - Retrieve a list of all registered food items.

## Getting Started

Follow these instructions to get the project up and running on your local machine.

1. Clone the repository:
   ```bash
   git clone https://github.com/GustavoSRost/Foods.git

## Usage
Explore the API endpoints using your preferred API testing tool (e.g., Postman or Swagger). Ensure to include the necessary headers and request bodies as per the API documentation.
