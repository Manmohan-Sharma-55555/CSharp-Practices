using System;
class parentclass
{
    public void parentclass1()
{
    Console.WriteLine("This is parent class method of inheritance");//4
}
    public void demoInheritance()
    {
        Console.WriteLine("This is demo method created in parent class");//3
    }
    public parentclass()
    {
        Console.WriteLine("This is the constructor called in parent class of inheritane");//Execute 1,5
    }
class childclass1 : parentclass
    {
        public childclass1()
        {
              Console.WriteLine("This is the Constructor of Childclass1");//2
        }
        class subchild : parentclass
        {
            public subchild() 
            {
                Console.WriteLine("This is the constructor of sub child class ");//4,6
            }
            
        }
        
        static void Main()
        {
            childclass1 c=new childclass1();
            c.demoInheritance();
            c.parentclass1();
            subchild c1 = new subchild();        

            
        }
    }
}