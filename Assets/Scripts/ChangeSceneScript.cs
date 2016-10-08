using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour {

	public void ChangeScene()
    {
        SceneManager.LoadScene("UpdateScene");
    }
}
