using System;

class paramaterized_constructor
{
    public paramaterized_constructor(int i)
    {
        Console.WriteLine("Paramaterized constructor called" + i);
    }
    public void demo(int j)
    {
        Console.WriteLine("Default method called"+j);
    }
    static void Main()
    {
        paramaterized_constructor x = new paramaterized_constructor(200);
        x.demo(100);
    }
}