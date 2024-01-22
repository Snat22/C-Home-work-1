int EvenCount(int n){
     int Even = 0;
for(int i = n; i > 0; i /= 10){
        if(i % 10 % 2 == 0 && i % 10 != 0) Even++;
}
        return Even;
}

int OddCount(int n){
     int Odd = 0;
for(int i = n; i > 0; i /= 10){
        if((i % 10) % 2 != 0 && i % 10 != 0) Odd++;
}
        return Odd;
}
int ZerosCount(int n){
     int Zeros = 0;
for(int i = n; i > 0; i /= 10){
        if(i % 10 == 0 ) Zeros++;
}
        return Zeros;
}
int Digits(int n){
     int digits = 0;
for(int i = n; i > 0; i /= 10){
         digits++;
}
        return digits;
}

int MinDigits(int n){
for(int i = n; i > 0; i /= 10){

}
        return 0;
}
int MaxDigits(int n){
     int Max = 0;
for(int i = n; i > 0; i /= 10){
        if(i % 10 > 0) Max++;
}
        return Max;
}

int SumOfDigits(int n){
     int sum = 0;
for(int i = n; i > 0; i /= 10){
         sum+=i%10;
}
        return sum;
}
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Even :" +EvenCount(n));
System.Console.WriteLine("Odd :" +OddCount(n));
System.Console.WriteLine("Zeros :" +ZerosCount(n));
System.Console.WriteLine("Digits :" +Digits(n));
System.Console.WriteLine("Min :" +MinDigits(n));
System.Console.WriteLine("Max :" +MaxDigits(n));
System.Console.WriteLine("Sum if Digits:" +SumOfDigits(n));