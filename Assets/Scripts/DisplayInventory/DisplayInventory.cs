using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public InventorySO inventory;
    public GameObject itemDefault;
    public Transform grid;
    // Start is called before the first frame update
    private void OnEnable()
    {
        CreateDisplay(inventory.listItens);
    }

    private void OnDisable()
    {
        for (int i = 0; i < grid.childCount; i++)
        {
            Destroy(grid.GetChild(i).gameObject);
        }
    }

    private void CreateDisplay(List<Item> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            GameObject obj = Instantiate(itemDefault, grid);
            obj.GetComponent<SetupItem>().item = inventory.listItens[i];
            obj.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() => ShopManager.Instance.GetItem(obj.GetComponent<SetupItem>().item, obj));
        }
    }
}
