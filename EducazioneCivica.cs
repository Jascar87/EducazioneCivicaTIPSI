using System;
using System.Reflection;

public class EducazioneCivica
{
    private static string alfabeto = "abcdefghijklmnopqrstuvwxyz";
    public static string Esercizio1(string s, int n)
    {
        s = s.ToLower();
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (s[i] == alfabeto[j])
                {
                    int index = j + n;
                    if (index > 25)
                    {
                        index -= 26;
                    }
                    result += alfabeto[index];
                }
            }
        }
        return result;
    }
}