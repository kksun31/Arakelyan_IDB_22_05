using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actObj : MonoBehaviour
{
    public GameObject objectToToggle;

    private void Update()
    {
        // Проверяем, нажата ли кнопка "E" в текущем кадре
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Проверяем состояние объекта
            if (objectToToggle.activeSelf)
            {
                // Если объект активен, деактивируем его
                objectToToggle.SetActive(false);
            }
            else
            {
                // Если объект неактивен, активируем его
                objectToToggle.SetActive(true);
            }
        }
    }
}
