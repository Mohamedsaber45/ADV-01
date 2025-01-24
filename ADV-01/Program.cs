using System.Collections;
using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        #region Question 01
        //var range = new Range<int>(1,20);
        //Console.WriteLine($"Is 5 In Range ? {range.IsInRange(20)}");
        //Console.WriteLine($"The Length Of Range = {range.Length()}");
        #endregion

        #region Question 02
        //var range = new Range<int>(1, 10);
        //ArrayList numbers = new ArrayList() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //range.Reverse(numbers);
        //range.Print(numbers);
        #endregion

        #region Question 03
        //var range = new Range<int>(1, 10);
        //List<int> output = new List<int>();
        //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //range.FindEvenNumsAndReturn(numbers,out output);
        //range.Print(output);
        #endregion

        #region Questino 04
        //try
        //{
        //    FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);
        //    fixedSizeList.Add(1);
        //    fixedSizeList.Add(2);
        //    fixedSizeList.Add(3);

        //    Console.WriteLine($"Get Element Number 1: {fixedSizeList.Get(2)}");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"{ex.Message}");
        //}
        #endregion

        #region Question 05
        //try
        //{
        //    var customString = new CustomString("swiss");
        //    Console.WriteLine("First non-repeated character: " + customString.GetFirstNonRepeatedCharacter());

        //    var emptyString = new CustomString("mohamed");
        //    Console.WriteLine("First non-repeated character: " + emptyString.GetFirstNonRepeatedCharacter());
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}
        #endregion

        Console.ReadKey();  
    }
}
