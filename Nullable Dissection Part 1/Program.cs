using System;

//ref link:https://www.youtube.com/watch?v=CLpCkitRu_8&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=21
//

class MainClass
{
    static void Main()
    {
        int? i = 5;
        JNullable<int> jamieI =  new JNullable<int>(5);
        Console.WriteLine(i);
        Console.WriteLine(jamieI);
        //Nullable<int> j = 6;
        //int? sum = i + j;
        //Console.WriteLine(sum);
        i = null;
        jamieI = new JNullable<int>();
    }
}