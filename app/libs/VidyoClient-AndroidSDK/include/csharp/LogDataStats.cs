// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2016 Vidyo, Inc. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace VidyoClient
{
	public class LogDataStats{
		private IntPtr objPtr; // opaque VidyoLogDataStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogDataStatsGetnameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLogDataStatsGetoccurancesNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLogDataStatsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLogDataStatsSetUserDataNative(IntPtr obj, IntPtr userData);

		public String name;
		public uint occurances;
		public LogDataStats(IntPtr obj){
			objPtr = obj;

			name = Marshal.PtrToStringAnsi(VidyoLogDataStatsGetnameNative(objPtr));
			occurances = VidyoLogDataStatsGetoccurancesNative(objPtr);
		}
	};
}
