using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_s_sharp_Operator_overload
{

    public class Square
    {
        private int A;
        public Square()
        {
            this.A = 1;
        }
        public Square(int length): this()
        {
            if(length>0)
            this.A = length;
        }

        public override string ToString()
        {
            return $"length: {A}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Square square &&
                   A == square.A;
        }

        public override int GetHashCode()
        {
            return -862436692 + A.GetHashCode();
        }

        public static Square operator ++(Square obj)
        {
            obj.A++;  
            return obj;
        }

        public static Square operator --(Square obj)
        {
            obj.A--;

            return obj;
        }

        public static Square operator +(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                A = p1.A + p2.A,
              
            };
            return p3;
        }

        public static Square operator -(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                A = p1.A - p2.A,

            };
            return p3;
        }

        public static Square operator *(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                A = p1.A * p2.A,

            };
            return p3;
        }
        public static Square operator /(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                A = p1.A / p2.A,

            };
            return p3;
        }
        public static bool operator ==(Square p1, Square p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Square p1, Square p2)
        {
            return !(p1 == p2);
        }

      

        public static bool operator >(Square p1, Square p2)
        {
            return p1.A > p2.A;
        }
       
        public static bool operator <(Square p1, Square p2)
        {
            return !(p1 > p2);
        }
​
        public static bool operator >=(Square p1, Square p2)
        {
            return p1.A >= p2.A;
        }
       
        public static bool operator <=(Square p1, Square p2)
        {
            return !(p1 >= p2);
        }

        public static bool operator true(Square p)
        {
            return p.A > 0 ;
        }
       
        public static bool operator false(Square p)
        {
            return p.A <= 0 ;
        }

        public static implicit operator Rectangle(Square p1)
        {
            return new Rectangle(p1.A,1);
        }

        public static implicit operator int(Square p)
        {
            return p.A;
        }
        

    }
    public class Rectangle
    {
        private int A;
        private int B;

        public Rectangle()
        {
            this.A = 1;
            this.B = 1;
        }
        public Rectangle(int length , int height) : this()
        {
            if (length > 0)
                this.A = length;
            if (height > 0)
                this.B = height;
        }
        public override string ToString()
        {
            return $"length: {A}\n"+
                   $"height: {B}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   A == rectangle.A &&
                   B == rectangle.B;
        }

        public override int GetHashCode()
        {
            int hashCode = -1817952719;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }

        public static Rectangle operator ++(Rectangle obj)
        {
            obj.A++;
            obj.B++;
            return obj;
        }

        public static Rectangle operator --(Rectangle obj)
        {
            obj.A--;
            obj.B--;
            return obj;
        }

        public static Rectangle operator +(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                A = p1.A + p2.A,
                B = p1.B + p2.B

            };
            return p3;
        }

        public static Rectangle operator -(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                A = p1.A - p2.A,
                B = p1.B - p2.B
            };
            return p3;
        }

        public static Rectangle operator* (Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                A = p1.A * p2.A,
                B = p1.B * p2.B

            };
            return p3;
        }
        public static Rectangle operator /(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                A = p1.A / p2.A,
                B = p1.B / p2.B
            };
            return p3;
        }
        public static bool operator ==(Rectangle p1, Rectangle p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Rectangle p1, Rectangle p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Rectangle p1, Rectangle p2)
        {
            return p1.A + p1.B > p2.A + p1.B;
        }

        public static bool operator <(Rectangle p1, Rectangle p2)
        {
            return !(p1 > p2);
        }
​
        public static bool operator >=(Rectangle p1, Rectangle p2)
        {
            return p1.A >= p2.A;
        }

        public static bool operator <=(Rectangle p1, Rectangle p2)
        {
            return !(p1 >= p2);
        }

        public static bool operator true(Rectangle p)
        {
            return p.A > 0 && p.B > 0;
        }
      
        public static bool operator false(Rectangle p)
        {
            return p.A <= 0 || p.B <= 0;
        }

        public static explicit operator Square(Rectangle p1)
        {
            return new Square(p1.A+ p1.B);
        }

        public static explicit operator int(Rectangle p)
        {
            return p.A + p.B;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
