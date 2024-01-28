namespace csharp;

class Program
{
    static void Main()
    {
        /* Reverse String */
        // 104 characters
        string string_of_letters = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        // Case 1: Reverse string via loop  

        long exe_time_total = 0;
        string rev_buf = "";

        for (int i = 0; i < 100; i++)
        {
            var start = System.Diagnostics.Stopwatch.StartNew();
            rev_buf = reverse_string_via_loop(string_of_letters);
            start.Stop();
            var exe_time = start.Elapsed.Microseconds;
            exe_time_total += exe_time;
        }

        GC.Collect();
        long used_mem1 = GC.GetTotalAllocatedBytes(true);
        rev_buf = reverse_string_via_loop(string_of_letters);
        long used_mem2 = GC.GetTotalAllocatedBytes(true);
        
        long used_mem = used_mem2 - used_mem1;

        long average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 1: Reverse string via loop");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "bytes");
        Console.WriteLine("Output: " + rev_buf + "\n");

        // Case 2: Reverse string via stack

        exe_time_total = 0;

        for (int i = 0; i < 100; i++)
        {
            var start = System.Diagnostics.Stopwatch.StartNew();
            rev_buf = reverse_string_via_stack(string_of_letters);
            start.Stop();
            var exe_time = start.Elapsed.Microseconds;
            exe_time_total += exe_time;
        }

        GC.Collect();
        used_mem1 = GC.GetTotalAllocatedBytes(true);
        rev_buf = reverse_string_via_stack(string_of_letters);
        used_mem2 = GC.GetTotalAllocatedBytes(true);
        
        used_mem = used_mem2 - used_mem1;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 2: Reverse string via stack");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "bytes");
        Console.WriteLine("Output: " + rev_buf + "\n");

        // Case 3: Reverse string via recursion

        exe_time_total = 0;

        for (int i = 0; i < 100; i++)
        {
            var start = System.Diagnostics.Stopwatch.StartNew();
            rev_buf = reverse_string_via_recursion(string_of_letters);
            start.Stop();
            var exe_time = start.Elapsed.Microseconds;
            exe_time_total += exe_time;
        }

        GC.Collect();
        used_mem1 = GC.GetTotalAllocatedBytes(true);
        rev_buf = reverse_string_via_recursion(string_of_letters);
        used_mem2 = GC.GetTotalAllocatedBytes(true);
        
        used_mem = used_mem2 - used_mem1;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 3: Reverse string via recursion");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "bytes");
        Console.WriteLine("Output: " + rev_buf + "\n");

        // Case 4: Sort number list in descending order via loop

        int[] list_of_nums = [
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
        ];

        int[] rev_list_of_nums;
        exe_time_total = 0;

        for (int i = 0; i < 100; i++)
        {
            var start = System.Diagnostics.Stopwatch.StartNew();
            rev_list_of_nums = sort_list_in_descending_order(list_of_nums);
            start.Stop();
            var exe_time = start.Elapsed.Microseconds;
            exe_time_total += exe_time;
        }

        GC.Collect();
        used_mem1 = GC.GetTotalAllocatedBytes(true);
        rev_list_of_nums = sort_list_in_descending_order(list_of_nums);
        used_mem2 = GC.GetTotalAllocatedBytes(true);
        
        used_mem = used_mem2 - used_mem1;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 4: Sort number list in descending order via loop");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "bytes");
        Console.WriteLine("Output: " + rev_buf + "\n");
    }

    public static string reverse_string_via_loop(string buf)
    {
        /* 
        Time complexity: O(n)
        Space complexity: O(n)
        Auxilary space: O(1)
        */

        System.Text.StringBuilder temp_string = new System.Text.StringBuilder();

        int j = buf.Length - 1;

        for (int i = buf.Length - 1; i > -1; i--)
        { 
            temp_string.Append(buf[i]);
        }

        return temp_string.ToString();
    }

    public static string reverse_string_via_stack(string buf) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        Stack<Char> list_of_chars_original = new Stack<Char>();

        for (int i = 0; i < buf.Length; i++) {
            list_of_chars_original.Push(buf[i]);
        }

        char[] list_of_chars = new char[buf.Length];

        for (int i = 0; i < buf.Length; i++) {
            list_of_chars[i] = list_of_chars_original.Pop();
        }

        return new string(list_of_chars);
    }

    public static string reverse_string_via_recursion(string buf) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */ 

        if (buf == "") {
            return buf;
        }

        return reverse_string_via_recursion(buf.Substring(1)) + buf[0];
    }

    public static int[] sort_list_in_descending_order(int[] num_list) {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        while(true) {
            int instances_out_of_order = 0;

            for (int i = 0; i < num_list.Length-1; i++) {
                if (num_list[i] < num_list[i+1]) {
                    int small = num_list[i];
                    int large = num_list[i+1];

                    num_list[i] = large;
                    num_list[i+1] = small;

                    instances_out_of_order += 1;
                }
            }

            if (instances_out_of_order == 0) {
                break;
            }
        }

        return num_list;
    }
}
