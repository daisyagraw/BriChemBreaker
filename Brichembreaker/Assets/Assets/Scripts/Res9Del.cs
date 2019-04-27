using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res9Del : MonoBehaviour {
	public static Image Res9;
	public static Sprite Rxn9Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res9 = GetComponent<Image>();
		Rxn9Res = Resources.Load<Sprite>("Rxn9Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 11) {
			TimedDestroy.Destroy(Res9);
	}
}
}