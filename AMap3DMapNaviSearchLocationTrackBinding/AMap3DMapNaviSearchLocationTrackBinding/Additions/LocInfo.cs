using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Autonavi.AE.Pos
{
    public partial class LocInfo : global::Java.Lang.Object, global::Java.IO.ISerializable
    {
		static IntPtr id_ctor_I;

		private const string __id = "(" +
			"III" +
			"DDDDDD" +
			"II" +
			"BDIJ" +
			"IIIIIII" +
			"DIDDFI" +
			"FFFFI" +
			"[Lcom/autonavi/ae/pos/LocMatchInfo;)V";
		
		[Register(".ctor", __id, "")]
		public unsafe LocInfo(
			int i1,
			int i2,
			int i3,
			double d1,
			double d2,
			double d3,
			double d4,
			double d5,
			double d6,
			int i4,
			int i5,
			byte b1,double d7,int i6,long j1,
			int i7,
			int i8,
			int i9,
			int i10,
			int i11,
			int i12,
			int i13,
			double d8,int i14,double d9,double d10,float f1,int i15,
			float f2,
			float f3,
			float f4,
			float f5,
			int i16,
			LocMatchInfo[] obj1)
		{
			if (Handle != IntPtr.Zero)
				return;
			if (GetType() != typeof(LocMatchInfo))
			{
				SetHandle(
						Android.Runtime.JNIEnv.CreateInstance(GetType(), __id,
						new JValue(i1),
						new JValue(i2),
						new JValue(i3),
						new JValue(d1),
						new JValue(d2),
						new JValue(d3),
						new JValue(d4),
						new JValue(d5),
						new JValue(d6),
						new JValue(i4),
						new JValue(i5),
						new JValue(b1),
						new JValue(d7),
						new JValue(i6),
						new JValue(j1),
						new JValue(i7),
						new JValue(i8),
						new JValue(i9),
						new JValue(i10),
						new JValue(i11),
						new JValue(i12),
						new JValue(i13),
						new JValue(d8),
						new JValue(i14),
						new JValue(d9),
						new JValue(d10),
						new JValue(f1),
						new JValue(i15),
						new JValue(f2),
						new JValue(f3),
						new JValue(f4),
						new JValue(f5),
						new JValue(i16),
						new JValue(JNIEnv.NewArray(obj1))),
						JniHandleOwnership.TransferLocalRef);
				return;
			}
			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID(class_ref, "<init>", __id);
			SetHandle(
					JNIEnv.NewObject(class_ref, id_ctor_I,
					new JValue(i1),
						new JValue(i2),
						new JValue(i3),
						new JValue(d1),
						new JValue(d2),
						new JValue(d3),
						new JValue(d4),
						new JValue(d5),
						new JValue(d6),
						new JValue(i4),
						new JValue(i5),
						new JValue(b1),
						new JValue(d7),
						new JValue(i6),
						new JValue(j1),
						new JValue(i7),
						new JValue(i8),
						new JValue(i9),
						new JValue(i10),
						new JValue(i11),
						new JValue(i12),
						new JValue(i13),
						new JValue(d8),
						new JValue(i14),
						new JValue(d9),
						new JValue(d10),
						new JValue(f1),
						new JValue(i15),
						new JValue(f2),
						new JValue(f3),
						new JValue(f4),
						new JValue(f5),
						new JValue(i16),
						new JValue(JNIEnv.NewArray(obj1))),
					JniHandleOwnership.TransferLocalRef);
		}
	}
}