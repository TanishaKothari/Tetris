using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(() => OnClick());
    }

    private void OnClick()
    {
        SceneManager.LoadScene(1);
        playButton.enabled = false;
    }
}
