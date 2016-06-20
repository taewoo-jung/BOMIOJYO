package ftw.swcapstone.com.bomiojyo.map;

import android.app.Activity;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.graphics.Color;
import android.location.Location;
import android.os.Bundle;
import android.os.IBinder;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.skp.Tmap.TMapCircle;
import com.skp.Tmap.TMapMarkerItem;
import com.skp.Tmap.TMapPoint;
import com.skp.Tmap.TMapPolyLine;
import com.skp.Tmap.TMapView;

import java.util.ArrayList;

import ftw.swcapstone.com.bomiojyo.R;
import ftw.swcapstone.com.bomiojyo.connection.ConsumerService;
import ftw.swcapstone.com.bomiojyo.data.AppData;
import ftw.swcapstone.com.bomiojyo.data.RoutePoint;

/**
 * Created by tw on 2016-05-02.
 */
public class Map extends Activity {

    private ArrayList<RoutePoint> routeData = new ArrayList<RoutePoint>();
    private ArrayList<Location> accidentData_public = new ArrayList<Location>();
    private ArrayList<Location> accidentData_child = new ArrayList<Location>();
    private ArrayList<Location> accidentData_oldman = new ArrayList<Location>();

    //gear와 통신
    private ConsumerService mConsumerService = null;
    private boolean mIsBound = false;

    //경보알람
    boolean checkArea_accident_public = false;
    boolean checkArea_accident_oldman = false;
    boolean checkArea_accident_child = false;

    int markerNum = 0;

    LinearLayout mapLayout;
    GPS_forMap gps;
    TMapView tmapView;
    AppData data;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.map_view);

        initData();

        gps = new GPS_forMap(this);
        if(gps.isGetLocation()){
            mapSetting(gps.getLocation());
        } else {
            gps.showSettingsAlert();
        }

        mIsBound = bindService(new Intent(Map.this, ConsumerService.class), mConnection, Context.BIND_AUTO_CREATE);


    }



    public void initData(){
        data = (AppData)getApplicationContext();

        routeData = data.getRouteData();
        accidentData_public = data.getAccidentData_public();
        accidentData_oldman = data.getAccidentData_oldman();
        accidentData_child = data.getAccidentData_child();
    }

    public void mapSetting(Location location){
        mapLayout = (LinearLayout)findViewById(R.id.MAP_LAYOUT);
        mapLayout.removeAllViews();
        tmapView = new TMapView(this);
        TMapPolyLine routeLineData = new TMapPolyLine();

        for (int i = 0; i < routeData.size(); i++) {
            for(int j=0; j<routeData.get(i).getpCoord().length; j++) {
                routeLineData.addLinePoint(new TMapPoint(routeData.get(i).getpCoord()[j][1], routeData.get(i).getpCoord()[j][0]));
            }
        }

        routeLineData.setLineColor(Color.BLUE);
        routeLineData.setLineWidth(2);
        tmapView.setCenterPoint(routeData.get(0).getpCoord()[0][0], routeData.get(0).getpCoord()[0][1]);
        tmapView.addTMapPath(routeLineData);

        if(accidentData_public != null || accidentData_oldman != null || accidentData_child != null) {
            //보행자(일반) 교통사고 다발지역 polygon 저장
            for (int i = 0; i < accidentData_public.size(); i++) {
                TMapCircle tempCircle = new TMapCircle();
                tempCircle.setCenterPoint(new TMapPoint(accidentData_public.get(i).getLatitude(), accidentData_public.get(i).getLongitude()));

                //일반인 보행자의 경우 중심좌표기준 300m
                tempCircle.setRadius(300);
                tempCircle.setLineAlpha(50);
                tempCircle.setAreaAlpha(50);
                tempCircle.setAreaColor(Color.RED);
                tempCircle.setLineColor(Color.RED);
                tmapView.addTMapCircle("accident_public_" + String.valueOf(i + 1), tempCircle);
            }

            //보행자(노인) 교통사고 다발지역 polygon 저장
            for(int i=0; i<accidentData_oldman.size(); i++){
                TMapCircle tempCircle = new TMapCircle();
                tempCircle.setCenterPoint(new TMapPoint(accidentData_oldman.get(i).getLatitude(), accidentData_oldman.get(i).getLongitude()));

                //노인 보행자의 경우 중심좌표기준 200m
                tempCircle.setRadius(200);
                tempCircle.setLineAlpha(50);
                tempCircle.setAreaAlpha(50);
                tempCircle.setAreaColor(Color.BLUE);
                tempCircle.setLineColor(Color.BLUE);
                tmapView.addTMapCircle("accident_oldman_"+String.valueOf(i+1), tempCircle);
            }

            //보행자(어린이) 교통사고 다발지역 polygon
            for(int i=0; i<accidentData_child.size(); i++){
                TMapCircle tempCircle = new TMapCircle();
                tempCircle.setCenterPoint(new TMapPoint(accidentData_child.get(i).getLatitude(), accidentData_child.get(i).getLongitude()));

                //어린이 보행자의 경우 중심좌표기준 200m
                tempCircle.setRadius(200);
                tempCircle.setLineAlpha(50);
                tempCircle.setAreaAlpha(50);
                tempCircle.setAreaColor(Color.CYAN);
                tempCircle.setLineColor(Color.CYAN);
                tmapView.addTMapCircle("accident_child_"+String.valueOf(i+1), tempCircle);
            }
        }

        tmapView.setZoomLevel(18);

        TMapPoint myPoint = new TMapPoint(gps.getLatitude(), gps.getLongitude());
        TMapMarkerItem myPointMarker = new TMapMarkerItem();
        myPointMarker.setTMapPoint(myPoint);
        myPointMarker.setVisible(TMapMarkerItem.VISIBLE);

//        tmapView.addMarkerItem("myPoint"+markerNum, myPointMarker);
        markerNum++;


        mapLayout.addView(tmapView);
    }

    private final ServiceConnection mConnection = new ServiceConnection() {
        @Override
        public void onServiceConnected(ComponentName className, IBinder service) {
            mConsumerService = ((ConsumerService.LocalBinder) service).getService();
            mConsumerService.findPeers();
        }

        @Override
        public void onServiceDisconnected(ComponentName className) {
            mConsumerService = null;
            mIsBound = false;
        }
    };

    public void onClick(View view){
        int id = view.getId();

        switch(id){
            case R.id.NAVIGATE_BTN:



                if(mIsBound == true && mConsumerService != null){
                    mConsumerService.findPeers();
                } else {
                    Toast.makeText(this, "뭔가가 오류...", Toast.LENGTH_LONG).show();
                }

                if(mIsBound == true && mConsumerService != null) {

                    if(mConsumerService.sendData(data.getRouteData().toString())){

                    } else {
                        Toast.makeText(this, R.string.ConnectionAlreadyDisconnected, Toast.LENGTH_LONG).show();
                    }
                }
                break;
            case R.id.ROUTE_BTN:
                android.app.AlertDialog.Builder routeAD = new android.app.AlertDialog.Builder(Map.this);
                routeAD.setMessage(data.getRouteData().toString());
                routeAD.setPositiveButton("OK", null);
                routeAD.show();
                break;
        }

    }

    @Override
    protected void onDestroy(){
        super.onDestroy();
        gps.stopGPS();
    }

    public class GPS_forMap extends GPS{

        public GPS_forMap(Context context) {
            super(context);
        }

        @Override
        public void onLocationChanged(Location location) {
            super.onLocationChanged(location);
            double distance_accident_public, distance_accident_oldman, distance_accident_child;


            for(int i=0; i<accidentData_public.size(); i++){
                distance_accident_public = location.distanceTo(accidentData_public.get(i));
                if(distance_accident_public < 300 && !checkArea_accident_public){
                    Toast.makeText(Map.this, "보행자 무당횡단 사고 주의구역입니다.\n조심하세요", Toast.LENGTH_SHORT).show();
                    mConsumerService.sendData("accident/public");
                    checkArea_accident_public = true;
                }
            }

            for(int i=0; i<accidentData_child.size(); i++){
                distance_accident_child = location.distanceTo(accidentData_child.get(i));
                if(distance_accident_child < 200 && !checkArea_accident_child){
                    Toast.makeText(Map.this, "보행자(어린이) 사고 다발지역입니다. \n주의하세요", Toast.LENGTH_SHORT).show();
                    mConsumerService.sendData("accident/child");
                    checkArea_accident_child = true;
                }
            }

            for(int i=0; i<accidentData_oldman.size(); i++){
                distance_accident_oldman = location.distanceTo(accidentData_oldman.get(i));
                if(distance_accident_oldman < 200 && !checkArea_accident_oldman){
                    Toast.makeText(Map.this, "보행자(노약자) 사고 다발지역입니다. \n주의하세요", Toast.LENGTH_SHORT).show();
                    mConsumerService.sendData("accident/oldman");
                    checkArea_accident_oldman= true;
                }
            }

            if(gps.isLocationChanged()) {
                mConsumerService.sendData("GPS/" + location.getLatitude() + "/" + location.getLongitude());
//                mapSetting(location);
            } else {
                gps.setIsLocationChanged(true);
            }
        }
    }

}


