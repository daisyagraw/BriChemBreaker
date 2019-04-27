using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res18Del : MonoBehaviour {
	public static Image Res18;
	public static Sprite Rxn18Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res18 = GetComponent<Image>();
		Rxn18Res = Resources.Load<Sprite>("Rxn18Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 2) {
			TimedDestroy.Destroy(Res18);
	}
}
}