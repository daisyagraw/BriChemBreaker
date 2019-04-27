using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public GameObject brickParticle;

	void OnCollisionEnter (Collision other)
	{
		Debug.Log(gameObject);
		Debug.Log(GameObject.Find("Brick (11)"));
		if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (11)"))) && (GM.bricks == 20)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (3)"))) && (GM.bricks == 19)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (15)"))) && (GM.bricks == 18)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (12)"))) && (GM.bricks == 17)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (19)"))) && (GM.bricks == 16)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (7)"))) && (GM.bricks == 15)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (16)"))) && (GM.bricks == 14)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (20)"))) && (GM.bricks == 13)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (8)"))) && (GM.bricks == 12)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (4)"))) && (GM.bricks == 11)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (13)"))) && (GM.bricks == 10)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (1)"))) && (GM.bricks == 9)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (17)"))) && (GM.bricks == 8)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (2)"))) && (GM.bricks == 7)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (9)"))) && (GM.bricks == 6)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (18)"))) && (GM.bricks == 5)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (5)"))) && (GM.bricks == 4)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick"))) && (GM.bricks == 3)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (10)"))) && (GM.bricks == 2)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
		else if ((GameObject.ReferenceEquals(gameObject, GameObject.Find("Brick (14)"))) && (GM.bricks == 1)) {
	
			Instantiate(brickParticle, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			Destroy(gameObject);
		}
	}
}