using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInfoButtonScript : MonoBehaviour {

    public Text UsernameField;
    public GameObject UserInfo;

    void Start()
    {
        UserInfo = GameObject.FindWithTag("UserInfo");

    }

    public void SaveUsername()
    {
        string username = UsernameField.text.ToString();
        UserInfo.GetComponent<UserInfoScript>().name = username;

    }

    public void SaveDate()
    {

    }
}
