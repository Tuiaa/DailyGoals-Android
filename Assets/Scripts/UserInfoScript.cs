using UnityEngine;
using System.Collections;

public class UserInfoScript : MonoBehaviour {

    public string name;
    public int chosenDate;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
