internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double so1, so2, tong, hieu, tich, thuong;
        Console.Write("nhập số thứ nhất:");
        so1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhập số thứ hai:");
        so2 = Convert.ToDouble(Console.ReadLine());


        tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;
        Console.WriteLine("{0} + {1} = {2}", so1, so2, tong);
        Console.WriteLine("{0} - {1} = {2}", so1, so2, hieu);
        Console.WriteLine("{0} * {1} = {2}", so1, so2, tich);

        if (so2 == 0)
        {
            Console.WriteLine("không thể chia cho 0");

        }
        else
        {
            thuong = so1 / so2;
            Console.WriteLine("{0} / {1} = {2}", so1, so2, thuong);
        }
    }
}

