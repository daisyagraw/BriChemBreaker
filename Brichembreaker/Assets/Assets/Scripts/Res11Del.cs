using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res11Del : MonoBehaviour {
	public static Image Res11A;
	public static Sprite Rxn11Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res11A = GetComponent<Image>();
		Rxn11Res = Resources.Load<Sprite>("Rxn11Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 9) {
			TimedDestroy.Destroy(Res11A);
	}
}
}