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
        <td style="text-align: right;">13909ns</td>
        <td style="text-align: right;">17229ns</td>
        <td style="text-align: right;">51521ns</td>
        <td style="text-align: right;">290797ns</td>
    </tr>
    <tr>
        <td>Golang</td>
        <td style="text-align: right;">5038ns</td>
        <td style="text-align: right;">5634ns</td>
        <td style="text-align: right;">37886ns</td>
        <td style="text-align: right;">3276ns</td>
    </tr>
    <tr>
        <td>JavaScript</td>
        <td style="text-align: right;">31650ns</td>
        <td style="text-align: right;">56149ns</td>
        <td style="text-align: right;">71800ns</td>
        <td style="text-align: right;">239263ns</td>
    </tr>
    <tr>
        <td>Java</td>
        <td style="text-align: right;">60123ns</td>
        <td style="text-align: right;">688430ns</td>
        <td style="text-align: right;">2821498ns</td>
        <td style="text-align: right;">73755ns</td>
    </tr>
</table>

### Stdout

#### Python

Case 1: Reverse string via loop \
Execution time: 13909ns

Case 2: Reverse string via stack \
Execution time: 17229ns

Case 3: Reverse string via recursion \
Execution time: 51521ns

Case 4: Sort number in descending order via loop \
Execution time: 290797ns

Case 5: Reverse string via extended slice \
Execution time: 1662ns

#### Golang

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

#### JavaScript

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

#### Java

Case 1: Reverse string via loop \
Execution time: 60123ns

Case 2: Reverse string via stack \
Execution time: 688430ns

Case 3: Reverse string via recursion \
Execution time: 2821498ns

Case 4: Sort number list in descending order via loop \
Execution time: 73755ns
