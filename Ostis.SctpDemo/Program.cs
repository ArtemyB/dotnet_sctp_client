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

#warning TODO: ������� ����� � �������, ������� � ���������� ��� ������ ������
#warning TODO: �������� � ���������� ������ ����������� ������
    }
}
