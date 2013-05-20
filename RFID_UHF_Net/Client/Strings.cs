using System;

using System.Collections.Generic;
using System.Text;
using com.abitech.rfid;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace RFID_UHF_Net
{
	/// <summary>
	/// Интернационализация (i8n)
	/// </summary>
	/// <remarks>
	/// Придумать способ сериализовать Dictionary в XML.
	/// Не говоря уже о Dictionary<string, Dictionary<string, string>>
	/// Можно было бы использовать Tuple<string, string, string>,
	/// но в Compact Edition он отсутствует, да и появился только в .NET 4.0
	/// </remarks>
    public class Strings
    {
        private Dictionary<string, Dictionary<string, string>> strings = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<string, string> current;

        public Strings(params string[] languages)
        {
            foreach (var language in languages)
            {
                strings.Add(language, new Dictionary<string, string>());
            }
        }

        public void SetLanguage(string language)
        {
			if (strings.ContainsKey(language))
			{
				current = strings[language];
			}
        }

        public void Add(string language, string stringName, string @string)
        {
            var current = strings[language];
            if (current.ContainsKey(stringName))
            {
                MessageBox.Show("Ключ " + stringName + "уже внесен в список");
                return;
            }
            current.Add(stringName, @string);
        }

        public string this[string stringName]
        {
            get
            {
                if (current.ContainsKey(stringName) == false)
                {
                    MessageBox.Show("Ключ " + stringName + "не найден");
                    return String.Empty;
                }
                return current[stringName];
            }
        }
    }

    public static class i8n
    {
        static public Strings strings;

        static public void Init()
        {
            strings = new Strings("kz", "ru");

            strings.SetLanguage("ru");


            //Main

            strings.Add("ru", "newRepair", "Новый ремонт");
			strings.Add("kz", "newRepair", "Жаңа жөндеу жұмысы");

			strings.Add("ru", "newAct", "Новый акт");
			strings.Add("kz", "newAct", "Жаңа акт");

            strings.Add("ru", "newOrder", "Новая заявка");
            strings.Add("kz", "newOrder", "Жаңа тапсырыс");

            strings.Add("ru", "orderList", "Список заявок");
            strings.Add("kz", "orderList", "Тапсырыстар тізімі");

            strings.Add("ru", "orderHistory", "Журнал заявок");
            strings.Add("kz", "orderHistory", "Тапсырыстар журналы");

            strings.Add("ru", "team", "Бригада №");
            strings.Add("kz", "team", "Бригада №");

			//

			strings.Add("ru", "technicalAssistanceNeeded", "Требуется техническая поддержка.");
			strings.Add("kz", "technicalAssistanceNeeded", "Требуется техническая поддержка.");

			strings.Add("ru", "clientConfigurationMissing", "Настройки соединения отсутствуют.");
			strings.Add("kz", "clientConfigurationMissing", "Настройки соединения отсутствуют.");

			strings.Add("ru", "readerNotReady", "Требуется перезагрузка считывателя.");
			strings.Add("kz", "readerNotReady", "Требуется перезагрузка считывателя.");

			strings.Add("ru", "waitForConnection", "Установка соединения. Ждите...");
			strings.Add("kz", "waitForConnection", "Установка соединения Ждите...");

			strings.Add("ru", "connectionFailure", "Связь не установлена.");
			strings.Add("kz", "connectionFailure", "Связь не установлена.");

			strings.Add("ru", "masterCardReadingStatusSuccess", "Мастер-карта считана.");
			strings.Add("kz", "masterCardReadingStatusSuccess", "Мастер-карта считана.");

			strings.Add("ru", "masterCardReadingStatusFailure", "Не удалось считать мастер-карту. Повторите.");
			strings.Add("kz", "masterCardReadingStatusFailure", "Не удалось считать мастер-карту. Повторите.");

			strings.Add("ru", "serverLocationUrlMissing", "Введите адрес сервера.");
			strings.Add("kz", "serverLocationUrlMissing", "Введите адрес сервера.");

			strings.Add("ru", "getDeviceListFailure", "Не удалось получить список устройств. Повторите.");
			strings.Add("kz", "getDeviceListFailure", "Не удалось получить список устройств. Повторите.");

			strings.Add("ru", "getNewDeviceKeyFailure", "Не удалось получить новый ключ устройства. Повторите.");
			strings.Add("kz", "getNewDeviceKeyFailure", "Не удалось получить новый ключ устройства. Повторите.");

			strings.Add("ru", "getNewDeviceKeySuccess", "Новый ключ устройства получен и сохранён.");
			strings.Add("kz", "getNewDeviceKeySuccess", "Новый ключ устройства получен и сохранён.");

			strings.Add("ru", "getDeviceDescriptionSuccess", "Данные о бригаде получены.");
			strings.Add("kz", "getDeviceDescriptionSuccess", "Данные о бригаде получены.");			
            
			//

            strings.Add("ru", "messageSending", "Идет отправка, подождите...");
			strings.Add("kz", "messageSending", "Күте тұрыңыз, жіберілу үстінде...");

			strings.Add("ru", "noOrdersAvailable", "Список заявок пуст.");
			strings.Add("kz", "noOrdersAvailable", "Список заявок пуст.");

            strings.Add("ru", "repeatAttempt", "Нет связи. Повторите операцию.");
			strings.Add("kz", "repeatAttempt", "Байланыс жок. Кайталаныз."); //Байланыс жоқ. Қайталаңыз.

            strings.Add("ru", "dispatchingStatusOK", "Доставлено.");
			strings.Add("kz", "dispatchingStatusOK", "Жеткізілді.");

			strings.Add("ru", "send", "Отправить");
			strings.Add("kz", "send", "Жеткізу");

			//
            //NewRepair
			strings.Add("ru", "ogpd", "НДГУ №");
			strings.Add("kz", "ogpd", "НГДУ №");

            strings.Add("ru", "ogwp", "ЦДНГ");
            strings.Add("kz", "ogwp", "ЦДНГ");

            strings.Add("ru", "cjp", "ГУ/ПС");
            strings.Add("kz", "cjp", "ГУ/ПС");

			strings.Add("ru", "oilwellNumberAbbr", "Cкв.");
			strings.Add("kz", "oilwellNumberAbbr", "Скв.");

            strings.Add("ru", "oilwellNumber", "Cкважина №");
            strings.Add("kz", "oilwellNumber", "Ұңғыма нөмірі");

            strings.Add("ru", "tubeDiameter", "Диаметр, мм");
            strings.Add("kz", "tubeDiameter", "Диаметр, мм");

			strings.Add("ru", "tubeDiameterAbbr", "ø");
			strings.Add("kz", "tubeDiameterAbbr", "ø");
			

            //NewOrder

            strings.Add("ru", "orderType", "Тип заявки");
            strings.Add("kz", "orderType", "Тапсырыс түрі");

            strings.Add("ru", "orderReason", "Основание"); // Основание заявки
            strings.Add("kz", "orderReason", "Себебі");

            strings.Add("ru", "orderReasonReplacement", "Замена");
            strings.Add("kz", "orderReasonReplacement", "Ауыстыру");

            strings.Add("ru", "orderReasonBath", "Ванна");
            strings.Add("kz", "orderReasonBath", "Ванна");

            strings.Add("ru", "orderReasonAssessment", "Допуск");
            strings.Add("kz", "orderReasonAssessment", "Кіру руксаты"); //рұқсаты
            
            strings.Add("ru", "orderTypeTubesDelivery", "Доставка НКТ");
            strings.Add("kz", "orderTypeTubesDelivery", "НКК-ды жеткізу");

            strings.Add("ru", "orderTypeTubesCleaning", "Уборка НКТ");
            strings.Add("kz", "orderTypeTubesCleaning", "НКК-ды жинау");

            strings.Add("ru", "tubesNumber", "Кол-во НКТ, шт");
            strings.Add("kz", "tubesNumber", "НКҚ саны");

            strings.Add("ru", "districtApproach", "Подъезд");
            strings.Add("kz", "districtApproach", "Көліктің келу тәсілі");

            strings.Add("ru", "districtApproachDriverInTheFront", "Водитель / Муфты вперёд");
            strings.Add("kz", "districtApproachDriverInTheFront", "Водитель / Муфты вперёд");

            strings.Add("ru", "districtApproachDriverInTheRear", "Водитель / Муфты назад");
            strings.Add("kz", "districtApproachDriverInTheRear", "Водитель / Муфты назад");

            strings.Add("ru", "districtApproachPassengerInTheFront", "Пассажир / Муфты вперёд");
            strings.Add("kz", "districtApproachPassengerInTheFront", "Пассажир / Муфты вперёд");

            strings.Add("ru", "districtApproachPassengerInTheRear", "Пассажир / Муфты назад");
            strings.Add("kz", "districtApproachPassengerInTheRear", "Пассажир / Муфты назад");

            // strings.Add("ru", "createNewOrder", "Отправить заявку");
            // strings.Add("kz", "createNewOrder", "Тапсырысты жіберу");

            strings.Add("ru", "dateExpected", "Плановое время");
            strings.Add("kz", "dateExpected", "Жоспарланған уақыт");

				//Валидация

            strings.Add("ru", "repairNotSelected", "Не выбран ремонт");
            strings.Add("kz", "repairNotSelected", "Жөндеу жұмысы өрісі таңдалмады");

            strings.Add("ru", "orderTypeNotSelected", "Не выбран тип заявки");
            strings.Add("kz", "orderTypeNotSelected", "Тапсырыс үлгісі таңданылмады");

            strings.Add("ru", "orderReasonNotSelected", "Не выбрано основание для заявки");
            strings.Add("kz", "orderReasonNotSelected", "Тапсырыс жасалуы себебі көрсетілмеді");

            strings.Add("ru", "ogpwMissing", "Не указан номер ЦДНГ");
            strings.Add("kz", "ogpwMissing", "ЦДНГ нөмiрi көрсетілмеді");

            strings.Add("ru", "ogpwWrongFormat", "В поле \"ЦДНГ\" должны быть только цифры");
            strings.Add("kz", "ogpwWrongFormat", "\"ЦДНГ\" өрісінде тек сандар жазылу керек");

            strings.Add("ru", "tubeDiameterNotSelected", "Не выбран диаметр НКТ");
            strings.Add("kz", "tubeDiameterNotSelected", "НКҚ-дың диаметрі таңданылмады");

            strings.Add("ru", "oilwellNumberMissing", "Не указан номер скважины");
            strings.Add("kz", "oilwellNumberMissing", "Ұңғыма нөмірі көрсетілмеді");

            strings.Add("ru", "oilwellNumberWrongFormat", "В поле \"Скважина, №\" должны быть только цифры");
            strings.Add("kz", "oilwellNumberWrongFormat", "\"Ұңғыма нөмірі\" өрісінде тек сандар жазылу керек");

            strings.Add("ru", "tubesNumberMissing", "Не указано количество НКТ");
            strings.Add("kz", "tubesNumberMissing", "НКҚ-ның саны көрсетілмеді");

            strings.Add("ru", "tubesNumberWrongFormat", "В поле \"Кол-во, шт\" должны быть только цифры");
            strings.Add("kz", "tubesNumberWrongFormat", "\"Құбырлар саны,\" өрісінде тек сандар жазылу керек");

            strings.Add("ru", "cjpMissing", "Не указана ГУ");
            strings.Add("kz", "cjpMissing", "ГУ көрсетілмеді");

            strings.Add("ru", "districtApproachNotSelected", "Не выбран способ подъезда");
            strings.Add("kz", "districtApproachNotSelected", "Көліктің келу тәсілі көрсетілмеді");

            strings.Add("ru", "cjpWrongFormat", "В поле \"ГУ\" должны быть только цифры");
            strings.Add("kz", "cjpWrongFormat", "\"ГУ\" өрісінде тек сандар жазылу керек");           

            //OrderList

            strings.Add("ru", "orderedTubesAmount", "По заявке");
            strings.Add("kz", "orderedTubesAmount", "Тапсырыс бойынша");

            strings.Add("ru", "shippedTubesAmount", "Принято");
            strings.Add("kz", "shippedTubesAmount", "Қабылданған саны");

            strings.Add("ru", "closeOrder", "Закрыть заявку");
            strings.Add("kz", "closeOrder", "Тапсырысты жабу");

            strings.Add("ru", "cancelOrder", "Отменить заявку");
            strings.Add("kz", "cancelOrder", "Тапсырысты жою");

            strings.Add("ru", "attachWaybill", "Прикрепить ТТН");
            strings.Add("kz", "attachWaybill", "Жүкқұжатты тіркеу");

				//Сообщения
            // strings.Add("ru", "doYouWantToCloseOrder", "Закрыть заявку?");
            // strings.Add("kz", "doYouWantToCloseOrder", "Тапсырысты жабу керек пе?");

            strings.Add("ru", "doYouWantToCancelOrder", "Отменить заявку?");
            strings.Add("kz", "doYouWantToCancelOrder", "Тапсырысты кушін жою керек пе?"); // күшін

            // strings.Add("ru", "syncingOrderListFailure", "Не удалось получить список заявок. Повторите попытку");
            // strings.Add("kz", "syncingOrderListFailure", "Тапсырыстар тізімі алынбады. Операцияны кайталаныз");

            strings.Add("ru", "orderNotSelected", "Не выбрана заявка");
            strings.Add("kz", "orderNotSelected", "Тапсырысты танданыз"); //таңдаңыз

            //Form_Waybill

            strings.Add("ru", "readTag", "Считать транспортную метку");
            strings.Add("kz", "readTag", "Транспорттық белгіні оқу ");

            strings.Add("ru", "tubeStatusNew", "Новые");
            strings.Add("kz", "tubeStatusNew", "Жаңа");

            strings.Add("ru", "tubeStatusOld", "Старые");
            strings.Add("kz", "tubeStatusOld", "Ескі");

            strings.Add("ru", "tubeStatus", "Состояние труб");
            strings.Add("kz", "tubeStatus", "НКҚ күйі");

            strings.Add("ru", "waybillNumber", "ТТН №");
            strings.Add("kz", "waybillNumber", "ТТЖ №");

            // strings.Add("ru", "sendWaybill", "Отправить ТТН");
            // strings.Add("kz", "sendWaybill", "Жүкқұжатты Жөнелту");

				//Сообщения

            // strings.Add("ru", "waybillDispatchingStatusOK", "Накладная доставлена");
            // strings.Add("kz", "waybillDispatchingStatusOK", "Жүкқұжат жеткізілді");

            strings.Add("ru", "waybillDispatchingStatusFailure", "Накладную доставить не удалось. Повторите отправку");
            strings.Add("kz", "waybillDispatchingStatusFailure", "Жүкқұжат жеткізілмеді. Операцияны қайталаңыз");

            strings.Add("ru", "epcReadingStatusFailure", "Не удалось считать номер транспортного средства. Повторите считывание");
            strings.Add("kz", "epcReadingStatusFailure", "Транспорттық құралдың нөмірі табылмады. Операцияны қайтлаңыз");

            strings.Add("ru", "epcReadingStatusMissing", "Метка не обнаружена. Повторите считывание");
            strings.Add("kz", "epcReadingStatusMissing", "Белгі табылмады. Операцияны қайталаңыз");

            strings.Add("ru", "epcReadingStatusTotalFailure", "Прекратите считывание и перейдите к заполнению оставшихся полей");
            strings.Add("kz", "epcReadingStatusTotalFailure", "Басқа өрістерді толтырыңыз");

				// Валидация

            // strings.Add("ru", "waybillNotValid", "ТТН не была отправлена, потому что:");
            // strings.Add("kz", "waybillNotValid", "Жүкқұжат жіберілмеді, өйткені:");

            strings.Add("ru", "tubeStatusNotChecked", "Не выбран тип подвески");
            strings.Add("kz", "tubeStatusNotChecked", "Подвесканың түрі таңдалмады");

            strings.Add("ru", "waybillNumberMissing", "Не указан номер ТТН");
            strings.Add("kz", "waybillNumberMissing", "Жүкқұжаттың нөмірі көрсетілмеді");

            strings.Add("ru", "waybillNumberWrongFormat", "В поле \"ТТН\" должны быть только цифры");
            strings.Add("kz", "waybillNumberWrongFormat", "\"ТТЖ\" өрісінде тек сандар болуы тиіс");

            strings.Add("ru", "epcNotValid", "Метка не считана");
            strings.Add("kz", "epcNotValid", "Белгі табылмады");

			// Акты

			strings.Add("ru", "actTypes", "Вид акта");
			strings.Add("kz", "actTypes", "Акттың түрі");

			strings.Add("ru", "actTypeExtraction", "Извлечение НКТ");
			strings.Add("kz", "actTypeExtraction", "НКҚ-ны шығару");

			strings.Add("ru", "actTypeDescent", "Спуск НКТ");
			strings.Add("kz", "actTypeDescent", "НКҚ түсіру");

			strings.Add("ru", "actTypeNotSelected", "Не выбран вид акта");
			strings.Add("kz", "actTypeNotSelected", "Акттың түрі таңдалмады");
        }
    }
}