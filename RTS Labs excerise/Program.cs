// written by Mark Neves for RTS labs

public class RTSExcercise
{
    // input:
    //  An unsorted collection of integers (the list)
    //  an integer(the comparison value)
    // output:
    //  a dictionary<string, int> containing keys "above" and "below" with the corresponding count of
    //  integers from the list that are above or below the comparison value
    public static Dictionary<string, int> aboveBelow(List<int> list_int_Input, int int_Comparison)
    { 
        Dictionary<string, int> dict_aboveBelow = new Dictionary<string, int>();
        dict_aboveBelow["above"] = 0;
        dict_aboveBelow["below"] = 0;
        foreach (int i in list_int_Input)
        {
            if(i > int_Comparison)
             {
                dict_aboveBelow["above"] = dict_aboveBelow["above"] + 1;
            }
            else if( i < int_Comparison)
            {
                dict_aboveBelow["below"] = dict_aboveBelow["below"] + 1;
            }
        }
        return dict_aboveBelow;
    
    }
    // input:
    //  a string (the original string)
    //  a positive integer(the rotation amount)
    // output: a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning
    //  
    public static string stringRotation(string str_Rotate, int int_RotateAmount)
    {
        return str_Rotate.Substring(int_RotateAmount % str_Rotate.Length) + str_Rotate.Substring(0,int_RotateAmount % str_Rotate.Length);
    }

    static void Main()
    {
        // test aboveBelow
        List<int> list_int_test = new List<int>{ -1,2,311,4,5};
        int int_test = 0;
        Dictionary<string,int> dict_output = aboveBelow(list_int_test, 0);
        foreach(KeyValuePair<string,int> kvp in dict_output)
            Console.Out.WriteLine(kvp.ToString());

        // test stringRotation
        string str_test = "Hello world!";
        int_test = 5;
        Console.Out.WriteLine(stringRotation(str_test, int_test));
    }
}