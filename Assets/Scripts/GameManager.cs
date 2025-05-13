using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button gameStartButton;
    // Start is called before the first frame update
    public void Start()
    {
        gameStartButton.onClick.AddListener(OnGameStartButtonClicked);
    }
    public void OnGameStartButtonClicked()
    {
        string playerName = inputField.text;
        if (string.IsNullOrEmpty(playerName))
        {
            Debug.Log("�÷��̾� �̸��� �Է��ϼ���.");
            return;
        }
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        Debug.Log("�÷��̾� �̸� ���� �� : " + playerName);

        SceneManager.LoadScene("Level_1");
    }
}


    // Update is called once per frame
    
