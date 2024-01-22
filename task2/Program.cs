char CheckGrade(int grade){
    if(grade >= 90 && grade <= 100)
    return 'A';
       else if(grade >= 80 && grade <= 89)
    return 'B';
       else if(grade >= 70 && grade <= 79)
    return 'C';
      else if(grade >= 60 && grade <= 69)
    return 'D';
       else 
       {
       return 'F';
       }
    
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckGrade(a));