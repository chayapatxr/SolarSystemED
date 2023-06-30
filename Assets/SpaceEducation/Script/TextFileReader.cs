using UnityEngine;
using UnityEditor;
using System.IO;
public class TextFileReader : MonoBehaviour
{
    public static TextFileReader Instance;

    //command 
    public bool isFire = false;

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 10;
    public void Update()
    {
        string path = "Assets/Resources/speech.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();

        // checkfire();
        if(reader.ReadToEnd() == "fire")
        {
            isFire = true;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position,bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward*bulletspeed;
        }
        else
        {
        }

    }
    public void checkfire()
    {
        Debug.Log("Checkfire");
    }
}