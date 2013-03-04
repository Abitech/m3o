﻿using System;
using System.Xml.Serialization;
using System.IO;

namespace com.abitech.rfid
{
    public enum Roles { repairForeman = 1, tubeMaster = 4 };

    /// <summary>
    /// Класс, хранящий данные о соединении с сервером
    /// </summary>
    public class Configuration
    {
        public string Server;
        public string DeviceKey;
        public string Location;
        public string Language;
        public string Team;
        public Roles Role;

        public Configuration()
        {
            Role = Roles.repairForeman;
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