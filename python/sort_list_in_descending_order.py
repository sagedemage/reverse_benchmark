def sort_list_in_descending_order(num_list: list):
    """
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    """

    for i in range(len(num_list)):
        instances_of_out_of_order = False
        for j in range(len(num_list)-1):
            if num_list[j] < num_list[j+1]:
                small = num_list[j]
                large = num_list[j+1]

                num_list[j] = large
                num_list[j+1] = small

                instances_of_out_of_order = True

        if not instances_of_out_of_order:
            break

    return num_list