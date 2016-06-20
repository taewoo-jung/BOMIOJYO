package ftw.swcapstone.com.bomiojyo.data;

import android.app.Application;
import android.location.Location;

import java.util.ArrayList;

/**
 * Created by tw on 2016-05-27.
 */
public class AppData extends Application {


    private CustomArrayList routeData = new CustomArrayList();
    private ArrayList<Location> accidentData_public = new ArrayList<Location>();
    private ArrayList<Location> accidentData_child = new ArrayList<Location>();
    private ArrayList<Location> accidentData_oldman = new ArrayList<Location>();

    private int naviFlag = 0;

    public CustomArrayList getRouteData() {
        return routeData;
    }

    public void setRouteData(CustomArrayList routeData) {
        this.routeData = routeData;
    }

    public ArrayList<Location> getAccidentData_public() {
        return accidentData_public;
    }

    public void setAccidentData_public(ArrayList<Location> accidentData_public) {
        this.accidentData_public = accidentData_public;
    }

    public ArrayList<Location> getAccidentData_child() {
        return accidentData_child;
    }

    public void setAccidentData_child(ArrayList<Location> accidentData_child) {
        this.accidentData_child = accidentData_child;
    }

    public ArrayList<Location> getAccidentData_oldman() {
        return accidentData_oldman;
    }

    public void setAccidentData_oldman(ArrayList<Location> accidentData_oldman) {
        this.accidentData_oldman = accidentData_oldman;
    }

    public int getNaviFlag() {
        return naviFlag;
    }

    public void setNaviFlag(int naviFlag) {
        this.naviFlag = naviFlag;
    }
}
