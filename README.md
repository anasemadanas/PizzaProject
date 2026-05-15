# Project Pizza 🍕

## Overview
Project Pizza is a desktop application developed using **C# Windows Forms (.NET Framework)**.  
The project simulates a pizza ordering system where users can create accounts, log in, customize pizzas, and generate an order bill.

---

## Main Features

### 1. User Authentication
- Login system with username and password.
- Passwords are encrypted using **SHA-256 hashing** for better security.
- Create new account feature.
- Forgot password screen.

### 2. Pizza Customization
Users can customize their pizza by selecting:
- Pizza size:
  - Small
  - Medium
  - Large
- Crust type:
  - Thin crust
  - Thick crust
- Toppings:
  - Extra Cheese
  - Mushrooms
  - Olives
  - Onion
  - Tomatoes
  - Green Peppers

### 3. Price Calculation
- Dynamic price calculation based on:
  - Pizza size
  - Crust type
  - Selected toppings
  - Number of pizzas
- Total price updates automatically.

### 4. Order Bill
- Generates a bill containing:
  - Pizza size
  - Crust type
  - Toppings
  - Eat in / Take out
  - Number of pizzas
  - Final total price

### 5. User Interface
- Interactive Windows Forms UI.
- Image animations and custom backgrounds.
- User-friendly navigation between screens.

---

## Technologies Used
- C#
- Windows Forms (.NET Framework)
- Object-Oriented Programming (OOP)
- SHA-256 Encryption
- Dictionaries & Enums
- Event-Driven Programming

---

## Project Structure
- `LoginScreen.cs` → Login and authentication.
- `PizzaScreen.cs` → Pizza customization and pricing.
- `OrderBill.cs` → Bill generation.
- `ScreenMenu.cs` → Main menu navigation.
- `users.txt` → Stores usernames and hashed passwords.

---

## Learning Outcomes
Through this project, the following concepts were practiced:
- Building desktop applications using Windows Forms.
- Applying OOP concepts.
- Handling events and UI controls.
- Implementing authentication and password hashing.
- Managing dynamic pricing logic using dictionaries and enums.

---

## Demo Video

[Youtube](https://youtu.be/ZSwYSMnNYpw)
