using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainScene : MonoBehaviour
{
    public void LoadMainLevel()
    {
        SceneManager.LoadScene(1);
    }
}
