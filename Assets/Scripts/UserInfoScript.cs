using UnityEngine;
using System.Collections;

public class UserInfoScript : MonoBehaviour {

    public string name;
    public string chosenDate;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
