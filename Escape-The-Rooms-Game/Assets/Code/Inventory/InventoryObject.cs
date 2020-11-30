using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject, ISerializationCallbackReceiver
{
    private ItemDataBaseObject database;

    public string savePath;

    public List<InventorySlot> Container = new List<InventorySlot>();

    #region Inventory AddItem method
    // Keeps count of how many items you have and adds items to inventory if it isn't already there
    public void AddItem(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                return;
            }
        }
        Container.Add(new InventorySlot(database.getId[_item], _item, _amount));

    }

    public void RemoveItem(ItemObject _item, int _amount)
    {

        for(int i = Container.Count; i > 0; i--)
        {
            if (Container[i].item == _item)
            {
                Container[i].RemoveAmount(_amount);
                return;
            }
        }

    }
    #endregion

    private void OnEnable()
    {
#if UNITY_EDITOR
        database = (ItemDataBaseObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/Database.asset", typeof(ItemDataBaseObject));
#else
        database = Resources.Load<ItemDataBaseObject>("Database");
#endif
    }

    #region Save/Load methods
    public void Save()
    {
        string saveData = JsonUtility.ToJson(this, true);

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        // This makes it so that you combine strings in to one string to help keep memory
        FileStream fileStream = File.Create(string.Concat(Application.persistentDataPath, savePath));

        binaryFormatter.Serialize(fileStream, saveData);

        fileStream.Close();
    }

    public void Load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream fileStream = File.Open(string.Concat(Application.persistentDataPath, savePath), FileMode.Open);

            JsonUtility.FromJsonOverwrite(binaryFormatter.Deserialize(fileStream).ToString(), this);

            fileStream.Close();
        }
    }
    #endregion

    #region SerializationResiver methods
    public void OnAfterDeserialize()
    {
        for (int i = 0; i < Container.Count; i++)
            Container[i].item = database.getItem[Container[i].id];
    }

    public void OnBeforeSerialize()
    {

    }
    #endregion
}
#region Ínventory amount/item/id


[System.Serializable]
public class InventorySlot
{

    public int id;

    public ItemObject item;

    public int amount;

    public InventorySlot(int _id, ItemObject _item, int _amount)
    {
        id = _id;
        item = _item;

        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }

    public void RemoveAmount(int value)
    {
        amount = value;
    }

}
#endregion