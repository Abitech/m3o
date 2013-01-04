using System;

using System.Collections.Generic;
using System.Text;
using com.abitech.rfid;
using System.Windows.Forms;

namespace RFID_UHF_Net
{
    class Strings
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
            current = strings[language];
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

    static class Resources
    {
        static public Strings strings;

        static public void Init()
        {
            strings = new Strings("kz", "ru");

            strings.SetLanguage("ru");

            //Form_Main

            strings.Add("ru", "NewOrder", "Новая заявка");
            strings.Add("kz", "NewOrder", "Жаңа тапсырыс");

            strings.Add("ru", "OrderList", "Список заявок");
            strings.Add("kz", "OrderList", "Тапсырыстар тізімі");

            strings.Add("ru", "OrderHistory", "Журнал заявок");
            strings.Add("kz", "OrderHistory", "Тапсырыстар журналы");

            strings.Add("ru", "Team", "Бригада №");
            strings.Add("kz", "Team", "Бригада №");

            //Form_NewOrder

            strings.Add("ru", "OrderType", "Тип заявки");
            strings.Add("kz", "OrderType", "Тапсырыс түрі");

            strings.Add("ru", "OrderTypeTubesDelivery", "Доставка НКТ");
            strings.Add("kz", "OrderTypeTubesDelivery", "НКК-ды жеткізу");

            strings.Add("ru", "OrderTypeTubesCleaning", "Уборка НКТ");
            strings.Add("kz", "OrderTypeTubesCleaning", "НКК-ды жинау");

            strings.Add("ru", "GroupUnit", "ГУ");
            strings.Add("kz", "GroupUnit", "ГУ");

            strings.Add("ru", "DistrictId", "Cкважина №");
            strings.Add("kz", "DistrictId", "Ұңғыма нөмірі");

            strings.Add("ru", "TubesDiameter", "Диаметр, мм");
            strings.Add("kz", "TubesDiameter", "Диаметр, мм");

            strings.Add("ru", "TubesNumber", "Кол-во, шт");
            strings.Add("kz", "TubesNumber", "НКҚ саны");

            strings.Add("ru", "CreateNewOrder", "Отправить заявку");
            strings.Add("kz", "CreateNewOrder", "Тапсырысты жіберу");

            //Сообщения

            strings.Add("ru", "OrderDispatchingStatusOK", "Заявка доставлена");
            strings.Add("kz", "OrderDispatchingStatusOK", "Тапсырыс жеткізілді");

            strings.Add("ru", "OrderDispatchingStatusFailure", "Заявку доставить не удалось. Повторите отправку.");
            strings.Add("kz", "OrderDispatchingStatusFailure", "Тапсырыс жеткізілмеді. Операцияны кайталаңыз");

            //Валидация

            strings.Add("ru", "OrderNotValid", "Заявка не была отправлена, потому что:");
            strings.Add("kz", "OrderNotValid", "Тапсырыстың жіберілмеген себебі:");

            strings.Add("ru", "OrderTypeNotSelected", "Не выбран тип заявки");
            strings.Add("kz", "OrderTypeNotSelected", "Тапсырыс үлгісі таңданылмады");

            strings.Add("ru", "TubesDiameterNotSelected", "Не выбран диаметр НКТ");
            strings.Add("kz", "TubesDiameterNotSelected", "НКҚ-дың диаметрі таңданылмады");

            strings.Add("ru", "DistrictIdMissing", "Не указан номер скважины");
            strings.Add("kz", "DistrictIdMissing", "Ұңғыма нөмірі көрсетілмеді");

            strings.Add("ru", "DistrictIdWrongFormat", "В поле \"Скважина, №\" должны быть только цифры");
            strings.Add("kz", "DistrictIdWrongFormat", "\"Ұңғыма нөмірі\" өрісінде тек сандар жазылу керек");

            strings.Add("ru", "TubesNumberMissing", "Не указано количество НКТ");
            strings.Add("kz", "TubesNumberMissing", "НКҚ-ның саны көрсетілмеді");

            strings.Add("ru", "TubesNumberWrongFormat", "В поле \"Кол-во, шт\" должны быть только цифры");
            strings.Add("kz", "TubesNumberWrongFormat", "\"Құбырлар саны,\" өрісінде тек сандар жазылу керек");

            strings.Add("ru", "GroupUnitMissing", "Не указана ГУ");
            strings.Add("kz", "GroupUnitMissing", "ГУ көрсетілмеді");

            strings.Add("ru", "GroupUnitWrongFormat", "В поле \"ГУ\" должны быть только цифры");
            strings.Add("kz", "GroupUnitWrongFormat", "\"ГУ\" өрісінде тек сандар жазылу керек");

            //Form_OrderList

            strings.Add("ru", "OrderedTubesAmount", "По заявке");
            strings.Add("kz", "OrderedTubesAmount", "Тапсырыс бойынша");

            strings.Add("ru", "ShippedTubesAmount", "Принято");
            strings.Add("kz", "ShippedTubesAmount", "Қабылданған саны");

            strings.Add("ru", "CloseOrder", "Закрыть заявку");
            strings.Add("kz", "CloseOrder", "Тапсырысты жабу");

            strings.Add("ru", "CancelOrder", "Отменить заявку");
            strings.Add("kz", "CancelOrder", "Тапсырысты жою");

            strings.Add("ru", "AttachWaybill", "Прикрепить ТТН");
            strings.Add("kz", "AttachWaybill", "Жүкқұжатты тіркеу");

            //Сообщения
            strings.Add("ru", "DoYouWantToCloseOrder", "Закрыть заявку?");
            strings.Add("kz", "DoYouWantToCloseOrder", "Тапсырысты жабу керек пе?");

            strings.Add("ru", "DoYouWantToCancelOrder", "Отменить заявку?");
            strings.Add("kz", "DoYouWantToCancelOrder", "Тапсырысты кушін жою керек пе?"); // күшін

            strings.Add("ru", "SyncingOrderListFailure", "Не удалось получить список заявок. Повторите попытку");
            strings.Add("kz", "SyncingOrderListFailure", "Тапсырыстар тізімі алынбады. Операцияны кайталаныз");

            strings.Add("ru", "OrderNotSelected", "Заявка не выбрана");
            strings.Add("kz", "OrderNotSelected", "Тапсырысты танданыз"); //таңдаңыз

            //Form_Waybill

            strings.Add("ru", "ReadTag", "Считать транспортную метку");
            strings.Add("kz", "ReadTag", "Транспорттық белгіні оқу ");

            strings.Add("ru", "TubeStatusNew", "Новые");
            strings.Add("kz", "TubeStatusNew", "Жаңа");

            strings.Add("ru", "TubeStatusOld", "Старые");
            strings.Add("kz", "TubeStatusOld", "Ескі");

            strings.Add("ru", "TubeStatus", "Состояние труб");
            strings.Add("kz", "TubeStatus", "НКҚ күйі");

            strings.Add("ru", "WaybillNumber", "ТТН №");
            strings.Add("kz", "WaybillNumber", "ТТЖ №");

            strings.Add("ru", "SendWaybill", "Отправить ТТН");
            strings.Add("kz", "SendWaybill", "Жүкқұжатты Жөнелту");

            //Сообщения

            strings.Add("ru", "WaybillDispatchingStatusOK", "Накладная доставлена");
            strings.Add("kz", "WaybillDispatchingStatusOK", "Жүкқұжат жеткізілді");

            strings.Add("ru", "WaybillDispatchingStatusFailure", "Накладную доставить не удалось. Повторите отправку");
            strings.Add("kz", "WaybillDispatchingStatusFailure", "Жүкқұжат жеткізілмеді. Операцияны қайталаңыз");

            strings.Add("ru", "EpcReadingStatusFailure", "Не удалось считать номер транспортного средства. Повторите считывание");
            strings.Add("kz", "EpcReadingStatusFailure", "Транспорттық құралдың нөмірі табылмады. Операцияны қайтлаңыз");

            strings.Add("ru", "EpcReadingStatusMissing", "Метка не обнаружена. Повторите считывание");
            strings.Add("kz", "EpcReadingStatusMissing", "Белгі табылмады. Операцияны қайталаңыз");

            strings.Add("ru", "EpcReadingStatusTotalFailure", "Возможно, метка повреждена. Прекратите считывание и перейдите к заполнению оставшихся полей");
            strings.Add("kz", "EpcReadingStatusTotalFailure", "Белгі зақымдалған болуы мүмкін. Басқа өрістерді толтырыңыз");


            // Валидация

            strings.Add("ru", "WaybillNotValid", "ТТН не была отправлена, потому что:");
            strings.Add("kz", "WaybillNotValid", "Жүкқұжат жіберілмеді, өйткені:");

            strings.Add("ru", "TubeStatusNotChecked", "Не выбран тип подвески");
            strings.Add("kz", "TubeStatusNotChecked", "Подвесканың түрі таңдалмады");

            strings.Add("ru", "WaybillNumberMissing", "Не указан номер ТТН");
            strings.Add("kz", "WaybillNumberMissing", "Жүкқұжаттың нөмірі көрсетілмеді");

            strings.Add("ru", "WaybillNumberWrongFormat", "В поле \"ТТН\" должны быть только цифры");
            strings.Add("kz", "WaybillNumberWrongFormat", "\"ТТЖ\" өрісінде тек сандар болуы тиіс");

            strings.Add("ru", "EpcNotValid", "Метка не считана");
            strings.Add("kz", "EpcNotValid", "Белгі табылмады");

            // Определено в Form_NewOrder 
            // strings.Add("ru", "TubesNumberMissing", "Не указано количество НКТ");
            // strings.Add("kz", "TubesNumberMissing", "");
            // strings.Add("ru", "TubesNumberWrongFormat", "В поле \"Количество НКТ\" должны быть только цифры");
            // strings.Add("kz", "TubesNumberWrongFormat", "");

        }
    }
}