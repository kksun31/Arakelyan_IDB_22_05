using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetObject;

    public void ButtonClick()
    {
        if (targetObject.activeSelf)
        {
            // Если объект активен, деактивируем его.
            targetObject.SetActive(false);
        }
        else
        {
            // Если объект неактивен, активируем его.
            targetObject.SetActive(true);
        }
    }
}
