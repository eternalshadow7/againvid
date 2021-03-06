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
	public class Device{
		private IntPtr objPtr; // opaque VidyoDevice reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoDeviceConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoDeviceDerivedEqualNative(IntPtr obj, IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoDeviceDestructNative(IntPtr device);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoDeviceGetIdNative(IntPtr d);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoDeviceGetNameNative(IntPtr d);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern DeviceType VidyoDeviceGetTypeNative(IntPtr d);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoDeviceGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoDeviceSetUserDataNative(IntPtr obj, IntPtr userData);

		public enum DeviceAudioSignalType{
			DeviceaudiosignaltypeVoice,
			DeviceaudiosignaltypeUnprocessed
		}
		public enum DeviceState{
			DevicestateAdded,
			DevicestateRemoved,
			DevicestateStarted,
			DevicestateStopped,
			DevicestateSuspended,
			DevicestateUnsuspended,
			DevicestateInUse,
			DevicestateAvailable,
			DevicestatePaused,
			DevicestateResumed,
			DevicestateControllable,
			DevicestateNotControllable,
			DevicestateDefaultChanged,
			DevicestateConfigureSuccess,
			DevicestateConfigureError,
			DevicestateError
		}
		public enum DeviceType{
			DevicetypeLocalCamera,
			DevicetypeLocalMicrophone,
			DevicetypeLocalMonitor,
			DevicetypeLocalWindowShare,
			DevicetypeLocalSpeaker,
			DevicetypeLocalRenderer,
			DevicetypeRemoteCamera,
			DevicetypeRemoteMicrophone,
			DevicetypeRemoteWindowShare,
			DevicetypeRemoteSpeaker,
			DevicetypeRemoteRenderer
		}
		public Device(IntPtr other){
			objPtr = VidyoDeviceConstructCopyNative(other);
			VidyoDeviceSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~Device(){
			if(objPtr != IntPtr.Zero){
				VidyoDeviceSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoDeviceDestructNative(objPtr);
			}
		}
		public Boolean DerivedEqual(){

			Boolean ret = VidyoDeviceDerivedEqualNative(objPtr, objPtr);

			return ret;
		}
		public String GetId(){

			IntPtr ret = VidyoDeviceGetIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetName(){

			IntPtr ret = VidyoDeviceGetNameNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public DeviceType GetType(){

			DeviceType ret = VidyoDeviceGetTypeNative(objPtr);

			return ret;
		}
	};
}
