/* 
   - Should have atleast 1 interface & 3 different types of properties  
   - should have 3/4 things : Instance Methods, Properties , events & indexers
   - Make sure the instances of this class in the main
*/
using System;

namespace FirstProgram
{
    //Interface - Is like a class but its a contract b/w the obj & user(cant give values,define data) 
    interface MyInterface
    {
        string Name { get; set; }
        int Jersey { get; set; }
        string Playerpostion { get; set; }
    }

    //class can inhert an interface
    class Basketball: MyInterface
    {

        private string name = "Jade";
        private int jer_num = 3;
        private string pos = "pointguard";

        public string Name
        {
            get { return name; }
            //set { name = value; }
            set
            {
                if (value == "Jade")
                    name = value;
            }
        }
        public int Jersey
        {
            get { return jer_num; }
            
            set
            {
                if (value == 3)
                    jer_num= value;
            }
        }

        public string Playerpostion
        {
            get { return pos; }

            set
            {
                if (value == "pointguard")
                    pos = value;
            }
        }

        static void Main(string[] args)
        {
            Basketball p1 = new Basketball();
            p1.Name = "Jade";
            Console.WriteLine(p1.Name);

            Basketball p2 = new Basketball();
            p2.Jersey=3 ;
            Console.WriteLine(p1.Jersey);

            Basketball p3 = new Basketball();
            p2.Playerpostion = "pointguard";
            Console.WriteLine(p1.Playerpostion);
        }

    }
}