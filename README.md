# DCIT 318 – Programming II: Assignment 1

This repository contains three C# Console Applications developed for DCIT 318 Assignment 1. Each application is designed to demonstrate conditional logic and user input handling in C#.

---

## 🔧 Applications Included

### 1. 🎓 Grade Calculator
- Prompts the user to enter a numerical grade (0–100).
- Displays the corresponding letter grade:
  - A (90–100)
  - B (80–89)
  - C (70–79)
  - D (60–69)
  - F (below 60)

### 2. 🎟️ Ticket Price Calculator
- Prompts the user to enter their age.
- Calculates ticket price based on:
  - GHC 7 for children (≤ 12) and seniors (≥ 65).
  - GHC 10 for all others.

### 3. 🔺 Triangle Type Identifier
- Prompts the user to enter three side lengths.
- Determines and displays the triangle type:
  - **Equilateral**: All three sides equal.
  - **Isosceles**: Two sides equal.
  - **Scalene**: All sides different.

---

## 📁 Folder Structure
dcit318-assignment1-ID/
├── GradeCalculator/
│ └── Program.cs
├── TicketPriceCalculator/
│ └── Program.cs
├── TriangleTypeIdentifier/
│ └── Program.cs
└── README.md


---

## ✅ How to Run

Use the .NET CLI inside each project folder:

```bash
cd GradeCalculator
dotnet run

cd ../TicketPriceCalculator
dotnet run

cd ../TriangleTypeIdentifier
dotnet run

