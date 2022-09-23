using System;


internal class Program
{
   public class Stack
{
    string[] stk;
    public int top;
    public Stack(int size)
    {
        top = 0;
        stk = new string[size];
    }

    public void Push(string veri)
    {
        if (top == stk.Length)
        {
            Console.WriteLine("Stack Doludur.");
            return;
        }
        stk[top++] = veri;
    }

    public string Pop()
    {
        if(top==0)
        {
            return "Stack Boştur.";
        }
            top--;
        return stk[top];
    }


}
    static void Main()
    {

        Console.Write("Ontakı ifadesi giriniz: ");
        string yaz=Console.ReadLine();
        int uzunluk = yaz.Length;

        if(uzunluk <3)
        {
            Console.WriteLine("Hatalı girdi");
            Console.ReadKey();
            return;
        }

        Stack stack = new Stack(uzunluk);

        for(int i=uzunluk-1;i>=0;i--)
        {
            if(yaz[i] =='-' || yaz[i] == '+' || yaz[i] == '/' || yaz[i] == '*' )
            {
                if(stack.top<2)
                {
                    Console.WriteLine("Hatalı Öntaki İfadedir.");
                    Console.ReadKey();
                    return;
                }
                 string temp='(' + stack.Pop() + yaz[i] + stack.Pop() + ')';
                 stack.Push(temp);
            }
            else
                stack.Push(Convert.ToString(yaz[i]));
        }

        if (stack.top != 1)
        {
            Console.WriteLine(yaz);
            Console.ReadKey();
            return;
        }

        Console.WriteLine("İçtaki Biçimi: "+stack.Pop());
        
     Console.ReadLine();

    }
}
    

