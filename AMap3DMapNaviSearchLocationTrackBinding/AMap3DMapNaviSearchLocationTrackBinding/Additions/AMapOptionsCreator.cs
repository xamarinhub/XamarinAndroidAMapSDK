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

namespace Com.Amap.Api.Maps
{
	public partial class AMapOptionsCreator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator
	{
		public Java.Lang.Object CreateFromParcel(Parcel source)
		{
			return RawCreateFromParcel(source);
		}

		public Java.Lang.Object[] NewArray(int size)
		{
			return RawNewArray(size);
		}
	}
}