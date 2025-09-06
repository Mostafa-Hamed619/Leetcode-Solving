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

LongestHarmoniousSubsequence594 prog = new();

int[] nums = { 1, 1, 1, 1 };
Console.WriteLine(prog.FindLHS(nums));