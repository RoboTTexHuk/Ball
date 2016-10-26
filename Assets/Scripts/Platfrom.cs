using UnityEngine;
using System.Collections;

public class Platfrom : MonoBehaviour {
	private Collider2D platform_collid;
	public float timer_platform; //таймер для бонусов
	public GameObject PF; //объект платформы
	public GameObject ball;// Обьект шарика для бонуса 3
	private bool bonus1,bonus2,bonus3;

	// Use this for initialization
	void Start () {
		platform_collid = GetComponent<Collider2D> ();//получение солида платформы
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Pause_ == false) { //если пауза не нажата
			if (bonus1 == true) {
				timer_platform += Time.deltaTime; 
				if (timer_platform > 3) {
					PF.transform.localScale = new Vector3 (1, 1, 1);
					timer_platform = 0;
					bonus1 = false;
				}
			}
			if (bonus2 == true) {
				timer_platform += Time.deltaTime;
				if (timer_platform > 4) {
					Ball.speedball = 20;
					timer_platform = 0;
					bonus2 = false;
				}
			}

			if (Input.GetKeyDown (KeyCode.RightArrow)) { //управление платформой
			
				platform_collid.transform.Translate (Vector3.right);
			
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			
				platform_collid.transform.Translate (Vector3.left);
				
			}
		}


	}

	void  OnTriggerEnter2D(Collider2D coll) { //если платформа поймала бонус
		if (coll.gameObject.tag == "bonus_1") { // изменяется длина платформы
			PF.transform.localScale=new Vector3(3,1,1);
			Debug.Log ("Касание");
			Debug.Log ("Таймер"+timer_platform);
			timer_platform=0;
			bonus1=true;
	}
		if (coll.gameObject.tag == "bonus_2") {//увеличивается скорость шарика
			Ball.speedball=10;
			bonus2=true;
		}
		if (coll.gameObject.tag == "bonus_3") { //создаётся ещё один шарик
			Instantiate(ball, new Vector3(PF.transform.position.x,PF.transform.position.y+3,PF.transform.position.z), Quaternion.identity);
			GameManager.col_ball++;
		}
}


}
