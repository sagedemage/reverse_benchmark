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
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">10us</td>
        <td style="text-align: right;">20us</td>
        <td style="text-align: right;">6us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">0.149KiB</td>
        <td style="text-align: right;">0.149KiB</td>
        <td style="text-align: right;">0.149KiB</td>
        <td style="text-align: right;">0.0KiB</td>
    </tr>
    <tr>
        <td>Golang</td>
        <td style="text-align: right;">7us</td>
        <td style="text-align: right;">7us</td>
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">0us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">0.097KiB</td>
        <td style="text-align: right;">0.098KiB</td>
        <td style="text-align: right;">0.097KiB</td>
        <td style="text-align: right;">0KiB</td>
    </tr>
    <tr>
        <td>JavaScript</td>
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">11us</td>
        <td style="text-align: right;">16us</td>
        <td style="text-align: right;">4us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">4.828KiB</td>
        <td style="text-align: right;">4.242KiB</td>
        <td style="text-align: right;">6.516KiB</td>
        <td style="text-align: right;">0.219KiB</td>
    </tr>
    <tr>
        <td>Java</td>
        <td style="text-align: right;">3us</td>
        <td style="text-align: right;">17us</td>
        <td style="text-align: right;">32us</td>
        <td style="text-align: right;">1us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">142.438KiB</td>
        <td style="text-align: right;">113.797KiB</td>
        <td style="text-align: right;">113.797KiB</td>
        <td style="text-align: right;">0.0KiB</td>
    </tr>
    <tr>
        <td>C#</td>
        <td style="text-align: right;">2us</td>
        <td style="text-align: right;">9us</td>
        <td style="text-align: right;">17us</td>
        <td style="text-align: right;">1us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">0.758KiB</td>
        <td style="text-align: right;">1.117KiB</td>
        <td style="text-align: right;">28.594KiB</td>
        <td style="text-align: right;">0KiB</td>
    </tr>
</table>

### Stdout

#### Python

Case 1: Reverse string via loop \
Average execution time: 6us \
Memory usage: 0.149KiB

Case 2: Reverse string via stack \
Average execution time: 10us \
Memory usage: 0.149KiB

Case 3: Reverse string via recursion \
Average execution time: 20us \
Memory usage: 0.149KiB

Case 4: Sort number in descending order via loop \
Average execution time: 6us \
Memory usage: 0.0KiB

Case 5: Reverse string via extended slice \
Average execution time: 0us \
Average memory usage: 0.149KiB

#### Golang

Case 1: Reverse string via loop \
Average execution time: 7us \
Memory usage: 0.097KiB

Case 2: Reverse string via stack \
Average execution time: 7us \
Memory usage: 0.098KiB

Case 3: Reverse string via recursion \
Average execution time: 6us \
Memory usage: 0.097KiB

Case 4: Sort number list in descending order via loop \
Average execution time: 0us \
Memory usage: 0KiB

Case 5: Reverse string via loop with rune \
Average execution time: 1us \
Memory usage: 0.002KiB

#### JavaScript

Case 1: Reverse string via loop \
Average execution time: 6us \
Memory usage: 4.828KiB

Case 2: Reverse string via stack \
Average execution time: 11us \
Memory usage: 4.242KiB

Case 3: Reverse string via recursion \
Average execution time: 16us \
Memory usage: 6.516KiB

Case 4: Sort number list in descending order via loop \
Average execution time: 4us \
Memory usage: 0.219KiB

Case 5: Reverse string via built-in functions \
Average execution time: 3us \
Memory usage: 2.023KiB

#### Java

Case 1: Reverse string via loop \
Average execution time: 3us \
Memory usage: 142.438KiB

Case 2: Reverse string via stack \
Average execution time: 17us \
Memory usage: 113.797KiB

Case 3: Reverse string via recursion \
Average execution time: 32us \
Memory usage: 113.797KiB

Case 4: Sort number list in descending order via loop \
Average execution time: 1us \
Memory usage: 0.0KiB

#### C#

Case 1: Reverse string via loop \
Average execution time: 2us \
Memory usage: 0.758KiB

Case 2: Reverse string via stack \
Average execution time: 9us \
Memory usage: 1.117KiB

Case 3: Reverse string via recursion \
Average execution time: 17us \
Memory usage: 28.594KiB

Case 4: Sort number list in descending order via loop \
Average execution time: 1us \
Memory usage: 0KiB
