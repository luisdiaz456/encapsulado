using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
	internal class Program
	{
		class Celular
		{
			private string contraseña = "1234";

			public void Desbloquear(string intento)
			{
				if (intento == contraseña)
				{
					Console.WriteLine("Celular desbloqueado.");
				}
				else
				{
					Console.WriteLine("Contraseña incorrecta.");
				}
			}
		}

		static void Main(string[] args)
		{
			Celular miCelular = new Celular();

			Console.Write("Ingrese la contraseña: ");
			string intento = Console.ReadLine();

			miCelular.Desbloquear(intento);

			Console.ReadKey(); // Para que la consola no se cierre inmediatamente
		}
	}
}
