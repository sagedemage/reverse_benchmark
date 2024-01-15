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
        <td style="text-align: right;">16us</td>
        <td style="text-align: right;">13us</td>
        <td style="text-align: right;">53us</td>
        <td style="text-align: right;">266us</td>
    </tr>
    <tr>
        <td>Golang</td>
        <td style="text-align: right;">5us</td>
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">27us</td>
        <td style="text-align: right;">4us</td>
    </tr>
    <tr>
        <td>JavaScript</td>
        <td style="text-align: right;">33us</td>
        <td style="text-align: right;">48us</td>
        <td style="text-align: right;">63us</td>
        <td style="text-align: right;">224us</td>
    </tr>
    <tr>
        <td>Java</td>
        <td style="text-align: right;">86us</td>
        <td style="text-align: right;">2583us</td>
        <td style="text-align: right;">5700us</td>
        <td style="text-align: right;">111us</td>
    </tr>
</table>

### Stdout

#### Python

Case 1: Reverse string via loop \
Execution time: 16us

Case 2: Reverse string via stack \
Execution time: 13us

Case 3: Reverse string via recursion \
Execution time: 53us

Case 4: Sort number in descending order via loop \
Execution time: 266us

Case 5: Reverse string via extended slice \
Execution time: 2us

#### Golang

Case 1: Reverse string via loop \
Execution time: 5us

Case 2: Reverse string via stack \
Execution time: 6us

Case 3: Reverse string via recursion \
Execution time: 27us

Case 4: Sort number list in descending order via loop \
Execution time: 4us

Case 5: Reverse string via loop with rune \
Execution time: 1us

#### JavaScript

Case 1: Reverse string via loop \
Execution time: 33us

Case 2: Reverse string via stack \
Execution time: 48us

Case 3: Reverse string via recursion \
Execution time: 63us

Case 4: Sort number list in descending order via loop \
Execution time: 224us

Case 5: Reverse string via built-in functions \
Execution time: 43us

#### Java

Case 1: Reverse string via loop \
Execution time: 86us

Case 2: Reverse string via stack \
Execution time: 2583us

Case 3: Reverse string via recursion \
Execution time: 5700us

Case 4: Sort number list in descending order via loop \
Execution time: 111us
