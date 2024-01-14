package main

func reverse_string_via_rune(buf string) string {
	/*
	   Time complexity: O(n)
	   Space complexity: O(n)
	   Auxiliary space: O(n)
	*/

	r := []rune(buf)
	for i, j := 0, len(r)-1; i < len(r)/2; i, j = i+1, j-1 {
		r[i], r[j] = r[j], r[i]
	}
	return string(r)
}
