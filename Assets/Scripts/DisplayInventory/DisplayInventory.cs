using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            obj.GetComponent<SetupItem>().item = list[i];
        }
    }
}
