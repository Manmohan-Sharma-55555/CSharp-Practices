using System;
class Class1
{
    public Class1(int i)
    {
        Console.WriteLine("This is the parent class Constructor Value:"+i);
        
    }
}
class Class2 : Class1
{
    public Class2(int y) : base(y)
    {
        Console.WriteLine("This is Class2 constructor:" +y);
    }
    static void Main()
    {
        Class2 class2 = new Class2(90);   
    }
}
