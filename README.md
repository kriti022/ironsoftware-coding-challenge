# Old Phone Pad Decoder

##  Problem

This project simulates an old mobile phone keypad where each number corresponds to multiple letters.
Pressing a number multiple times cycles through its letters.

Example:

* `2` → A
* `22` → B
* `222` → C

Spaces are used to separate inputs from the same key, `*` acts as backspace, and `#` marks the end of input.

---

## Approach

I grouped consecutive key presses and mapped them to characters using modulo logic.
Spaces separate inputs from the same key, and `*` removes the last character.

I focused on keeping the logic simple and readable rather than over-engineering.

---

##  Assumptions

* Input always ends with `#`
* Invalid characters are ignored
* `0` maps to space




---

## How to Run

Run tests using:

```
dotnet test
```

---

##  Testing

I used xUnit and covered:

* Basic functionality
* Edge cases (backspace, repeated inputs)
* Wrap-around behavior (e.g., `9999` → Z)

---

##  Notes

I spent extra time covering edge cases like backspaces and repeated inputs, as these are common failure points.

---

## 🤖 AI Usage

Tool: ChatGPT

Used for:

* Reviewing structure
* Improving test coverage ideas

Core logic and implementation were written manually.
