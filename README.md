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
        <td style="text-align: right;">12us</td>
        <td style="text-align: right;">22us</td>
        <td style="text-align: right;">6us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">353bytes</td>
        <td style="text-align: right;">1037bytes</td>
        <td style="text-align: right;">10404bytes</td>
        <td style="text-align: right;">96bytes</td>
    </tr>
    <tr>
        <td>Golang</td>
        <td style="text-align: right;">6us</td>
        <td style="text-align: right;">7us</td>
        <td style="text-align: right;">5us</td>
        <td style="text-align: right;">0us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">257bytes</td>
        <td style="text-align: right;">265bytes</td>
        <td style="text-align: right;">265bytes</td>
        <td style="text-align: right;">172bytes</td>
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
        <td style="text-align: right;">4944bytes</td>
        <td style="text-align: right;">4344bytes</td>
        <td style="text-align: right;">6672bytes</td>
        <td style="text-align: right;">224bytes</td>
    </tr>
    <tr>
        <td>Java</td>
        <td style="text-align: right;">17us</td>
        <td style="text-align: right;">75us</td>
        <td style="text-align: right;">98us</td>
        <td style="text-align: right;">2us</td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align: right;">145656bytes</td>
        <td style="text-align: right;">116528bytes</td>
        <td style="text-align: right;">116528bytes</td>
        <td style="text-align: right;">0bytes</td>
    </tr>
</table>

### Stdout

#### Python

Case 1: Reverse string via loop \
Average execution time: 6us \
Memory usage: 353bytes

Case 2: Reverse string via stack \
Average execution time: 12us \
Memory usage: 1037bytes

Case 3: Reverse string via recursion \
Average execution time: 22us \
Memory usage: 10404bytes

Case 4: Sort number in descending order via loop \
Average execution time: 6us \
Memory usage: 96bytes

Case 5: Reverse string via extended slice \
Average execution time: 0us \
Average memory usage: 153bytes

#### Golang

Case 1: Reverse string via loop \
Average execution time: 6us \
Memory usage: 257bytes

Case 2: Reverse string via stack \
Average execution time: 7us \
Memory usage: 265bytes

Case 3: Reverse string via recursion \
Average execution time: 5us \
Memory usage: 265bytes

Case 4: Sort number list in descending order via loop \
Average execution time: 0us \
Memory usage: 172bytes

Case 5: Reverse string via loop with rune \
Average execution time: 1us \
Memory usage: 176bytes

#### JavaScript

Case 1: Reverse string via loop \
Average execution time: 6us \
Memory usage: 4944bytes

Case 2: Reverse string via stack \
Average execution time: 11us \
Memory usage: 4344bytes

Case 3: Reverse string via recursion \
Average execution time: 16us \
Memory usage: 6672bytes

Case 4: Sort number list in descending order via loop \
Average execution time: 4us \
Memory usage: 224bytes

Case 5: Reverse string via built-in functions \
Average execution time: 3us \
Memory usage: 2072bytes

#### Java

Case 1: Reverse string via loop \
Average execution time: 17us \
Memory usage: 145656bytes

Case 2: Reverse string via stack \
Average execution time: 75us \
Memory usage: 116528bytes

Case 3: Reverse string via recursion \
Average execution time: 98us \
Memory usage: 116528bytes

Case 4: Sort number list in descending order via loop \
Average execution time: 2us \
Memory usage: 0bytes

