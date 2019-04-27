using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res1Del : MonoBehaviour {
	public static Image Res1A;
	public static Sprite Rxn1Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res1A = GetComponent<Image>();
		Rxn1Res = Resources.Load<Sprite>("Rxn1Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 19) {
			TimedDestroy.Destroy(Res1A);
	}
}
}