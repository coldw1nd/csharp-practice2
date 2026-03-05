namespace CsharpPractice;

partial class Transaction
{
    public int Amount { get; set; }
    public string Currency { get; set; }
    public partial string Status { get; set; }
}

partial class Transaction
{
    private string _status = "New";

    public partial string Status
    {
        get => _status;
        set => _status = value;
    }
}
