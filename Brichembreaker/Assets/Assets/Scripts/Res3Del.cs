using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res3Del : MonoBehaviour {
	public static Image Res3;
	public static Sprite Rxn3Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res3 = GetComponent<Image>();
		Rxn3Res = Resources.Load<Sprite>("Rxn3Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 17) {
			TimedDestroy.Destroy(Res3);
	}
}
}