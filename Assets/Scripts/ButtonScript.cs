using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript : MonoBehaviour
{

    public GameObject manager;

    public void IconPressed()
    {
        string name = gameObject.GetComponent<NameScript>().name;

        for (int i = 0; i < manager.GetComponent<ActivateIconsScript>().icons_bw.Length; i++)
        {
            if (name == manager.GetComponent<ActivateIconsScript>().icons_bw[i].name)
                manager.GetComponent<ActivateIconsScript>().ActivateIcons(name);
            else
                manager.GetComponent<ActivateIconsScript>().DeactivateIcons(name);
        }
    }
}
