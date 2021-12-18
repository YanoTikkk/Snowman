using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text nameText;

    [SerializeField] private List<GameObject> caps = new List<GameObject>();

    [SerializeField] private List<Renderer> playerMaterial = new List<Renderer>();

    public void SetName(string name)
    {
        nameText.text = name;
    }

    public void SetCap(int index)
    {
        for (int i = 0; i < caps.Count; i++)
        {
            if (i == index)
            {
                caps[i].SetActive(true);
            }
            else
            {
                caps[i].SetActive(false);
            }
        }
    }

    public void SetMaterial(Material material)
    {
        for (int i = 0; i < playerMaterial.Count; i++)
        {
            playerMaterial[i].material = material;
        }
    }
}
