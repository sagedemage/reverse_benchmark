using System.Runtime.CompilerServices;
using System.Text;

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
        double used_mem1 = GC.GetTotalAllocatedBytes(true);
        rev_buf = reverse_string_via_loop(string_of_letters);
        double used_mem2 = GC.GetTotalAllocatedBytes(true);

        double used_mem = Math.Round((used_mem2 - used_mem1) / 1024 * 1000) / 1000;

        long average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 1: Reverse string via loop");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "KiB");
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

        used_mem = Math.Round((used_mem2 - used_mem1) / 1024 * 1000) / 1000;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 2: Reverse string via stack");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "KiB");
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

        used_mem = Math.Round((used_mem2 - used_mem1) / 1024 * 1000) / 1000;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 3: Reverse string via recursion");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "KiB");
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

        used_mem = Math.Round((used_mem2 - used_mem1) / 1024 * 1000) / 1000;

        average_exe_time = exe_time_total / 100;

        Console.WriteLine("Case 4: Sort number list in descending order via loop");
        Console.WriteLine("Average execution time: " + average_exe_time + "us");
        Console.WriteLine("Memory usage: " + used_mem + "KiB");
        Console.WriteLine("Output: ");
        Console.WriteLine(convert_list_to_string(rev_list_of_nums));
    }

    public static string reverse_string_via_loop(string buf)
    {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxilary space: O(1)
        */

        System.Text.StringBuilder temp_string = new System.Text.StringBuilder();

        for (int i = buf.Length - 1; i > -1; i--)
        {
            temp_string.Append(buf[i]);
        }

        return temp_string.ToString();
    }

    public static string reverse_string_via_stack(string buf)
    {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        Stack<Char> list_of_chars_original = new Stack<Char>();

        for (int i = 0; i < buf.Length; i++)
        {
            list_of_chars_original.Push(buf[i]);
        }

        char[] list_of_chars = new char[buf.Length];

        for (int i = 0; i < buf.Length; i++)
        {
            list_of_chars[i] = list_of_chars_original.Pop();
        }

        return new string(list_of_chars);
    }

    public static string reverse_string_via_recursion(string buf)
    {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        if (buf == "")
        {
            return buf;
        }

        return reverse_string_via_recursion(buf.Substring(1)) + buf[0];
    }

    public static int[] sort_list_in_descending_order(int[] num_list)
    {
        /*
        Time complexity: O(n)
        Space complexity: O(n)
        Auxiliary space: O(n)
        */

        for (int i = 0; i < num_list.Length; i++)
        {
            bool instances_out_of_order = false;

            for (int j = 0; j < num_list.Length - 1; j++)
            {
                if (num_list[j] < num_list[j + 1])
                {
                    int small = num_list[j];
                    int large = num_list[j + 1];

                    num_list[j] = large;
                    num_list[j + 1] = small;

                    instances_out_of_order = true;
                }
            }

            if (!instances_out_of_order)
            {
                break;
            }
        }

        return num_list;
    }

    public static string convert_list_to_string(int[] list_of_nums)
    {
        StringBuilder list_of_nums_string = new StringBuilder("[");

        for (int i = 0; i < list_of_nums.Length; i++)
        {
            list_of_nums_string.Append(list_of_nums[i]);

            if (i != list_of_nums.Length - 1)
            {
                list_of_nums_string.Append(", ");
            }

            else
            {
                list_of_nums_string.Append("]");
            }
        }
        return list_of_nums_string.ToString();
    }
}
