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

let exe_time_total = 0
let rev_buf = ""

for (let i = 0; i < 100; i++) {
    let start = process.hrtime()

    rev_buf = reverse_string_via_loop(string_of_letters)
    
    let end = process.hrtime()
    
    let exe_time = end[1] - start[1]

    exe_time_total += exe_time
}

let used_mem1 = process.memoryUsage()

rev_buf = reverse_string_via_loop(string_of_letters)

let used_mem2 = process.memoryUsage()

let used_mem = used_mem2.heapUsed - used_mem1.heapUsed

let average_exe_time = Math.round(((exe_time_total / 1000) / 100))

console.log("Case 1: Reverse string via loop")
console.log("Average execution time: " + average_exe_time + "us");
console.log("Memory usage: " + used_mem + "bytes")
console.log("Output: " + rev_buf + "\n")

// Case 2: Reverse string via stack

exe_time_total = 0

for (let i = 0; i < 100; i++) {
    let start = process.hrtime()

    rev_buf = reverse_string_via_stack(string_of_letters)
    
    let end = process.hrtime()
    
    let exe_time = end[1] - start[1]

    exe_time_total += exe_time
}

used_mem1 = process.memoryUsage()

rev_buf = reverse_string_via_stack(string_of_letters)

used_mem2  = process.memoryUsage()

used_mem = used_mem2.heapUsed - used_mem1.heapUsed

average_exe_time = Math.round(((exe_time_total / 1000) / 100))

console.log("Case 2: Reverse string via stack")
console.log("Average execution time: " + average_exe_time + "us");
console.log("Memory usage: " + used_mem + "bytes")
console.log("Output: " + rev_buf + "\n")

// Case 3: Reverse string via recursion

exe_time_total = 0

for (let i = 0; i < 100; i++) {
    let start = process.hrtime()

    rev_buf = reverse_string_via_recursion(string_of_letters)
    
    let end = process.hrtime()
    
    let exe_time = end[1] - start[1]

    exe_time_total += exe_time
}

used_mem1 = process.memoryUsage()

rev_buf = reverse_string_via_recursion(string_of_letters)

used_mem2  = process.memoryUsage()

used_mem = used_mem2.heapUsed - used_mem1.heapUsed

average_exe_time = Math.round(((exe_time_total / 1000) / 100))

console.log("Case 3: Reverse string via recursion")
console.log("Average execution time: " + average_exe_time + "us");
console.log("Memory usage: " + used_mem + "bytes")
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

let rev_list_of_nums = []
exe_time_total = 0

for (let i = 0; i < 100; i++) {
    let start = process.hrtime()

    rev_list_of_nums = sort_list_in_descending_order(list_of_nums)
    
    let end = process.hrtime()
    
    let exe_time = end[1] - start[1]

    exe_time_total += exe_time
}

used_mem1 = process.memoryUsage()

rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

used_mem2  = process.memoryUsage()

used_mem = used_mem2.heapUsed - used_mem1.heapUsed

average_exe_time = Math.round(((exe_time_total / 1000) / 100))

console.log("Case 4: Sort number list in descending order via loop")
console.log("Average execution time: " + average_exe_time + "us");
console.log("Memory usage: " + used_mem + "bytes")
console.log("Output: ")
console.log(rev_list_of_nums)
console.log("")

/* Reverse string */

// Case 5: Reverse string via built-in functions

exe_time_total = 0

for (let i = 0; i < 100; i++) {
    let start = process.hrtime()

    rev_buf = reverse_string_via_built_in_functions(string_of_letters)
    
    let end = process.hrtime()
    
    let exe_time = end[1] - start[1]

    exe_time_total += exe_time
}

used_mem1 = process.memoryUsage()

rev_buf = reverse_string_via_built_in_functions(string_of_letters)

used_mem2  = process.memoryUsage()

used_mem = used_mem2.heapUsed - used_mem1.heapUsed

average_exe_time = Math.round(((exe_time_total / 1000) / 100))

console.log("Case 5: Reverse string via built-in functions")
console.log("Average execution time: " + average_exe_time + "us");
console.log("Memory usage: " + used_mem + "bytes")
console.log("Output: " + rev_buf + "\n")