using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class ImplicitGeometry
    {
        public abstract bool IsInside(double x, double y);
        public void Visualize(double xGrid, double yGrid)
        {
            for (double y= yGrid; y >= 0; y--)
            {
                for (double x = 0; x<= xGrid; x++)
                {
                    if (IsInside(x, y))
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    //Console.Write("#");
                    //Console.Write($"({x},{y})");
                }
                Console.Write('\n');
            }
        }  
    }
    public class Rectangle : ImplicitGeometry
    {
        public double widthX1;
        public double widthX2;
        public double widthY1;
        public double widthY2;

        public Rectangle(double widthX1, double widthX2, double widthY1, double widthY2)
        {
            this.widthX1 = widthX1;
            this.widthX2 = widthX2;
            this.widthY1 = widthY1;
            this.widthY2 = widthY2;
        }
        public override bool IsInside(double x, double y)
        {
        if ( widthX1 <= x && widthX2 >= x && widthY1 <= y && widthY2 >= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public abstract class Operation : ImplicitGeometry
    {
        public Operation(ImplicitGeometry operand1, ImplicitGeometry operand2)
        {

        }
    }
    public class Circle : ImplicitGeometry
    {
        public double xCenter;
        public double yCenter;
        public double radius;
        public Circle(double xCenter, double yCenter, double radius)
        {
            this.xCenter = xCenter;
            this.yCenter = yCenter;
            this.radius = radius;
        }
        public override bool IsInside(double x, double y)
        {
            if ((x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= radius * radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Union : Operation
    {
        public ImplicitGeometry operand1;
        public ImplicitGeometry operand2;
        
        public Union(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x, y) |operand2.IsInside(x, y);
        }
    }
    public class Difference : Operation
    {
        public ImplicitGeometry operand1;
        public ImplicitGeometry operand2;
        
        public Difference(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x, y) && !operand2.IsInside(x,y);
        }
    }
    public class Intersection : Operation
    {
        public ImplicitGeometry operand1;
        public ImplicitGeometry operand2;

        public Intersection(ImplicitGeometry operand1, ImplicitGeometry operand2) :base(operand1, operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
        public override bool IsInside(double x, double y)
        {
            return operand1.IsInside(x,y) && operand2.IsInside(x,y);
        }
    }
}
