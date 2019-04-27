using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res2Del : MonoBehaviour {
	public static Image Res2;
	public static Sprite Rxn2Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res2 = GetComponent<Image>();
		Rxn2Res = Resources.Load<Sprite>("Rxn2Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 18) {
			TimedDestroy.Destroy(Res2);
	}
}
}