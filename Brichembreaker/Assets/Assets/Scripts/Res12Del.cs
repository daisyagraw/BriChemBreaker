using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res12Del : MonoBehaviour {
	public static Image Res12;
	public static Sprite Rxn12Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res12 = GetComponent<Image>();
		Rxn12Res = Resources.Load<Sprite>("Rxn12Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 8) {
			TimedDestroy.Destroy(Res12);
	}
}
}