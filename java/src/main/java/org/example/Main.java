package org.example;

import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        /* Reverse String */
        // 104 characters
        String string_of_letters = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        // Case 1: Reverse string via loop

        long exe_time_total = 0;
        String rev_buf = "";

        for (int i = 0; i < 100; i++) {
            long start = System.nanoTime();
            rev_buf = reverse_string_via_loop(string_of_letters);
            long end = System.nanoTime();

            long exe_time = end - start;
            exe_time_total += exe_time;
        }

        Runtime rt = Runtime.getRuntime();

        System.gc();

        long used_mem1 = rt.totalMemory() - rt.freeMemory();

        rev_buf = reverse_string_via_loop(string_of_letters);

        long used_mem2 = rt.totalMemory() - rt.freeMemory();

        long used_mem = used_mem2 - used_mem1;

        long average_exe_time = (exe_time_total / 1000) / 100;

        System.out.println("Case 1: Reverse string via loop");
        System.out.println("Average execution time: " + average_exe_time + "us");
        System.out.println("Memory usage: " + used_mem + "bytes");
        System.out.println("Output: " + rev_buf + "\n");

        // Case 2: Reverse string via stack

        exe_time_total = 0;

        for (int i = 0; i < 100; i++) {
            long start = System.nanoTime();
            rev_buf = reverse_string_via_stack(string_of_letters);
            long end = System.nanoTime();

            long exe_time = end - start;
            exe_time_total += exe_time;
        }

        System.gc();

        used_mem1 = rt.totalMemory() - rt.freeMemory();

        rev_buf = reverse_string_via_stack(string_of_letters);

        used_mem2 = rt.totalMemory() - rt.freeMemory();

        used_mem = used_mem2 - used_mem1;

        average_exe_time = (exe_time_total / 1000) / 100;

        System.out.println("Case 2: Reverse string via stack");
        System.out.println("Average execution time: " + average_exe_time + "us");
        System.out.println("Memory usage: " + used_mem + "bytes");
        System.out.println("Output: " + rev_buf + "\n");

        // Case 3: Reverse string via recursion

        exe_time_total = 0;

        for (int i = 0; i < 100; i++) {
            long start = System.nanoTime();
            rev_buf = reverse_string_via_recursion(string_of_letters);
            long end = System.nanoTime();

            long exe_time = end - start;
            exe_time_total += exe_time;
        }

        System.gc();

        used_mem1 = rt.totalMemory() - rt.freeMemory();

        rev_buf = reverse_string_via_recursion(string_of_letters);

        used_mem2 = rt.totalMemory() - rt.freeMemory();

        used_mem = used_mem2 - used_mem1;

        average_exe_time = (exe_time_total / 1000) / 100;

        System.out.println("Case 3: Reverse string via recursion");
        System.out.println("Average execution time: " + average_exe_time + "us");
        System.out.println("Memory usage: " + used_mem + "bytes");
        System.out.println("Output: " + rev_buf + "\n");

        /* Sort Number List in Descending Order (Reverse Order) */

        // Case 4: Sort number list in descending order via loop

        int[] list_of_nums = new int[]{
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
        };

        int[] rev_list_of_nums;
        exe_time_total = 0;

        for (int i = 0; i < 100; i++) {
            long start = System.nanoTime();
            rev_list_of_nums = sort_list_in_descending_order(list_of_nums);
            long end = System.nanoTime();

            long exe_time = end - start;
            exe_time_total += exe_time;
        }

        System.gc();

        used_mem1 = rt.totalMemory() - rt.freeMemory();

        rev_list_of_nums = sort_list_in_descending_order(list_of_nums);

        used_mem2 = rt.totalMemory() - rt.freeMemory();

        used_mem = used_mem2 - used_mem1;

        average_exe_time = (exe_time_total / 1000) / 100;

        System.out.println("Case 4: Sort number list in descending order via loop");
        System.out.println("Average execution time: " + average_exe_time + "us");
        System.out.println("Memory usage: " + used_mem + "bytes");
        System.out.println("Output: ");
        System.out.println(Arrays.toString(rev_list_of_nums) + "\n");
    }

    public static String reverse_string_via_loop(String buf) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(1)
        */

        StringBuilder temp_buf = new StringBuilder();

        for (int i = 0; i < buf.length(); i++) {
            temp_buf.insert(0, buf.charAt(i));
        }

        return temp_buf.toString();
    }

    public static String reverse_string_via_stack(String buf) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        StringBuilder temp_buf = new StringBuilder();

        List<Character> list_of_chars = buf.chars().mapToObj(e -> (char)e).toList();

        for (int i = 0; i < list_of_chars.size(); i++) {
            temp_buf.insert(0, buf.charAt(i));
        }

        return temp_buf.toString();
    }

    public static String reverse_string_via_recursion(String buf) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        if (buf.isEmpty()) {
            return buf;
        }

        String temp_buf = buf.substring(1);

        return reverse_string_via_recursion(temp_buf) + buf.charAt(0);
    }

    public static int[] sort_list_in_descending_order(int[] num_list) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
         */
        while (true) {
            int instances_of_out_of_order = 0;
            for (int i = 0; i < num_list.length-1; i++) {
                if (num_list[i] < num_list[i+1]) {
                    int small = num_list[i];
                    int large = num_list[i+1];

                    num_list[i] = large;
                    num_list[i+1] = small;

                    instances_of_out_of_order += 1;
                }
            }

            if (instances_of_out_of_order == 0) {
                break;
            }
        }
        return num_list;
    }
}