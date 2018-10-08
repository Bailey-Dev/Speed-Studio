using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {


	public void Facebook(){
		Application.OpenURL ("https://www.facebook.com/");

	}
	public void Discord(){
		Application.OpenURL ("https://discord.gg/qutz7nj");

	}
	public void Quit(){

		Application.Quit ();

	}
    public void startgame()
    {
     LoadScene.Scene
    }

}
