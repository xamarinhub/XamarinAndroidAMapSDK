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

namespace Com.Alibaba.Idst.Nls.Nlsclientsdk.Requests.Tts
{
    
    public abstract partial class SpeechSynthesizerListener : global::Java.Lang.Object, global::Com.Alibaba.Idst.Nls.Nlsclientsdk.Transport.IConnectionListener
    {
        
        void global::Com.Alibaba.Idst.Nls.Nlsclientsdk.Transport.IConnectionListener.OnMessage1(string p0)
        {
            OnMessage(p0);
        }
        void global::Com.Alibaba.Idst.Nls.Nlsclientsdk.Transport.IConnectionListener.OnMessage2(global::Java.Nio.ByteBuffer p0)
        {
            OnMessage(p0);
        }
    }
}