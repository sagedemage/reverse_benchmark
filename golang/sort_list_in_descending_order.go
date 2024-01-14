package main

func sort_list_in_descending_order(num_list []int) []int {
	for {
		instances_of_out_of_order := 0
		for i := 0; i < len(num_list)-1; i++ {
			if num_list[i] < num_list[i+1] {
				small := num_list[i]
				large := num_list[i+1]

				num_list[i] = large
				num_list[i+1] = small

				instances_of_out_of_order += 1
			}
		}
		if instances_of_out_of_order == 0 {
			break
		}
	}
	return num_list
}
