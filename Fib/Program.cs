
global::System.
    Console.WriteLine("Введите число из числового порядка Фибаначчи чтобы узнать его порядок");
string a = Console.ReadLine();
int b = int.Parse(a);
int first = 0;
int second = 1;
int result = 0;
int count = 0;
void fub(int b)
{
    for (int i = 0;; i++)
    {

        result = first + second;
        first = second;
        second =result;
        count++;


        if (result == b)
        {
            Console.WriteLine($"Число в последовательности - {count+2}");
            break;
        }
      


    }
    
}
fub(b);
