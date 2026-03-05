namespace CsharpPractice;

static class StringExtension
{
    extension(string str)
    {

        public int WordCount
        {
            get
            {
                int count = 0;
                foreach (var sym in str)
                {
                    if (sym == ' ')
                    {
                        count++;
                    }
                }

                return count + 1;
            }
        }
        
        public string MaskPassword()
        {
            var s = "";
            for (int i = 0; i < str.Length; i++)
            {
                s += '*';
            }

            return s;
        }
    }

    public static bool IsHex(this string str)
    {
        foreach(var sym in str)
        {
            if (sym > '0' && sym < '9' || sym > 'A' && sym < 'F')
            {
                
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

static class ByteArrayExtension
{
    extension(byte[])
    {
        public static byte[] operator +(byte[] arr1, byte[] arr2)
        {
            byte[] arr = new byte[arr1.Length + arr2.Length];
            int j = 0;
            for (int i = 0; i < arr1.Length; i++, j++)
            {
                arr[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++, j++)
            {
                arr[j] = arr2[i];
            }

            return arr;
        }
        
        public static byte[] EmptyCustom =>  new byte[] {0};
    }
}