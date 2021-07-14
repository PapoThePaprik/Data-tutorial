using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChooseName : MonoBehaviour
{
	public TMP_InputField inputField;
	public string playerName;


	private void Update()
	{
		PlayerChooseName();
	}


	void PlayerChooseName()
	{
		playerName = inputField.text;
		MenuManager.Instance.currentPlayerName = playerName;
	}

}
