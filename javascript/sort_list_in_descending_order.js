function sort_list_in_descending_order(num_list) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    */

    while (true) {
        let instances_of_out_of_order = 0
        for (let i = 0; i < num_list.length; i++) {
            if (num_list[i] < num_list[i + 1]) {
                let small = num_list[i]
                let large = num_list[i + 1]

                num_list[i] = large
                num_list[i + 1] = small

                instances_of_out_of_order += 1
            }
        }
        if (instances_of_out_of_order == 0) {
            break
        }
    }

    return num_list
}

exports.sort_list_in_descending_order = sort_list_in_descending_order
