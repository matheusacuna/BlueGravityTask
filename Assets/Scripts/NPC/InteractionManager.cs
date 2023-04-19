using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class InteractionManager : MonoBehaviour
    {
        [SerializeField] bool isTouchNPC;
        [SerializeField] private GameObject animAlertShop;
        [SerializeField] private GameObject shopUI;
        [SerializeField] private InputManager myInput;
        //[SerializeField] private GameObject displayInventory;

        private void Update()
        {
            if (isTouchNPC)
            {
                if (myInput.input.Player.Interaction.triggered)
                {
                    shopUI.SetActive(true);
                    ShopManager.Instance.invetorShop = shopUI.GetComponent<DisplayInventory>().inventory;
                }
            }
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                isTouchNPC = true;
                animAlertShop.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                isTouchNPC = false;
                animAlertShop.SetActive(false);
            }
        }
    }
}

