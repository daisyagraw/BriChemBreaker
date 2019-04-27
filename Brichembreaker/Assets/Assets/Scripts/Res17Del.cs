using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res17Del : MonoBehaviour {
	public static Image Res17;
	public static Sprite Rxn17Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res17 = GetComponent<Image>();
		Rxn17Res = Resources.Load<Sprite>("Rxn17Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 3) {
			TimedDestroy.Destroy(Res17);
	}
}
}