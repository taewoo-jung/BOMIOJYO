package ftw.swcapstone.com.bomiojyo.data;

import java.util.ArrayList;

/**
 * Created by tw on 2016-05-27.
 */
public class CustomArrayList extends ArrayList<RoutePoint> {
    private static final long serialVersionUID = 1L;

    @Override
    public String toString(){
        String res = "";

        for(int i=0; i<this.size(); i++){
            if(this.get(i).getpType().equals("Point")){
                res += this.get(i).toString()+",";
            }

        }

        return res;
    }
}
