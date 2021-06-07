using UnityEngine;
using UnityEngine.UI;

public class MagnetFillUpTheBArs : MonoBehaviour
{

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    int i = 0;
    private void Start()
    {

        
        i = PlayerPrefs.GetInt("LastValueMagnet", 0);
        
    }

    private void Update()
    {
        if (i == 0)
        {
            MagnetTimer.magnetTimer = 10f;
            image1.gameObject.SetActive(false); image2.gameObject.SetActive(false); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
        }
        if (i > 0)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(false); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
            MagnetTimer.magnetTimer = 12f;
        }

        if (i > 1)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
            MagnetTimer.magnetTimer = 14f;
        }
        if (i > 2)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(true); image4.gameObject.SetActive(false);
            MagnetTimer.magnetTimer = 16f;
        }
        if (i > 3)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(true); image4.gameObject.SetActive(true);
            MagnetTimer.magnetTimer = 18f;
        }
        if (i >= PlayerPrefs.GetInt("LastValueMagnet", 0))
        {
            PlayerPrefs.SetInt("LastValueMagnet", i);


        }
    }
    public void FillTheBar()
    {


        if (i == 0)
        {
            if (PlayerPrefs.GetInt("ShopStars", 0) >= 1000)
            {
                int temp = PlayerPrefs.GetInt("ShopStars", 0);

                temp -= 1000;
                PlayerPrefs.SetInt("ShopStars", temp);
                i++;
            }
            else
            {
                FindObjectOfType<MainMenuSoundManager>().Play("AlarmBuzz");
            }
        }
        if (i == 1)
        {
            if (PlayerPrefs.GetInt("ShopStars", 0) >= 2000)
            {
                int temp = PlayerPrefs.GetInt("ShopStars", 0);
                temp -= 2000;
                PlayerPrefs.SetInt("ShopStars", temp);
                i++;
            }
            else
            {
                FindObjectOfType<SoundManager>().Play("AlarmBuzz");
            }
        }
        if (i == 2)
        {
            if (PlayerPrefs.GetInt("ShopStars", 0) >= 3000)
            {
                int temp = PlayerPrefs.GetInt("ShopStars", 0);
                temp -= 3000;
                PlayerPrefs.SetInt("ShopStars", temp);
                i++;
            }
            else
            {
                FindObjectOfType<SoundManager>().Play("AlarmBuzz");
            }
        }
        if (i == 3)
        {
            if (PlayerPrefs.GetInt("ShopStars", 0) >= 4000)
            {
                int temp = PlayerPrefs.GetInt("ShopStars", 0);
                temp -= 4000;
                PlayerPrefs.SetInt("ShopStars", temp);
                i++;
            }
            else
            {
                FindObjectOfType<SoundManager>().Play("AlarmBuzz");
            }
        }

    }
}