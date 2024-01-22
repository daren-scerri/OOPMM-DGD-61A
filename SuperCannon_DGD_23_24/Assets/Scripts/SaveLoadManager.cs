using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
public class SaveLoadManager 
{

    public void SaveData()
    {
        SerializedData mySerializedData = new SerializedData();
        mySerializedData.ser_score = GameData.Score;
        mySerializedData.ser_lives = GameData.PlayerHealth;

        BinaryFormatter bf = new BinaryFormatter();

        FileStream myfile = File.Create(Application.persistentDataPath + "/CannonData.save");
        Debug.Log(Application.persistentDataPath.ToString());
        bf.Serialize(myfile, mySerializedData);  //Serialize and save
        myfile.Close();
        Debug.Log("FILE SAVED");


        //USING JSON
        /*
        string jsonToSave = JsonUtility.ToJson(mySerializedData);  //SERIALIZE TO JSON
        Debug.Log(jsonToSave);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/CannonData.json", jsonToSave); //SAVE TO JSON FILE
        */
    }

    public void LoadData()
    {
        SerializedData mySerializedData = new SerializedData();

        if (File.Exists(Application.persistentDataPath + "/CannonData.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream myfile = File.Open(Application.persistentDataPath + "/CannonData.save", FileMode.Open);
            mySerializedData = (SerializedData)bf.Deserialize(myfile);
            myfile.Close();

            GameData.Score = mySerializedData.ser_score;
            GameData.PlayerHealth = mySerializedData.ser_lives;
        }

        //USING JSON
        /*
        if (File.Exists(Application.persistentDataPath + "/CannonData.json"))
        {
            string jsonLoaded = File.ReadAllText(Application.persistentDataPath + "/TanksData.json");
            mySerializedData = JsonUtility.FromJson<SerializedData>(jsonLoaded);
            GameData.GameScore = mySerializedData.ser_score;
            GameData.Lives = mySerializedData.ser_lives;

        }
        */
    }

    public void DeleteFile()
    {
        if (File.Exists(Application.persistentDataPath + "/CannonData.save"))
        {
            File.Delete(Application.persistentDataPath + "/CannonData.save");
        }

    }

}
