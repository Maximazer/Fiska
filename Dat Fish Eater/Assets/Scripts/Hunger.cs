using UnityEngine;
using System.Collections;

public class Hunger : MonoBehaviour
{

    public GameObject hungerall;
    float mytimer = 100f;// задание плавающего числа
    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        mytimer = 100f;
        mytimer -= Time.deltaTime;//изменения числа с течением времени
        if (mytimer / mytimer == 1f) //проверка на период времени в 1 секунду
        {
            hungerall.transform.position = new Vector3(hungerall.transform.position.x - 0.001f, hungerall.transform.position.y, hungerall.transform.position.z);
            hungerall.transform.localScale = new Vector3(hungerall.transform.localScale.x - 0.001f, 1, 1);
            //выше идет сдвижение влево и уменьшение по ширине зеленой полосы для имитации шкалы
        }
        if (hungerall.transform.localScale.x < 0) //если шкала исчезла то загрузка идет загрузка главного меню 
        {
            Application.LoadLevel("MainMenu");
        }
    }
}