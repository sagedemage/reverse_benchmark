function reverse_string_via_built_in_functions(buf) {
    /*
    Time complexity: O(n)
    Space complexity: O(n)
    Auxiliary space: O(n)
    */

    let list_of_chars = buf.split("")

    let reverse_list = list_of_chars.reverse()

    let reverse_string = reverse_list.join("")

    return reverse_string

}

exports.reverse_string_via_built_in_functions = reverse_string_via_built_in_functions
   