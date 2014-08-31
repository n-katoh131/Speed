using UnityEngine;
using System.Collections;

public class GameScene : SceneMonoBehaviour {

	void Start () {
		enabled = false;
	}
		
	void OnGUI () {
		if (GUI.Button(new Rect(20, 20, 100, 30), "Result")) {
			// Transition to GameScene
			SceneManager.Instance.NextScene(SceneType.Result);
			EndScene();
		}
	}

	public override void StartScene () {
		enabled = true;
		transform.FindChild("Plane").renderer.enabled = true;
		Debug.Log("GameScene_StartScene");
	}
	
	public override void EndScene () {
		enabled = false;
		transform.FindChild("Plane").renderer.enabled = false;
		Debug.Log("GameScene_EndScene");
	}
}
