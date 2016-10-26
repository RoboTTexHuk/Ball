using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Collider2D ball;
	public static float speedball=20;
	public AudioSource touch_block;
	public Vector2 direction = new Vector2(0, 0);  
	// Use this for initialization
	void Start () {
		ball = GetComponent<Collider2D> ();

		direction =  new Vector2(0, -1f);  
	}
	void FixedUpdate () {
		if (GameManager.Pause_ == false) {
			
			ball.transform.Translate (direction / speedball); //Движение шарика
		}
	}



	void OnCollisionEnter2D(Collision2D coll) {

			Debug.Log ("Касание");

			ContactPoint2D contact = coll.contacts [0];
			
			direction = Vector2.Reflect (direction, contact.normal); //Расчёт отражения от поверхностей
		if (coll.gameObject.tag == "fire")
					{
						GameManager.col_ball--;
			direction =  new Vector2(0,0);  
					}
	}
}



