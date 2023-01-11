using System.Numerics;

namespace ExponentcialCipher;

public class Cipher
{
    public static List<int> GetBlocks(string text)
    {
        List<int> blocks = new List<int>();
        if (text.Length % 2 != 0) return blocks;
        for (int i = 0; i < text.Length; i += 2)
        {
            int n1 = text[i] - 'a';
            int n2 = text[i+1] - 'a';
            string block = n1 + (n2.ToString());
            blocks.Add(Convert.ToInt32(block));
        }

        return blocks;
    }

    public static List<BigInteger> Encrypt(int e, int m, List<int> input)
    {
        List<BigInteger> result = new();
        foreach (var item in input)
        {
            result.Add(BigInteger.ModPow(item, e, m));
            
        }

        return result;
    }
}