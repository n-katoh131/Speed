using UnityEngine;
using System.Collections;

public class TutorialScene : SceneMonoBehaviour {

	void Start () {
		enabled = false;
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 20, 100, 30), "Back")) {
			// Transition to TopScene
			SceneManager.Instance.NextScene(SceneType.Top);
			EndScene();
		}
	}
	
	public override void StartScene () {
		enabled = true;
		transform.FindChild("Plane").renderer.enabled = true;
		Debug.Log("TutorialScene_StartScene");
	}
	
	public override void EndScene () {
		enabled = false;
		transform.FindChild("Plane").renderer.enabled = false;
		Debug.Log("TutorialScene_EndScene");
	}
}
