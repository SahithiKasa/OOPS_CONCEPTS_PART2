using System;
class Father
{
    public void FatherDetails( )
    {

        Console.WriteLine($"Father:Arjun");
    }
}

class Mother
{
    public void MotherDetails()
    {
        Console.WriteLine("Mother:Anitha");
    }
}
class Child : Father
{
    public void ChildDetails()
    {
        
        Console.WriteLine("Child:Anu");
    }
    //Child creates  an instance of mother class to access its members
    Mother m = new Mother();

    public void showMotherDetails()
    {
        m.MotherDetails();

    }

    class program
    {
        static void Main()
        {
            Child c = new Child();
            c.FatherDetails();
            c.showMotherDetails();
            c.ChildDetails();
           

        }

    }
}