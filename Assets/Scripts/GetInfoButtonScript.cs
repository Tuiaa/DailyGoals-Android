using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GetInfoButtonScript : MonoBehaviour {

    public Text UserInfoText;
    public GameObject UserInfo;

    void Start ()
    {
        UserInfo = GameObject.FindWithTag("UserInfo");
    }

	public void GetUserInfo()
    {
        string username = UserInfo.GetComponent<UserInfoScript>().name;
       // string date = UserInfo.GetComponent<UserInfoScript>().chosenDate;

        UserInfoText.text = "Username: " + username;
    }
}
