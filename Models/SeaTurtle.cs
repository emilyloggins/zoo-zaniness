using System;

namespace zoological_zaniness
{
    class SeaTurtle : IWalking, ISwimming
{
    int MaximumDepth { get; } = 100;

    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }

    public void Swim()
    {
        Console.WriteLine("Animal is now swimming");
    }
}
}