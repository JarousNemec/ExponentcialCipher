using System.Numerics;
using ExponentcialCipher;

var b1 = 2114;
var b2 = 1014;
int e = 29;
int m = 2633;
var blocks = Cipher.GetBlocks("voko");
foreach (var block in Cipher.Encrypt(e, m, blocks))
{
    Console.WriteLine(block);
}


var res = ExtendedEuclideanAlgorithm.Calculate(29, 2633);
Console.WriteLine(res);


Console.ReadKey();