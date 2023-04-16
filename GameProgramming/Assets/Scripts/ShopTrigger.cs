using UnityEngine;
using UnityEngine.UI;

public class ShopTrigger : MonoBehaviour
{
      public bool isTriggered ;
    private Text interactUI;
    // Update is called once per frame
    public string namePNJ;
    public item[] items;
    private void Awake()
    {
        interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
    }
  
    public void OnInteract()
    {
        ShopManager.instance.Shop(items, namePNJ);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            
            interactUI.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
            interactUI.enabled = false;
            ShopManager.instance.EndShop();
        }
    }
}