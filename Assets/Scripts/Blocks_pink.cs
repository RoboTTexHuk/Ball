using UnityEngine;
using System.Collections;

public class Blocks_pink : MonoBehaviour {

	private Collider2D block_pink;
	private Rigidbody2D block_rigid_pink;
	public Animator destroy_animation;
	public static bool Destroy_pink;
	public GameObject bonus;
	public static Vector3 vector_pink;
	// Use this for initialization
	void Start () {
		block_pink=GetComponent<Collider2D>();
		block_rigid_pink=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

			

	}
	void  OnCollisionEnter2D(Collision2D coll) { // если в блок попал шарик
		if (coll.gameObject.tag == "ball") {
			Debug.Log ("Касание");
			block_pink.enabled=false;
			block_rigid_pink.isKinematic=false;
			destroy_animation.SetBool("destroy",true);
			Destroy_pink=true;
			vector_pink=block_pink.transform.position;
			GameManager.blocks_destroed--;
			GameManager.Total++;
		}
		
		
	}
}
