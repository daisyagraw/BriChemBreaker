using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res6Del : MonoBehaviour {
	public static Image Res6;
	public static Sprite Rxn6Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res6 = GetComponent<Image>();
		Rxn6Res = Resources.Load<Sprite>("Rxn6Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 14) {
			TimedDestroy.Destroy(Res6);
	}
}
}