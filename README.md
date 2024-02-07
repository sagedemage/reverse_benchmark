# reverse_benchmark

Benchmarks the programming languages on some simple algorithms.
I called it reverse benchmark since most of these algorithms reverses the order of the strings
and sorts the lists in descending order (reverse order).

## Results

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

