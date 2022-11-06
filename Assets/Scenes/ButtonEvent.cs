using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
	public void OnClick()
	{
#if UNITY_EDITOR
		// ゲームの実行を停止します
		UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
		// ゲームを終了します
    UnityEngine.Application.Quit();
#endif
	}
}
