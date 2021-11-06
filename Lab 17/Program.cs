using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			Console.WriteLine("Введите номера счета: ");
			string id = Console.ReadLine();
			Console.WriteLine("Введите баланс: ");
			double balance = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите ФИО: ");
			string name = Console.ReadLine();
			*/
			BankAccount<string> acc1 = new BankAccount<string>();
            BankAccount<int> acc2 = new BankAccount<int>();
			
			acc1.Enter();
			acc1.Print();
			Console.WriteLine("----------------------");
			acc2.Enter();
			acc2.Print();
		}
		class BankAccount<T>
		{
			private T Id { get; set; }
			private double Balance { get; set; }
			private string Name { get; set; }

			public void Enter()
			{
				Console.WriteLine("Введите номера счета: ");
				Id = Console.ReadLine();
				Console.WriteLine("Введите баланс: ");
				Balance = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите ФИО: ");
				Name = Console.ReadLine();
			}
			public void Print()
			{
				Console.WriteLine($"Номера счета: {Id}");
				Console.WriteLine($"Баланс: {Balance}");
				Console.WriteLine($"ФИО: {Name}");
			}

		}
	}
}
