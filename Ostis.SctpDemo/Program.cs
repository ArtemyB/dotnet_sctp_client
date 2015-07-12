using System;

namespace Ostis.SctpDemo
{
    class Program
	{
		public static void Main (string[] args)
		{
            // ����������� ������ ����������� ������� ������ � ������ Demo.
            var demo = new Demo();

		    Console.WriteLine(string.Empty);
            Console.WriteLine("�������� ���������� ��������:");
            var address = demo.CreateNode();

            Console.WriteLine(string.Empty);
            Console.WriteLine("�������� ����������� ��������� ���������� ����:");
            demo.CheckElement(address);

            Console.WriteLine(string.Empty);
            Console.WriteLine("�������� ����������� ��������:");
            address = demo.CreateNodeAsync();

            Console.WriteLine(string.Empty);
            Console.WriteLine("�������� ������������ ��������� ���������� ����:");
            demo.CheckElementAsync(address);

            Console.WriteLine(string.Empty);
            Console.WriteLine("��������� ������� ���������. ������� ����� ������� ��� ����������...");
		    Console.ReadKey();
		}
    }
}
