int n = Convert.ToInt32(Console.ReadLine());
int negative = 0, positiv = 0, zeros = 0, odd=0,sum=0 ,min = 1234567, max = -1234567, even=0;
int [] arr = new int[n];
for(int i = 0 ; i < n; i++){
  arr[i] = Convert.ToInt32(Console.ReadLine());

     if( arr[i] < 0) negative++;
  if( arr[i] > 0) positiv++;
 if( arr[i] %2==0) even++;
if( arr[i] %2!= 0) odd++;
if( arr[i] < min) min = arr[i];
 if( arr[i] > max) max = arr[i];

      sum= sum+ arr[i];




}
Console.WriteLine("Negative = " +negative);
Console.WriteLine(" Positive = " + positiv);
Console.WriteLine("Zeros = " +zeros);
Console.WriteLine("Even = " +even);
Console.WriteLine("Odd = " +odd);
Console.WriteLine("Max = " +max);
Console.WriteLine("Max = " +min);
Console.WriteLine("Sum of Digits = " +sum );


