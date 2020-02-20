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

namespace Com.Amap.Api.Navi
{
    public partial class AMapHudView : global::Android.Widget.FrameLayout, global::Android.Views.View.IOnClickListener, global::Android.Views.View.IOnTouchListener, global::Com.Amap.Api.Navi.IMyNaviListener
    {
        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnAMapNaviListenerUpdateTrafficFacility1(global::Com.Amap.Api.Navi.Model.AMapNaviTrafficFacilityInfo p0) 
        {
            
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnAMapNaviListenerUpdateTrafficFacility2(global::Com.Amap.Api.Navi.Model.AMapNaviTrafficFacilityInfo[] p0) 
        {
            
        }
        
        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnAMapNaviListenerUpdateTrafficFacility3(global::Com.Autonavi.Tbt.TrafficFacilityInfo p0) 
        {
            
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnCalculateRouteFailure1(global::Com.Amap.Api.Navi.Model.AMapCalcRouteResult p0)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnCalculateRouteFailure2(int p0)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnCalculateRouteSuccess1(global::Com.Amap.Api.Navi.Model.AMapCalcRouteResult p0)
        {
            
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnCalculateRouteSuccess2(int[] p0)
        {
            
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnGetNavigationText1(int p0, string p1)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.OnGetNavigationText2(string p0)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.ShowLaneInfo1(global::Com.Amap.Api.Navi.Model.AMapLaneInfo p0)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.ShowLaneInfo2(global::Com.Amap.Api.Navi.Model.AMapLaneInfo[] p0, byte[] p1, byte[] p2)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.UpdateAMapNaviListenerAimlessModeCongestionInfo(global::Com.Amap.Api.Navi.Model.AimLessModeCongestionInfo p0)
        {
        }

        void global::Com.Amap.Api.Navi.IAMapNaviListener.UpdateAMapNaviListenerAimlessModeStatistics(global::Com.Amap.Api.Navi.Model.AimLessModeStat p0)
        {

        }
    }
}