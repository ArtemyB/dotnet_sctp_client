using System;

namespace Ostis.SctpDemo
{
    class Program
	{
		public static void Main (string[] args)
		{
            // ����������� ������ ����������� ������� ������ � ������ Demo.
            var demo = new Demo();
			demo.CreateNode();
		    Console.ReadKey();
		}

#warning TODO: 1. AssemblyInfo.cs - ������� ���� � ������ � ���������
#warning TODO: 2. ������� ����� � �������, ������� � ���������� ��� ������ ������
#warning TODO: 3. �������� � ���������� ������ ����������� ������
    }
}
