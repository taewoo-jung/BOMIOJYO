package ftw.swcapstone.com.bomiojyo.map;

import android.os.StrictMode;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;

import java.io.IOException;

/**
 * Created by tw on 2016-05-20.
 */
public class Request {

    public Request(){};

    public String get(String url) throws IOException {

        StrictMode.setThreadPolicy(new StrictMode.ThreadPolicy.Builder().permitNetwork().build());

        String result;

        HttpGet httpGet = new HttpGet(url);
        HttpClient httpClient = new DefaultHttpClient();
        HttpResponse response = httpClient.execute(httpGet);
        HttpEntity entity = response.getEntity();
        result = EntityUtils.toString(entity);

        return result;
    }
}
