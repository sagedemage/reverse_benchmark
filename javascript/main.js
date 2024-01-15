const { sort_list_in_descending_order } = require("./sort_list_in_descending_order")
const { reverse_string_via_built_in_functions } = require("./reverse_string_via_built_in_functions")

/* Reverse a string */

function reverse_string_via_loop(buf) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(1)
    */

    let temp_buf = ""

    for (let i = 0; i < buf.length; i++) {
        temp_buf = buf[i] + temp_buf
    }

    return temp_buf
}

function reverse_string_via_stack(buf) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    */
    let temp_buf = ""

    let buf_list = buf.split("")

    let length = buf_list.length

    for (let i = 0; i < length; i++) {
        temp_buf += buf_list.pop(-1)
    }

    return temp_buf
}

function reverse_string_via_recursion(buf) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    */
    if (buf.length == 0) {
        return buf
    }

    return reverse_string_via_recursion(buf.slice(1)) + buf[0]
}

/* Reverse string */

// 104 characters
let string_of_letters = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"

// Case 1: Reverse string via loop

let start = process.hrtime()

let rev_buf = reverse_string_via_loop(string_of_letters)

let end = process.hrtime()

let total_time = Math.round((end[1] - start[1]) / 1000)

console.log("Case 1: Reverse string via loop")
console.log("Execution time: " + total_time + "us");
console.log("Output: " + rev_buf + "\n")

// Case 2: Reverse string via stack

start = process.hrtime()

rev_buf = reverse_string_via_stack(string_of_letters)

end = process.hrtime()

total_time = Math.round((end[1] - start[1]) / 1000)

console.log("Case 2: Reverse string via stack")
console.log("Execution time: " + total_time + "us");
console.log("Output: " + rev_buf + "\n")

// Case 3: Reverse string via recursion

start = process.hrtime()

rev_buf = reverse_string_via_recursion(string_of_letters)

end = process.hrtime()

total_time = Math.round((end[1] - start[1]) / 1000)

console.log("Case 3: Reverse string via recursion")
console.log("Execution time: " + total_time + "us");
console.log("Output: " + rev_buf + "\n")

/* Sort Number List in Descending Order (Reverse Order) */

// Case 4: Sort number list in descending order via loop

let list_of_nums = [
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
    21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
    31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
    41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
]

start = process.hrtime()

let rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

end = process.hrtime()

total_time = Math.round((end[1] - start[1]) / 1000)

console.log("Case 4: Sort number list in descending order via loop")
console.log("Execution time: " + total_time + "us");
console.log("Output: ")
console.log(rev_list_of_nums)
console.log("")

/* Reverse string */

// Case 5: Reverse string via built-in functions

start = process.hrtime()

rev_buf = reverse_string_via_built_in_functions(string_of_letters)

end = process.hrtime()

total_time = Math.round((end[1] - start[1]) / 1000)

console.log("Case 5: Reverse string via built-in functions")
console.log("Execution time: " + total_time + "us");
console.log("Output: " + rev_buf + "\n")