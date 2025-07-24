# Exam Management System

This is a simple C# console application that simulates an exam system with two types of exams:
- **Final Exam**
- **Practical Exam**

The project demonstrates the use of object-oriented programming principles in C# such as inheritance, abstraction, and polymorphism.

---

## 🚀 Features

- Supports both Final and Practical exams
- Uses base and derived classes to separate common and specific functionality
- Includes questions, answers, and scoring logic
- Dynamic question loading using helper class

---

## 🏗️ Project Structure

```
Exam/
│
├── Answer.cs           # Represents a student's answer
├── BaseExam.cs         # Abstract base class for all exams
├── FinalExam.cs        # Final exam-specific logic
├── PracticalExam.cs    # Practical exam-specific logic
├── FillQuestionList.cs # Provides sample questions
├── Program.cs          # Entry point for the application
├── Question.cs         # Represents a question
├── Subject.cs          # Represents a subject entity
├── Exam.csproj         # C# project file
└── Exam.sln            # Visual Studio solution file
```

---

## 💡 Concepts Demonstrated

- **Abstraction** via `BaseExam` class
- **Inheritance** (`FinalExam`, `PracticalExam` inherit from `BaseExam`)
- **Polymorphism** by overriding the `ShowExam()` method
- **Encapsulation** of questions and answers

---

## 🛠️ How to Run

1. Open the solution `Exam.sln` in Visual Studio 2022 or later.
2. Build the solution to restore any dependencies.
3. Run the project (`Ctrl + F5`) to launch the console app.

---

## 🧑‍💻 Author

Made by [Dina Ragab] — for learning and practicing C# OOP.

---

## 📄 License

This project is open-source and free to use for educational purposes.
# Exam
