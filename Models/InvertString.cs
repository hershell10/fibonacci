using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.Models
{
    public class InvertString
  {
  
    public void Main(string[] args)
    {
        Console.WriteLine("Digite uma string para inverter seus caracteres:");
        string input = Console.ReadLine();

        string invertedString = InverterString(input);

        Console.WriteLine($"String invertida: {invertedString}");
    }

    public string InverterString(string input)
    {
        char[] charArray = input.ToCharArray();
        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - 1 - i];
            charArray[length - 1 - i] = temp;
        }

        return new string(charArray);
    }
  }
}
