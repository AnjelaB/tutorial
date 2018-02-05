using System;


namespace Complex
{
    //New custom type for complex numbers and required mathods.
    struct NewDouble
    {
        //every NewDouble object has it's appropriate double type number
        // field for appropriate double type number
        double x;

        //property getter and setter for x number .
        public double Number
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        
        //Constructor with one parameter.
        public NewDouble(double t)
        {
            x = t;
        }

        //Overload + operator to add two NewDouble type objects;
        public static NewDouble operator+(NewDouble operand1 , NewDouble operand2)
        {
            NewDouble add=new NewDouble(operand1.Number + operand2.Number);
            return add;
        }

        //Overload - operator to subtract two NewDouble type objects;
        public static NewDouble operator-(NewDouble operand1,NewDouble operand2)
        {
            NewDouble sub=new NewDouble(operand1.Number-operand2.Number);
            return sub;
        }

        //Overload * operator to multiply two NewDouble type objects;
        public static NewDouble operator*(NewDouble operand1,NewDouble operand2)
        {
            NewDouble Mul = new NewDouble(operand1.Number * operand2.Number);
            return Mul;
        }

        //Overload / operator to divide two NewDouble type objects;
        public static NewDouble operator/(NewDouble operand1,NewDouble opernad2)
        {
            return new NewDouble(operand1.x / opernad2.x);
        }

        //Overload > operator to compare two NewDouble type objects,and find out if operand1 > operand2.
        public static bool operator>(NewDouble operand1,NewDouble operand2)
        {
            return operand1.Number > operand2.Number;
        }

        //Overload < operator to compare two NewDouble type objects,and find out if operand1 < operand2.
        public static bool operator<(NewDouble operand1,NewDouble operand2)
        {
            return operand1.Number < operand2.Number;
        }

        //Overload <= operator to compare two NewDouble type objects,and find out if operand1 <= operand2.
        public static bool operator<=(NewDouble operand1,NewDouble operand2)
        {
            return operand1.Number <= operand2.Number;
        }

        //Overload >= operator to compare two NewDouble type objects,and find out if operand1 >= operand2.
        public static bool operator>=(NewDouble operand1,NewDouble operand2)
        {
            return operand1.Number >= operand2.Number;
        }

        //Method to calculate square root of NewDouble type object.
        public NewDouble Root()
        {
            return new NewDouble(Math.Sqrt(this.x));
        }

        //Method to print info about NewDouble type object.
        public void Printn()
        {
            Console.WriteLine(this.Number);
        }
    }
}
