using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class DataStore : ScriptableObject
{
	public List<DataModel> datas;
}

[System.Serializable]
public class DataModel
{
	public string Name;
	public string Value;
}