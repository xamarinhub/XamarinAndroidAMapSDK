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
	public partial class LocMatchInfo : global::Java.Lang.Object, global::Java.IO.ISerializable
    {
		static IntPtr id_ctor_I;

		private const string signature = "(" +
			"Lcom/autonavi/ae/pos/LocMapPoint;" +
			"Lcom/autonavi/ae/pos/LocMapPoint;" +
			"D" +
			"D" +
			"D" +
			"I" +
			"S" +
			"S" +
			"S" +
			"I" +
			"I" +
			"I" +
			"S" +
			"J" +
			"I" +
			")V";
		
		[Register(".ctor", signature, "")]
		public unsafe LocMatchInfo(
			Com.Autonavi.AE.Pos.LocMapPoint p1,
			Com.Autonavi.AE.Pos.LocMapPoint p2,
			double p3,
			double p4,
			double p5,
			int p6,
			byte p7,
			byte p8,
			byte p9,
			int p10,
			int p11,
			int p12,
			byte p13,
			long p14,
			int p15) 
			:base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;
			if (GetType() != typeof(LocMatchInfo))
			{
				SetHandle(
						Android.Runtime.JNIEnv.CreateInstance(GetType(), signature,
						new JValue(p1),
						new JValue(p2),
						new JValue(p3),
						new JValue(p4),
						new JValue(p5),
						new JValue(p6),
						new JValue(p7),
						new JValue(p8),
						new JValue(p9),
						new JValue(p10),
						new JValue(p11),
						new JValue(p12),
						new JValue(p13),
						new JValue(p14),
						new JValue(p15)),
						JniHandleOwnership.TransferLocalRef);
				return;
			}
			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID(class_ref, "<init>", signature);
			SetHandle(
					JNIEnv.NewObject(class_ref, id_ctor_I,
					new JValue(p1),
						new JValue(p2),
						new JValue(p3),
						new JValue(p4),
						new JValue(p5),
						new JValue(p6),
						new JValue(p7),
						new JValue(p8),
						new JValue(p9),
						new JValue(p10),
						new JValue(p11),
						new JValue(p12),
						new JValue(p13),
						new JValue(p14),
						new JValue(p15)),
					JniHandleOwnership.TransferLocalRef);
		}
	}
}