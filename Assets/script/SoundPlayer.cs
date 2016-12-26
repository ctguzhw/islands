using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundPlayer : MonoBehaviour {

	public string userName = "";
	public string password = "";

	void OnGUI(){
	/*	AudioSource audio = GetComponent<AudioSource> ();
		if (GUI.Button (new Rect (200, 500, 100, 50), "开始"))
			audio.Play ();
		if (GUI.Button (new Rect (400, 500, 100, 50), "停止"))
			audio.Stop ();
		GUI.Label (new Rect (300, 400, 100, 50), "hello world!");
		*/
		//登录框
		GUI.Box (new Rect (10, 10, 200, 120), "登录框");
		//用户名
		GUI.Label (new Rect (20, 40, 70, 30), "用户名");
		userName = GUI.TextField (new Rect (70, 40, 120, 20), userName);

		//密码
		GUI.Label (new Rect (20, 70, 50, 30), "密码");
		password = GUI.PasswordField (new Rect (70, 70, 120, 20), password,'*');

		if (GUI.Button (new Rect (70, 100, 50, 25), "登录")) {
			if (userName == "hellozhw" && password == "1223"){
					Debug.Log ("登录成功");
					SceneManager.LoadScene("chapter01_1");
				}
			else
				Debug.Log("登录失败");

		}
		
	}
}
