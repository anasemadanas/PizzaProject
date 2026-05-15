# 🍕 Project Pizza

[![Project](https://img.shields.io/badge/Final-Project-orange?logo=visual-studio&logoColor=white)](https://github.com/anasemadanas/PizzaProject)

---

## 📌 Overview
Project Pizza is a comprehensive desktop application built using the **C# programming language** and the **Windows Forms (.NET Framework)** architecture. This software application simulates a real-world digital pizza ordering system tailored for restaurants. It offers a complete, end-to-end user experience where customers or staff members can securely register new user accounts, authenticating their identity through an encrypted login screen. Once inside the system, users can interact with a highly dynamic configuration interface to completely customize their pizza orders, compute prices automatically in real-time, and finally render a clear, detailed financial breakdown and transactional order bill.

---

## 🎥 Demo Video
▶️ [Project Demo](https://youtu.be/ZSwYSMnNYpw)

---

## ✨ Detailed Features Description

### 🔐 1. User Authentication and Cryptography
The application prioritizes data integrity and security by incorporating a robust local user authentication system. Users are greeted with a standard login interface requiring a valid username and password combination. To prevent storing sensitive security credentials in plain text, the backend system implements **SHA-256 cryptographic hashing algorithms**. When a new profile is established via the registration interface, the system processes the raw password input, computes its unique 256-bit hash, and stores only this encrypted string. Upon subsequent login attempts, the entered password undergoes the exact same mathematical hashing function to verify its match against the record, ensuring modern security practices are strictly followed. Additionally, a dedicated recovery form is designed to handle forgotten passwords safely.

### 🍕 2. Granular Pizza Customization Engine
The core application workspace features an immersive configuration panel designed for pizza modification. The user interface allows individuals to specify exact preferences across various dimensions. Customers can select from predefined structural configurations including physical sizes (Small, Medium, and Large) alongside foundational crust types (Thin crust or Thick crust). Beyond these base variables, the platform provides individual selection checkboxes for an array of classic culinary toppings. These modular selections include Extra Cheese, Mushrooms, Olives, Onions, fresh Tomatoes, and Green Peppers, allowing for dozens of unique combinations.

### 💰 3. Dynamic Price Calculation and Structure
Behind the visual user interface lies an automated pricing engine that executes continuous recalculations. Rather than utilizing static values, the calculation logic evaluates a complex matrix of choices dynamically. The pricing module maps base fees to specific pizza sizes and applies percentage or flat-rate increments depending on the chosen crust texture. Furthermore, each added topping updates a cumulative ingredient cost variable. This calculated sum is then multiplied by the chosen numeric quantity selected in the input fields. The application utilizes event-triggered functions so that whenever a user checks or unchecks an option, the total monetary amount reflects on the screen instantaneously.

### 🧾 4. Receipt and Invoice Generation
Once an order configuration satisfies the customer, the application processes the multi-layered data model to generate a definitive transactional summary receipt. This receipt component lists the structural parameters of the custom pizza, maps out every single selected ingredient topping, highlights the selected dining mode (such as Eat In or Take Out), and outputs the specified unit quantities alongside the final computed financial total. This invoice serves as a clear, reader-friendly verification system.

---

## 🛠️ Architectural Design & Technologies Used
- **C# Language:** The foundational source code utilizing structured object-oriented paradigms.
- **Windows Forms (.NET Framework):** Used to construct the graphical windows, event listeners, buttons, and custom layout controls.
- **Object-Oriented Programming (OOP):** Leveraged to instantiate modular pizza objects, user objects, and specialized pricing classes to ensure clean, maintainable architecture.
- **Event-Driven Architecture:** Implemented to bind reactive visual UI components to backend math functions upon user clicks or text modifications.
- **Data Structures (Dictionaries & Enums):** Strongly typed enumerations restrict inputs to valid options (like specific sizes), while C# Dictionaries bind precise decimal price mappings to string-based toppings efficiently.

---

## 🖥️ Application Previews

| Screen | Preview |
|--------|--------|
| Login  | ![login](screenshots/login.png) |
| Order  | ![menu](screenshots/menu.png) |

---

## 📚 Learning Outcomes
By engineering this pizza management utility for my CS50x final milestone, I successfully bridged fundamental computer science theory with desktop software development. I gained massive hands-on experience structuring local state configurations, managing visual view layers natively, protecting authentication routes with security industry standards like SHA-256 hashing, and mastering C# specific memory data structures to handle pricing calculations safely.

---

## 👨‍💻 Creator Information
- **GitHub Profile:** [anasemadanas](https://github.com/anasemadanas)
- **Project Repository:** [PizzaProject Link](https://github.com/anasemadanas/PizzaProject)
