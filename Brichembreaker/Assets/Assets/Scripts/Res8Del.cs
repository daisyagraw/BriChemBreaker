using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res8Del : MonoBehaviour {
	public static Image Res8;
	public static Sprite Rxn8Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res8 = GetComponent<Image>();
		Rxn8Res = Resources.Load<Sprite>("Rxn8Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 12) {
			TimedDestroy.Destroy(Res8);
	}
}
}