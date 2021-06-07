using UnityEngine;
using UnityEngine.UI;


public class SlowFillUpthebars : MonoBehaviour
{

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    int i = 0;
    private void Start()
    {

        
        i = PlayerPrefs.GetInt("LastValueSlow", 0);
        
    }

    private void Update()
    {
        if (i == 0)
        {
            SlowTİme.slowTimeRate = 2;
            image1.gameObject.SetActive(false); image2.gameObject.SetActive(false); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
        }
        if (i > 0)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(false); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
            SlowTİme.slowTimeRate = 3;
        }

        if (i > 1)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(false); image4.gameObject.SetActive(false);
            SlowTİme.slowTimeRate = 4;
        }
        if (i > 2)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(true); image4.gameObject.SetActive(false);
            SlowTİme.slowTimeRate = 5;
        }
        if (i > 3)
        {
            image1.gameObject.SetActive(true); image2.gameObject.SetActive(true); image3.gameObject.SetActive(true); image4.gameObject.SetActive(true);
            SlowTİme.slowTimeRate = 6;
        }
        if (i >= PlayerPrefs.GetInt("LastValueSlow", 0))
        {
            PlayerPrefs.SetInt("LastValueSlow", i);


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
                FindObjectOfType<MainMenuSoundManager>().Play("AlarmBuzz");
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
                FindObjectOfType<MainMenuSoundManager>().Play("AlarmBuzz");
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
                FindObjectOfType<MainMenuSoundManager>().Play("AlarmBuzz");
            }
        }

    }
}