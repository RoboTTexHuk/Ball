using UnityEngine;
using System.Collections;

public class Blocks_green : MonoBehaviour {
	private Collider2D block_green;
	private Rigidbody2D block_rigid_green;
	public Animator destroy_animation;
	public static bool Destroy_green;
	public static Vector3 vector_green;
	// Use this for initialization
	void Start () {
		block_green=GetComponent<Collider2D>();
		block_rigid_green=GetComponent<Rigidbody2D>();

	}
	
	
	void  OnCollisionEnter2D(Collision2D coll) { // если в блок попал шарик
		if (coll.gameObject.tag == "ball") {
			Debug.Log ("Касание");
			block_green.enabled=false;
			block_rigid_green.isKinematic=false;
			destroy_animation.SetBool("destroy",true);
			Destroy_green=true;
			vector_green=block_green.transform.position;
			GameManager.blocks_destroed--;
			GameManager.Total++;
		}
		
		
	}
}
