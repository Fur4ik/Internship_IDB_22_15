using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems; // Необходимо для работы с событиями

public class scr1 : MonoBehaviour
{
    public GameObject objectToRotate; // Объект для поворота
    public Vector3 rotationAngle; // Угол поворота
    public float duration = 2.0f; // Продолжительность поворота в секундах
    //public GameObject robot2; // Объект для поворота
    //public GameObject robot4; // Объект для поворота
    //public GameObject robot5; // Объект для поворота
    //public GameObject robot6; // Объект для поворота

    // Вызывается, когда что-то входит в триггер коллайдера
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверка, что в коллайдер вошел игрок или другой объект
        {
            StartCoroutine(RotateOverTime(rotationAngle, duration));
        }
    }

    // Корутина для плавного поворота объекта
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

