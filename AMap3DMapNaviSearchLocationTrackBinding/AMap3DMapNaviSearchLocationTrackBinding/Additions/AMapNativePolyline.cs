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
	public partial class AMapNativePolyline
    {
		static IntPtr id_ctor_I;

		private const string __id = "(" +
			"J" +
			"[F" +
			"IFI" +
			"FFFFFZZZ" +
			"[F" +
			"II)V";

		[Register("nativeDrawLineByTextureID", __id, "")]
		public unsafe static void NativeDrawLineByTextureID(
			long p1,
			float[] p2,
			int p3,
			float p4,
			int p5,
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
			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetStaticMethodID(class_ref,
						"nativeDrawLineByTextureID", __id);
			JNIEnv.CallStaticVoidMethod(class_ref, id_ctor_I,
				new JValue(p1),
						new JValue(JNIEnv.NewArray(p2)),
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