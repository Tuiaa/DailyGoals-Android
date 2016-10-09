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
    public NameScript changeIcons;
    public GameObject ManagerObj;

    public GameObject brushTeethMorningObj;
    public GameObject brushTeethNightObj;

    void Start()
    {
        UserInfo = GameObject.FindWithTag("UserInfo");
        changeIcons = GetComponent<NameScript>();
    }

    public void GetUserInfo()
    {
        bool brushTeethMorning = false;
        bool brushTeethNight = false;

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
             Debug.Log("Listasta kohta " + i + ": " + list[i] + "\n");
            // Debug.Log("Inside for, i: " + i + "\n");
            if (list[i].Equals("Name"))
            {
                // Debug.Log("Listasta kohta " + i + ": " + list[i] + "\n");
                if (list[i + 2] == nameOfUser)
                {

                    if (list[i - 11].Equals(":true,"))
                    {
                        Debug.Log("list i -12 : " + list[i - 12] + "\n");
                        Debug.Log("list i -11 : " + list[i - 11] + "\n");
                        brushTeethMorning = true;
                    }

                    Debug.Log("Inside if\n");
                    playerNameFromMongo = list[i + 2];
                    if (list[i - 9].Equals(":true,"))
                    {
                        Debug.Log("list i -10 : " + list[i - 10] + "\n");
                        Debug.Log("list i -9 : " + list[i-9] + "\n");
                        brushTeethMorning = true;
                    }

                    
                       
                    Debug.Log("brushteethmorning = " + brushTeethMorning + "\n");
                    Debug.Log("brushteethnight = " + brushTeethNight + "\n");
                    break;
                }
                else
                {
                    Debug.Log("Inside couldn't find\n");
                    playerNameFromMongo = "Couldn't find";
                }

            }
        }
        ManagerObj.GetComponent<ButtonScript>().IconPressed
        brushTeethMorningObj.GetComponent<ActivateIconsScript>().ActivateIcons("Morning_bw");

        teksti.text = playerNameFromMongo;
    }
}