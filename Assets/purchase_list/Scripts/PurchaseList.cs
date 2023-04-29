using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShopRecord{
    public string id { get; set; }
    public string name { get; set; }
    public int amount { get; set; }
}

public class PurchaseList : MonoBehaviour
{
    // 把由ShopRecord組成的陣列存到file_name裡
    public void save(List<ShopRecord> shopping_list, string file_name){
        string json = JsonUtility.ToJson(shopping_list);
        File.WriteAllText(file_name, json);
    }

    // 從file_name讀取由ShopRecord組成的陣列的購物清單
    public List<ShopRecord> load(string file_name){
        if(File.Exists(file_name)){
            string json = File.ReadAllText(file_name);
            return JsonUtility.FromJson<List<ShopRecord>>(json);
        }else{
            Debug.LogError(file_name + " not found!");
            return new List<ShopRecord>{};
        }
    }

    // 新增一項商品進購物清單
    public List<ShopRecord> addItem(List<ShopRecord> shopping_list, ShopRecord item){
        ShopRecord result = shopping_list.Find(it => it.id == item.id);
        if(shopping_list.Exists(it => it.id == item.id)){
            shopping_list.Find(it => it.id == item.id).amount += item.amount;
        }else{
            shopping_list.Add(item);
        }
        return shopping_list;
    }
}
