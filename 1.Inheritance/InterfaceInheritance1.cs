
namespace InterfaceInheticanceBasics
{

    //declare not implement
    interface Interface1
    {
        //memeber declarations no implementison like a class
        string getLocation();
        string EmpName { get; set; }
        //int _id;
        // no fields no consturcors
        //every member in interface by defualt public
    }


    interface Inteface2
    {
        string getLocationByID(int id);
        int empGetAge();

    }

    interface Interface3 : Interface1, Inteface2
    {
        string getAdress();  // all members of interace1 and interface2 as well.
    }


}