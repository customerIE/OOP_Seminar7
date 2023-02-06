using System;

public class Menu
{
	public static void mainMenu()
	{
		Console.WriteLine("1 - Отобразить справочник");
		Console.WriteLine("2 - Выгрузить данные");
		Console.WriteLine("3 - Загрузить данные");
		Console.WriteLine(". ", 15);
		Console.Write("Выберите действие: ");
		int input = Convert.ToInt32(Console.ReadLine());
		
		Filemanager run = new Filemanager();
		Addressbook phones = new Addressbook();
		phones.addressBook();

		switch (input)
		{
			case 1:
				phones.showAddressBook();
				break;
			case 2:
				phones.addressBook();
				run.fileExport(phones.pb);
				Console.WriteLine("Экспорт выполнен.");
				break;
			case 3:
				phones.addressBook();
				phones.showAddressBook();
				break;
		}
	}
}