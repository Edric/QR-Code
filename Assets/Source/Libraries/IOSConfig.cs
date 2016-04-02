using UnityEngine;
using System.Collections;

public class IOSConfig : MonoBehaviour {

	void Awake(){
		#if UNITY_IPHONE
			switch(UnityEngine.iOS.Device.generation){
				// 2048 x 1536 *0.5
				case UnityEngine.iOS.DeviceGeneration.iPad3Gen:

	//				Screen.SetResolution(1024,768,true);
					break;
				
				
				case UnityEngine.iOS.DeviceGeneration.iPhone4:
					Application.targetFrameRate = 30;	
					QualitySettings.antiAliasing = 0;

					break;
				case UnityEngine.iOS.DeviceGeneration.iPhone4S:
					Application.targetFrameRate = 30;	
					QualitySettings.antiAliasing = 2;
					break;

				default:
					Application.targetFrameRate = 60;	
					QualitySettings.antiAliasing = 2;
					break;
			}
		#else
			// Application.targetFrameRate = 30;
			QualitySettings.antiAliasing = 0;
		#endif
		
		
	}
	
	
}
