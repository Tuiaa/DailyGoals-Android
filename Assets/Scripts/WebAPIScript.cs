using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WebAPIScript : MonoBehaviour
{

    public string url = "http://localhost:49931/api/users/";
    public Text teksti;
    private string names;

    public void getPlayerNames()
    {
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

        foreach (string name in playerNames)
        {
            names = names + name + "\n";
        }

        teksti.text = names;
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

        foreach (string name in playerNames)
        {
            names = names + name + "\n";
        }

        teksti.text = names;
    }
}
