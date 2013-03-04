using System;

using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsCE.Forms;

namespace RFID_UHF_Net
{
	public class GpsMessageWindow : MessageWindow
	{
		public delegate void onReceivingGpsData(Message message);

		onReceivingGpsData @delegate;

		public GpsMessageWindow(onReceivingGpsData @delegate)
		{
			this.@delegate = @delegate;
		}

		protected override void WndProc(ref Message message)
		{
			switch (message.Msg)
			{
				case GpsParse.WM_USER_RECVDATA:
					@delegate(message);
					break;
			}

			base.WndProc(ref message);
		}

	}
}
