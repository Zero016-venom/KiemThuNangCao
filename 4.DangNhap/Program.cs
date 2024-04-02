using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Nhập tài khoản:");
		string username = Console.ReadLine();

		Console.WriteLine("Nhập mật khẩu (tối thiểu 6 ký tự):");
		string password = Console.ReadLine();

		if (username == "admin" && password == "admin123")
		{
			Console.WriteLine("Đăng nhập thành công!");
		}
		else if (password.Length < 6)
		{
			Console.WriteLine("Sai mật khẩu! Mật khẩu phải có ít nhất 6 ký tự.");
		}
		else
		{
			Console.WriteLine("Sai tài khoản hoặc mật khẩu!");
		}
	}
}
