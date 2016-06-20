package ftw.swcapstone.com.bomiojyo.CustomView;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.TextView;

import ftw.swcapstone.com.bomiojyo.Main;
import ftw.swcapstone.com.bomiojyo.R;

/**
 * Created by tw on 2016-05-31.
 */
public class AlertDialog extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        Bundle bundle = getIntent().getExtras();
        String msg = bundle.getString("msg");
        setContentView(R.layout.alert_dialog);

        TextView alertMsg = (TextView)findViewById(R.id.DIALOG_TEXT);
        alertMsg.setText(msg);

        Button positiveBTN = (Button)findViewById(R.id.DIALOG_POSITIVE_BTN);
        positiveBTN.setOnClickListener(new PositiveOnClickListner());

        Button nagativeBTN = (Button)findViewById(R.id.DIALOG_NAGATIVE_BTN);
        nagativeBTN.setOnClickListener(new NagativeOnClickListner());
    }

    private class PositiveOnClickListner implements View.OnClickListener{

        @Override
        public void onClick(View v) {
            startActivity(new Intent(getApplicationContext(), Main.class));
        }
    }

    private class NagativeOnClickListner implements View.OnClickListener{

        @Override
        public void onClick(View v) {
            finish();
        }
    }
}
