using UnityEngine;
using System.Collections;

public class Blocks_red : MonoBehaviour {
	private Collider2D block_red;
	private Rigidbody2D block_rigid;

	private int i;
	public Animator destroy_animation;
	public static bool Destroy_red;
	public static Vector3 vector_red;
	// Use this for initialization
	void Start () {
		block_red=GetComponent<Collider2D>();
		block_rigid=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	if (i == 2) 
		{
			block_red.enabled=false;
			block_rigid.isKinematic=false;
			i=0;
			destroy_animation.SetBool("destroy",true);
			vector_red=block_red.transform.position;
			Destroy_red=true;
			Debug.Log ("Уничтожен красный"+Destroy_red);
			GameManager.blocks_destroed--;
			GameManager.Total++;
	}



			            }

	void  OnCollisionEnter2D(Collision2D coll) { // если в блок попал шарик
			if (coll.gameObject.tag == "ball") {
				Debug.Log ("Касание");
				i++;
				
			}
	
			
		}
}
