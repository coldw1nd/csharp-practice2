namespace CsharpPractice;

partial class Request
{
    public string Method { get; set; }
    public string Path { get; set; }
    public string Role { get; set; }
    public partial void LogRoute(string destination);
}

partial class Request
{
    public void Deconstruct(out string method, out string path, out string role)
    {
        method = Method;
        path = Path;
        role = Role;
    }

    public partial void LogRoute(string destination)
    {
        Console.WriteLine($"[LOG] {Method} {Path} ---> {destination}");
    }
}