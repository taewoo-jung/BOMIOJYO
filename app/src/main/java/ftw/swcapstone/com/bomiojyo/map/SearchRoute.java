package ftw.swcapstone.com.bomiojyo.map;

import android.app.Activity;
import android.content.Intent;
import android.location.Location;
import android.os.Bundle;
import android.os.StrictMode;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;

import ftw.swcapstone.com.bomiojyo.data.AppData;
import ftw.swcapstone.com.bomiojyo.data.CustomArrayList;
import ftw.swcapstone.com.bomiojyo.data.RoutePoint;

/**
 * Created by tw on 2016-05-04.
 */

public class SearchRoute extends Activity {

    private String routeURL, accidentURL_public, accidentURL_child, accidentURL_oldman;
    private String startX, startY, endX, endY, startName, endName, upperAdd, siDoCode;
    private Request request = new Request();
    private HashMap<String, Integer> siDo = new HashMap<String, Integer>();
    private HashMap<String, Integer> guGun = new HashMap<String, Integer>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        AppData data = (AppData)getApplicationContext();

        setCode();
        settingURI();

        String routeJSON = null;
        String accidentJSON = null;
        try {
            routeJSON = request.get(routeURL);
            data.setRouteData(parser_routeJSON(routeJSON));

            accidentJSON = request.get(accidentURL_public);
            data.setAccidentData_public(parser_accidentJSON(accidentJSON));

            accidentJSON = request.get(accidentURL_oldman);
            data.setAccidentData_oldman(parser_accidentJSON(accidentJSON));

            accidentJSON = request.get(accidentURL_child);
            data.setAccidentData_child(parser_accidentJSON(accidentJSON));

            data.setNaviFlag(0);

            Intent intent = new Intent(this, Map.class);
            startActivity(intent);

        } catch (IOException e) {
            e.printStackTrace();
        } catch (JSONException e) {
            e.printStackTrace();
        }


    }

//    public void onClick (View v) throws IOException {
//
//        int id = v.getId();
//
//        switch(id){
//            case R.id.REQUEST_BTN:
//                String jsonData = request.get(url);
//                TextView textView = (TextView)findViewById(R.id.RESULT_VIEW);
//                textView.setText(jsonData);
//                routeData = parser(jsonData);
//                break;
//            case R.id.VIEW_MAP_BTN:
//                Intent intent = new Intent(this, Map.class);
//                intent.putExtra("routeData", routeData);
//                startActivity(intent);
//                break;
//            default:
//                Log.e("[Error]", "Selection error");
//                break;
//        }
//
//    }

    public CustomArrayList parser_routeJSON(String json){
        CustomArrayList routeRes = new CustomArrayList();
        try {
            JSONObject jObject = new JSONObject(json);
            Double[][] coordTemp;
            ArrayList<Location> tempLocation = new ArrayList<Location>();
            JSONArray featureArray = new JSONArray(jObject.getString("features"));
            for(int i=0, j=0; i<featureArray.length(); i++){
                RoutePoint routePoint = new RoutePoint();
                JSONObject featureObj = featureArray.getJSONObject(i);
                JSONObject geometry = new JSONObject(featureObj.getString("geometry"));
                String geoType = geometry.getString("type");
                routePoint.setpType(geoType);
                JSONArray geoCoord = new JSONArray(geometry.getString("coordinates"));
                if(geoType.equals("Point")){
                    //coordinate
                    tempLocation = new ArrayList<Location>();
                    Location location = new Location("");
                    location.setLatitude(Double.parseDouble(geoCoord.get(1).toString()));
                    location.setLongitude(Double.parseDouble(geoCoord.get(0).toString()));
                    coordTemp = new Double[1][2];
                    coordTemp[0][0] = Double.parseDouble(geoCoord.get(0).toString());
                    coordTemp[0][1] = Double.parseDouble(geoCoord.get(1).toString());

                    tempLocation.add(location);
                    routePoint.setpLocation(tempLocation);
                    routePoint.setpCoord(coordTemp);
                }
                else{ // geoType == "LineString"
                    coordTemp = new Double[geoCoord.length()][2];
                    tempLocation = new ArrayList<Location>();
                    for(int l=0; l<geoCoord.length(); l++){

                        Location location = new Location("");
                        location.setLatitude(Double.parseDouble(geoCoord.getJSONArray(l).get(1).toString()));
                        location.setLongitude(Double.parseDouble(geoCoord.getJSONArray(l).get(0).toString()));
                        tempLocation.add(location);
                        coordTemp[l][0] = Double.parseDouble(geoCoord.getJSONArray(l).get(0).toString());
                        coordTemp[l][1] = Double.parseDouble(geoCoord.getJSONArray(l).get(1).toString());
                    }
                    routePoint.setpLocation(tempLocation);
                    routePoint.setpCoord(coordTemp);
                }
                JSONObject properties = new JSONObject(featureObj.getString("properties"));
                routePoint.setpDescription(properties.getString("description"));
                routePoint.setpName(properties.getString("name"));
                routeRes.add(routePoint);
            }
            return routeRes;

        } catch (JSONException e) {
            e.printStackTrace();
            return routeRes;
        }
    }

    public ArrayList<Location> parser_accidentJSON(String json) throws JSONException {
        Location tempLoc;
        String lon, lat;
        ArrayList<Location> temp = new ArrayList<Location>();

        JSONObject jObject = new JSONObject(json);
        JSONObject result = new JSONObject(jObject.getString("searchResult"));
        JSONArray frequentzone = new JSONArray(result.getString("frequentzone"));

        for(int i=0; i<frequentzone.length(); i++){
            JSONObject frequent = frequentzone.getJSONObject(i);
            tempLoc = new Location("");
            lon = frequent.getString("x_crd");
            lat = frequent.getString("y_crd");
            tempLoc.setLatitude(Double.parseDouble(lat.substring(0,9)));
            tempLoc.setLongitude(Double.parseDouble(lon.substring(0,10)));
            temp.add(tempLoc);
        }
//        for(int i=0; i<frequentzone.length(); i++) {
//            JSONObject frequent = frequentzone.getJSONObject(i);
//            JSONObject geometry = new JSONObject(frequent.getString("geometry"));
//            JSONArray geoCoord = new JSONArray(geometry.getString("coordinates"));
//            tempCoord = new Double[geoCoord.getJSONArray(0).length()][2];
//            for(int j=0; j<geoCoord.getJSONArray(0).length(); j++){
//                tempCoord[j][0] = Double.parseDouble(geoCoord.getJSONArray(0).getJSONArray(j).get(0).toString());
//                tempCoord[j][1] = Double.parseDouble(geoCoord.getJSONArray(0).getJSONArray(j).get(1).toString());
//            }
//            temp.add(tempCoord);
//        }
        return temp;
    }

    public void settingURI(){
        Intent intent = getIntent();
        startX = intent.getStringExtra("startX");
        startY = intent.getStringExtra("startY");
        endX = intent.getStringExtra("endX");
        endY = intent.getStringExtra("endY");
        //문자열 공백제거
        startName = intent.getStringExtra("startName").replace(" ", "");
        endName = intent.getStringExtra("endName").replace(" ", "");
        upperAdd = intent.getStringExtra("upperAdd");
        siDoCode = siDo.get(upperAdd).toString();


        routeURL = "https://apis.skplanetx.com/tmap/routes/pedestrian?version=1" +
                "&appKey=5f1b1ac2-1131-395d-9555-d6fff8eb3e4e" +
                "&startX="+startX+"&startY="+startY+
                "&endX="+endX+"&endY="+endY+
                "&reqCoordType=WGS84GEO&resCoordType=WGS84GEO"+"&searchOption=10"+
                "&startName="+startName+"&endName="+endName;

        accidentURL_public = "http://apis.data.go.kr/B552061/jaywalking/getRestJaywalking" +
                "?servicekey=kvgBH4wjBL%2BCHkUzxGVJ2nmA2m9VihIXWsQBczWv%2BTolzBRaqKgFYnf1VdWcXmq6M4bTQHbE05MMO01Ngix0Xg%3D%3D" +
                "&searchYearCd=2015052&siDo="+siDoCode;

        accidentURL_child = "http://apis.data.go.kr/B552061/frequentzoneChild/getRestFrequentzoneChild" +
                "?servicekey=kvgBH4wjBL%2BCHkUzxGVJ2nmA2m9VihIXWsQBczWv%2BTolzBRaqKgFYnf1VdWcXmq6M4bTQHbE05MMO01Ngix0Xg%3D%3D" +
                "&searchYearCd=2015049&siDo="+siDoCode;


        accidentURL_oldman = "http://apis.data.go.kr/B552061/frequentzoneOldman/getRestFrequentzoneOldman" +
                "?servicekey=kvgBH4wjBL%2BCHkUzxGVJ2nmA2m9VihIXWsQBczWv%2BTolzBRaqKgFYnf1VdWcXmq6M4bTQHbE05MMO01Ngix0Xg%3D%3D" +
                "&searchYearCd=2015048&siDo="+siDoCode;


    }

    public void setCode(){
        siDo.put("서울", 11);
        siDo.put("부산", 26);
        siDo.put("대구", 27);
        siDo.put("인천", 28);
        siDo.put("광주", 29);
        siDo.put("대전", 30);
        siDo.put("울산", 31);
        siDo.put("세종시", 36);
        siDo.put("경기", 41);
        siDo.put("강원", 42);
        siDo.put("충북", 43);
        siDo.put("충남", 44);
        siDo.put("전북", 45);
        siDo.put("전남", 46);
        siDo.put("경북", 47);
        siDo.put("경남", 48);
        siDo.put("제주", 50);
    }


}
