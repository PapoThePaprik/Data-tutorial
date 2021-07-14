using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[System.Serializable]
public class MenuUIManager : MonoBehaviour
{

	public TextMeshProUGUI playerNameTxt;
	public TextMeshProUGUI bestScoreTxt;
	public GameObject chooseNameAnimation;
	

	private void Awake()
	{

		bestScoreTxt.text = $"Best Score: {MenuManager.Instance.highScorePlayerName} : {MenuManager.Instance.highScore}";
	}

	
	public void LeaderboardsScene()
	{
		SceneManager.LoadScene(1);
	}
	public void StartGameScene()
	{
		
		SceneManager.LoadScene(1);
	}

	public void AnimStop()
	{
		chooseNameAnimation.SetActive(false);
	}
public void Exit()
	{
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
	}
}
