using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assigment.InventoryScreen
{
   public class ShowInventory : MonoBehaviour
   {
      public InventoryObject inventory;

      public int xStart;
      public int yStart;
      public int xSpace;
      public int ySpace;
      public int numberOfColumn;

      [SerializeField] private GameObject[] prefabs;
      private Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

      private void Start()
      {
         CreateDisplay();
      }

      private void Update()
      {
         UpdateDisplay();
      }

      public void CreateDisplay()
      {
         for (int i = 0; i < inventory.Container.Count; i++)
         {
            GameObject obj = Instantiate(prefabs[(int) inventory.Container[i].item], Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
            
            itemsDisplayed.Add(inventory.Container[i], obj);
         }
      }
      public void UpdateDisplay()
      {
         for (int i = 0; i < inventory.Container.Count; i++)
         {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
               itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text =
                  inventory.Container[i].amount.ToString("n0");
            }
            else
            {
               GameObject obj = Instantiate(prefabs[(int)inventory.Container[i].item], Vector3.zero, Quaternion.identity, transform);
               obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
               obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
               itemsDisplayed.Add(inventory.Container[i], obj);
            }
         }
      }
      public Vector3 GetPosition(int i)
      {
         return new Vector3(xStart+ (xSpace * (i % numberOfColumn)), yStart +(-ySpace * (i / numberOfColumn)), 0f);
      }
      private void OnApplicationQuit()
      {
         inventory.Container.Clear();
      }
   }
}
