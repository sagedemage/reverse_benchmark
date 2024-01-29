package main

func sort_list_in_descending_order(num_list []int) []int {
	for i := 0; i < len(num_list)-1; i++ {
		instances_of_out_of_order := false
		for j := 0; j < len(num_list)-1; j++ {
			if num_list[i] < num_list[j+1] {
				small := num_list[j]
				large := num_list[j+1]

				num_list[j] = large
				num_list[j+1] = small

				instances_of_out_of_order = true
			}
		}
		if !instances_of_out_of_order {
			break
		}
	}
	return num_list
}
