using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
	public void OnClick()
	{
#if UNITY_EDITOR
		// �Q�[���̎��s���~���܂�
		UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
		// �Q�[�����I�����܂�
    UnityEngine.Application.Quit();
#endif
	}
}
