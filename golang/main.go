package main

import (
	"fmt"
	"math"
	"runtime"
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

	exe_time_total := 0
	var used_mem, used_mem1, used_mem2 float64
	rev_buf := ""

	for i := 0; i < 100; i++ {
		start := time.Now().UnixMicro()

		rev_buf = reverse_string_via_loop(string_of_letters)

		end := time.Now().UnixMicro()

		exe_time := end - start

		exe_time_total += int(exe_time)
	}

	average_exe_time := exe_time_total / 100

	var m1 runtime.MemStats
	var m2 runtime.MemStats

	runtime.GC()

	runtime.ReadMemStats(&m1)

	rev_buf = reverse_string_via_loop(string_of_letters)

	runtime.ReadMemStats(&m2)

	used_mem1 = float64(m1.Mallocs - m1.Frees)
	used_mem2 = float64(m2.Mallocs - m2.Frees)
	used_mem = math.Round((used_mem2-used_mem1)/1024*1000) / 1000

	fmt.Println("Case 1: Reverse string via loop")
	fmt.Println("Average execution time: " + fmt.Sprint(average_exe_time) + "us")
	fmt.Println("Memory usage: " + fmt.Sprint(used_mem) + "KiB")
	fmt.Println("Output: " + rev_buf + "\n")

	// Case 2: Reverse string via stack

	exe_time_total = 0

	for i := 0; i < 100; i++ {
		start := time.Now().UnixMicro()

		rev_buf = reverse_string_via_stack(string_of_letters)

		end := time.Now().UnixMicro()

		exe_time := end - start

		exe_time_total += int(exe_time)
	}

	average_exe_time = exe_time_total / 100

	runtime.GC()

	runtime.ReadMemStats(&m1)

	rev_buf = reverse_string_via_stack(string_of_letters)

	runtime.ReadMemStats(&m2)

	used_mem1 = float64(m1.Mallocs - m1.Frees)
	used_mem2 = float64(m2.Mallocs - m2.Frees)
	used_mem = math.Round((used_mem2-used_mem1)/1024*1000) / 1000

	fmt.Println("Case 2: Reverse string via stack")
	fmt.Println("Average execution time: " + fmt.Sprint(average_exe_time) + "us")
	fmt.Println("Memory usage: " + fmt.Sprint(used_mem) + "KiB")
	fmt.Println("Output: " + rev_buf + "\n")

	// Case 3: Reverse string via recursion

	exe_time_total = 0

	for i := 0; i < 100; i++ {
		start := time.Now().UnixMicro()

		rev_buf = reverse_string_via_recursion(string_of_letters)

		end := time.Now().UnixMicro()

		exe_time := end - start

		exe_time_total += int(exe_time)
	}

	average_exe_time = exe_time_total / 100

	runtime.GC()

	runtime.ReadMemStats(&m1)

	rev_buf = reverse_string_via_recursion(string_of_letters)

	runtime.ReadMemStats(&m2)

	used_mem1 = float64(m1.Mallocs - m1.Frees)
	used_mem2 = float64(m2.Mallocs - m2.Frees)
	used_mem = math.Round((used_mem2-used_mem1)/1024*1000) / 1000

	fmt.Println("Case 3: Reverse string via recursion")
	fmt.Println("Average execution time: " + fmt.Sprint(average_exe_time) + "us")
	fmt.Println("Memory usage: " + fmt.Sprint(used_mem) + "KiB")
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

	var rev_list_of_nums []int

	exe_time_total = 0

	for i := 0; i < 100; i++ {
		start := time.Now().UnixMicro()

		rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

		end := time.Now().UnixMicro()

		exe_time := end - start

		exe_time_total += int(exe_time)
	}

	average_exe_time = exe_time_total / 100

	runtime.GC()

	runtime.ReadMemStats(&m1)

	rev_list_of_nums = sort_list_in_descending_order(list_of_nums)

	runtime.ReadMemStats(&m2)

	used_mem1 = float64(m1.Mallocs - m1.Frees)
	used_mem2 = float64(m2.Mallocs - m2.Frees)
	used_mem = math.Round((used_mem2-used_mem1)/1024*1000) / 1000

	fmt.Println("Case 4: Sort number list in descending order via loop")
	fmt.Println("Average execution time: " + fmt.Sprint(average_exe_time) + "us")
	fmt.Println("Memory usage: " + fmt.Sprint(used_mem) + "KiB")
	fmt.Println("Output: ")
	fmt.Println(rev_list_of_nums)
	fmt.Println()

	/* Reverse string */

	// Case 5: Reverse string via loop with rune

	exe_time_total = 0

	for i := 0; i < 100; i++ {
		start := time.Now().UnixMicro()

		rev_buf = reverse_string_via_rune(string_of_letters)

		end := time.Now().UnixMicro()

		exe_time := end - start

		exe_time_total += int(exe_time)
	}

	average_exe_time = exe_time_total / 100

	runtime.GC()

	runtime.ReadMemStats(&m1)

	rev_buf = reverse_string_via_rune(string_of_letters)

	runtime.ReadMemStats(&m2)

	used_mem1 = float64(m1.Mallocs - m1.Frees)
	used_mem2 = float64(m2.Mallocs - m2.Frees)
	used_mem = math.Round((used_mem2-used_mem1)/1024*1000) / 1000

	fmt.Println("Case 5: Reverse string via loop with rune")
	fmt.Println("Average execution time: " + fmt.Sprint(average_exe_time) + "us")
	fmt.Println("Memory usage: " + fmt.Sprint(used_mem) + "KiB")
	fmt.Println("Output: " + rev_buf + "\n")
}
