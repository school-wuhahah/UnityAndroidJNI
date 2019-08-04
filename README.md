# UnityAndroidJNI
Unity Interact with android java 

##### 构建：

- Unity导出AndroidStudio工程

- 在UnityPlayerActivity的onCreate时初始化Device (Device.onCreate(this);)

  ~~~java
      @Override protected void onCreate(Bundle savedInstanceState)
      {
          requestWindowFeature(Window.FEATURE_NO_TITLE);
          super.onCreate(savedInstanceState);
          Device.onCreate(this);
          mUnityPlayer = new UnityPlayer(this);
          setContentView(mUnityPlayer);
          mUnityPlayer.requestFocus();
      }
  ~~~

  

