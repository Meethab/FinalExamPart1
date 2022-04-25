using System;
using System.Collections;

public class FinalExamPart1
{
    public class GenericList<T>
    {
        public void Add(T item) 
        {
            Console.WriteLine(item);
        }
    }
    class TestGenericList
    {
        private class ExampleClass 
        {

        }
        public static void Main()
        {           
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            list1.Add(5);
            list1.Add(10);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Hello");

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            
        }
    }
}

