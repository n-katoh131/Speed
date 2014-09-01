using UnityEngine;
using System.Collections;

public class TopScene : SceneMonoBehaviour {

	void OnGUI () {
		if (GUI.Button(new Rect(10, 20, 100, 30), "Start")) {
			// Transition to GameScene
			SceneManager.Instance.NextScene(SceneType.Game);
			EndScene();
		}

		if (GUI.Button(new Rect(150, 20, 100, 30), "Tutorial")) {
			// Transition to TutorialScene
			SceneManager.Instance.NextScene(SceneType.Tutorial);
			EndScene();
		}
	}

	public override void StartScene () {
		enabled = true;
		transform.FindChild("Plane").renderer.enabled = true;
		Debug.Log("TopScene_StartScene");

	}

	public override void EndScene () {
		enabled = false;
		transform.FindChild("Plane").renderer.enabled = false;
		Debug.Log("TopScene_EndScene");
	}
}
