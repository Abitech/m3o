using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;
using RFID_UHF_Net.Forms;

namespace RFID_UHF_Net
{

	public class GpsParse
	{
		// constant
		public const int WM_USER_RECVDATA = 0x0400 + 10000;
		public const int SATELLITE_COUNT = 12;

		// Struct
		[StructLayout(LayoutKind.Sequential)]
		public struct GPS_DOP
		{
			public double dPDop;    // Position dilution of precision
			public double dHDop;    // Horizontal dilution of precision
			public double dVDop;    // Vertical dilution of precision

		};

		[StructLayout(LayoutKind.Sequential)]
		public struct GPS_SATELLITE
		{
			public int nID;         // Satellite PRN number
			public int nElevation;  // Elevation, degrees
			public int nAzimuth;    // Azimuth, degrees
			public int nSNR;        // Signal to noise ration in dBHz
		};

		public struct GPS_PARSE_INFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public GPS_SATELLITE[] mSat;    // Satellite information structure
			public GPS_DOP mDop;    // Dilution of precision sturcture

			public int nSatInUse;		// Satellites being used (0 - 12)
			public int nSatNum;		// Satellites in view
			public bool bSatInfo;		// Check correct Satellites information

			public double dHeading;		// Course in degrees
			public double dVelocity;		// Speed over the ground in knots

			public bool bNorthLatitude;	// TRUE: North / FALSE: South
			public bool bEastLongitude;	// TRUE: East / FALSE: West	
			public double dLatitude;		// Latitude: ddmm.mmmm
			public double dLongitude;		// Longitude: ddmm.mmmm
			public double dAltitude;		// Altitude in meters according to WGS-84 ellipsoid

			public double dUTCDate;		// UTC Date: DDMMYY
			public double dUTCTime;		// UTC Time: hhmmss.sss

			public int nPosFix;		// Position Fix: 0 = Invalid, 1 = Valid SPS, 2 = Valid DGPS, 3 = Valid PPS
			public int nGPSStatus;		// GPS Status: 1 = Valid, 0 = Invalid

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string mNMEAMsg;    // Current NMEA message
		};

		// Restart type
		public const int GPS_COLD_START = 0;
		public const int GPS_WARM_START = 1;
		public const int GPS_HOT_START = 2;
		//

		public delegate void M3GetGpsInfoDelegate(ref GpsParse.GPS_PARSE_INFO info);

		// function
		[DllImport("M3GpsParse.dll")]
		private static extern bool M3GPS_Open(IntPtr hMainWnd, string tzComPort, int nBaudRate, [MarshalAs(UnmanagedType.FunctionPtr)] M3GetGpsInfoDelegate func);

		[DllImport("M3GpsParse.dll")]
		private static extern bool M3GPS_Close();

		[DllImport("M3GpsParse.dll")]
		private static extern bool M3GPS_ModuleRestart(int nStartType);


		public bool Open(IntPtr hMainWnd, string tzComPort, int nBaudRate, M3GetGpsInfoDelegate getGpsInfoDelegate)
		{
			return M3GPS_Open(hMainWnd, tzComPort, nBaudRate, getGpsInfoDelegate);
		}

		public bool Close()
		{
			return M3GPS_Close();
		}

		public bool Gps_ModuleRestart(int nStarType)
		{
			return M3GPS_ModuleRestart(nStarType);
		}

	}
}
