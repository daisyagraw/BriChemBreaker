using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res10Del : MonoBehaviour {
	public static Image Res10;
	public static Sprite Rxn10Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res10 = GetComponent<Image>();
		Rxn10Res = Resources.Load<Sprite>("Rxn10Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 10) {
			TimedDestroy.Destroy(Res10);
	}
}
}