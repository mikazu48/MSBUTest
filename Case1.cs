
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input Alfabet (example : abcd) : ");
        string Alfabet = Console.ReadLine();
        Console.WriteLine("Input Queries (example : 1,2,3,4) : ");
        string Queries = Console.ReadLine();
        
        string[] ListPoint = GetPoint(Alfabet).Split(",");
        string[] ListQueries = Queries.Split(",");
        
        if(ListQueries.Length > ListPoint.Length) {
            Console.Write("Size of Queries more than Alfabet!");
            return;
        }
        
        string Result = "[";
        for(int i=0; i< ListQueries.Length; i++) {
            if(ListQueries[i] == ListPoint[i]) {
                Result += "Yes, ";
            }
            else {
                Result += "No, ";
            }
        }
        Result += "]";
        Console.WriteLine ("Result : " + Result.ToString());
    }
    
    private static string GetPoint(string Alfabet) {
        string ListPoint = "";
        int PrevAlfaPoint = 0;
        int TempPrev = 0;
        for(int i=0; i< Alfabet.Length; i++) {
            int CurrentPoint = GetBobot(Alfabet[i].ToString());
            
             if(TempPrev == CurrentPoint) {
                PrevAlfaPoint += CurrentPoint;
                ListPoint = ListPoint.Substring(0, ListPoint.Length - 2) + PrevAlfaPoint.ToString() + ",";
                continue;
            }
            else {
                PrevAlfaPoint = CurrentPoint;
                ListPoint += PrevAlfaPoint.ToString() + ",";
            }
            TempPrev = CurrentPoint;
        }
        
        string ResultData = ListPoint;
        if(ListPoint.Length > 2) {
            ResultData =  ListPoint.Substring(0, ListPoint.Length - 1);
        }
        return ResultData;
    }
    private static int GetBobot(string value) {
        if (value.ToLower() == "a") return 1;
        if (value.ToLower() == "b") return 2;
        if (value.ToLower() == "c") return 3;
        if (value.ToLower() == "d") return 4;
        if (value.ToLower() == "e") return 5;
        if (value.ToLower() == "f") return 6;
        if (value.ToLower() == "g") return 7;
        if (value.ToLower() == "h") return 8;
        if (value.ToLower() == "i") return 9;
        if (value.ToLower() == "j") return 10;
        if (value.ToLower() == "k") return 11;
        if (value.ToLower() == "l") return 12;
        if (value.ToLower() == "m") return 13;
        if (value.ToLower() == "n") return 14;
        if (value.ToLower() == "o") return 15;
        if (value.ToLower() == "p") return 16;
        if (value.ToLower() == "q") return 17;
        if (value.ToLower() == "r") return 18;
        if (value.ToLower() == "s") return 19;
        if (value.ToLower() == "t") return 20;
        if (value.ToLower() == "u") return 21;
        if (value.ToLower() == "v") return 22;
        if (value.ToLower() == "w") return 23;
        if (value.ToLower() == "x") return 24;
        if (value.ToLower() == "y") return 25;
        if (value.ToLower() == "z") return 26;
        else return 0;
    }
    
}