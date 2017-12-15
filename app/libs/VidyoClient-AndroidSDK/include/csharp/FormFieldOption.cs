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
	public class FormFieldOption{
		private IntPtr objPtr; // opaque VidyoFormFieldOption reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoFormFieldOptionGetselectedNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoFormFieldOptionGetvalueNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoFormFieldOptionGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoFormFieldOptionSetUserDataNative(IntPtr obj, IntPtr userData);

		public Boolean selected;
		public String value;
		public FormFieldOption(IntPtr obj){
			objPtr = obj;

			selected = VidyoFormFieldOptionGetselectedNative(objPtr);
			value = Marshal.PtrToStringAnsi(VidyoFormFieldOptionGetvalueNative(objPtr));
		}
	};
}