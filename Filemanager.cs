using System;
using System.Collections.Generic;
using System.IO;

public class Filemanager
{
	private bool InstanceFieldsInitialized = false;

	public Filemanager()
	{
		if (!InstanceFieldsInitialized)
		{
			InitializeInstanceFields();
			InstanceFieldsInitialized = true;
		}
	}

	private void InitializeInstanceFields()
	{
		FILE_PATH_FULL = FILE_PATH + FILE_NAME_EXPORT;
	}


	internal string FILE_PATH = "./Seminar6/";
	internal string FILE_NAME_EXPORT = "export.csv";
	internal string FILE_PATH_FULL;

	public virtual void fileExport(List<Phonebook> pb)
	{
		try
		{
			using (StreamWriter writer = new StreamWriter(FILE_PATH + FILE_NAME_EXPORT, false))
			{
				foreach (Phonebook i in pb)
				{
					string text = i.Name + ";" + i.Phone + ";" + i.City;
					writer.Write(text);
				}
				writer.Flush();
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
