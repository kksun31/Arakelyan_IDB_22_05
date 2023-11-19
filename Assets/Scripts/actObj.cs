using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actObj : MonoBehaviour
{
    public GameObject objectToToggle;

    private void Update()
    {
        // ���������, ������ �� ������ "E" � ������� �����
        if (Input.GetKeyDown(KeyCode.E))
        {
            // ��������� ��������� �������
            if (objectToToggle.activeSelf)
            {
                // ���� ������ �������, ������������ ���
                objectToToggle.SetActive(false);
            }
            else
            {
                // ���� ������ ���������, ���������� ���
                objectToToggle.SetActive(true);
            }
        }
    }
}
