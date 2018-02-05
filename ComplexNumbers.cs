using System;



namespace Complex
{
    class ComplexNumbers
    {
        NewDouble re;       //field for real number of complex number
        NewDouble im;       //field for imaginary number of complex number

        //Property for geting or setting real number .
        public NewDouble Real
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        //Property for getting or setting imaginary number.
        public NewDouble Imaginary
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        //Constructor for Complex Numbers with 2 parameters
        public ComplexNumbers(NewDouble re1,NewDouble im1)  
        {
            re = re1;
            im = im1;
        }

        //Constructor without parameters
        public ComplexNumbers()
        {
            re = new NewDouble();
            im = new NewDouble();
        }

        // Overload + operator to add two ComplexNumbers objects.
        public static ComplexNumbers operator+(ComplexNumbers operand1,ComplexNumbers operand2)
        {
            ComplexNumbers add=new ComplexNumbers(operand1.re + operand2.re,operand1.im+operand2.im);
            return add;
        }

        //Overload - operator to subtract two ComplexNumbers objects.
        public static ComplexNumbers operator-(ComplexNumbers operand1, ComplexNumbers operand2)
        {
            ComplexNumbers sub = new ComplexNumbers(operand1.re - operand2.re, operand1.im - operand2.im);
            return sub;
        }

        //Overload * operator to multiply two ComplexNumbers objects.
        public static ComplexNumbers operator*(ComplexNumbers operand1,ComplexNumbers operand2)
        {
            NewDouble re = operand1.re * operand2.re - operand1.im * operand2.im;
            NewDouble im = operand1.im * operand2.re + operand1.re * operand2.im;
            return new ComplexNumbers(re, im);
        }

        //Overload / operator to divide two ComplexNumbers objects.
        public static ComplexNumbers operator/(ComplexNumbers operand1,ComplexNumbers operand2)
        {
            NewDouble re = (operand1.re * operand2.re + operand1.im * operand2.im) / (operand2.re * operand2.re + operand2.im * operand2.im);
            NewDouble im = (operand1.im * operand2.re - operand1.re * operand2.im) / (operand2.re * operand2.re + operand2.im * operand2.im);
            return new ComplexNumbers(re, im);
        }

        //Method to get Absolute value of complex number.
        public NewDouble Absolute()
        {
            NewDouble k = this.re * this.re + this.im * this.im;
            return k.Root();
        }

        //Method to get Argument of complex number.
        public NewDouble Arg()
        {
            return new NewDouble(Math.Atan2(re.Number,im.Number)); 
        }

        //Method to print Complex numbers with it's real and imaginary numbers.
        public void Printf()
        {
            if (im.Number > 0 && re.Number != 0)
                Console.WriteLine(re.Number + "+" + im.Number + "i");
            else if (im.Number < 0 && re.Number != 0)
                Console.WriteLine(re.Number + "" + im.Number + "i");
            else if (im.Number == 0)
                Console.WriteLine(re.Number);
            else if (re.Number == 0)
                Console.WriteLine(im.Number + "i");
            
        }

    }
}
