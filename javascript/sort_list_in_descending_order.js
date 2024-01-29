function sort_list_in_descending_order(num_list) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    */

    for (let i = 0; i < num_list.length; i++) {
        let instances_of_out_of_order = false
        for (let j = 0; j < num_list.length; j++) {
            if (num_list[j] < num_list[j + 1]) {
                let small = num_list[j]
                let large = num_list[j + 1]

                num_list[j] = large
                num_list[j + 1] = small

                instances_of_out_of_order = true
            }
        }
        if (!instances_of_out_of_order) {
            break
        }
    }

    return num_list
}

exports.sort_list_in_descending_order = sort_list_in_descending_order
