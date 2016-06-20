package ftw.swcapstone.com.bomiojyo.test;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.location.Location;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import com.skp.Tmap.TMapData;
import com.skp.Tmap.TMapPoint;

import org.xml.sax.SAXException;

import java.io.IOException;

import javax.xml.parsers.ParserConfigurationException;

import ftw.swcapstone.com.bomiojyo.R;
import ftw.swcapstone.com.bomiojyo.connection.ConsumerActivity;
import ftw.swcapstone.com.bomiojyo.data.AppData;
import ftw.swcapstone.com.bomiojyo.map.GPS;

/**
 * Created by tw on 2016-05-23.
 */
public class Navigate extends Activity {

    private GPS_forNavi gps;
    private TMapPoint myLocation;
    private double x, y;
    private double radian, degree;
    Bitmap direction;
    TMapData tmapData = new TMapData();
    AppData data;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.test_navigate);

        data = (AppData)getApplicationContext();

        gps = new GPS_forNavi(this);
        if(gps.isGetLocation()) {

            try {
                TextView textLocation = (TextView)findViewById(R.id.MYLOCATION);
                textLocation.setText("위도 : " + gps.getLatitude() +
                        ", 경도 : " + gps.getLongitude()+
                        "\n위치 : " + tmapData.convertGpsToAddress(gps.getLatitude(), gps.getLongitude()));
                TextView descriptionText = (TextView)findViewById(R.id.DESCRIPTION);
                descriptionText.setText(data.getRouteData().get(data.getNaviFlag()).getpDescription());
                TextView pointLocationText = (TextView)findViewById(R.id.POINT_LOCATION);
                pointLocationText.setText("위도 : "+data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][1]+
                        "\n경도 : "+data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][0]+
                        "\n다음위치 : "+data.getRouteData().get(data.getNaviFlag()).getpName());
            } catch (IOException e) {
                e.printStackTrace();
            } catch (ParserConfigurationException e) {
                e.printStackTrace();
            } catch (SAXException e) {
                e.printStackTrace();
            }
            Toast.makeText(this, "GPS start", Toast.LENGTH_SHORT).show();
        } else {
            gps.showSettingsAlert();
        }

        direction = BitmapFactory.decodeResource(getResources(), R.drawable.direction);
    }

    public void onClick(View view){
        int id = view.getId();

        switch(id){
            case R.id.GPS_BTN:
                gps.stopGPS();
                startActivity(new Intent(this, ConsumerActivity.class));
                break;
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        gps.stopGPS();
    }

    public class GPS_forNavi extends GPS {

        public GPS_forNavi(Context context) {
            super(context);
        }

        @Override
        public void onLocationChanged(Location location) {
            super.onLocationChanged(location);

            TextView descriptionText = (TextView)findViewById(R.id.DESCRIPTION);
            TextView pointLocationText = (TextView)findViewById(R.id.POINT_LOCATION);
            Bitmap direction;

            Location pointLocation = new Location("");
            pointLocation.setLatitude(data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][1]);
            pointLocation.setLongitude(data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][0]);



//            if(!isLocationChanged) { //첫 안내 point
//                descriptionText.setText(data.getRouteData().get(data.getNaviFlag()).getpDescription());
//                pointLocationText.setText("위도 : "+data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][1]+
//                        "\n경도 : "+data.getRouteData().get(data.getNaviFlag()).getpCoord()[data.getNaviFlag()][0]+
//                        "\n다음위치 : "+data.getRouteData().get(data.getNaviFlag()).getpName());
//                isLocationChanged = true;
//            } else {
                float distance = location.distanceTo(pointLocation);
                double x = Math.abs(pointLocation.getLatitude() - location.getLatitude());
                double y = Math.abs(pointLocation.getLongitude() - location.getLongitude());
                double rad = Math.atan2(y, x);
                double deg = Math.toDegrees(rad);
                Toast.makeText(Navigate.this, String.valueOf(distance)+"m", Toast.LENGTH_SHORT).show();
                direction = BitmapFactory.decodeResource(Navigate.this.getResources(), R.drawable.direction);
                showDirection(deg, direction);

                if(distance < 8) { //point 접근
                    Toast.makeText(Navigate.this, "다음 포인트로 안내합니다.", Toast.LENGTH_SHORT).show();
                    data.setNaviFlag(data.getNaviFlag() + 1);
                    if(data.getRouteData().get(data.getNaviFlag()).getpType().equals("Point")){
                        descriptionText.setText(data.getRouteData().get(data.getNaviFlag()).getpDescription());
                        pointLocationText.setText("위도 : " + data.getRouteData().get(data.getNaviFlag()).getpCoord()[0][1] +
                                "\n경도 : " + data.getRouteData().get(data.getNaviFlag()).getpCoord()[0][0]);
                    }
//                    for(int i=0; i<data.getRouteData().get(data.getNaviFlag()).getpLocation().size(); i++) {
//                        descriptionText.setText(data.getRouteData().get(data.getNaviFlag()).getpDescription());
//                        pointLocationText.setText("위도 : " + data.getRouteData().get(data.getNaviFlag()).getpCoord()[i][1] +
//                                "\n경도 : " + data.getRouteData().get(data.getNaviFlag()).getpCoord()[i][0]);
//
//                    }

                } else if(data.getNaviFlag() == data.getRouteData().size()) {
                    Toast.makeText(Navigate.this, "목적지에 도착하였습니다.", Toast.LENGTH_SHORT).show();
                    onDestroy();
                }

//            }
        }
    }




}
