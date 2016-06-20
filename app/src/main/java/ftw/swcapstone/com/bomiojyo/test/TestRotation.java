package ftw.swcapstone.com.bomiojyo.test;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.graphics.Matrix;
import android.os.Bundle;
import android.os.Environment;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.SeekBar;
import android.widget.Spinner;
import android.widget.TextView;

import ftw.swcapstone.com.bomiojyo.R;

/**
 * Created by tw on 2016-05-28.
 */
public class TestRotation extends Activity {

    private String imageSdCard;

    ImageView imageView;
    Spinner spinnerScale;
    SeekBar seekbarRotate;
    SeekBar seekbarSkewX, seekbarSkewY;
    TextView textSkewX, textSkewY;

    private static final String[] strScale = {
            "0.2x", "0.5x", "1.0x", "2.0x", "5.0x" };
    private static final Float[] floatScale = { 0.2F, 0.5F, 1F, 2F, 5F };
    private final int defaultSpinnerScaleSelection = 2;

    private ArrayAdapter<String> adapterScale;

    private float curScale = 1F;
    private float curRotate = 0F;
    private float curSkewX = 0F;
    private float curSkewY = 0F;
    private double degree;

    Bitmap bitmap;
    int bmpWidth, bmpHeight;

    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.test_rotation);

        degree = getIntent().getDoubleExtra("degree", 100.0);

        imageSdCard = Environment.getExternalStorageDirectory().toString() +  "/Download/view04.png";

        imageView = (ImageView) findViewById(R.id.imageview);

        spinnerScale = (Spinner) findViewById(R.id.scale);
        seekbarRotate = (SeekBar) findViewById(R.id.rotate);
        seekbarSkewX = (SeekBar) findViewById(R.id.skewx);
        seekbarSkewY = (SeekBar) findViewById(R.id.skewy);

        spinnerScale.setOnItemSelectedListener(spinScaleOnItemSelectedListener);
        seekbarRotate.setOnSeekBarChangeListener(seekbarRotateChangeListener);
        seekbarSkewX.setOnSeekBarChangeListener(seekbarSkewXChangeListener);
        seekbarSkewY.setOnSeekBarChangeListener(seekbarSkewYChangeListener);

        textSkewX = (TextView) findViewById(R.id.textskewx);
        textSkewY = (TextView) findViewById(R.id.textskewy);

        adapterScale = new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, strScale);
        adapterScale.setDropDownViewResource(
                android.R.layout.simple_spinner_dropdown_item);
        spinnerScale.setAdapter(adapterScale);
        spinnerScale.setSelection(defaultSpinnerScaleSelection);
        curScale = floatScale[defaultSpinnerScaleSelection];

        bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.direction);
        bmpWidth = bitmap.getWidth();
        bmpHeight = bitmap.getHeight();

        drawMatrix();


    }

    private void drawMatrix() {

        Matrix matrix = new Matrix();
        matrix.postScale(curScale, curScale);
        matrix.postRotate(curRotate);
        matrix.postSkew(curSkewX, curSkewY);

        Bitmap resizedBitmap = Bitmap.createBitmap(
                bitmap, 0, 0, bmpWidth, bmpHeight, matrix, true);
        imageView.setBackgroundColor(Color.WHITE);
        imageView.setImageBitmap(resizedBitmap);

    }

    private SeekBar.OnSeekBarChangeListener seekbarSkewYChangeListener =
            new SeekBar.OnSeekBarChangeListener() {

                public void onStopTrackingTouch(SeekBar seekBar) {
                }

                public void onStartTrackingTouch(SeekBar seekBar) {
                }

                public void onProgressChanged(SeekBar seekBar,
                                              int progress, boolean fromUser) {
                    curSkewY = (float) (progress - 100) / 100;
                    textSkewY.setText("Skew-Y: " + String.valueOf(curSkewY));
                    drawMatrix();
                }
            };

    private SeekBar.OnSeekBarChangeListener seekbarSkewXChangeListener =
            new SeekBar.OnSeekBarChangeListener() {

                public void onProgressChanged(SeekBar seekBar,
                                              int progress, boolean fromUser) {
                    curSkewX = (float) (progress - 100) / 100;
                    textSkewX.setText("Skew-X: " + String.valueOf(curSkewX));
                    drawMatrix();
                }

                public void onStartTrackingTouch(SeekBar seekBar) {
                }

                public void onStopTrackingTouch(SeekBar seekBar) {
                }
            };

    private SeekBar.OnSeekBarChangeListener seekbarRotateChangeListener =
            new SeekBar.OnSeekBarChangeListener() {

                public void onProgressChanged(SeekBar seekBar,
                                              int progress, boolean fromUser) {
                    curRotate = (float) progress;
                    drawMatrix();
                }

                public void onStartTrackingTouch(SeekBar seekBar) {
                }

                public void onStopTrackingTouch(SeekBar seekBar) {
                }
            };

    private Spinner.OnItemSelectedListener spinScaleOnItemSelectedListener =
            new Spinner.OnItemSelectedListener() {

                public void onItemSelected(AdapterView<?> arg0,
                                           View arg1, int arg2, long arg3) {
                    curScale = floatScale[arg2];
                    drawMatrix();
                }

                public void onNothingSelected(AdapterView<?> arg0) {
                    spinnerScale.setSelection(defaultSpinnerScaleSelection);
                    curScale = floatScale[defaultSpinnerScaleSelection];
                }
            };
}
