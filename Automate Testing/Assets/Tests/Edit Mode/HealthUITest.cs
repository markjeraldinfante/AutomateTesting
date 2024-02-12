using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;
public class HealthUITest
{

    [Test]
    public void testNullText()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefab/HealthUI");
        HealthUI healthUI = prefab.GetComponent<HealthUI>();

        Debug.Log("Prefab: " + prefab);
        Debug.Log("HealthUI Component: " + healthUI);

        Assert.IsNotNull(healthUI, "HealthUI Component is Null");
        Assert.IsNotNull(healthUI.livesText, "Health Text is Null");
    }

    
}
