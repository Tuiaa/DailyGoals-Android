using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    public GameObject[] icons;
    public GameObject[] icons_bw;

    public string[] iconNames;
    public string[] iconNamesBW;

    void Awake()
    {
        icons = GameObject.FindGameObjectsWithTag("Icon");
        icons_bw = GameObject.FindGameObjectsWithTag("Icon_bw");

        iconNames = new string[icons.Length];
        iconNamesBW = new string[icons_bw.Length];

        for (int j = 0; j < iconNames.Length; j++)
        {
            iconNames[j] = icons[j].GetComponent<NameScript>().name;
        }

        for (int j = 0; j < iconNamesBW.Length; j++)
        {
            iconNames[j] = icons_bw[j].GetComponent<NameScript>().name;
        }

        for (int i = 0; i < icons.Length; i++)
        {
            icons[i].SetActive(false);
        }
    }

    public void ActivateIcons(string nameOfPressedIcon)
    {

        for (int j = 0; j < icons.Length; j++)
        {
            if (iconNamesBW[j] == nameOfPressedIcon)
            {
                icons_bw[j].SetActive(false);

                GameObject pair = icons_bw[j].GetComponent<NameScript>().pair;
                pair.SetActive(true);
                return;
            }
            else
            {
                Debug.Log("didn't find same name");
            }
        }
    }

    public void DeactivateIcons(string nameOfPressedIcon)
    {

        for (int a = 0; a < icons_bw.Length; a++)
        {
            if (iconNames[a] == nameOfPressedIcon)
            {
                icons[a].SetActive(false);

                GameObject pair = icons[a].GetComponent<NameScript>().pair;
                pair.SetActive(true);
                return;
            }
            else
            {
                Debug.Log("didn't find same name");
            }
        }
    }
}
