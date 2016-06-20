package ftw.swcapstone.com.bomiojyo.map;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Toast;

import com.skp.Tmap.TMapData;
import com.skp.Tmap.TMapPOIItem;
import com.skp.Tmap.TMapPoint;

import org.xml.sax.SAXException;

import java.io.IOException;
import java.util.ArrayList;

import javax.xml.parsers.ParserConfigurationException;

import ftw.swcapstone.com.bomiojyo.CustomView.ListViewAdapter_location;
import ftw.swcapstone.com.bomiojyo.R;

/**
 * Created by tw on 2016-05-04.
 */

public class SearchLocation extends Activity {

    private String startName, destName;
    private ArrayList<TMapPOIItem> items_start, items_dest;
    private TMapData tmapData = new TMapData();
    private TMapPOIItem start, dest;
    private ListView listView;
    private GPS gps;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.start_dest);

        StrictMode.setThreadPolicy(new StrictMode.ThreadPolicy.Builder().permitNetwork().build());



    }

    public void onClick(View v) throws ParserConfigurationException, SAXException, IOException {
        int id = v.getId();

        listView = (ListView)findViewById(R.id.LOCATION_LIST);
        ListViewAdapter_location locationAdapter = new ListViewAdapter_location(this);

        switch(id){
            case R.id.CURRENT_LOCATION:
                gps = new GPS(this);
                if(gps.isGetLocation()) {
                    Double lon = gps.getLongitude();
                    Double lat = gps.getLatitude();
                    if(lon == 0 || lat == 0){
                        Toast.makeText(this, "위치검색이 되지 않습니다.\n다시시도 해주세요", Toast.LENGTH_SHORT).show();
                        break;
                    }
                    String address = tmapData.convertGpsToAddress(lat, lon);
                    Toast.makeText(this, address, Toast.LENGTH_SHORT).show();
                    TMapPOIItem tempItem = tmapData.findAddressPOI(address).get(0);
                    showDialog(tempItem);
                } else {
                    gps.showSettingsAlert();
                }
                gps.stopGPS();
                break;

            case R.id.START_POINT_BTN:
                EditText startPoint = (EditText)findViewById(R.id.START_POINT);
                startName = startPoint.getText().toString();
                listView.setVisibility(View.VISIBLE);
                items_start = searchLocation(startName, 1);
                //검색결과가 존재하지 않을 때
                if(items_start == null){
                    Toast.makeText(SearchLocation.this, "검색결과가 존재하지 않습니다. \n다시 입력해주세요", Toast.LENGTH_LONG).show();
                    break;
                }
                locationAdapter.setList(items_start);
                listView.setAdapter(locationAdapter);
                listView.setOnItemClickListener(listener_startpoint);
                break;
            case R.id.DEST_POINT_BTN:
                EditText destPoint = (EditText)findViewById(R.id.DEST_POINT);
                destName = destPoint.getText().toString();
                listView.setVisibility(View.VISIBLE);
                items_dest = searchLocation(destName, 2);
                //검색결과가 존재하지 않을 때
                if(items_dest == null){
                    Toast.makeText(SearchLocation.this, "검색결과가 존재하지 않습니다. \n다시 입력해주세요", Toast.LENGTH_LONG).show();
                    break;
                }
                locationAdapter.setList(items_dest);
                listView.setAdapter(locationAdapter);
                listView.setOnItemClickListener(listener_destpoint);
                break;
            case R.id.ROUTE_SEARCH_BTN_URI:

                Toast.makeText(SearchLocation.this, "경로검색을 시작합니다", Toast.LENGTH_SHORT).show();
//                searchRoute(start, dest);
                Intent intent = new Intent(this, SearchRoute.class);
                intent.putExtra("startX", start.frontLon);
                intent.putExtra("startY", start.frontLat);
                intent.putExtra("endX", dest.frontLon);
                intent.putExtra("endY", dest.frontLat);
                intent.putExtra("startName", startName);
                intent.putExtra("endName", destName);
                intent.putExtra("upperAdd", start.upperAddrName);
                startActivity(intent);

                break;
            default:
                break;
        }

    }
    public ArrayList<TMapPOIItem> searchLocation(String name, int flag){

        ArrayList<TMapPOIItem> items = new ArrayList<TMapPOIItem>();

        //출발지 설정
        if(flag == 1) {
            try {
                items = tmapData.findAllPOI(name);
                return items;
            } catch (IOException e) {
                e.printStackTrace();
            } catch (ParserConfigurationException e) {
                e.printStackTrace();
            } catch (SAXException e) {
                e.printStackTrace();
            }
        } else { //목적지 설정(출발지 기준)
            if(start == null){
                Toast.makeText(SearchLocation.this, "출발지를 먼저 입력해주세요.", Toast.LENGTH_LONG).show();
            }
            else {
                TMapPoint central = new TMapPoint(Double.parseDouble(start.frontLat), Double.parseDouble(start.frontLon));
                try {
                    //출발지와 목적지 사이의 거리 약 10km(9900m)로 제한
                    items = tmapData.findAroundKeywordPOI(central, name, 33, 20);
                    if (items == null) {
                        Toast.makeText(SearchLocation.this, "출발지와 목적지 사이의 거리는 10km로 제한되어있습니다. \n다시 검색해주세요.", Toast.LENGTH_LONG).show();
                    }
                    return items;
                } catch (IOException e) {
                    e.printStackTrace();
                } catch (ParserConfigurationException e) {
                    e.printStackTrace();
                } catch (SAXException e) {
                    e.printStackTrace();
                }
            }
        }

        return items;
    }

    AdapterView.OnItemClickListener listener_startpoint = new AdapterView.OnItemClickListener(){

        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
            start = items_start.get(position);
            startName = start.getPOIName();
            listView.setVisibility(View.GONE);

            EditText text = (EditText)findViewById(R.id.START_POINT);
            text.setText(start.getPOIName());

            Toast.makeText(SearchLocation.this, "목적지를 입력하세요", Toast.LENGTH_SHORT).show();

        }
    };

    AdapterView.OnItemClickListener listener_destpoint = new AdapterView.OnItemClickListener(){

        @Override
        public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
            dest = items_dest.get(position);
            destName = dest.getPOIName();
            listView.setVisibility(View.GONE);
            if(dest.getPOIID().equals(start.getPOIID())==true){
                Toast.makeText(SearchLocation.this, "출발지와 목적지가 같습니다. \n다시 입력하여주세요", Toast.LENGTH_LONG).show();
                dest=null;
            }
            else {
                Toast.makeText(SearchLocation.this, "출발지, 목적지 설정이 완료되었습니다", Toast.LENGTH_SHORT).show();
                EditText text = (EditText)findViewById(R.id.DEST_POINT);
                text.setText(dest.getPOIName());

                LinearLayout searchBTNLayout = (LinearLayout)findViewById(R.id.SEARCH_BTN_LAYOUT);
                searchBTNLayout.setVisibility(View.VISIBLE);

            }
        }
    };

    public void showDialog(final TMapPOIItem poi){
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);

        alertDialog.setTitle("출발지 설정");
        alertDialog.setMessage("현재위치는 " + poi.getPOIName() + "입니다.\n출발지로 설정하시겠습니까?");

        // OK 를 누르게 되면 설정창으로 이동합니다.
        alertDialog.setPositiveButton("출발지 설정",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        start = poi;
                        EditText editText = (EditText)findViewById(R.id.START_POINT);
                        editText.setText(poi.getPOIName());
                        startName = poi.getPOIName();
                        gps.stopGPS();
                    }
                });

        // Cancle 하면 종료 합니다.
        alertDialog.setNegativeButton("직접 검색",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.cancel();
                        gps.stopGPS();
                    }
                });

        alertDialog.show();
    }
}