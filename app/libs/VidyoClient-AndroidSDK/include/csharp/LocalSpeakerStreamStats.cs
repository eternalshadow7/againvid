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
	public class LocalSpeakerStreamStats{
		private IntPtr objPtr; // opaque VidyoLocalSpeakerStreamStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalSpeakerStreamStatsGetbitsPerSampleNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetdelayNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern MediaFormat VidyoLocalSpeakerStreamStatsGetformatNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGethighThresholdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGethighestThresholdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalSpeakerStreamStatsGetisActiveNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoLocalSpeakerStreamStatsGetlastEnergyNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetlastPlayedNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetlowThresholdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetlowestThresholdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetmaxThresholdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalSpeakerStreamStatsGetnameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalSpeakerStreamStatsGetnumberOfChannelsNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetoverrunNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetplayedNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalSpeakerStreamStatsGetsampleRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalSpeakerStreamStatsGetunderrunNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLocalSpeakerStreamStatsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLocalSpeakerStreamStatsSetUserDataNative(IntPtr obj, IntPtr userData);

		public uint bitsPerSample;
		public ulong delay;
		public MediaFormat format;
		public ulong highThreshold;
		public ulong highestThreshold;
		public Boolean isActive;
		public int lastEnergy;
		public ulong lastPlayed;
		public ulong lowThreshold;
		public ulong lowestThreshold;
		public ulong maxThreshold;
		public String name;
		public uint numberOfChannels;
		public ulong overrun;
		public ulong played;
		public uint sampleRate;
		public ulong underrun;
		public LocalSpeakerStreamStats(IntPtr obj){
			objPtr = obj;

			bitsPerSample = VidyoLocalSpeakerStreamStatsGetbitsPerSampleNative(objPtr);
			delay = VidyoLocalSpeakerStreamStatsGetdelayNative(objPtr);
			format = VidyoLocalSpeakerStreamStatsGetformatNative(objPtr);
			highThreshold = VidyoLocalSpeakerStreamStatsGethighThresholdNative(objPtr);
			highestThreshold = VidyoLocalSpeakerStreamStatsGethighestThresholdNative(objPtr);
			isActive = VidyoLocalSpeakerStreamStatsGetisActiveNative(objPtr);
			lastEnergy = VidyoLocalSpeakerStreamStatsGetlastEnergyNative(objPtr);
			lastPlayed = VidyoLocalSpeakerStreamStatsGetlastPlayedNative(objPtr);
			lowThreshold = VidyoLocalSpeakerStreamStatsGetlowThresholdNative(objPtr);
			lowestThreshold = VidyoLocalSpeakerStreamStatsGetlowestThresholdNative(objPtr);
			maxThreshold = VidyoLocalSpeakerStreamStatsGetmaxThresholdNative(objPtr);
			name = Marshal.PtrToStringAnsi(VidyoLocalSpeakerStreamStatsGetnameNative(objPtr));
			numberOfChannels = VidyoLocalSpeakerStreamStatsGetnumberOfChannelsNative(objPtr);
			overrun = VidyoLocalSpeakerStreamStatsGetoverrunNative(objPtr);
			played = VidyoLocalSpeakerStreamStatsGetplayedNative(objPtr);
			sampleRate = VidyoLocalSpeakerStreamStatsGetsampleRateNative(objPtr);
			underrun = VidyoLocalSpeakerStreamStatsGetunderrunNative(objPtr);
		}
	};
}
