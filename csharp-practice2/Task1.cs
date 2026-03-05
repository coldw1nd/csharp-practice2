namespace CsharpPractice;

ref struct SignalProcessor
{
    private Span<int> data;
    public SignalProcessor(int[] arr, Range range)
    {
        data = arr.AsSpan()[range];
    }

    public ref int FindCriticalPeak()
    {
        for(int i = 0; i<data.Length; i++)
        {
            if (data[i] > 1000)
            {
                return ref data[i];
            }
        }

        throw new Exception();
    }

    int Calc(Span<int> span)
    {
        int s = 0;
        foreach (var elem in span)
        {
            s += elem;
        }

        return s;
    }

    public (bool, int) AnalyzeSignature()
    {
        return data switch
        {
            [255, .. var payload, 0] => (true, Calc(payload)),
            _ => (false, 0)
        };
    }
}