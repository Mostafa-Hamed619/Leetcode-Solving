//using NeetCode.Easy.Arrays;

//_1768_Merge_Strings_Alternately prog = new _1768_Merge_Strings_Alternately();
//Console.WriteLine(prog.MergeAlternately("ab", "pqrs"));

#region Abstraction Implements Encapsulation


//Employee Emp = new Employee();

//Emp.Validate();

//public class Employee
//{
//    public string Name { get; set; }
//    public string Address { get; set; }

//    public void Validate()
//    {
//        CheckName();
//        CheckAddress();
//    }

//    private void CheckName()
//    {
//        Console.WriteLine("Hello from Name Checker");
//    }

//    private void CheckAddress()
//    {
//        Console.WriteLine("Hello from Address Checker");
//    }
//}
#endregion

#region Operator Overloading

//public class SomeClass
//{
//    public int SomeValue { get; set; }
//    public SomeClass(int val)
//    {
//        SomeValue = val;
//    }

//    public static SomeClass operator +(SomeClass a, SomeClass b)
//    {
//        return new SomeClass(a.SomeValue + b.SomeValue);
//    }


//}


#endregion


using NeetCode.Easy.Dictionary;

Find_the_Difference_of_Two_Arrays_2215 prog = new();

int[] num1 = { 1, 2, 3 }; int[] num2 = { 2, 4, 6 };

Console.WriteLine(prog.FindDifference(num1, num2));