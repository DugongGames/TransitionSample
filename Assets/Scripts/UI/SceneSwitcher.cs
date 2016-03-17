using UnityEngine;
using System.Collections;
using Prime31.TransitionKit;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	public void WindTransition() {
		var wind = new WindTransition()
		{
			nextScene = 1,
			duration = 1.0f,
			size = 0.3f
		};
		TransitionKit.instance.transitionWithDelegate( wind );
	}

	public void FishEyeTransition() {
		var fishEye = new FishEyeTransition()
		{
			nextScene = 1,
			duration = 1.0f,
			size = 0.08f,
			zoom = 10.0f,
			colorSeparation = 3.0f
		};
		TransitionKit.instance.transitionWithDelegate( fishEye );
	}

	public void PixelateTransition() {
		var pixelater = new PixelateTransition()
		{
			nextScene = 1,
			duration = 1.0f
		};
		TransitionKit.instance.transitionWithDelegate( pixelater );
	}

	public void BackToMenu() {
		var ripple = new RippleTransition()
		{
			nextScene = 0,
			duration = 1.0f,
			amplitude = 1500f,
			speed = 20f
		};
		TransitionKit.instance.transitionWithDelegate( ripple );
	}

}
