namespace Template.Client;

public static class Program
{
    public static void Main(string[] args)
    {
        var hypercubeEntryPoint = new Hypercube.Client.EntryPoint();
        var entryPoint = new EntryPoint();
        
        hypercubeEntryPoint.Enter(args, entryPoint.Enter);
    }
}