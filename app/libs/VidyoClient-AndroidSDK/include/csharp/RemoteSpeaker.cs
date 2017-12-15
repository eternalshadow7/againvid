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
	public class RemoteSpeaker{
		private IntPtr objPtr; // opaque VidyoRemoteSpeaker reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteSpeakerConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRemoteSpeakerDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteSpeakerGetIdNative(IntPtr s);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteSpeakerGetNameNative(IntPtr s);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoRemoteSpeakerGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoRemoteSpeakerSetUserDataNative(IntPtr obj, IntPtr userData);

		public RemoteSpeaker(IntPtr other){
			objPtr = VidyoRemoteSpeakerConstructCopyNative(other);
			VidyoRemoteSpeakerSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~RemoteSpeaker(){
			if(objPtr != IntPtr.Zero){
				VidyoRemoteSpeakerSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoRemoteSpeakerDestructNative(objPtr);
			}
		}
		public String GetId(){

			IntPtr ret = VidyoRemoteSpeakerGetIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetName(){

			IntPtr ret = VidyoRemoteSpeakerGetNameNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
	};
}