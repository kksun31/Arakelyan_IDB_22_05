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
            // ���� ������ �������, ������������ ���.
            targetObject.SetActive(false);
        }
        else
        {
            // ���� ������ ���������, ���������� ���.
            targetObject.SetActive(true);
        }
    }
}
