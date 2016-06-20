package ftw.swcapstone.com.bomiojyo.test;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.skp.Tmap.TMapData;

import org.xml.sax.SAXException;

import java.io.IOException;

import javax.xml.parsers.ParserConfigurationException;

import ftw.swcapstone.com.bomiojyo.R;
import ftw.swcapstone.com.bomiojyo.map.GPS;

import static android.widget.Toast.LENGTH_SHORT;

/**
 * Created by tw on 2016-05-25.
 */
public class TestGps extends Activity{

    // GPSTracker class
    private GPS gps;
    private TMapData tmapData = new TMapData();

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.test_gps);



        Button btn = (Button)findViewById(R.id.testGps_btn);
        // GPS 정보를 보여주기 위한 이벤트 클래스 등록
        btn.setOnClickListener(new View.OnClickListener() {

            public void onClick(View arg0) {
                gps = new GPS(TestGps.this);
                // GPS 사용유무 가져오기
                if (gps.isGetLocation()) {

                    double latitude = gps.getLatitude();
                    double longitude = gps.getLongitude();

                    Toast.makeText(
                            getApplicationContext(),
                            "당신의 위치 - \n위도: " + latitude + "\n경도: " + longitude,
                            Toast.LENGTH_LONG).show();

                    String address = null;
                    try {
                        address = tmapData.convertGpsToAddress(latitude, longitude);
                        Toast.makeText(TestGps.this, address, LENGTH_SHORT).show();

                    } catch (IOException e) {
                        e.printStackTrace();
                    } catch (ParserConfigurationException e) {
                        e.printStackTrace();
                    } catch (SAXException e) {
                        e.printStackTrace();
                    }


                    TextView tv = (TextView)findViewById(R.id.testGps);
                    tv.setText("위도 : "+latitude+"\n경도 : "+longitude);
                } else {
                    // GPS 를 사용할수 없으므로
                    gps.showSettingsAlert();
                }
            }
        });
    }

}
