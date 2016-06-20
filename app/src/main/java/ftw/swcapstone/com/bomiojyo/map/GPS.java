package ftw.swcapstone.com.bomiojyo.map;

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.Service;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.Matrix;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Build;
import android.os.Bundle;
import android.os.IBinder;
import android.provider.Settings;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.widget.ImageView;
import android.widget.Toast;

import ftw.swcapstone.com.bomiojyo.R;

public class GPS extends Service implements LocationListener {

    private final Context mContext;
    private Criteria providerSetter = new Criteria();

    // 현재 GPS 사용유무
    boolean isGPSEnabled = false;

    // 네트워크 사용유무
    boolean isNetworkEnabled = false;

    boolean isLocationMangerEnabled = false;

    public boolean isLocationChanged() {
        return isLocationChanged;
    }

    public void setIsLocationChanged(boolean isLocationChanged) {
        this.isLocationChanged = isLocationChanged;
    }

    // GPS 상태값
    boolean isGetLocation = false;

    boolean isLocationChanged = false;

    Location location;
    double lat; // 위도
    double lon; // 경도

    // 최소 GPS 정보 업데이트 거리 m
    private static final long MIN_DISTANCE_CHANGE_FOR_UPDATES = 5;

    // 최소 GPS 정보 업데이트 시간 msec(1000*60*1 = 1분)
    private static final long MIN_TIME_BW_UPDATES = 1000 * 5;

    protected LocationManager locationManager;

    public GPS(Context context) {
        this.mContext = context;
        getLocation();
    }

    public Location getLocation() {

//        providerSetter.setAccuracy(Criteria.ACCURACY_COARSE);
//        providerSetter.setPowerRequirement(Criteria.POWER_MEDIUM);
//        providerSetter.setBearingRequired(true);

        try {
            locationManager = (LocationManager) mContext
                    .getSystemService(LOCATION_SERVICE);

//            locationManager.getBestProvider(providerSetter, true);
//            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
//                if (checkSelfPermission(Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && checkSelfPermission(Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
//                    // TODO: Consider calling
//                    //    public void requestPermissions(@NonNull String[] permissions, int requestCode)
//                    // here to request the missing permissions, and then overriding
//                    //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
//                    //                                          int[] grantResults)
//                    // to handle the case where the user grants the permission. See the documentation
//                    // for Activity#requestPermissions for more details.
//
//    //                return TODO;
//                    Toast.makeText(mContext, "GPS permission error...", Toast.LENGTH_SHORT).show();
//                }
//            }
//
//            isLocationMangerEnabled = locationManager.isProviderEnabled(
//                    locationManager.getBestProvider(providerSetter, true)
//            );
//
//            if(!isLocationMangerEnabled) {
//
//            } else {
//                this.isGetLocation = true;
//                locationManager.requestLocationUpdates(
//                        locationManager.getBestProvider(providerSetter, true),
//                        MIN_TIME_BW_UPDATES,
//                        MIN_DISTANCE_CHANGE_FOR_UPDATES,
//                        this
//                );
//                if (locationManager != null) {
//                    location = locationManager.getLastKnownLocation(locationManager.getBestProvider(providerSetter, true));
//                    if (location != null) {
//                        lat = location.getLatitude();
//                        lon = location.getLongitude();
//                    }
//                }
//            }

            isGPSEnabled = locationManager
                    .isProviderEnabled(LocationManager.GPS_PROVIDER);
            isNetworkEnabled = locationManager
                    .isProviderEnabled(LocationManager.NETWORK_PROVIDER);

            if (!isGPSEnabled && !isNetworkEnabled) {
            } else {
                this.isGetLocation = true;

                if (isGPSEnabled) {
                    if (location == null) {
                        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                            if (ContextCompat.checkSelfPermission(mContext, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED
                                    && ContextCompat.checkSelfPermission(mContext, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                                Toast.makeText(mContext, "Permission error", Toast.LENGTH_SHORT).show();
                                ActivityCompat.requestPermissions((Activity) mContext, new String[]{Manifest.permission.ACCESS_FINE_LOCATION}, 0);
                                ActivityCompat.requestPermissions((Activity) mContext, new String[]{Manifest.permission.ACCESS_COARSE_LOCATION}, 0);
                            }
                        }
                        locationManager.requestLocationUpdates(
                                LocationManager.GPS_PROVIDER,
                                MIN_TIME_BW_UPDATES,
                                MIN_DISTANCE_CHANGE_FOR_UPDATES, this);
                        if (locationManager != null) {
                            location = locationManager
                                    .getLastKnownLocation(LocationManager.GPS_PROVIDER);
                            if (location != null) {
                                lat = location.getLatitude();
                                lon = location.getLongitude();
                            }
                        }
                    }
                }

                if (isNetworkEnabled) {
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                        if (ContextCompat.checkSelfPermission(mContext, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED
                                && ContextCompat.checkSelfPermission(mContext, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                            ActivityCompat.requestPermissions((Activity) mContext, new String[]{Manifest.permission.ACCESS_FINE_LOCATION}, 0);
                            ActivityCompat.requestPermissions((Activity) mContext, new String[]{Manifest.permission.ACCESS_COARSE_LOCATION}, 0);
                            Toast.makeText(mContext, "Permission error", Toast.LENGTH_SHORT).show();
                        }
                    }
                }
                locationManager.requestLocationUpdates(
                        LocationManager.NETWORK_PROVIDER,
                        MIN_TIME_BW_UPDATES,
                        MIN_DISTANCE_CHANGE_FOR_UPDATES, this);
                if (locationManager != null) {
                    location = locationManager
                            .getLastKnownLocation(LocationManager.NETWORK_PROVIDER);
                    if (location != null) {
                        lat = location.getLatitude();
                        lon = location.getLongitude();
                    }
                }
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
        return location;
    }

    public void stopGPS() {
        if (locationManager != null) {
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                if (ContextCompat.checkSelfPermission(mContext,Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED
                        && ContextCompat.checkSelfPermission(mContext, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                    return;
                }
            }
            locationManager.removeUpdates(GPS.this);
        }
    }

    public double getLatitude(){
        if(location != null){
            lat = location.getLatitude();
        }
        return lat;
    }

    public double getLongitude(){
        if(location != null){
            lon = location.getLongitude();
        }
        return lon;
    }

    public boolean isGetLocation() {
        return this.isGetLocation;
    }

    public void showSettingsAlert(){
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(mContext);

        alertDialog.setTitle("GPS 설정오류");
        alertDialog.setMessage("GPS 사용설정이 안되있습니다.\n 설정창으로 가시겠습니까?");

        alertDialog.setPositiveButton("Settings",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        Intent intent = new Intent(Settings.ACTION_LOCATION_SOURCE_SETTINGS);
                        mContext.startActivity(intent);
                    }
                });

        alertDialog.setNegativeButton("Cancel",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.cancel();
                    }
                });

        alertDialog.show();
    }

    @Override
    public IBinder onBind(Intent arg0) {
        return null;
    }

    @Override
    public void onLocationChanged(Location location) {
        // TODO Auto-generated method stub

    }

    @Override
    public void onStatusChanged(String provider, int status, Bundle extras) {
        // TODO Auto-generated method stub

    }

    public void onProviderEnabled(String provider) {
        // TODO Auto-generated method stub

    }

    public void onProviderDisabled(String provider) {
        // TODO Auto-generated method stub

    }

    public void showDirection(double degree, Bitmap bitmap){
        Matrix matrix = new Matrix();
        matrix.setRotate((float)degree);

        Bitmap resize = Bitmap.createBitmap(bitmap, 0, 0, bitmap.getWidth(), bitmap.getHeight(), matrix, true);
        ImageView directionView = (ImageView)((Activity)mContext).findViewById(R.id.DIRECTION_IMAGE);
//        directionView.clearColorFilter();
//        directionView.setBackgroundColor();
        directionView.setImageBitmap(resize);

    }
}
