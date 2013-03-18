using System;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace com.abitech.rfid
{
	public enum Roles { repairForeman = 1, tubeMaster = 4 };

	/// <summary>
	/// Класс, хранящий данные о соединении с сервером
	/// </summary>
	public class Configuration
	{
		private string root = "HKEY_CURRENT_USER\\Software\\Abitech\\";
		public string Server;
		public string DeviceKey;
		public string Location;
		public string Language;
		public string Team;
		public Roles Role;

		public Configuration()
		{
			Server = (string)Registry.GetValue(root, "Server", String.Empty);
			DeviceKey = (string)Registry.GetValue(root, "DeviceKey", String.Empty);
			Location = (string)Registry.GetValue(root, "Location", String.Empty);
			Language = (string)Registry.GetValue(root, "Language", String.Empty);
			Team = (string)Registry.GetValue(root, "Team", String.Empty);
			Role = (Roles)Registry.GetValue(root, "Role", Roles.repairForeman);
		}

		public void Save()
		{
			Registry.SetValue(root, "Server", Server, RegistryValueKind.String);
			Registry.SetValue(root, "DeviceKey", DeviceKey, RegistryValueKind.String);
			Registry.SetValue(root, "Location", Location, RegistryValueKind.String);
			Registry.SetValue(root, "Language", Language, RegistryValueKind.String);
			Registry.SetValue(root, "Team", Team, RegistryValueKind.String);
			Registry.SetValue(root, "Role", (int)Role);
		}

		/// <summary>
		/// Сериализовать данные и сохранить
		/// </summary>
		/// <param name="path"></param>
		public void Serialize(string path)
		{
			var serializer = new XmlSerializer(typeof(Configuration));
			// File.Delete(path);
			TextWriter writer = new StreamWriter(path);
			serializer.Serialize(writer, this);
			writer.Close();
		}

		/// <summary>
		/// Мэппинг конфигурации из файла в экземпляр класса
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static Configuration Deserialize(string path)
		{
			try
			{
				var serializer = new XmlSerializer(typeof(Configuration));
				var fs = new FileStream(path, FileMode.Open);
				var conf = (Configuration)serializer.Deserialize(fs);
				fs.Close();
				return conf;
			}

			catch
			{
				var conf = new Configuration();
				conf.Serialize("config.xml");
				return null;
			}
		}
	}
}