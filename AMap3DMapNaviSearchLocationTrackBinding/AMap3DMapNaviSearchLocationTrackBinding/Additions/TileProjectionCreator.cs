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

namespace Com.Amap.Api.Maps.Model
{
    public partial class TileProjectionCreator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator
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