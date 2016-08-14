using UnityEngine;
using System.Collections;

public class ActivateIconsScript : MonoBehaviour
{

    public GameObject[] icons;
    public GameObject[] icons_bw;

    public GameObject[] waterIcons;
    public GameObject[] waterIcons_bw;

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
            iconNamesBW[j] = icons_bw[j].GetComponent<NameScript>().name;
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
                if (icons_bw[j].GetComponent<NameScript>().isWater == true)
                {
                    int id = icons_bw[j].GetComponent<NameScript>().id;
                    ActivateWaterIcons(id);
                    return;
                }

                icons_bw[j].SetActive(false);

                GameObject pair = icons_bw[j].GetComponent<NameScript>().pair;
                pair.SetActive(true);
                return;
            }
            else
            {
                Debug.Log("didn't find same name bw");
            }
        }
    }

    public void DeactivateIcons(string nameOfPressedIcon)
    {
        for (int a = 0; a < icons_bw.Length; a++)
        {
            if (iconNames[a] == nameOfPressedIcon)
            {
                if (icons[a].GetComponent<NameScript>().isWater == true)
                {
                    int id = icons[a].GetComponent<NameScript>().id;
                    ActivateWaterIcons(id);
                    return;
                }
                icons[a].SetActive(false);

                GameObject pair = icons[a].GetComponent<NameScript>().pair;
                pair.SetActive(true);
                return;
            }
            else
            {
                Debug.Log("didn't find same name color");
            }
        }
    }


    public void ActivateWaterIcons(int numberInList)
    {
        Debug.Log("number in list: " + numberInList);
        //numberInList += 1;
        Debug.Log("number in list: " + numberInList);
        for (int i = 0; i < waterIcons.Length; i++)
        {
            Debug.Log("number: " + i);
            waterIcons[i].SetActive(false);
            waterIcons_bw[i].SetActive(true);
        }

        for (int i = 0; i <= numberInList; i++)
        {
            Debug.Log("number: " + i);
            waterIcons[i].SetActive(true);
            waterIcons_bw[i].SetActive(false);
        }
    }

    public void DeactivateWaterIcons(int numberInList)
    {

        for (int i = 0; i < waterIcons.Length; i++)
        {
            waterIcons[i].SetActive(false);
            waterIcons_bw[i].SetActive(true);
        }

        for (int i = 0; i < numberInList; i++)
        {
            waterIcons[i].SetActive(true);
            waterIcons_bw[i].SetActive(false);
        }
    }
}
