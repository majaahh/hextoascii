using System;

public class Program {
    static void Main(string[] args) {
        foreach (var arg in args) {
            string hex = arg;
            string output = "";

            for (int i = 0; i < hex.Length; i += 2) {
                string chunk = hex.Substring(i, 2);
                int dec = Convert.ToInt32(chunk, 16);

                output += ((char)dec);
            }
            Console.WriteLine(output);
        }
    }
}
