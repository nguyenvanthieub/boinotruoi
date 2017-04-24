using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using StartApp;

public class GameManager : MonoBehaviour {
	
	public static GameManager instance;
	// View
	private GameObject imageObject; 
	public GameObject dialog;
	public Text view;
	
	// Data
	public DataStore BanTay;
	public DataStore Mat;
	public DataStore NamSau;
	public DataStore NamTruoc;
	public DataStore NuSau;
	public DataStore NuTruoc;
	private DataStore dataStore;
	
	// Type
	private string namePrefabImageObject = "BanTay";
	private int TypeDataStore = Const.MAT;

	// Other
	private string detail;
	
	void Awake(){
		instance = this;
		if (PlayerPrefs.HasKey ("Type") == true) {
			TypeDataStore = PlayerPrefs.GetInt("Type");
		}
		switch (TypeDataStore){
		case Const.BANTAY:
			dataStore = BanTay;
			namePrefabImageObject = "BanTay";
			break;
		case Const.MAT:
			dataStore = Mat;
			namePrefabImageObject = "Mat";
			break;
		case Const.NAMSAU:
			dataStore = NamSau;
			namePrefabImageObject = "NamSau";
			break;
		case Const.NAMTRUOC:
			dataStore = NamTruoc;
			namePrefabImageObject = "NamTruoc";
			break;
		case Const.NUSAU:
			dataStore = NuSau;
			namePrefabImageObject = "NuSau";
			break;
		case Const.NUTRUOC:
			dataStore = NuTruoc;
			namePrefabImageObject = "NuTruoc";
			break;
		}
		if (imageObject == null)
		{
			var objEnergy = Resources.Load<GameObject>("Prefabs/" + namePrefabImageObject);
			if (objEnergy != null)
			{
				GameObject en = Instantiate(objEnergy) as GameObject;
				en.name = "ImageObject";
			}
			else
			{
				Debug.LogError("Not find Object EnergyPlayer in Resources/Prefabs/ --->> Please check again!");
			}
		}
	}

	int iMaxAds = 1;
	void Start () {
//		#if UNITY_ANDROID
//		StartAppWrapper.init();
//		StartAppWrapper.loadAd();
//		#endif
//		#if UNITY_IPHONE
//		StartAppWrapperiOS.unityOrientation(StartAppWrapperiOS.STAUnityOrientation.STAAutoRotation);
//		StartAppWrapperiOS.loadAd();
//		#endif    
		iMaxAds = 1;
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) { 
			Application.LoadLevel ("Menu");
		}
	}
	
	public void HideDialog(){
		dialog.SetActive(false);
	}
	
	public void ViewDialog(string name){
		detail = GetDetail (name);
		PlayerPrefs.SetString("number", name);
		PlayerPrefs.SetString ("detail", detail);
		string textView = "Số " + name + ": " + detail; 
		view.text = textView;
		print ("Text View: " + textView);
		dialog.SetActive(true);

		int iAds = Random.Range (0, iMaxAds);
		if (iAds < 2) {
//			#if UNITY_ANDROID
//			StartAppWrapper.showAd();
//			StartAppWrapper.loadAd();
//			#endif
//			#if UNITY_IPHONE
//			StartAppWrapperiOS.showAd();
//			#endif 
			iMaxAds = iMaxAds + 5;
		}
	}
	
	private string GetDetail(string name){
		foreach (var ds in dataStore.datas) {
			if (ds.Name == name) {
				return ds.Value;
			}
		}
		return null;
	}

	public void Share(){
		print ("Share: " + detail);
	}
	
}
