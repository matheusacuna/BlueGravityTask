using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class OpenShop : MonoBehaviour
    {
        [SerializeField] bool isTouchNPC;
        [SerializeField] private GameObject animAlertShop;
        [SerializeField] private GameObject shopUI;
        [SerializeField] private InputManager myInput;
        [SerializeField] private DisplayInventory displayInventory;

        public InventorySO inventorySO;

        private void Update()
        {
            if (isTouchNPC)
            {
                if (myInput.input.Player.Interaction.triggered)
                {
                    ShopManager.Instance.displayInventory = displayInventory;
                    displayInventory.inventoryReference = inventorySO;
                    shopUI.SetActive(true);
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
                displayInventory.inventoryReference = null;
            }
        }
    }
}

