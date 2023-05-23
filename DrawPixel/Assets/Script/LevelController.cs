using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameObject[] lvls;
    [SerializeField] private Transform canvas;

    public void OpenLevel(int level)
    {
        Instantiate(lvls[level], canvas);
    }
}
