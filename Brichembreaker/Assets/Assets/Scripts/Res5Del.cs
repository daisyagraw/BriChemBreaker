using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res5Del : MonoBehaviour {
	public static Image Res5;
	public static Sprite Rxn5Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res5 = GetComponent<Image>();
		Rxn5Res = Resources.Load<Sprite>("Rxn5Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 15) {
			TimedDestroy.Destroy(Res5);
	}
}
}