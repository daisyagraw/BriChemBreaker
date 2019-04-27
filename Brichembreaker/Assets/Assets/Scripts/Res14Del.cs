using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res14Del : MonoBehaviour {
	public static Image Res14;
	public static Sprite Rxn14Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res14 = GetComponent<Image>();
		Rxn14Res = Resources.Load<Sprite>("Rxn14Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 6) {
			TimedDestroy.Destroy(Res14);
	}
}
}