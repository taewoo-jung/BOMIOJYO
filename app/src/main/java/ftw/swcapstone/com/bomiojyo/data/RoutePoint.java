package ftw.swcapstone.com.bomiojyo.data;

import android.location.Location;

import java.io.Serializable;
import java.util.ArrayList;


/**
 * Created by tw on 2016-05-16.
 */
public class RoutePoint implements Serializable {

    public RoutePoint(){}

    private String pName;
    private String pDescription;
    private String pType;
    private Double[][] pCoord;
    private ArrayList<Location> pLocation;

    public ArrayList<Location> getpLocation() {
        return pLocation;
    }

    public void setpLocation(ArrayList<Location> pLocation) {
        this.pLocation = pLocation;
    }

    public String getpType() {
        return pType;
    }

    public void setpType(String pType) {
        this.pType = pType;
    }

    public String getpName() {
        return pName;
    }

    public void setpName(String pName) {
        this.pName = pName;
    }

    public String getpDescription() {
        return pDescription;
    }

    public void setpDescription(String pDescription) {
        this.pDescription = pDescription;
    }

    public Double[][] getpCoord() {
        return pCoord;
    }

    public void setpCoord(Double[][] pCoord) {
        this.pCoord = pCoord;
    }

    @Override
    public String toString(){
        if(this.pType.equals("Point")) {
            String data_forTizen;
            data_forTizen = this.pDescription + "/" + this.pCoord[0][1] + "/" + this.pCoord[0][0];
            return data_forTizen;
        } else {
            return "LineString";
        }
    }
}
