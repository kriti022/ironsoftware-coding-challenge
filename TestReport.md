# Test Report

## Objective

Validate correctness, robustness, and edge-case handling of the Old Phone Pad Decoder.

---

## Test Strategy

I used unit testing with xUnit and focused on:

* Functional testing (correct letter mapping)
* Edge case testing (backspace, repeated inputs)
* Boundary testing (wrap-around cases like 9999 → Z)
* Input variation testing

---

## Test Coverage

* Core functionality: Covered
* Edge cases: Covered
* Backspace scenarios: Covered

---

## Metrics

* Total test cases: 7
* Pass rate: 100%
* Edge cases covered: Yes

---

## Key Observations

* Backspace handling required careful ordering to avoid incorrect deletions
* Grouping consecutive inputs was critical for correct decoding
* Modulo logic ensures correct cycling of characters

---

## Limitations

* Input validation is minimal (invalid characters are ignored)
* Assumes input always ends with `#`
