package ftw.swcapstone.com.bomiojyo.test;

import android.app.Activity;
import android.graphics.Color;
import android.os.Bundle;
import android.os.StrictMode;
import android.widget.LinearLayout;

import com.skp.Tmap.TMapCircle;
import com.skp.Tmap.TMapPoint;
import com.skp.Tmap.TMapPolygon;
import com.skp.Tmap.TMapView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.ArrayList;

import ftw.swcapstone.com.bomiojyo.map.Request;


/**
 * Created by tw on 2016-05-18.
 */
public class TestMap extends Activity {

    private String url = "http://apis.data.go.kr/B552061/jaywalking/getRestJaywalking?servicekey=kvgBH4wjBL%2BCHkUzxGVJ2nmA2m9VihIXWsQBczWv%2BTolzBRaqKgFYnf1VdWcXmq6M4bTQHbE05MMO01Ngix0Xg%3D%3D&searchYearCd=2015052&siDo=11&guGun=680";
    Request request = new Request();
    private ArrayList<Double[][]> temp = new ArrayList<Double[][]>();
    private TMapPolygon tempPolygon = new TMapPolygon();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        String jsonData;
        super.onCreate(savedInstanceState);

        StrictMode.setThreadPolicy(new StrictMode.ThreadPolicy.Builder().permitNetwork().build());

        //설정된 출발지, 목적지에 대한 지도 표시(T map)
        TMapView tmapView = new TMapView(this);
        TMapCircle tCircle = new TMapCircle();
        ArrayList<TMapPolygon> tPolygon = new ArrayList<TMapPolygon>();

        tCircle.setAreaColor(Color.RED);
        tCircle.setLineColor(Color.RED);
        tCircle.setAreaAlpha(50);
        tCircle.setCenterPoint(new TMapPoint(37.4934222405449, 127.061144182759));
        tCircle.setRadius(300);


        try {
            jsonData = request.get(url);
            parser(jsonData);

            TMapPoint testPoint;
            for(int i=0; i<temp.size(); i++){
                for(int j=0; j<temp.get(i).length; j++){
                    tempPolygon.addPolygonPoint(new TMapPoint(temp.get(i)[j][1], temp.get(i)[j][0]));
                }
                tempPolygon.setAreaColor(Color.BLUE);
                tempPolygon.setLineColor(Color.BLUE);
                tempPolygon.setAreaAlpha(50);
                tmapView.addTMapPolygon(String.valueOf(i), tempPolygon);
            }

//            routeLineData = tmapData.findPathDataWithType(TMapData.TMapPathType.PEDESTRIAN_PATH, tPoint1, tPoint4);
            LinearLayout mapLayout = new LinearLayout(this);

//            tmapView.addTMapPath(routeLineData);
            tmapView.addTMapCircle("3", tCircle);

            tmapView.setCenterPoint(127.061144182759, 37.4934222405449);
            tmapView.setZoomLevel(17);

            mapLayout.addView(tmapView);
            setContentView(mapLayout);

        } catch (IOException e) {
            e.printStackTrace();
        } catch (JSONException e) {
            e.printStackTrace();
        }


    }

    public void parser(String json) throws JSONException {
        Double[][] tempCoord = null;

        JSONObject jObject = new JSONObject(json);
        JSONObject result = new JSONObject(jObject.getString("searchResult"));
        JSONArray frequentzone = new JSONArray(result.getString("frequentzone"));
        for(int i=0; i<frequentzone.length(); i++) {
            JSONObject frequent = frequentzone.getJSONObject(i);
            JSONObject geometry = new JSONObject(frequent.getString("geometry"));
            JSONArray geoCoord = new JSONArray(geometry.getString("coordinates"));
            tempCoord = new Double[geoCoord.getJSONArray(0).length()][2];
            for(int j=0; j<geoCoord.getJSONArray(0).length(); j++){
                tempCoord[j][0] = Double.parseDouble(geoCoord.getJSONArray(0).getJSONArray(j).get(0).toString());
                tempCoord[j][1] = Double.parseDouble(geoCoord.getJSONArray(0).getJSONArray(j).get(1).toString());
            }
            String spotName = frequent.getString("spotname");
            temp.add(tempCoord);
        }
    }
}
