using System;
using System.Collections.Generic;

public class Addressbook
{

	public List<Phonebook> pb = new List<Phonebook>();
	public virtual void addressBook()
	{
		pb.Add(new Phonebook("Сафонов Игорь Сергеевич", "9189775563", "Воронеж"));
		pb.Add(new Phonebook("Соболев Игорь Аркадьевич", "9997775522", "Пермь"));
	}

	public virtual void showAddressBook()
	{
		foreach (Phonebook i in pb)
		{
			Console.WriteLine(i.Name + " " + i.Phone + " " + i.City);
		}
	}
}