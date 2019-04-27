using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res16Del : MonoBehaviour {
	public static Image Res16;
	public static Sprite Rxn16Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res16 = GetComponent<Image>();
		Rxn16Res = Resources.Load<Sprite>("Rxn16Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 4) {
			TimedDestroy.Destroy(Res16);
	}
}
}