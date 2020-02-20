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

namespace Com.Autonavi.Base.Amap.Mapcore
{
    public partial class AMapNativeRenderer
    {
		static IntPtr id_nativeDrawLineByTextureID;

		private const string nativeDrawLineByTextureIDSignature = "(" +
			"[F"+
			"I" +
			"F" +
			"I" +
			"FFFFFFZZZ" +
			"[F" +
			"IIZ)V";
		
		[Register("nativeDrawLineByTextureID", nativeDrawLineByTextureIDSignature, "")]
		public unsafe static void NativeDrawLineByTextureID(
			float[] p1,
			int p2,
			float p3,
			int p4,			
			float p5,
			float p6,
			float p7,
			float p8,
			float p9,
			float p10,
			bool p11,
			bool p12,
			bool p13,
			float[] p14,
			int p15,
			int p16,
			bool p17)
		{
			if (id_nativeDrawLineByTextureID == IntPtr.Zero)
				id_nativeDrawLineByTextureID = JNIEnv.GetStaticMethodID(class_ref,
						"nativeDrawLineByTextureID", nativeDrawLineByTextureIDSignature);
			JNIEnv.CallStaticVoidMethod(class_ref, id_nativeDrawLineByTextureID,
				new JValue(JNIEnv.NewArray(p1)),
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
						new JValue(JNIEnv.NewArray(p14)),
						new JValue(p15),
						new JValue(p16),
						new JValue(p17));
		}

		static IntPtr id_nativeDrawLineByTextureID2;

		private const string nativeDrawLineByTextureID2Signature = "(" +
			"[F" +
			"I" +
			"F" +
			"I" +
			"FFFFFFZZZ" +
			"[F" +
			"II)V";
		
		[Register("nativeDrawLineByTextureID", nativeDrawLineByTextureID2Signature, "")]
		public unsafe static void NativeDrawLineByTextureID(
			float[] p1,
			int p2,
			float p3,
			int p4,
			float p5,
			float p6,
			float p7,
			float p8,
			float p9,
			float p10,
			bool p11,
			bool p12,
			bool p13,
			float[] p14,
			int p15,
			int p16)
		{
			if (id_nativeDrawLineByTextureID2 == IntPtr.Zero)
				id_nativeDrawLineByTextureID2 = JNIEnv.GetStaticMethodID(class_ref,
						"nativeDrawLineByTextureID", nativeDrawLineByTextureID2Signature);
			JNIEnv.CallStaticVoidMethod(class_ref, id_nativeDrawLineByTextureID2,
				new JValue(JNIEnv.NewArray(p1)),
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
						new JValue(JNIEnv.NewArray(p14)),
						new JValue(p15),
						new JValue(p16));
		}
	}
}