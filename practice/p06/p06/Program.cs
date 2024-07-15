//Fibonacci Series
int[] Fibonacci(int n)
{
    if(n <= 0) return new int[0];
    int[] fibonacciDizisi = new int[n];
    fibonacciDizisi[0] = 0;
    if(n > 1)
    fibonacciDizisi[1] = 1;
    for(int i = 2;i <= n;i++)
    {
        fibonacciDizisi[i] = fibonacciDizisi[i-1] + fibonacciDizisi[i-2];
    }
     return fibonacciDizisi;
}
Fibonacci(10);
