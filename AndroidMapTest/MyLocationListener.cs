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
//        {// GPS��λ���
//           sb.Append("\nspeed : ");
//           sb.Append(location.getSpeed());// ��λ������ÿСʱ
//           sb.Append("\nsatellite : ");
//           sb.Append(location.getSatelliteNumber());
//           sb.Append("\nheight : ");
//           sb.Append(location.getAltitude());// ��λ����
//           sb.Append("\ndirection : ");
//           sb.Append(location.getDirection());// ��λ��
//           sb.Append("\naddr : ");
//           sb.Append(location.getAddrStr());
//           sb.Append("\ndescribe : ");
//           sb.Append("gps��λ�ɹ�");

//        }
//        else if (location.getLocType() == BDLocation.TypeNetWorkLocation)
//        {// ���綨λ���
//           sb.Append("\naddr : ");
//           sb.Append(location.getAddrStr());
//            //��Ӫ����Ϣ
//           sb.Append("\noperationers : ");
//           sb.Append(location.getOperators());
//           sb.Append("\ndescribe : ");
//           sb.Append("���綨λ�ɹ�");
//        }
//        else if (location.getLocType() == BDLocation.TypeOffLineLocation)
//        {// ���߶�λ���
//           sb.Append("\ndescribe : ");
//           sb.Append("���߶�λ�ɹ������߶�λ���Ҳ����Ч��");
//        }
//        else if (location.getLocType() == BDLocation.TypeServerError)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("��������綨λʧ�ܣ����Է���IMEI�źʹ��嶨λʱ�䵽loc-bugs@baidu.com��������׷��ԭ��");
//        }
//        else if (location.getLocType() == BDLocation.TypeNetWorkException)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("���粻ͬ���¶�λʧ�ܣ����������Ƿ�ͨ��");
//        }
//        else if (location.getLocType() == BDLocation.TypeCriteriaException)
//        {
//           sb.Append("\ndescribe : ");
//           sb.Append("�޷���ȡ��Ч��λ���ݵ��¶�λʧ�ܣ�һ���������ֻ���ԭ�򣬴��ڷ���ģʽ��һ���������ֽ�����������������ֻ�");
//        }
//       sb.Append("\nlocationdescribe : ");
//       sb.Append(location.getLocationDescribe());// λ�����廯��Ϣ
//        List<MapPoi> list = location.getPoiList();// POI����
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