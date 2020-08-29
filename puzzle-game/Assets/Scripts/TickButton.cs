using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TickButton : MonoBehaviour
{
    [SerializeField]
    public InputField inputField;
    Button tickButton;
    [SerializeField]
    GameManager gameManager;
    Answer correctAnswer;
    void Start()
    {
        tickButton = GetComponent<Button>();
        gameManager=FindObjectOfType<GameManager>();
        tickButton.onClick.AddListener(delegate {
            //gameManager = GetComponent<GameManager>();
            Debug.Log("inside the tickbutton" + gameManager.questions);
            correctAnswer = gameManager.questions[0].answerArray[0];
            if (inputField.text == correctAnswer.answerData.ToString())
            {
                SceneManager.LoadScene("CorrectAnswer");
            }
        });
    }

    void Destroy()
    {
        tickButton.onClick.RemoveAllListeners();
    }
}
