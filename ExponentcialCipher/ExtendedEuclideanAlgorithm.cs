namespace ExponentcialCipher;

public class ExtendedEuclideanAlgorithm
{
    public static int Calculate(int exponent, int modulo)
    {
        modulo--;
        List<Expression> procedure = new List<Expression>();
        procedure.Add(new Expression(modulo, 0,0,0,exponent));
        procedure.Add(new Expression(procedure[^1].Residue, 1,1,-((int)(procedure[^1].Left/procedure[^1].Residue)),CalculateResidue(procedure)));
        int residue;
        do
        {
            residue = CalculateResidue(procedure);
            procedure.Add(new Expression(procedure[^1].Residue, CalculateResult(procedure),1,-((int)(procedure[^1].Left/procedure[^1].Residue)),residue));
        } while (residue!=1);

        int result = CalculateResult(procedure);
        
        if (result*(-1)>0)
        {
            return result + modulo;
        }
        return result;
    }

    private static int CalculateResidue(List<Expression> procedure)
    {
        return 1 * procedure[^1].Left -
               (procedure[^1].Left / procedure[^1].Residue) * procedure[^1].Residue;
    }

    private static int CalculateResult(List<Expression> procedure)
    {
        return procedure[^1].TimesL*procedure[^2].Result+procedure[^1].TimesR*procedure[^1].Result;
    }
}

internal class Expression
{
    public Expression(int left, int result, int timesL, int timesR, int residue)
    {
        Left = left;
        Result = result;
        TimesL = timesL;
        TimesR = timesR;
        Residue = residue;
    }

    public int Left { get; init; }
    public int Result { get; private set; }

    public int TimesL { get; private set; }

    public int TimesR { get; private set; }

    public int Residue { get; set; }
}