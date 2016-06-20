package ftw.swcapstone.com.bomiojyo.CustomView;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.skp.Tmap.TMapData;
import com.skp.Tmap.TMapPOIItem;

import java.util.ArrayList;

import ftw.swcapstone.com.bomiojyo.R;


/**
 * Created by tw on 2016-05-06.
 */
public class ListViewAdapter_location extends BaseAdapter {

    private Context mContext = null;
    private ArrayList<TMapPOIItem> mListItem = new ArrayList<TMapPOIItem>();

    public ListViewAdapter_location(Context mContext){
        super();
        this.mContext = mContext;
    }

    public ListViewAdapter_location(TMapData.FindAllPOIListenerCallback findAllPOIListenerCallback) {
        super();
    }

    @Override
    public int getCount() {
        return mListItem.size();
    }

    @Override
    public Object getItem(int position) {
        return mListItem.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ViewHolder holder;

        if(convertView == null){
            holder = new ViewHolder();

            LayoutInflater inflater = (LayoutInflater)mContext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = inflater.inflate(R.layout.list_view_item, null);

            holder.locationName = (TextView)convertView.findViewById(R.id.LIST_VIEW_LOCATION_NAME);
            holder.locationAddress = (TextView)convertView.findViewById(R.id.LIST_VIEW_LOCATION_ADDRESS);

            convertView.setTag(holder);
        } else{
            holder = (ViewHolder)convertView.getTag();
        }

        TMapPOIItem item = mListItem.get(position);

        holder.locationName.setText(item.getPOIName());
        //null 제거
        String temp = item.getPOIAddress().replace(" null", "");
        holder.locationAddress.setText(temp);


        return convertView;
    }

    public void setList(ArrayList<TMapPOIItem> items){
        mListItem.addAll(items);
    }
}
