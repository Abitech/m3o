using System;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace com.abitech.rfid
{
	public enum Roles { repairForeman = 1, tubeMaster = 4 };

	/// <summary>
	/// Класс, хранящий данные о соединении с сервером
	/// </summary>
	public class ClientConfiguration
	{
		private string root = "HKEY_CURRENT_USER\\Software\\Abitech\\";
		public string Server;
		public string DeviceKey;
		public string Location;
		public string Language;
		public string Team;
		public Roles Role;

		/// <summary>
		/// Вытаскиваем из реестра настройки, необходимые для функционирования клиента
		/// Необходимы являются Server и DeviceKey
		/// Location, Team, Role можно получить запросом с сервера
		/// </summary>
		public ClientConfiguration()
		{
			Server = GetRegistryValue<string>(root, "Server", String.Empty);
			DeviceKey = GetRegistryValue<string>(root, "DeviceKey", String.Empty);
			Language = GetRegistryValue<string>(root, "Language", "ru");
		}

		private T GetRegistryValue<T>(string keyName, string valueName, T defaultValue)
		{
			try
			{
				T value = (T)Registry.GetValue(keyName, valueName, defaultValue);
				if (value == null)
				{
					return defaultValue;
				}

				return value;
			}
			catch (Exception e)
			{
				return defaultValue;
			}
		}

		public void Save()
		{
			Registry.SetValue(root, "Server", Server, RegistryValueKind.String);
			Registry.SetValue(root, "DeviceKey", DeviceKey, RegistryValueKind.String);
			Registry.SetValue(root, "Language", Language, RegistryValueKind.String);
		}
	}
}