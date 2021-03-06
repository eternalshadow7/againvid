package com.example.janelynncamingue.againvid;

/**
 * Created by Janelynn Camingue on 12/2/2017.
 */
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.pm.ResolveInfo;
import android.os.Bundle;
import android.telephony.SmsMessage;

import java.util.List;


public class BroadcastReceiverSMS extends BroadcastReceiver {

    public static final String SMS_BUNDLE = "pdus";

    public void onReceive(Context context, Intent intent) {
        Bundle intentExtras = intent.getExtras();
        intent.setComponent(null);

        List<ResolveInfo> l=context.getPackageManager().queryBroadcastReceivers(intent, 0);

        if (intentExtras != null) {
            Object[] sms = (Object[]) intentExtras.get(SMS_BUNDLE);
            String smsMessageStr = "";
            for (int i = 0; i < sms.length; ++i) {
                String format = intentExtras.getString("format");
                SmsMessage smsMessage = SmsMessage.createFromPdu((byte[]) sms[i], format);

                String smsBody = smsMessage.getMessageBody().toString();
                String address = smsMessage.getOriginatingAddress();

                // smsMessageStr += "SMS From: " + address + "\n";
                smsMessageStr += smsBody + "\n";
            }

            MainActivity inst = MainActivity.instance();
            inst.updateInbox(smsMessageStr);
        }
    }
}

