using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using TMPro;
public class InitialLifeTest
{

    [UnityTest]
    public IEnumerator testInitialLife()
    {
        SceneManager.LoadScene("SampleScene");
        yield return null;

        yield return new WaitForSeconds(5f);
        GameObject gameObject = GameObject.Find("HealthUI(Clone)");

        HealthUI healthUI = gameObject.GetComponent<HealthUI>();
        string healthText = healthUI.livesText.text;
        Entity entity = GameObject.Find("Entity").GetComponent<Entity>();

      
        Assert.AreEqual(healthText, $"Health: {entity.GetCurrentHealth()}","HealthText and Entity Health do not match.");

    }
}
