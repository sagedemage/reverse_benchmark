# reverse_benchmark

Benchmarks the programming languages on some simple algorithms.
I called it reverse benchmark since most of these algorithms reverses the order of the strings
and sorts the lists in descending order (reverse order).

## Results

### Python

Case 1: Reverse string via loop \
Execution time: 8.821µs

Case 2: Reverse string via stack \
Execution time: 22.888µs

Case 3: Reverse string via recursion \
Execution time: 61.512µs

Case 4: Sort number in descending order via loop \
Execution time: 273.466µs

Case 5: Reverse string via extended slice \
Execution time: 0.954µs


### Golang

Case 1: Reverse string via loop \
Execution time: 5038ns

Case 2: Reverse string via stack \
Execution time: 5634ns

Case 3: Reverse string via recursion \
Execution time: 37886ns

Case 4: Sort number list in descending order via loop \
Execution time: 3276ns

Case 5: Reverse string via loop with rune \
Execution time: 1212ns

### JavaScript

Case 1: Reverse string via loop \
Execution time: 31650ns

Case 2: Reverse string via stack \
Execution time: 56149ns

Case 3: Reverse string via recursion \
Execution time: 71800ns

Case 4: Sort number list in descending order via loop \
Execution time: 239263ns

Case 5: Reverse string via built-in functions \
Execution time: 38690ns

