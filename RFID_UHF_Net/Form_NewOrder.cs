using System;
using System.Drawing;
using System.Windows.Forms;
using com.abitech.rfid;

namespace RFID_UHF_Net
{
    public partial class Form_NewOrder : Form
    {
        private Strings strings = Resources.strings;

        public Form_NewOrder()
        {
            InitializeComponent();            

            OrderTypeT.Text = strings["OrderType"];
            GroupUnitT.Text = strings["GroupUnit"];
            DistrictIdT.Text = strings["DistrictId"];
            TubesDiameterT.Text = strings["TubesDiameter"];
            TubesNumberT.Text = strings["TubesNumber"];
            CreateNewOrder.Text = strings["CreateNewOrder"];
            this.Text = "";

            OrderDispatchingStatusT.Text = String.Empty;

            TubesDiameter.Items.Add(new ComboBoxItem() { id = 0, value = "60" });
            TubesDiameter.Items.Add(new ComboBoxItem() { id = 1, value = "73" });
            TubesDiameter.Items.Add(new ComboBoxItem() { id = 2, value = "73 выс" });
            TubesDiameter.Items.Add(new ComboBoxItem() { id = 3, value = "89" });

            OrderType.Items.Add(new ComboBoxItem() { id = 0, value = strings["OrderTypeTubesDelivery"] });
            OrderType.Items.Add(new ComboBoxItem() { id = 1, value = strings["OrderTypeTubesCleaning"] });
        }

        private void CreateNewOrder_Click(object sender, EventArgs e)
        {
            var isValid = true;
            OrderDispatchingStatusT.Text = String.Empty;

            #region Валидация полей
            //Вид заявки
            if (OrderType.SelectedItem == null)
            {
                OrderDispatchingStatusT.Text += strings["OrderTypeNotSelected"] + "\n";
                isValid = false;
            }

            //ГУ
            if (GroupUnit.Text.Length == 0)
            {
                OrderDispatchingStatusT.Text += strings["GroupUnitMissing"] + "\n";
                isValid = false;
            }
            
            else if (Helper.TryParse(GroupUnit.Text) == false)
            {
                OrderDispatchingStatusT.Text += strings["GroupUnitWrongFormat"] + "\n";
                isValid = false;
            }

            //Скважина
            if (DistrictId.Text.Length == 0)
            {
                OrderDispatchingStatusT.Text += strings["DistrictIdMissing"] + "\n";
                isValid = false;
            }

            else if (Helper.TryParse(DistrictId.Text) == false)
            {
                OrderDispatchingStatusT.Text += strings["DistrictIdWrongFormat"] + "\n";
                isValid = false;
            }

            //Диаметр
            if (TubesDiameter.SelectedItem == null)
            {
                OrderDispatchingStatusT.Text += strings["TubesDiameterNotSelected"] + "\n";
                isValid = false;
            }

            //Кол-во
            if (TubesNumber.Text.Length == 0)
            {
                OrderDispatchingStatusT.Text += strings["TubesNumberMissing"] + "\n";
                isValid = false;
            }

            else if (Helper.TryParse(TubesNumber.Text) == false)
            {
                OrderDispatchingStatusT.Text += strings["TubesNumberWrongFormat"] + "\n";
                isValid = false;
            }

            if (isValid == false)
            {
                OrderDispatchingStatusT.Text = strings["OrderNotValid"] + " " + OrderDispatchingStatusT.Text;
                OrderDispatchingStatusT.ForeColor = Color.Red;
                return;
            }
            #endregion

            var order = new TubesOrder
            {
                orderType = ((ComboBoxItem)OrderType.SelectedItem).id,
                groupUnit = Int32.Parse(GroupUnit.Text),
                districtId = Int32.Parse(DistrictId.Text),
                tubesDiameter = ((ComboBoxItem)TubesDiameter.SelectedItem).id,
                tubesNumber = Int32.Parse(TubesNumber.Text),
                orderStatus = TubesOrder.OrderStatus.New,
                dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            var response = RfidReader.web.SendOrder(order);

            if (response.status == RpcResponse.StatusCode.Ok || response.status == RpcResponse.StatusCode.DuplicatedMessage)
            {
                OrderDispatchingStatusT.Text = strings["OrderDispatchingStatusOK"];
                OrderDispatchingStatusT.ForeColor = Color.Green;

                OrderType.SelectedItem = null;
                GroupUnit.Text = "";
                DistrictId.Text = "";
                TubesDiameter.SelectedItem = null;
                TubesNumber.Text = "";
            }
            else
            {
                OrderDispatchingStatusT.Text = strings["OrderDispatchingStatusFailure"];
                OrderDispatchingStatusT.ForeColor = Color.Red;
            }
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void tubesNumberT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tubesLengthT_TextChanged(object sender, EventArgs e)
        {

        }

        private void districtIdT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void orderTypeT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}