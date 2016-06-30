//using UnityEngine;
//using System.Collections;
//using UnityEditor;
//
//public class TestScriptableObject
//{
//
//	[MenuItem("Assets/Create/FileAsset")]
//	public static void Create()
//	{ 
//		DataStore asset = ScriptableObject.CreateInstance<DataStore>();
//		AssetDatabase.CreateAsset(asset, "Assets/Resources/Datas/Thu3.asset");
//		AssetDatabase.SaveAssets();
//		EditorUtility.FocusProjectWindow();
//		Selection.activeObject = asset;
//	}
//
//}