//
// Source code recreated from a .class file by IntelliJ IDEA
// (powered by Fernflower decompiler)
//

package com.example.hyz.devinterface;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;

public class Device {
    private static Context mContext;

    public Device() {
    }

    public static void onCreate(Context context) {
        mContext = context;
    }

    private static Context getContext() {
        return mContext;
    }

    public static String getVersionName() {
        Context mContext = getContext();
        PackageManager pmagr = mContext.getPackageManager();

        try {
            PackageInfo packageInfo = pmagr.getPackageInfo(mContext.getPackageName(), 0);
            return packageInfo.versionName;
        } catch (Exception var3) {
            var3.printStackTrace();
            return null;
        }
    }

    public static int getVersionCode() {
        Context mContext = getContext();
        PackageManager pmagr = mContext.getPackageManager();

        try {
            PackageInfo packageInfo = pmagr.getPackageInfo(mContext.getPackageName(), 0);
            return packageInfo.versionCode;
        } catch (Exception var3) {
            var3.printStackTrace();
            return 0;
        }
    }

    private static String getAppName() {
        Context mContext = getContext();
        PackageManager pmagr = mContext.getPackageManager();

        try {
            PackageInfo packageInfo = pmagr.getPackageInfo(mContext.getPackageName(), 0);
            ApplicationInfo applicationInfo = packageInfo.applicationInfo;
            int labelRes = applicationInfo.labelRes;
            return mContext.getResources().getString(labelRes);
        } catch (Exception var5) {
            var5.printStackTrace();
            return null;
        }
    }
}
