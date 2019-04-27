using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res4Del : MonoBehaviour {
	public static Image Res4;
	public static Sprite Rxn4Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res4 = GetComponent<Image>();
		Rxn4Res = Resources.Load<Sprite>("Rxn4Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 16) {
			TimedDestroy.Destroy(Res4);
	}
}
}