def sort_list_in_descending_order(num_list: list):
    """
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    """

    while True:
        instances_of_out_of_order = 0
        for i in range(len(num_list)-1):
            if num_list[i] < num_list[i+1]:
                small = num_list[i]
                large = num_list[i+1]

                num_list[i] = large
                num_list[i+1] = small

                instances_of_out_of_order += 1

        if instances_of_out_of_order == 0:
            break

    return num_list