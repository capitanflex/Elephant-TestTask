using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public void NextLevel()
    {
        SceneManager.LoadScene("second_scene");
    }

    public void PreviousLevel()
    {
        SceneManager.LoadScene("first_scene");
    }
}
