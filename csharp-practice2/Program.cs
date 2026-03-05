using CsharpPractice;
using ByteArray = byte[];

RunTask1();
RunTask2();
RunTask3();
RunTask4();

static void RunTask1()
{
    var signalprocessor = new SignalProcessor(new int[] {0, 0, 255, 100 ,500,1500, 0}, 2..);

    ref int peak = ref signalprocessor.FindCriticalPeak();
    peak = 3000;
    (_, var payload) = signalprocessor.AnalyzeSignature();
    Console.WriteLine(payload);
}

static void RunTask2()
{
    Transaction t =  new Transaction() {Amount = 15000, Currency = "USD"};
    string Validate(Transaction t)
    {
        return t switch
        {
            { Currency: "USD" } and { Amount: >= 10000 } => "Blocked",
            { Amount: < 0 } and { Currency: "" } => "Error",
            { Status: not "Blocked" and not "Error" } => "Approved",
            _ => "Pending"
        };
    }
    
    string status = Validate(t);
    Console.WriteLine(status);
}

static void RunTask3()
{
    var request = new Request() {Method = "GET", Path = "api/data", Role="Admin"};
    var route = Route(request);
    request.LogRoute(route);
    
    string Route(Request request)
    {
        return request switch
        {
            ("GET", "api/data", _) => "DataServer",
            ("POST", "api/admin", "Admin") => "AdminServer",
            (var method, var path, _) => $"Unknown: {method} {path}"
        };
    }
}

static void RunTask4()
{
    string str = "abac";
    var newstr = str.MaskPassword();
    Console.WriteLine(newstr);
    byte[] arr1 = {1,2,3,4};
    byte[] arr2 = { 5, 6, 7 };
    byte[] arr = arr1 + arr2;
    foreach(var elem in arr)
    {
        Console.WriteLine(elem);
    }
    Console.WriteLine(ByteArray.EmptyCustom[0]);
}
