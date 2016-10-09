using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.UI;

public class GetInfoButtonScript : MonoBehaviour
{

    public Text UserInfoText;
    public GameObject UserInfo;

    public string url = "http://localhost:49931/api/users/";
    public Text teksti;
    private string nameOfUser;

    void Start()
    {
        UserInfo = GameObject.FindWithTag("UserInfo");
    }

    public void GetUserInfo()
    {
        /* string username = UserInfo.GetComponent<UserInfoScript>().name;
         string date = UserInfo.GetComponent<UserInfoScript>().chosenDate;

         UserInfoText.text = "Username: " + username + "\nDate: " + date;*/

        nameOfUser = UserInfo.GetComponent<UserInfoScript>().name;
        WWW www = new WWW(url);

        while (!www.isDone)
        {
            // Waiting for download to finish
        }

        string response = www.text;

        // Prints the whole response into console for testing purposes
        Debug.Log(response);

        // Separates the players' names from the response and prints them
        string[] list = response.Split(new string[] { "\"" }, System.StringSplitOptions.None);

        string playerNameFromMongo = "";


        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].Equals(nameOfUser))
            {
                
                playerNameFromMongo = list[i + 2];
            }
            else
            {
                playerNameFromMongo = "Couldn't find";
            }

        }

        teksti.text = playerNameFromMongo;
    }
}