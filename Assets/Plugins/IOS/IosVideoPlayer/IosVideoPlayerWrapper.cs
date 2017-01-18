using UnityEngine;
// We need this one for importing our IOS functions
using System.Runtime.InteropServices;

public class IosVideoPlayerWrapper : MonoBehaviour
{
	// Use this #if so that if you run this code on a different platform, you won't get errors.
	#if UNITY_IPHONE

	// For the most part, your imports match the function defined in the iOS code    
	[DllImport ("__Internal")]
	private static extern void playVideo(string url);

	#endif

	// Now make c# methods that can provide the iOS functionality
	public static void PlayVideo(string url)
	{
		// We check for UNITY_IPHONE again so we don't try this if it isn't iOS platform.
		#if UNITY_IPHONE
		// Now we check that it's actually an iOS device/simulator, not the Unity Player. You only get plugins on the actual device or iOS Simulator.
		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			Debug.Log("UNITY LOG: PlayVideo() " + url);

			playVideo(url);
		}
		#endif
	}

}