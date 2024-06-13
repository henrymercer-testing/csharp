using System;

if (true)
{
    Random random = new Random();
    string password = "random" + random.Next();
}

class C
{
    public static void M()
    {
        C.M();
    }
}
