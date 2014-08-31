using UnityEngine;
using System.Collections;

public enum SceneType {
	Top = 0,
	Tutorial = 1,
	Game = 2,
	Result = 3,
}

public class SceneManager : SingletonMonoBehaviour<SceneManager> {

	public GameObject [] sceneList;
	
	public void Awake()
	{
		if(this != Instance)
		{
			Destroy(this);
			return;
		}
		
		DontDestroyOnLoad(this.gameObject);
	}  

//	// Use this for initialization
//	void Start () {
//
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

	public void NextScene (SceneType sceneType) {
		sceneList[(int)sceneType].GetComponent<SceneMonoBehaviour>().StartScene();
	}
}
