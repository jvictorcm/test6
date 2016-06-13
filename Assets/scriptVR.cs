using UnityEngine;

public class scriptVR : MonoBehaviour
{
    float currentCount = 0;
    bool conta = false;
    void Start()
    {

    }

    void Update()
    {
        if (conta)
        {
            currentCount += Time.deltaTime;
        }else
        {
            currentCount = 0;
        }
        if (currentCount >= 1)
        {
            Destroy(gameObject);
            print("deletou");
        }
    }

    public void stareAt()
    {

        conta = true;

    }

    public void parouDeOlhar()
    {
        conta = false;
    }

    
}