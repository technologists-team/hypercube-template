namespace Template.Server;

public static class Program
{
    public static void Main(string[] args)
    {
        var hypercubeEntryPoint = new Hypercube.Server.EntryPoint();
        var entryPoint = new EntryPoint();
        
        hypercubeEntryPoint.Enter(args, entryPoint.Enter);
    }
}