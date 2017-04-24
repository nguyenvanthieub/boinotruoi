using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Facebook;
using Facebook.Unity;
using Facebook.MiniJSON;

public class FacebookManager : MonoBehaviour
{	
	void Awake()
	{
		DontDestroyOnLoad(this);
		
		if (!FB.IsInitialized)
		{
			FB.Init(InitCallback, OnHideUnity);
		}
		else
		{
			FB.ActivateApp();
		}
		
	}
	
	private void InitCallback()
	{
		if (FB.IsInitialized)
		{
			FB.ActivateApp();
			if (FB.IsLoggedIn)
			{
				ControlData();
			}
			else
			{
			}
		}
		else
		{
			Debug.Log("Failed to Initialize the Facebook SDK");
		}
	}
	
	private void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
	}
	
	public void Login()
	{
		print("Login in FacebookManager");
		var perms = new List<string>() { "publish_actions" };
		FB.LogInWithPublishPermissions(perms, LoginCallBack);
	}
	
	private void LoginCallBack(ILoginResult result)
	{
		if (FB.IsLoggedIn)
		{
			ControlData();
		}
		else
		{
			Debug.Log("User cancelled login");
		}
	}

	void ControlData(){
		string linkPhoto = "http://www.chiemtinh.com.vn/wp-content/uploads/2014/07/boi_not_ruoi_ban_tay.jpg";

		int TypeDataStore = Const.MAT;
		if (PlayerPrefs.HasKey ("Type") == true) {
			TypeDataStore = PlayerPrefs.GetInt("Type");
		}
		switch (TypeDataStore){
		case Const.BANTAY:
			linkPhoto = Const.linkAnhBanTay;
			break;
		case Const.MAT:
			linkPhoto = Const.linkAnhMat;
			break;
		case Const.NAMSAU:
			linkPhoto = Const.linkAnhNamSau;
			break;
		case Const.NAMTRUOC:
			linkPhoto = Const.linkAnhNamTruoc;
			break;
		case Const.NUSAU:
			linkPhoto = Const.linkAnhNuSau;
			break;
		case Const.NUTRUOC:
			linkPhoto = Const.linkAnhNuTruoc;
			break;
		}

		Uri contentURL = new Uri (Const.linkApp);

		string contentTitle = "Số " + PlayerPrefs.GetString ("number") + " : " + PlayerPrefs.GetString("detail");
		string contentDescription = "Ứng dụng giải mã ý nghĩa những nốt ruồi";
		Uri photoURL = new Uri(linkPhoto);

		FB.ShareLink(
			contentURL,
			contentTitle,
			contentDescription,
			photoURL,
			callback: ShareCallback
		);
//		FB.ShareLink(
//			new Uri("https://developers.facebook.com/"),
//			callback: ShareCallback
//			);
	}

	private void ShareCallback (IShareResult result) {
		if (result.Cancelled || !String.IsNullOrEmpty(result.Error)) {
			Debug.Log("ShareLink Error: "+result.Error);
		} else if (!String.IsNullOrEmpty(result.PostId)) {
			// Print post identifier of the shared content
			Debug.Log("Print post identifier of the shared content" + result.PostId);
		} else {
			// Share succeeded without postID
			Debug.Log("ShareLink success!");
		}
	}

	
}