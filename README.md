# reverse_benchmark

Benchmarks the programming languages on some simple algorithms.
I called it reverse benchmark since most of these algorithms reverses the order of the strings
and sorts the lists in descending order (reverse order).

## Results

### Table
<table>
    <tr>
        <th>Languages</th>
        <th>Case 1: Reverse string via loop</th>
        <th>Case 2: Reverse string via stack</th>
        <th>Case 3: Reverse string via recursion</th>
        <th>Case 4: Sort number in descending order via loop</th>
    </tr>
    <tr>
        <td>Python</td>
        <td style="text-align: right;">7us</td>
        <td style="text-align: right;">10us</td>
        <td style="text-align: right;">20us</td>
        <td style="text-align: right;">6us</td>
    </tr>
    <tr>
        <td>Golang</td>
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">7us</td>
        <td style="text-align: right;">8us</td>
        <td style="text-align: right;">0us</td>
    </tr>
    <tr>
        <td>JavaScript</td>
        <td style="text-align: right;">5us</td>
        <td style="text-align: right;">11us</td>
        <td style="text-align: right;">17us</td>
        <td style="text-align: right;">5us</td>
    </tr>
    <tr>
        <td>Java</td>
        <td style="text-align: right;">18us</td>
        <td style="text-align: right;">44us</td>
        <td style="text-align: right;">99us</td>
        <td style="text-align: right;">2us</td>
    </tr>
</table>

### Stdout

#### Python

Case 1: Reverse string via loop \
Average execution time: 7us

Case 2: Reverse string via stack \
Average execution time: 10us

Case 3: Reverse string via recursion \
Average execution time: 20us

Case 4: Sort number in descending order via loop \
Average execution time: 6us

Case 5: Reverse string via extended slice \
Average execution time: 0us

#### Golang

Case 1: Reverse string via loop \
Average execution time: 6us

Case 2: Reverse string via stack \
Average execution time: 7us

Case 3: Reverse string via recursion \
Average execution time: 8us

Case 4: Sort number list in descending order via loop \
Average execution time: 0us
Output: 

Case 5: Reverse string via loop with rune \
Average execution time: 1us

#### JavaScript

Case 1: Reverse string via loop \
Average execution time: 5us

Case 2: Reverse string via stack \
Average execution time: 11us

Case 3: Reverse string via recursion \
Average execution time: 17us

Case 4: Sort number list in descending order via loop \
Average execution time: 5us

Case 5: Reverse string via built-in functions \
Average execution time: 3us

#### Java

Case 1: Reverse string via loop \
Average execution time: 18us

Case 2: Reverse string via stack \
Average execution time: 44us

Case 3: Reverse string via recursion \
Average execution time: 99us

Case 4: Sort number list in descending order via loop \
Average execution time: 2us

