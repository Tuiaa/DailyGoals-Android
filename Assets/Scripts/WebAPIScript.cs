using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WebAPIScript : MonoBehaviour
{

    public string url = "http://localhost:49931/api/users/";
    public Text teksti;
    private string nameOfUser;
    public GameObject UserInfo;

    void Awake()
    {
        UserInfo = GameObject.FindGameObjectWithTag("UserInfo");
    }

    public void getPlayerNames()
    {
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
            if (list[i].Equals("Name"))
            {
                if(list[i + 2] == nameOfUser)
                {
                    playerNameFromMongo = list[i + 2];
                }
                else
                {
                    playerNameFromMongo = "Couldn't find";
                }
                   
            }
        }


        teksti.text = playerNameFromMongo;
    }

    public void getUserDate()
    {

        url = "http://localhost:49931/api/users/";

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

        List<string> playerNames = new List<string>();

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].Equals("Name"))
            {
                playerNames.Add(list[i + 2]);
            }
        }


    }
}
