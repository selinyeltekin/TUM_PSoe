using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment1_Ben
{
    public abstract class ImplicitGeometry
    {
        //abstract method of isinside
        public abstract bool IsInside(double x, double y);
        
        //method of visualize
        public void Visualize(double[] xGrid, double[] yGrid)
        {
            double xMin = xGrid[0];
            double yMin = yGrid[0];
            double xMax = xGrid[1];
            double yMax = yGrid[1];

            for (double y = yMax; y >= 0; y--)
            {
                for(double x = 0; x <= xMax; x++)
                {
                    if (IsInside(x,y))
                    {
                  //Console.Write($"({x},{y})");
                  Console.Write(" X");
                    }
                    else
                    {
                     Console.Write(" ");
                    }
                    //Console.Write($"({x},{y})");
                }
                Console.Write("\n");
            }
        }
    }


    //CIRCLE

    public class Circle : ImplicitGeometry
    {
        public double xCenter;
        public double yCenter;
        public double radius;

        //constructor
        public Circle(double xCenter, double yCenter, double radius)
        {
            this.xCenter = xCenter;
            this.yCenter = yCenter;
            this.radius = radius;

        }

        public override bool IsInside(double x, double y)
        {
            return false;

        }
    }



    //RECTANGLE
    public class Rectangle : ImplicitGeometry
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;

        //constructor
        public Rectangle(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override bool IsInside(double x, double y)
        {
            if (y1 <= y && y <= y2)
            {
                if(x1 <= x && x <= x2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    //OPERATION
    public abstract class Operation : ImplicitGeometry
    {
        //abstract class olduğu için sadece içi boş tanım yaptık.
        public ImplicitGeometry operand1, operand2;

        //constructor
        public Operation(ImplicitGeometry operand1, ImplicitGeometry operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }   
    }


    //UNION
    public class Union : Operation
    {
        
        public Union(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2) { }
        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x, y) | operand2.IsInside(x, y);
        }
    }

    //INTERSECTION
    public class Intersection : Operation
    {
        public Intersection(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2) { }

        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x, y) & operand2.IsInside(x, y);
        }
    }
    //DIFFERENCE
    public class Difference : Operation
    {
        public Difference(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2) { }
        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x,y) & operand2.IsInside(x,y);

        }
    }

}
