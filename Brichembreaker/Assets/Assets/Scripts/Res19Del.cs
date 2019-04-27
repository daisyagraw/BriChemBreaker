using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res19Del : MonoBehaviour {
	public static Image Res19;
	public static Sprite Rxn19Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res19 = GetComponent<Image>();
		Rxn19Res = Resources.Load<Sprite>("Rxn19Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 1) {
			TimedDestroy.Destroy(Res19);
	}
}
}