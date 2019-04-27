using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res13Del : MonoBehaviour {
	public static Image Res13;
	public static Sprite Rxn13Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res13 = GetComponent<Image>();
		Rxn13Res = Resources.Load<Sprite>("Rxn13Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 7) {
			TimedDestroy.Destroy(Res13);
	}
}
}