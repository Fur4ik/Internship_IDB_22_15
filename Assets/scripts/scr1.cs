using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems; // ���������� ��� ������ � ���������

public class scr1 : MonoBehaviour
{
    public GameObject objectToRotate; // ������ ��� ��������
    public Vector3 rotationAngle; // ���� ��������
    public float duration = 2.0f; // ����������������� �������� � ��������
    //public GameObject robot2; // ������ ��� ��������
    //public GameObject robot4; // ������ ��� ��������
    //public GameObject robot5; // ������ ��� ��������
    //public GameObject robot6; // ������ ��� ��������

    // ����������, ����� ���-�� ������ � ������� ����������
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, ��� � ��������� ����� ����� ��� ������ ������
        {
            StartCoroutine(RotateOverTime(rotationAngle, duration));
        }
    }

    // �������� ��� �������� �������� �������
    IEnumerator RotateOverTime(Vector3 angle, float duration)
    {
        Quaternion startRotation = objectToRotate.transform.rotation;
        Quaternion endRotation = objectToRotate.transform.rotation * Quaternion.Euler(angle);
        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            objectToRotate.transform.rotation = Quaternion.Slerp(startRotation, endRotation, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        objectToRotate.transform.rotation = endRotation;
    }
}

