using System;

namespace oop_6115261020_w05
{
    class Program
    {
        static void Main(string[] args)
        {
           Building b4 = new Building ("5", "Building 4", "222", "333");
            Room r424 = new Room ("424", "Room 424", "3", "3", "computer",b4);
            Subject S = new Subject ("615261020", "ced", "3", "2", "2");
            Lecturer nathee = new Lecturer ("Tao", "naka", "lecturer");
            Section ced1 = new Section ("15", "8.00", "8.01", r424 , S , nathee );
            Console.WriteLine(r424.ToString());
            Console.WriteLine(ced1.ToString());
        }
    }
}
