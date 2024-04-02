public class Program
{
	public static void Main(string[] args)
	{
		int a, b;

		Console.WriteLine("Nhap so nguyen a:  ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nhap so nguyen b:  ");
		b = Convert.ToInt32(Console.ReadLine());

		int c;
		c = a * b;
		Console.WriteLine("Tich 2 so nguyen la : " + c);
	}
}