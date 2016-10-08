using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInfoButtonScript : MonoBehaviour {

    public Text UsernameField;
    public Text DateField;
    public InputField dateInputField;
    public GameObject UserInfo;

    void Start()
    {
        UserInfo = GameObject.FindWithTag("UserInfo");
        dateInputField = GetComponent<InputField>();
        dateInputField.characterValidation = InputField.CharacterValidation.Integer;
    }

    public void SaveUsername()
    {
        string username = UsernameField.text.ToString();
        UserInfo.GetComponent<UserInfoScript>().name = username;

    }

    public void SaveDate()
    {
        string date = DateField.text;
        UserInfo.GetComponent<UserInfoScript>().chosenDate = date;
    }
}
