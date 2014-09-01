using UnityEngine;
using System.Collections;

public class ResultScene : SceneMonoBehaviour {

	void Start () {
		enabled = false;
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 20, 100, 30), "Top")) {
			// Transition to TopScene
			SceneManager.Instance.NextScene(SceneType.Top);
			EndScene();
		}
	}
	
	public override void StartScene () {
		enabled = true;
		transform.FindChild("Plane").renderer.enabled = true;
		Debug.Log("ResultScene_StartScene");
	}
	
	public override void EndScene () {
		enabled = false;
		transform.FindChild("Plane").renderer.enabled = false;
		Debug.Log("ResultScene_EndScene");
	}
}
