package main

import (
	"fmt"
	"strings"
	"time"
)

func reverse_string_via_loop(buf string) string {
	/*
	   Time complexity: O(n)
	   Space complexity: O(n)
	   Auxiliary space: O(1)
	*/
	temp_buf := ""
	for i := 0; i < len(buf); i++ {
		temp_buf = string(buf[i]) + temp_buf
	}
	return temp_buf
}

func reverse_string_via_stack(buf string) string {
	/*
	   Time complexity: O(n)
	   Space complexity: O(n)
	   Auxiliary space: O(n)
	*/
	temp_buf := ""
	var list_arr []string = strings.Split(buf, "")

	var length = len(list_arr)

	for i := 0; i < length; i++ {
		temp_buf += list_arr[len(list_arr)-1]
		list_arr[len(list_arr)-1] = ""        // Erase last element
		list_arr = list_arr[:len(list_arr)-1] // Truncate slice
	}

	return temp_buf
}

func reverse_string_via_recursion(buf string) string {
	/*
	   Time complexity: O(n)
	   Space complexity: O(n)
	   Auxiliary space: O(n)
	*/

	if len(buf) == 0 {
		return buf
	}

	return reverse_string_via_recursion(buf[1:]) + string(buf[0])
}

func main() {
	// 104 characters
	string_of_letters := "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"

	/* Reverse string */

	// Case 1: Reverse string via loop

	start := time.Now().UnixNano()

	rev_buf := reverse_string_via_loop(string_of_letters)

	end := time.Now().UnixNano()

	exe_time := end - start

	fmt.Println("Case 1: Reverse string via loop")
	fmt.Println("Execution time: " + fmt.Sprint(exe_time) + "ns")
	fmt.Println("Output: " + rev_buf + "\n")

	// Case 2: Reverse string via stack

	start = time.Now().UnixNano()

	rev_buf = reverse_string_via_stack(string_of_letters)

	end = time.Now().UnixNano()

	exe_time = end - start

	fmt.Println("Case 2: Reverse string via stack")
	fmt.Println("Execution time: " + fmt.Sprint(exe_time) + "ns")
	fmt.Println("Output: " + rev_buf + "\n")

	// Case 3: Reverse string via recursion

	start = time.Now().UnixNano()

	rev_buf = reverse_string_via_recursion(string_of_letters)

	end = time.Now().UnixNano()

	exe_time = end - start

	fmt.Println("Case 3: Reverse string via recursion")
	fmt.Println("Execution time: " + fmt.Sprint(exe_time) + "ns")
	fmt.Println("Output: " + rev_buf + "\n")

	/* Sort Number List in Descending Order (Reverse Order) */

	// Case 4: Sort number list in descending order via loop

	var list_of_nums []int = []int{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
		21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
		31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
		41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
	}

	start = time.Now().UnixNano()

	var rev_list_of_nums []int = sort_list_in_descending_order(list_of_nums)

	end = time.Now().UnixNano()

	exe_time = end - start

	fmt.Println("Case 4: Sort number list in descending order via loop")
	fmt.Println("Execution time: " + fmt.Sprint(exe_time) + "ns")
	fmt.Println("Output: ")
	fmt.Println(rev_list_of_nums)
	fmt.Println()

	/* Reverse string */

	// Case 5: Reverse string via loop with rune

	start = time.Now().UnixNano()

	rev_buf = reverse_string_via_rune(string_of_letters)

	end = time.Now().UnixNano()

	exe_time = end - start

	fmt.Println("Case 5: Reverse string via loop with rune")
	fmt.Println("Execution time: " + fmt.Sprint(exe_time) + "ns")
	fmt.Println("Output: " + rev_buf + "\n")
}
