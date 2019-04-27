using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res20Del : MonoBehaviour {
	public static Image Res20;
	public static Sprite Rxn20Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res20 = GetComponent<Image>();
		Rxn20Res = Resources.Load<Sprite>("Rxn20Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 0) {
			TimedDestroy.Destroy(Res20);
	}
}
}