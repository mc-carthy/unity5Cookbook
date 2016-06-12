using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuActions : MonoBehaviour {
	public void MENU_ACTION_GotoPage(string sceneName){
		SceneManager.LoadScene(sceneName);
	}
}