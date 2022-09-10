namespace EloDopamine.Application;

internal static class Program {

    public static void Main()
    {
        var eloDopamine = new EloDopamine(new ConsoleLogger());
        eloDopamine.Start();
    }
    
}