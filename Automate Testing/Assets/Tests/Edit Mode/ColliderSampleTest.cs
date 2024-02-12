using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ColliderSampleTest
{
   
    [Test]
    public void testNullCollider()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefab/SampleObject");
        Collider collider = prefab.GetComponent<Collider>();

        Assert.IsNotNull(collider, "Collider Component is Null");
    }


}
