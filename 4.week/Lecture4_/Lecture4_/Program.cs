using System;
using System.Collections.Generic;

namespace Lecture4_
{
    
    interface ITemplate
    { 
         int InternalValue {get; set; }    //implemented as a (getter-/ setter-) method
                                        //int InternalValue; // this doesnt work since interfaces cannot contain fields
    }
  

    class FirstTemplate_A : ITemplate
    {
        public int InternalValue { get; set; }

        //Constructors
        public FirstTemplate_A() { }
        public FirstTemplate_A(int value)
        {
            this.InternalValue = value;
        }

        //ToString already exits for all classes as virtual
        public override string ToString()
        {
            return "Result of ToString() in Template A is " + this.InternalValue.ToString();
        }
    }


    //Declaration of class SecondTemplate_B 
    class SecondTemplate_B  : ITemplate
    {
        public int InternalValue { get; set; }
        
        //Constructors
        public SecondTemplate_B() { }
        public SecondTemplate_B(int value)
        {
            this.InternalValue = value;
        }

        //ToString already exits for all classes as virtual
        public override string ToString()
        {
            return "Result of ToString() in Template B is " + this.InternalValue.ToString();
        }
    }

    class LiveCodingClass
    {
        //Add Template Functions-Methods
        public static FirstTemplate_A AddTemplates(FirstTemplate_A a, FirstTemplate_A b)
        {
            return new FirstTemplate_A(a.InternalValue + b.InternalValue);
        }
        public static SecondTemplate_B AddTemplates(SecondTemplate_B a, SecondTemplate_B b)
        {
            return new SecondTemplate_B(a.InternalValue + b.InternalValue);
        }

        
        public static void GenericPrint<T, T2>(T firstArg, T2 secondArg)
        {
            Console.WriteLine("Generic function...");
            //what if we want to use functionalities of 1? This doesnt work:
            //Console.WriteLine("Internal value?: {0}", firstArg.InternalValue);
        }


        public static T GenericAdd<T>(T firstArg, T secondArg) where T: ITemplate, new()
        //public static T GenericAdd<T>(T firstArg, T secondArg) where T : FirstTemplate_A, new()
        {
            T k_obj = new T();
            k_obj.InternalValue = firstArg.InternalValue + secondArg.InternalValue;
            return k_obj;
        }



        static void Main(string[] args)
        {
            /*
            //FIRST example: generics

            var firstObj_A = new FirstTemplate_A(2);
            var secondObj_A = new FirstTemplate_A(2);
            var sum_of_objs_A = AddTemplates(firstObj_A, secondObj_A);
            Console.WriteLine("Sum of templates: " + sum_of_objs_A.ToString());


            var firstObj_B = new SecondTemplate_B(1);
            var secondObj_B = new SecondTemplate_B(2);
            var sum_of_objs_B = AddTemplates(firstObj_B, secondObj_B);
            Console.WriteLine("Sum of templates: " + sum_of_objs_B.ToString());

            //Generic Template code
            GenericPrint(firstObj_B, secondObj_B);
            var generic_sum_a = GenericAdd(firstObj_A, secondObj_A);
            Console.WriteLine("Generic sum of A templates: " + generic_sum_a.ToString());
           
            //What if we want to use the other template class? --> error because of generic constraits...
            var generic_sum_b = GenericAdd(firstObj_B, secondObj_B);
            Console.WriteLine("Generic sum of B templates: " + generic_sum_b.ToString());
            */

            //SECOND Example
            
            var obj_a1 = new FirstTemplate_A(42);
            var obj_a2 = new FirstTemplate_A(99);

            var list_a = new List<FirstTemplate_A>();
            list_a.Add(obj_a1);
            list_a.Add(obj_a2);

            for (int i = 0; i < list_a.Count; i++)    //For arrays it is actually arr.Length
            {
                Console.WriteLine(list_a[i].InternalValue);
            }

            //Add and delete elements
            list_a.Remove(obj_a1);
            var obj_a3 = new FirstTemplate_A(1000);
            list_a.Add(obj_a3);
            for (int i = 0; i < list_a.Count; i++)
            {
                Console.WriteLine(list_a[i].InternalValue);
            }


            Console.ReadKey();
        }
    }   
}
