# UpdatedFizzBuzz

A modern implementation of the classic FizzBuzz problem in C# using .NET 8 and NUnit for unit testing — adapted from a coding challenge on Qualified.io.

---

## 📌 Description

This project demonstrates:

- Clean architecture using **.NET 8**
- Separation of concerns between logic and tests
- Full **unit test coverage** with **NUnit**
- Modern **SDK-style project structure**
- Best practices for open-source C# projects

---

## 🧠 Challenge Description

**Task:**  
Given the input number `n`, return a string containing every value from `1` to `n`, inclusive, following these rules:

### ✅ Rules

- If the value is a multiple of **3**, return `"Fizz"`
- If the value is a multiple of **5**, return `"Buzz"`
- If the value is a multiple of **both 3 and 5**, return `"FizzBuzz"`
- Otherwise, return the **integer value as a string**

Each value should be separated by a newline (`\n`) — **no trailing newline** after the last value.

### 🚫 Exceptions

- If `n < 1`, return an **empty string** (`""`)

---

## 🧪 Examples

Here are some common inputs and their corresponding outputs:

| Input (`n`) | Output                                                                 |
|-------------|------------------------------------------------------------------------|
| 1           | `1`                                                                    |
| 2           | `1\n2`                                                                 |
| 3           | `1\n2\nFizz`                                                           |
| 5           | `1\n2\nFizz\n4\nBuzz`                                                  |
| 10          | `1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz`                          |
| 15          | `1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz` |
| 0           | *(empty string)*                                                       |
| -5          | *(empty string)*                                                       |

## ✍️ Function Specification

```csharp
Challenge.FizzBuzz(int n) -> string
