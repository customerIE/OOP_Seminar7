public class Phonebook
{
	internal string Name;
	internal string Phone;
	internal string City;

	public Phonebook(string name, string phone, string city)
	{
		this.Name = name;
		this.Phone = phone;
		this.City = city;
	}

	public virtual string Name1
	{
		get
		{
			return Name;
		}
		set
		{
			Name = value;
		}
	}

	public virtual string Phone1
	{
		get
		{
			return Phone;
		}
		set
		{
			Phone = value;
		}
	}
	public virtual string City1
	{
		get
		{
			return City;
		}
		set
		{
			City = value;
		}
	}

}