using System;

class NonNegativeException : Exception {
    public NonNegativeException() : base("n and p should be non-negative") { }
}

class Calculator {
    public int power(int n, int p) {
        if (n < 0 || p < 0)
            throw new NonNegativeException();
        var s = Math.Pow(n, p);
        return (int)s;
    }
}

class Solution {
    static void Main(String[] args) {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while(T-->0) {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try {
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e) {
               Console.WriteLine(e.Message);
            }
        }
    }
}