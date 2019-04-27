using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res15Del : MonoBehaviour {
	public static Image Res15;
	public static Sprite Rxn15Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res15 = GetComponent<Image>();
		Rxn15Res = Resources.Load<Sprite>("Rxn15Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 5) {
			TimedDestroy.Destroy(Res15);
	}
}
}