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

namespace Com.Amap.Api.Navi
{
	
    public partial class AMapNavi: global::Java.Lang.Object, global::Com.Amap.Api.Navi.INavi 
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.navi']/class[@name='AMapNavi']/method[@name='setAMapNaviListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.navi.AMapNaviListener']]"
		[Obsolete(@"deprecated")]
		[Register("setAMapNaviListener", "(Lcom/amap/api/navi/AMapNaviListener;)V", "GetSetAMapNaviListener_Lcom_amap_api_navi_AMapNaviListener_Handler")]
		public virtual unsafe void SetAMapNaviListener(global::Com.Amap.Api.Navi.IAMapNaviListener p0)
		{
			const string __id = "setAMapNaviListener.(Lcom/amap/api/navi/AMapNaviListener;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		public event EventHandler<global::Com.Amap.Api.Navi.AMapNaviListenerUpdateTrafficFacility1EventArgs> SetAMapNaviListenerUpdateTrafficFacility1
		{
			add
			{
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Navi.IAMapNaviListener, global::Com.Amap.Api.Navi.IAMapNaviListenerImplementor>(
						ref weak_implementor_SetAMapNaviListener,
						__CreateIAMapNaviListenerImplementor,
						SetAMapNaviListener,
						__h => __h.OnAMapNaviListenerUpdateTrafficFacility1Handler += value);
			}
			remove
			{
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Navi.IAMapNaviListener, global::Com.Amap.Api.Navi.IAMapNaviListenerImplementor>(
						ref weak_implementor_SetAMapNaviListener,
						global::Com.Amap.Api.Navi.IAMapNaviListenerImplementor.__IsEmpty,
						__v => SetAMapNaviListener(null),
						__h => __h.OnAMapNaviListenerUpdateTrafficFacility1Handler -= value);
			}
		}

		WeakReference weak_implementor_SetAMapNaviListener;
		
		
		public unsafe string NaviLocation
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.navi']/class[@name='AMapNavi']/method[@name='getNaviLocation' and count(parameter)=0]"
			[Register("getNaviLocation", "()Ljava/lang/String;", "")]
			get
			{
				const string __id = "getNaviLocation.()Ljava/lang/String;";
				try
				{
					var __rm = _members.StaticMethods.InvokeObjectMethod(__id, null);
					return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.navi']/class[@name='AMapNavi']/method[@name='setNaviLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register("setNaviLocation", "(Ljava/lang/String;)V", "GetSetNaviLocation_Ljava_lang_String_Handler")]
			set
			{
				const string __id = "setNaviLocation.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* __args = stackalloc JniArgumentValue[1];
					__args[0] = new JniArgumentValue(native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}		
	}
}