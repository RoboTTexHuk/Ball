using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Start_Button()
	{

		Application.LoadLevel ("GamePlay");
	}
	public void Exite_Button()
	{
		
		Application.Quit();
	}
}
