using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string GameLevel;
    [SerializeField] private GameObject menu;
    // Start is called before the first frame update
    public void Jogar()
    {
        SceneManager.LoadScene(GameLevel);
    }

    // Update is called once per frame
    public void Fechar()
    {
        Application.Quit();
    }
}
