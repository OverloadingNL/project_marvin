using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace Overloading.Core
{
	public class GameManager : MonoBehaviour
	{
		// public static GameManager Instance = null;

		// //Awake is always called before any Start functions
		// void Awake()
		// {
		// 	#region singleton
		// 	if (Instance == null)
		// 	{
		// 		Instance = this;
		// 	}
		// 	else if (Instance != this)
		// 	{
		// 		Destroy(gameObject);
		// 	}
		// 	DontDestroyOnLoad(gameObject);
		// 	#endregion
		// }
		
		void Start()
		{
			QualitySettings.vSyncCount = 0;
			Application.targetFrameRate = 60;
		}

	}
}