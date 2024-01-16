import datetime
import tracemalloc
from reverse_string_via_extended_slice import reverse_string_via_extended_slice
from sort_list_in_descending_order import sort_list_in_descending_order

"""Reverse a string"""


def reverse_string_via_loop(buf: str):
    """
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(1)
    """
    temp_buf = ""

    for i in range(len(buf)):
        temp_buf = buf[i] + temp_buf

    return temp_buf


def reverse_string_via_stack(buf: str):
    """
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    """
    temp_buf = ""

    buf_list = list(buf.strip(""))

    for i in range(len(buf_list)):
        temp_buf += buf_list.pop(-1)

    return temp_buf


def reverse_string_via_recursion(buf: str):
    """
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    """
    if len(buf) == 0:
        return buf

    return reverse_string_via_recursion(buf[1:]) + buf[0]


"""Reverse string"""

# 104 characters
string_of_letters = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"

# Case 1: Reverse string via loop

exe_time_total = 0
rev_buf = ""
memory = 0

for i in range(100):
    start_t = datetime.datetime.now()

    rev_buf = reverse_string_via_loop(string_of_letters)

    end_t = datetime.datetime.now()

    exe_time = end_t - start_t

    exe_time_total += exe_time.microseconds

tracemalloc.start()

rev_buf = reverse_string_via_loop(string_of_letters)

memory = tracemalloc.get_traced_memory()[0]

tracemalloc.stop()

average_exe_time = int(exe_time_total / 100)

print("Case 1: Reverse string via loop")
print("Average execution time: " + str(average_exe_time) + "us")
print("Memory usage: " + str(memory) + "bytes")
print("Output: " + rev_buf + "\n")

# Case 2: Reverse string via stack

exe_time_total = 0
memory = 0

for i in range(100):
    start_t = datetime.datetime.now()

    rev_buf = reverse_string_via_stack(string_of_letters)

    end_t = datetime.datetime.now()

    exe_time = end_t - start_t

    exe_time_total += exe_time.microseconds

tracemalloc.start()

rev_buf = reverse_string_via_stack(string_of_letters)

memory = tracemalloc.get_traced_memory()[0]

tracemalloc.stop()

average_exe_time = int(exe_time_total / 100)

print("Case 2: Reverse string via stack")
print("Average execution time: " + str(average_exe_time) + "us")
print("Memory usage: " + str(memory) + "bytes")
print("Output: " + rev_buf + "\n")

# Case 3: Reverse string via recursion

exe_time_total = 0
total_memory = 0

for i in range(100):
    start_t = datetime.datetime.now()

    rev_buf = reverse_string_via_recursion(string_of_letters)

    end_t = datetime.datetime.now()

    exe_time = end_t - start_t

    exe_time_total += exe_time.microseconds

    total_memory += tracemalloc.get_traced_memory()[0]

tracemalloc.start()

rev_buf = reverse_string_via_recursion(string_of_letters)

memory = tracemalloc.get_traced_memory()[0]

tracemalloc.stop()

average_exe_time = int(exe_time_total / 100)

print("Case 3: Reverse string via recursion")
print("Average execution time: " + str(average_exe_time) + "us")
print("Memory usage: " + str(memory) + "bytes")
print("Output: " + rev_buf + "\n")

"""Sort Number List in Descending Order (Reverse Order)"""

# Case 4: Sort number list in descending order via loop

list_of_nums = [
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
    21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
    31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
    41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
]

rev_list_of_nums = []

exe_time_total = 0
total_memory = 0

for i in range(100):
    start_t = datetime.datetime.now()

    rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

    end_t = datetime.datetime.now()

    exe_time = end_t - start_t

    exe_time_total += exe_time.microseconds

tracemalloc.start()

rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

memory = tracemalloc.get_traced_memory()[0]

tracemalloc.stop()

average_exe_time = int(exe_time_total / 100)

print("Case 4: Sort number in descending order via loop")
print("Average execution time: " + str(average_exe_time) + "us")
print("Memory usage: " + str(memory) + "bytes")
print("Output: ")
print(rev_list_of_nums)
print("")

"""Reverse string"""

# Case 5: Reverse string via extended slice

exe_time_total = 0
total_memory = 0

for i in range(100):
    start_t = datetime.datetime.now()

    rev_buf = reverse_string_via_extended_slice(string_of_letters)

    end_t = datetime.datetime.now()

    exe_time = end_t - start_t

    exe_time_total += exe_time.microseconds

tracemalloc.start()

rev_buf = reverse_string_via_extended_slice(string_of_letters)

memory = tracemalloc.get_traced_memory()[0]

tracemalloc.stop()

average_exe_time = int(exe_time_total / 100)

print("Case 5: Reverse string via extended slice")
print("Average execution time: " + str(average_exe_time) + "us")
print("Average memory usage: " + str(memory) + "bytes")
print("Output: " + rev_buf + "\n")
