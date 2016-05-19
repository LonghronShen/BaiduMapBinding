//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Com.Baidu.Mapapi.Map;
//using static Com.Baidu.Mapapi.Map.BaiduMap;

//namespace BaiduMapTest
//{ 
//    public override class MyLocationListener : ILocationListener
//    {
//        public void onReceiveLocation(BDLocation location)
//    {
//        //Receive Location
//        var sb = new StringBuilder();
//       sb.Append("time : ");
//       sb.Append(location.getTime());
//       sb.Append("\nerror code : ");
//       sb.Append(location.getLocType());
//       sb.Append("\nlatitude : ");
//       sb.Append(location.getLatitude());
//       sb.Append("\nlontitude : ");
//       sb.Append(location.getLongitude());
//       sb.Append("\nradius : ");
//       sb.Append(location.getRadius());
//        if (location.getLocType() == BDLocation.TypeGpsLocation)
//        {// GPS定位结果
//           sb.Append("\nspeed : ");
//           sb.Append(location.getSpeed());// 单位：公里每小时
//           sb.Append("\nsatellite : ");
//           sb.Append(location.getSatelliteNumber());
//           sb.Append("\nheight : ");
//           sb.Append(location.getAltitude());// 单位：米
//           sb.Append("\ndirection : ");
//           sb.Append(location.getDirection());// 单位度
//           sb.Append("\naddr : ");
//           sb.Append(location.getAddrStr());
//           sb.Append("\ndescribe : ");
//           sb.Append("gps定位成功");

//        }
//        else if (location.getLocType() == BDLocation.TypeNetWorkLocation)
//        {// 网络定位结果
//           sb.Append("\naddr : ");
//           sb.Append(location.getAddrStr());
//            //运营商信息
//           sb.Append("\noperationers : ");
//           sb.Append(location.getOperators());
//           sb.Append("\ndescribe : ");
//           sb.Append("网络定位成功");
//        }
//        else if (location.getLocType() == BDLocation.TypeOffLineLocation)
//        {// 离线定位结果
//           sb.Append("\ndescribe : ");
//           sb.Append("离线定位成功，离线定位结果也是有效的");
//        }
//        else if (location.getLocType() == BDLocation.TypeServerError)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("服务端网络定位失败，可以反馈IMEI号和大体定位时间到loc-bugs@baidu.com，会有人追查原因");
//        }
//        else if (location.getLocType() == BDLocation.TypeNetWorkException)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("网络不同导致定位失败，请检查网络是否通畅");
//        }
//        else if (location.getLocType() == BDLocation.TypeCriteriaException)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("无法获取有效定位依据导致定位失败，一般是由于手机的原因，处于飞行模式下一般会造成这种结果，可以试着重启手机");
//        }
//       sb.Append("\nlocationdescribe : ");
//       sb.Append(location.getLocationDescribe());// 位置语义化信息
//        List<MapPoi> list = location.getPoiList();// POI数据
//        if (list != null)
//        {
//           sb.Append("\npoilist size = : ");
//           sb.Append(list.Size());
//            for (MapPoiClickEventArgs p : list)
//            {
//               sb.Append("\npoi= : ");
//               sb.Append(p.getId() + " " + p.getName() + " " + p.getRank());
//            }
//        }
//        Log.i("BaiduLocationApiDem", sb.toString());
//    }
//}