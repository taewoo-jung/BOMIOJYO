package ftw.swcapstone.com.bomiojyo.test;

import android.app.Activity;
import android.content.Intent;
import android.location.Location;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import ftw.swcapstone.com.bomiojyo.R;

/**
 * Created by tw on 2016-05-29.
 */
public class TestTriFunc extends Activity {

    private double radian;
    private double degree;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.test_trifunc);

        Location location1 = new Location("");
        location1.setLatitude(37.523291);
        location1.setLongitude(127.230458);

        Location location2 = new Location("");
        location2.setLatitude(37.394852);
        location2.setLongitude(127.246942);

        double a = Math.abs(location1.getLatitude() - location2.getLatitude());
        double b = Math.abs(location1.getLongitude() - location2.getLongitude());

        radian = Math.atan2(b, a);
        degree = Math.toDegrees(radian);

        TextView tv = (TextView)findViewById(R.id.TRI_FUNC_1);
        tv.setText("Radian : "+ radian+"\nDegree : "+degree);

    }

    public void onClick(View v){
        int id = v.getId();

        switch(id){
            case R.id.TRI_FUNC_BTN:
                Intent intent = new Intent(this, TestRotation.class);
                intent.putExtra("degree", degree);
                startActivity(intent);
                break;
        }
    }
}

